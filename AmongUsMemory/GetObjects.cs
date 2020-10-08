using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmongUsMemory
{
    public static class GetObjects
    {
        public static List<Player> GetAllPlayers()
        {
            List<Player> newPlayers = new List<Player>();

            byte[] playerAoB = Main.mem.ReadBytes(Pattern.PlayerControl_Pointer, Utils.SizeOf<PlayerControl>());
            string aobData = Main.MakeAobString(playerAoB, 4, "?? ?? ?? ??");
            Task<IEnumerable<long>> aobResult = Main.mem.AoBScan(aobData, true, true);
            aobResult.Wait();

            IEnumerable<long> results = aobResult.Result;
            foreach (long inst in results)
            {
                byte[] bytes = Main.mem.ReadBytes(inst.GetAddress(), Utils.SizeOf<PlayerControl>());
                PlayerControl PlayerControl = Utils.FromBytes<PlayerControl>(bytes);
                // filter garbage instance datas
                if (PlayerControl.SpawnFlags == 257 && PlayerControl.NetId < uint.MaxValue - 10000)
                {
                    newPlayers.Add(new Player()
                    {
                        Instance = PlayerControl,
                        PlayerControlOffset = inst.GetAddress(),
                        PlayerControlOffsetPtr = new IntPtr((int)inst)
                    });
                }
            }
            return newPlayers;
        }

        public static ShipStatus GetShipStatus()
        {
            ShipStatus shipStatus = new ShipStatus();
            byte[] shipAob = Main.mem.ReadBytes(Pattern.ShipStatus_Pointer, Utils.SizeOf<ShipStatus>());
            string aobStr = Main.MakeAobString(shipAob, 4, "00 00 00 00 ?? ?? ?? ??");
            Task<IEnumerable<long>> aobResults = Main.mem.AoBScan(aobStr, true, true);
            aobResults.Wait();
            foreach (long result in aobResults.Result)
            {
                byte[] resultByte = Main.mem.ReadBytes(result.GetAddress(), Utils.SizeOf<ShipStatus>());
                ShipStatus resultInst = Utils.FromBytes<ShipStatus>(resultByte);
                if (resultInst.AllVents != IntPtr.Zero && resultInst.NetId < uint.MaxValue - 10000)
                    if (resultInst.MapScale < 6470545000000 && resultInst.MapScale > 0.1f)
                        shipStatus = resultInst;
            }
            return shipStatus;
        }

        // Figure out which scanned 'AmongUsClients' is the actual one used
        public static AmongUsClient GetAmongUsClient()
        {
            AmongUsClient client = new AmongUsClient();
            byte[] clientAob = AmongUsMemory.Main.mem.ReadBytes(Pattern.AmongusClient_Pointer, Utils.SizeOf<AmongUsClient>());
            string aobStr = AmongUsMemory.Main.MakeAobString(clientAob, 4, "?? ?? ?? ??");
            Task<IEnumerable<long>> aobResults = AmongUsMemory.Main.mem.AoBScan(aobStr, true, true);
            aobResults.Wait();
            foreach (long result in aobResults.Result)
            {
                byte[] resultByte = AmongUsMemory.Main.mem.ReadBytes(result.GetAddress(), Utils.SizeOf<AmongUsClient>());
                AmongUsClient resultInst = Utils.FromBytes<AmongUsClient>(resultByte);
                client = resultInst;

                Type t = resultInst.GetType(); // Where obj is object whose properties you need.
                System.Reflection.PropertyInfo[] pi = t.GetProperties();
                Console.WriteLine(result.GetAddress());
                foreach (System.Reflection.PropertyInfo p in pi)
                    System.Console.WriteLine(p.Name + " : " + p.GetValue(resultInst));
            }
            return client;
        }
    }
}
