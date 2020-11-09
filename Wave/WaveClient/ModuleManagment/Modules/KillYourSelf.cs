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

        static Pointer kys = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0x19C });
        static Pointer ypos = new Pointer("Minecraft.Windows.exe", 0x036A0238, new int[] { 0x10, 0x18, 0x80, 0x9F8, 0x18, 0x45C});
        static float cypos = Memory0.mem.ReadFloat(yos);
        static float dropvalue = cypos + 30;
        public static void Enable()
        {
          Memory0.mem.WriteMemory(kys, dropvalue);
        }
    }
    
}
