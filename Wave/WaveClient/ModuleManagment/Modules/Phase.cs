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
        static Pointer ypos2 = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C + 12 });
        //static Pointer X1 = new Pointer("Minecraft.Windows.exe", 0x30366F8, new int[] { 0x0 - 4 });
        //static Pointer Z1 = new Pointer("Minecraft.Windows.exe", 0x30366F8, new int[] { 0x0 + 4 });
        //static Pointer X2 = new Pointer("Minecraft.Windows.exe", 0x30366F8, new int[] { 0x0 + 8 });
        //static Pointer Z2 = new Pointer("Minecraft.Windows.exe", 0x30366F8, new int[] { 0x0 + 13 });
        static float Y1 = Memory0.mem.ReadFloat(ypos);
        static float Y2 = Memory0.mem.ReadFloat(ypos2);

        public static void findypos()
        {
            float Y1;
            Y1 = Memory0.mem.ReadFloat(ypos);
            return Y1;
        }
        //
        public static void Tick10()
        {
            findypos();
            float Y2 = Y1;
            Memory0.mem.WriteMemory(ypos, Y2);
        }
        //
        public static void Disable()
        {
            float Y2 = Y1 + 1.8f;
            Memory0.mem.WriteMemory(ypos, Y2);
        }
        //
    }

}
