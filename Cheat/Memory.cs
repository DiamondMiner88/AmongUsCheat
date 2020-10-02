using HamsterCheese.AmongUsMemory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cheat
{
    class Memory
    {
        static int UPDATE_DELAY = 250;

        static List<PlayerData> playerDatas = new List<PlayerData>();
        static bool fakeImp;

        // Figure out which scanned 'AmongUsClients' is the actual one used
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
        }
        */

        public static void Init()
        {
            HamsterCheese.AmongUsMemory.Cheese.ObserveShipStatus((uint x) => Reset());

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    Update();
                    System.Threading.Thread.Sleep(UPDATE_DELAY);
                }
            });

            Task.Factory.StartNew(HandleConsole);
            Console.Clear();
            Console.WriteLine("Initialized cheat.");
        }

        public static void Reset()
        {
            foreach (PlayerData p in playerDatas) p.StopObserveState();
            playerDatas = HamsterCheese.AmongUsMemory.Cheese.GetAllPlayers();
            foreach (PlayerData p in playerDatas) p.StartObserveState();
            if (playerDatas.Count == 0) return;

            PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);

            if (fakeImp != true)
            {
                IntPtr killTimerPtr = HamsterCheese.AmongUsMemory.Utils.GetMemberPointer(player.offset_ptr, typeof(PlayerControl), "killTimer");
                HamsterCheese.AmongUsMemory.Cheese.mem.FreezeValue(killTimerPtr.GetAddress(), "float", "0.0");
            }

            // flashes intensly for some reason, fix later
            //IntPtr lightSourcePtr = HamsterCheese.AmongUsMemory.Utils.GetMemberPointer(player.Instance.myLight, typeof(LightSource), "LightRadius");
            //HamsterCheese.AmongUsMemory.Cheese.mem.FreezeValue(lightSourcePtr.GetAddress(), "float", "100.0");
        }

        public static void Update() { }

        private static void SetImposter(PlayerData player, bool setIsImposter)
        {
            // keep track if the player is fake impostering to prevent killing while crewmate which doesnt actually register
            IntPtr isImposterPtr = HamsterCheese.AmongUsMemory.Utils.GetMemberPointer(player.playerInfoOffset_ptr, typeof(PlayerInfo), "IsImpostor");
            int isImposter = HamsterCheese.AmongUsMemory.Cheese.mem.ReadByte(isImposterPtr.GetAddress());
            if ((fakeImp == false && isImposter == 0) || fakeImp == true) fakeImp = setIsImposter;
            player?.WriteMemory_Impostor(Convert.ToByte(setIsImposter));

            IntPtr killTimerPtr = HamsterCheese.AmongUsMemory.Utils.GetMemberPointer(player.offset_ptr, typeof(PlayerControl), "killTimer");
            if (fakeImp) HamsterCheese.AmongUsMemory.Cheese.mem.FreezeValue(killTimerPtr.GetAddress(), "float", "60.0");
            else HamsterCheese.AmongUsMemory.Cheese.mem.UnfreezeValue(killTimerPtr.GetAddress());
        }

        public static void HandleConsole()
        {
            while (true)
            {
                string input = Console.ReadLine();
                PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);
                if (player == null)
                {
                    Console.WriteLine(input + "-> No local player. Do 'reset' or be in a in-progress game");
                    continue;
                }
                switch (input)
                {
                    case "reset":
                        Reset();
                        Console.WriteLine(input + " -> ok");
                        break;
                    case "dead":
                        player?.WriteMemory_IsDead(Convert.ToByte(true));
                        Console.WriteLine(input + " -> ok");
                        break;
                    case "alive":
                        player?.WriteMemory_IsDead(Convert.ToByte(false));
                        Console.WriteLine(input + " -> ok");
                        break;
                    case "imp":
                        SetImposter(player, true);
                        Console.WriteLine(input + " -> ok");
                        break;
                    case "noimp":
                        SetImposter(player, false);
                        Console.WriteLine(input + " -> ok");
                        break;
                }
            }
        }
    }
}
