using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.cmr;

namespace WaveClient.Module
{
    class Airjump
    {
        public static bool ToggleState;

        public static void onTick10()
        {
            if (ToggleState == true)
            {
                Wave.cmr.Memory.WriteProcessMemory(pointers.OnGround, 16777473);
            }
            else
            {

            }
        }
    }
}
