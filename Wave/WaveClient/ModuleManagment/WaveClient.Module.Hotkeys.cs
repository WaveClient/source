using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaveClient.Module;
using WaveClient.ModuleManagment;
using Wave.Cmr;
using System.Threading;


namespace WaveClient.ModuleManagment
{
    class WaveClient
    {
        public static bool UsingHotKeys = true;
        public static void HotKeys()
        {
            if (cmr_input.GetKeyStateDown(Wave.Cmr.Win32API.Win32.VirtualKeys.G))
            {
                Module.AirJump.ToggleState = !Module.AirJump.ToggleState;
                Thread.Sleep(1000);
            }
            



            //hotkey's that automaticly turn off
            if (cmr_input.GetKeyStateDown(Wave.Cmr.Win32API.Win32.VirtualKeys.F))
            {
                Module.Jetpack.ToggleState = true;
            }
            if (cmr_input.GetKeyStateUp(Wave.Cmr.Win32API.Win32.VirtualKeys.F))
            {
                Module.Jetpack.ToggleState = false;
            }
            if (cmr_input.GetKeyStateDown(Wave.Cmr.Win32API.Win32.VirtualKeys.C))
            {
                Module.BypassGlide.ToggleState = true;
                
            }
            if (cmr_input.GetKeyStateUp(Wave.Cmr.Win32API.Win32.VirtualKeys.C))
            {
                Module.BypassGlide.ToggleState = false;
                
            }
        }
    }
}
