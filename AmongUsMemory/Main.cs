using ProcessUtil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AmongUsMemory
{
    public static class Main
    {
        public static Memory.Mem mem = new Memory.Mem();
        public static ProcessMemory ProcessMemory = null;

        // Increase this if your computer can't handle the load very well. On a Ryzen 3900x with 500ms delay it takes about 11-16% CPU usage.
        // Remove the scanning later anyways and replace with a keybind system.
        public static int SCAN_DELAY = 500;

        public static bool Init()
        {
            bool state = mem.OpenProcess("Among Us");
            if (state)
            {
                Methods.Init();
                Process proc = Process.GetProcessesByName("Among Us")[0];
                ProcessMemory = new ProcessMemory(proc);
                ProcessMemory.Open(ProcessAccess.AllAccess);
            }
            return state;
        }

        private static ShipStatus prevShipStatus;
        private static ShipStatus shipStatus;
        static Dictionary<string, CancellationTokenSource> Tokens = new Dictionary<string, CancellationTokenSource>();
        static System.Action<uint> onChangeShipStatus;


        static void _ObserveShipStatus()
        {
            while (Tokens.ContainsKey("ObserveShipStatus") && Tokens["ObserveShipStatus"].IsCancellationRequested == false)
            {
                Thread.Sleep(SCAN_DELAY);
                shipStatus = GetShipStatus();
                if (prevShipStatus.OwnerId != shipStatus.OwnerId)
                {
                    prevShipStatus = shipStatus;
                    onChangeShipStatus?.Invoke(shipStatus.Type);
                }
            }
        }


        public static void ObserveShipStatus(System.Action<uint> onChangeShipStatus)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            if (Tokens.ContainsKey("ObserveShipStatus"))
            {
                Tokens["ObserveShipStatus"].Cancel();
                Tokens.Remove("ObserveShipStatus");
            }

            Tokens.Add("ObserveShipStatus", cts);
            Main.onChangeShipStatus = onChangeShipStatus;
            Task.Factory.StartNew(_ObserveShipStatus, cts.Token);
        }

        public static ShipStatus GetShipStatus()
        {
            ShipStatus shipStatus = new ShipStatus();
            byte[] shipAob = mem.ReadBytes(Pattern.ShipStatus_Pointer, Utils.SizeOf<ShipStatus>());
            var aobStr = MakeAobString(shipAob, 4, "00 00 00 00 ?? ?? ?? ??");
            var aobResults = mem.AoBScan(aobStr, true, true);
            aobResults.Wait();
            foreach (var result in aobResults.Result)
            {
                byte[] resultByte = mem.ReadBytes(result.GetAddress(), Utils.SizeOf<ShipStatus>());
                ShipStatus resultInst = Utils.FromBytes<ShipStatus>(resultByte);
                if (resultInst.AllVents != IntPtr.Zero && resultInst.NetId < uint.MaxValue - 10000)
                    if (resultInst.MapScale < 6470545000000 && resultInst.MapScale > 0.1f)
                        shipStatus = resultInst;
            }
            return shipStatus;
        }

        public static string MakeAobString(byte[] aobTarget, int length, string unknownText = "?? ?? ?? ??")
        {
            int cnt = 0;
            // aob pattern
            string aobData = "";
            // read 4byte aob pattern.
            foreach (var _byte in aobTarget)
            {
                if (_byte < 16)
                    aobData += "0" + _byte.ToString("X");
                else
                    aobData += _byte.ToString("X");

                if (cnt + 1 != 4)
                    aobData += " ";

                cnt++;
                if (cnt == length)
                {
                    aobData += $" {unknownText}";
                    break;
                }
            }
            return aobData;
        }
        public static List<PlayerData> GetAllPlayers()
        {
            List<PlayerData> datas = new List<PlayerData>();

            // find player pointer
            byte[] playerAoB = mem.ReadBytes(Pattern.PlayerControl_Pointer, Utils.SizeOf<PlayerControl>());
            // aob pattern
            string aobData = MakeAobString(playerAoB, 4, "?? ?? ?? ??");
            // get result 
            var result = mem.AoBScan(aobData, true, true);
            result.Wait();

            var results = result.Result;
            // real-player
            foreach (var x in results)
            {
                var bytes = mem.ReadBytes(x.GetAddress(), Utils.SizeOf<PlayerControl>());
                var PlayerControl = Utils.FromBytes<PlayerControl>(bytes);
                // filter garbage instance datas.
                if (PlayerControl.SpawnFlags == 257 && PlayerControl.NetId < uint.MaxValue - 10000)
                {
                    datas.Add(new PlayerData()
                    {
                        Instance = PlayerControl,
                        offset_str = x.GetAddress(),
                        offset_ptr = new IntPtr((int)x)
                    });
                }
            }
            return datas;
        }
    }
}
