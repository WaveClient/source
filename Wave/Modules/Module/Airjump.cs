using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.cmr;
using WaveClient.Module;

namespace WaveClient.Module
{
    class Airjump
    {
        public static bool ToggleState;
        public static Pointer onGround = pointers.OnGround;

        public static void onTick10()
        {
            if (ToggleState == true)
            {
                //Memory.WriteProcessMemory(onGround, 1);
            }
            else
            {

            }
        }
    }
}
