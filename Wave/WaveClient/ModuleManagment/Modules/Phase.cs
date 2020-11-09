using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Net.NetworkInformation;
using Wave.Cmr;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using WaveClient.SDK;

namespace WaveClient.Module
{
    public static class Phase
    {
        public static bool ToggleState;

        static Pointer ypos = new Pointer("Minecraft.Windows.exe", 0x036A0238, new int[] { 0x10, 0x18, 0x80, 0x9F8, 0x18, 0x45C});
        static float ha = Memory0.mem.ReadFloat(ypos);
        static float Y2 = ha + 1.8f;

       // static float currentYPos = Memory0.mem.ReadFloat(yPos);

        public static void Enable()
        {
            Y2 
        }

        public static void Disable()
        {
            Y2 = ha + 1.8f;
        }

    }

}
