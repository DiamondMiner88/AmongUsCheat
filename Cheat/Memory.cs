using AmongUsMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheat
{
    class Memory
    {
        static int UPDATE_DELAY = 500;

        static List<AmongUsMemory.PlayerData> playerDatas = new List<AmongUsMemory.PlayerData>();
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
            AmongUsMemory.Main.ObserveShipStatus((uint x) =>
            {
                Console.WriteLine("Ship status changed", x);
                Reset();
            });

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
            foreach (AmongUsMemory.PlayerData p in playerDatas) p.StopObserveState();
            playerDatas = AmongUsMemory.Main.GetAllPlayers();
            foreach (AmongUsMemory.PlayerData p in playerDatas) p.StartObserveState();
            if (playerDatas.Count == 0) return;


            AmongUsMemory.PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);

            if (fakeImp != true && player != null)
            {
                IntPtr killTimerPtr = AmongUsMemory.Utils.GetMemberPointer(player.offset_ptr, typeof(PlayerControl), "killTimer");
                AmongUsMemory.Main.mem.FreezeValue(killTimerPtr.GetAddress(), "float", "0.0");
            }

            Console.WriteLine("Reset");
        }

        public static void Update()
        {
            //AmongUsMemory.PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);
            //if (player == null) return;
            //Console.WriteLine(player.Position.x + "f, " + player.Position.y + "f");
        }

        public static void HandleConsole()
        {
            while (true)
            {
                string input = Console.ReadLine().ToLower();
                RunCommand(input);
            }
        }

        private static void SetImposter(AmongUsMemory.PlayerData player, bool setIsImposter)
        {
            // keep track if the player is fake impostering to prevent killing while crewmate which doesnt actually register
            IntPtr isImposterPtr = Utils.GetMemberPointer(player.playerInfoOffset_ptr, typeof(PlayerInfo), "IsImpostor");
            int isImposter = Main.mem.ReadByte(isImposterPtr.GetAddress());
            if ((fakeImp == false && isImposter == 0) || fakeImp == true) fakeImp = setIsImposter;
            player?.WriteMemory_Impostor(Convert.ToByte(setIsImposter));

            IntPtr killTimerPtr = Utils.GetMemberPointer(player.offset_ptr, typeof(PlayerControl), "killTimer");
            if (fakeImp) Main.mem.FreezeValue(killTimerPtr.GetAddress(), "float", "60.0");
            else Main.mem.UnfreezeValue(killTimerPtr.GetAddress());
        }


        public static int RunCommand(string input)
        {
            PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);

            string[] playerCommands = new string[] { "dead", "alive", "imposter", "crewmate", "fullbright", "nofullbright" };
            if (player == null && playerCommands.Contains(input))
            {
                Reset();
                player = playerDatas.Find((p) => p.IsLocalPlayer);
                if (player == null)
                {
                    Console.WriteLine(input + " -> No local player. Do 'reset' or be in a in-progress game");
                    return -1;
                }
            }

            switch (input)
            {
                case "reset":
                    Reset();
                    Console.WriteLine(input + " -> ok");
                    break;
                case "quit":
                case "exit":
                case "stop":
                    Program.Exit();
                    break;

                // Local player-required commands
                case "dead":
                    player?.WriteMemory_IsDead(Convert.ToByte(true));
                    Console.WriteLine(input + " -> ok");
                    break;
                case "alive":
                    player?.WriteMemory_IsDead(Convert.ToByte(false));
                    Console.WriteLine(input + " -> ok");
                    break;
                case "imposter":
                    SetImposter(player, true);
                    Console.WriteLine(input + " -> ok");
                    break;
                case "crewmate":
                    SetImposter(player, false);
                    Console.WriteLine(input + " -> ok");
                    break;
                case "fullbright":
                    IntPtr lightSourcePtr = Utils.GetMemberPointer(player.Instance.myLight, typeof(LightSource), "LightRadius");
                    Main.mem.FreezeValue(lightSourcePtr.GetAddress(), "float", "1000.0");
                    Console.WriteLine(input + " -> ok");
                    break;
                case "nofullbright":
                    IntPtr lightSourcePtr2 = Utils.GetMemberPointer(player.Instance.myLight, typeof(LightSource), "LightRadius");
                    Main.mem.UnfreezeValue(lightSourcePtr2.GetAddress());
                    Console.WriteLine(input + " -> ok");
                    break;
            }
            return 0;
        }

        public static int SetKillCoolDown(int seconds)
        {
            if (fakeImp) return 1;
            PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);
            if (player == null)
            {
                Reset();
                player = playerDatas.Find((p) => p.IsLocalPlayer);
                if (player == null)
                    return -1;
            }
            IntPtr killTimerPtr = Utils.GetMemberPointer(player.offset_ptr, typeof(PlayerControl), "killTimer");
            Main.mem.FreezeValue(killTimerPtr.GetAddress(), "float", seconds.ToString());
            return 0;
        }

        public static int SetBrightness(string value)
        {
            double not_needed;
            if (!double.TryParse(value, out not_needed))
                return -2;

            PlayerData player = playerDatas.Find((p) => p.IsLocalPlayer);
            if (player == null)
            {
                Reset();
                player = playerDatas.Find((p) => p.IsLocalPlayer);
                if (player == null)
                    return -1;
            }

            IntPtr lightSourcePtr = Utils.GetMemberPointer(player.Instance.myLight, typeof(LightSource), "LightRadius");
            Main.mem.FreezeValue(lightSourcePtr.GetAddress(), "float", value);
            return 0;
        }
    }
}
