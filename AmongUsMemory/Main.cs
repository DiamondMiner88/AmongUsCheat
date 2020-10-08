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

        #region ObserveShipStatus
        private static ShipStatus prevShipStatus;
        private static ShipStatus shipStatus;

        private static Dictionary<string, CancellationTokenSource> Tokens = new Dictionary<string, CancellationTokenSource>();

        public static System.Action<uint> onShipStatusUpdate;

        static void _ObserveShipStatus()
        {
            while (Tokens.ContainsKey("ObserveShipStatus") && Tokens["ObserveShipStatus"].IsCancellationRequested == false)
            {
                shipStatus = GetObjects.GetShipStatus();
                if (prevShipStatus.OwnerId != shipStatus.OwnerId)
                {
                    prevShipStatus = shipStatus;
                    onShipStatusUpdate?.Invoke(shipStatus.Type);
                }
                Thread.Sleep(ObserveDelays.ObserveShipStatus);
            }
        }

        public static void ObserveShipStatus()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            if (Tokens.ContainsKey("ObserveShipStatus"))
            {
                Tokens["ObserveShipStatus"].Cancel();
                Tokens.Remove("ObserveShipStatus");
            }

            Tokens.Add("ObserveShipStatus", cts);
            Task.Factory.StartNew(_ObserveShipStatus, cts.Token);
        }
        #endregion

        public static string MakeAobString(byte[] aobTarget, int length, string unknownText = "?? ?? ?? ??")
        {
            int cnt = 0;
            // aob pattern
            string aobData = "";
            // read 4byte aob pattern.
            foreach (byte _byte in aobTarget)
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
    }
}
