using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class KillYourSelf
    {
        public static bool ToggleState;

        static Pointer ypos = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C });
        static float cypos;
        public static void Enable()
        {
            cypos = Memory0.mem.ReadFloat(ypos);
            float dropvalue = cypos + 30f;
            Console.WriteLine("The ypos is " + cypos + "and the drop value is " + dropvalue);
            Memory0.mem.WriteMemory(ypos, dropvalue);
        }
    }
    
}
