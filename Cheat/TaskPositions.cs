using System;

namespace Cheat
{
    static class TaskPositions
    {
        #region ADMIN
        static TaskPos ADMIN_SWIPE_CARD = new TaskPos(0f, 0f);
        #endregion

        #region ELECTRICAL
        static TaskPos ELECTRICAL_DIVERT_POWER = new TaskPos(-8.981053f, -7.706059f);
        static TaskPos ELECTRICAL_DOWNLOAD = new TaskPos(-9.750517f, -7.68535f);
        static TaskPos ELECTRICAL_FIX_WIRE = new TaskPos(-7.688993f, -7.740832f);
        static TaskPos ELECTRICAL_SPINNY_CIRCLES = new TaskPos(-5.83707f, -7.871005f);
        #endregion

        #region SABOTAGE
        static TaskPos SABOTAGE_LIGHTS = new TaskPos(-9.827162f, -10.23858f);
        #endregion


        public static TaskPos NameToTaskPos(string name)
        {
            // name to taskpos list
            return ELECTRICAL_DIVERT_POWER;
        }

        public class TaskPos
        {
            float x;
            float y;
            public TaskPos(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }
    }
}
