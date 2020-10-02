
using AmongUsMemory;
using System;
using System.Linq;

namespace AmongUsMemory
{
    public class CallAttribute : System.Attribute { }
    public class InitAttribute : System.Attribute { }

    public static class Methods
    {
        #region PlayerControl.GetData
        public static IntPtr PlayerControl_GetDataPTR = IntPtr.Zero;
        #endregion

        [Init]
        public static void Init_PlayerControl_GetData()
        {
            if (PlayerControl_GetDataPTR == IntPtr.Zero)
            {
                var aobScan = Main.mem.AoBScan(Pattern.PlayerControl_GetData);
                aobScan.Wait();
                if (aobScan.Result.Count() == 1)
                    PlayerControl_GetDataPTR = (IntPtr)aobScan.Result.First();
            }
        }

        [Call]
        public static int Call_PlayerControl_GetData(IntPtr playerInfoPtr)
        {
            if (PlayerControl_GetDataPTR != IntPtr.Zero)
            {
                var ptr = PlayerControl_GetDataPTR;
                var playerInfoAddress = Main.ProcessMemory.CallFunction(ptr, playerInfoPtr);
                return playerInfoAddress;
            }
            return -1;
        }
        public static void Init()
        {
            var methods = typeof(Methods).GetMethods();
            foreach (var m in methods)
            {
                var atts = m.GetCustomAttributes(true);
                foreach (var att in atts)
                    if (att.GetType() == typeof(InitAttribute))
                        m.Invoke(null, null);
            }
        }
    }
}