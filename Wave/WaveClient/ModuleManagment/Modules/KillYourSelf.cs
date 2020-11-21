using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Net.NetworkInformation;

namespace WaveClient.Module
{
    public static class KillYourSelf
    {
        public static bool ToggleState;

        static Pointer X1_Position = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C - 4 });
        static Pointer Y1_Position =  new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C });
        static Pointer Z1_Position =  new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C + 4 });
        static Pointer X2_Position =  new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C + 8 });
        static Pointer Y2_Position =  new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C + 12 });
        static Pointer Z2_Position =  new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C + 13 });

        public static void Enable()
        {
            float ypos1 = Memory0.mem.ReadFloat(Y1_Position);
            float ypos2 = Memory0.mem.ReadFloat(Y2_Position);
            float dropvalue = 30 + ypos1;
            Memory0.mem.WriteMemory(Y1_Position, dropvalue);
            Memory0.mem.WriteMemory(Y2_Position, dropvalue + 1.8f);
            Console.WriteLine("The Ypos 1, and 2 is, " + ypos1 + ": " + ypos2);
            ToggleState = false;
        }
    }
    
}
