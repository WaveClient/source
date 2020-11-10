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

        static Pointer ypos = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C });
        static Pointer ypos2 = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C });
        static float Y1 = Memory0.mem.ReadFloat(ypos);
        static float Y2 = Memory0.mem.ReadFloat(ypos2);

       // static float currentYPos = Memory0.mem.ReadFloat(yPos);

        public static void Tick10()
        {
            float Y2 = Y1;
            Memory0.mem.WriteMemory(ypos, Y2);
        }

        public static void Disable()
        {
            float Y2 = Y1 + 1.8f;
            Memory0.mem.WriteMemory(ypos, Y2);
        }

    }

}
