
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

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
                Task<IEnumerable<long>> aobScan = Main.mem.AoBScan(Pattern.PlayerControl_GetData);
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
                IntPtr ptr = PlayerControl_GetDataPTR;
                int playerInfoAddress = Main.ProcessMemory.CallFunction(ptr, playerInfoPtr);
                return playerInfoAddress;
            }
            return -1;
        }

        public static void Init()
        {
            MethodInfo[] methods = typeof(Methods).GetMethods();
            foreach (MethodInfo m in methods)
            {
                object[] atts = m.GetCustomAttributes(true);
                foreach (object att in atts)
                    if (att.GetType() == typeof(InitAttribute))
                        m.Invoke(null, null);
            }
        }
    }
}