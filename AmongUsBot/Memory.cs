using HamsterCheese.AmongUsMemory;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace AmongUsBot
{
    class Memory
    {
        static List<PlayerData> playerDatas = new List<PlayerData>();
        static bool originallyImp;

        // Figure out which scanned 'Clients' are the ones actually used
        /*
        public static AmongUsClient GetAmongUsClient()
        {
            AmongUsClient client = new AmongUsClient();
            byte[] clientAob = HamsterCheese.AmongUsMemory.Cheese.mem.ReadBytes(Pattern.AmongusClient_Pointer, Utils.SizeOf<AmongUsClient>());
            string aobStr = HamsterCheese.AmongUsMemory.Cheese.MakeAobString(clientAob, 4, "?? ?? ?? ??");
            var aobResults = HamsterCheese.AmongUsMemory.Cheese.mem.AoBScan(aobStr, true, true);
            aobResults.Wait();
            foreach (var result in aobResults.Result)
            {
                byte[] resultByte = Cheese.mem.ReadBytes(result.GetAddress(), Utils.SizeOf<AmongUsClient>());
                AmongUsClient resultInst = Utils.FromBytes<AmongUsClient>(resultByte);
                client = resultInst;
            }
            return client;
        }*/

        public static void Init()
        {
            // Update Player Data Every Game
            HamsterCheese.AmongUsMemory.Cheese.ObserveShipStatus((uint x) =>
            {
                Console.WriteLine("ObserveShipStatus");
                Console.WriteLine(x);
                Reset();
            });

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Update();
                    System.Threading.Thread.Sleep(250);
                }
            });

            Task.Factory.StartNew(HandleConsole);
        }

        public static void Reset()
        {
            Console.WriteLine("Reset()");

            foreach (PlayerData p in playerDatas) p.StopObserveState();
            playerDatas = HamsterCheese.AmongUsMemory.Cheese.GetAllPlayers();
            foreach (PlayerData p in playerDatas) p.StartObserveState();
            if (playerDatas.Count == 0) return;


            PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);

            //var killTimerPtr = HamsterCheese.AmongUsMemory.Utils.GetMemberPointer(player.offset_ptr, typeof(PlayerInfo), "killTimer");
            //HamsterCheese.AmongUsMemory.Cheese.mem.FreezeValue(killTimerPtr.GetAddress(), "float", "0.0");

            var lightSourcePtr = HamsterCheese.AmongUsMemory.Utils.GetMemberPointer(player.Instance.myLight, typeof(LightSource), "LightRadius");
            HamsterCheese.AmongUsMemory.Cheese.mem.FreezeValue(lightSourcePtr.GetAddress(), "float", "100.0");

            Console.WriteLine("Reset() done");
        }

        public static void Update()
        {
            PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);
            player?.WriteMemory_KillTimer(0.0f);

        }

        public static void HandleConsole()
        {
            while (true)
            {
                string input = Console.ReadLine();
                PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);
                switch (input)
                {
                    case "reset":
                        Reset();
                        Console.WriteLine("ok");
                        break;
                    case "dead":
                        player?.WriteMemory_IsDead(Convert.ToByte(true));
                        Console.WriteLine("ok");
                        break;
                    case "alive":
                        player?.WriteMemory_IsDead(Convert.ToByte(false));
                        Console.WriteLine("ok");
                        break;
                    case "imp":
                        player?.WriteMemory_Impostor(Convert.ToByte(true));
                        Console.WriteLine("ok");
                        break;
                    case "noimp":
                        player?.WriteMemory_Impostor(Convert.ToByte(false));
                        Console.WriteLine("ok");
                        break;
                }
            }
        }
    }
}
