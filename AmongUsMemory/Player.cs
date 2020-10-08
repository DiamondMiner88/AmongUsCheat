using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AmongUsMemory
{
    public class Player
    {
        public IntPtr PlayerControl_GetData_Offset = IntPtr.Zero;
        public PlayerControl Instance;

        public IntPtr playerInfoOffsetPtr;
        private string playerInfoOffset;

        public IntPtr playerControlPtr;
        public string playerControlOffset;


        #region ObserveState
        #region ObserveStates
        private bool player_hasDied = false;
        #endregion

        #region Handlers
        public System.Action<Vector2, byte> onDie;
        #endregion

        Dictionary<string, CancellationTokenSource> Tokens = new Dictionary<string, CancellationTokenSource>();

        public void ObserveState()
        {
            if (PlayerInfo.HasValue)
            {
                if (player_hasDied == false && PlayerInfo.Value.IsDead == 1)
                {
                    player_hasDied = true;
                    onDie?.Invoke(Position, PlayerInfo.Value.ColorId);
                }
            }
        }

        public void StopObserveState()
        {
            if (!Tokens.ContainsKey("ObserveState"))
                return;

            if (Tokens["ObserveState"].IsCancellationRequested == false)
            {
                Tokens["ObserveState"].Cancel();
                Tokens.Remove("ObserveState");
            }
        }

        public void StartObserveState()
        {
            if (Tokens.ContainsKey("ObserveState"))
                return;

            CancellationTokenSource cts = new CancellationTokenSource();
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    ObserveState();
                    System.Threading.Thread.Sleep(ObserveDelays.ObservePlayerDeath);
                }
            }, cts.Token);
            Tokens.Add("ObserveState", cts);
        }
        #endregion

        #region Getters
        public PlayerInfo? PlayerInfo
        {
            get
            {
                if (playerInfoOffsetPtr == IntPtr.Zero)
                {
                    int ptr = Methods.Call_PlayerControl_GetData(this.playerControlPtr);
                    playerInfoOffset = ptr.GetAddress();
                    PlayerInfo pInfo = Utils.FromBytes<PlayerInfo>(Main.mem.ReadBytes(playerInfoOffset, Utils.SizeOf<PlayerInfo>()));
                    playerInfoOffsetPtr = new IntPtr(ptr);
                    return pInfo;
                }
                else
                    return Utils.FromBytes<PlayerInfo>(Main.mem.ReadBytes(playerInfoOffset, Utils.SizeOf<PlayerInfo>()));
            }
        }

        public LightSource LightSource
        {
            get
            {
                IntPtr lsPtr = Instance.myLight;
                byte[] lsBytes = Main.mem.ReadBytes(lsPtr.GetAddress(), Utils.SizeOf<LightSource>());
                return Utils.FromBytes<LightSource>(lsBytes);
            }
        }

        public Vector2 Position
        {
            get
            {
                return IsLocalPlayer ? GetMyPosition() : GetSyncPosition();
            }
        }

        public bool IsLocalPlayer
        {
            get
            {
                return Instance.myLight != IntPtr.Zero;
            }
        }
        #endregion

        #region WriteMemory
        public void Set_LightRange(float value)
        {
            var targetPointer = Utils.GetMemberPointer(Instance.myLight, typeof(LightSource), "LightRadius");
            Main.mem.WriteMemory(targetPointer.GetAddress(), "float", value.ToString("0.0"));
        }

        public void Set_Impostor(byte value)
        {
            var targetPointer = Utils.GetMemberPointer(playerInfoOffsetPtr, typeof(PlayerInfo), "IsImpostor");
            Main.mem.WriteMemory(targetPointer.GetAddress(), "byte", value.ToString());
        }

        public void Set_IsDead(byte value)
        {
            var targetPointer = Utils.GetMemberPointer(playerInfoOffsetPtr, typeof(PlayerInfo), "IsDead");
            Main.mem.WriteMemory(targetPointer.GetAddress(), "byte", value.ToString());
        }

        public void Set_KillTimer(float value)
        {
            var targetPointer = Utils.GetMemberPointer(playerControlPtr, typeof(PlayerControl), "killTimer");
            Main.mem.WriteMemory(targetPointer.GetAddress(), "float", value.ToString());
        }

        public void Set_SetNameTextColor(Color value)
        {
            IntPtr targetPointer = Utils.GetMemberPointer(Instance.nameText, typeof(TextRenderer), "Color");
            Main.mem.WriteMemory(targetPointer.GetAddress(), "float", value.r.ToString("0.0"));
            Main.mem.WriteMemory((targetPointer + 4).GetAddress(), "float", value.g.ToString("0.0"));
            Main.mem.WriteMemory((targetPointer + 8).GetAddress(), "float", value.b.ToString("0.0"));
            Main.mem.WriteMemory((targetPointer + 12).GetAddress(), "float", value.a.ToString("0.0"));
        }
        #endregion

        // whats the point of this? 0 references
        public void ReadMemory() =>
            Instance = Utils.FromBytes<PlayerControl>(Main.mem.ReadBytes(playerControlOffset, Utils.SizeOf<PlayerControl>()));

        #region GetPosition
        public Vector2 GetSyncPosition()
        {
            try
            {
                int _offset_vec2_position = 60;
                int _offset_vec2_sizeOf = 8;
                var netTransform = ((int)Instance.NetTransform + _offset_vec2_position).ToString("X");
                var vec2Data = Main.mem.ReadBytes($"{netTransform}", _offset_vec2_sizeOf); // Read 8 bytes from address  
                if (vec2Data != null && vec2Data.Length != 0)
                {
                    var vec2 = Utils.FromBytes<Vector2>(vec2Data);
                    return vec2;
                }
                else
                    return Vector2.Zero;
            }


            catch (Exception e)
            {
                Console.WriteLine(e);
                return Vector2.Zero;
            }
        }

        public Vector2 GetMyPosition()
        {
            try
            {
                int _offset_vec2_position = 80;
                int _offset_vec2_sizeOf = 8;

                string netTransform = ((int)Instance.NetTransform + _offset_vec2_position).ToString("X");
                byte[] vec2Data = Main.mem.ReadBytes($"{netTransform}", _offset_vec2_sizeOf); // Read 8 bytes from address
                if (vec2Data != null && vec2Data.Length != 0)
                    return Utils.FromBytes<Vector2>(vec2Data);
                else
                    return Vector2.Zero;
            }
            catch
            {
                return Vector2.Zero;
            }
        }
        #endregion
    }
}
