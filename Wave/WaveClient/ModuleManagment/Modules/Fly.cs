using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class Fly
    {
        public static bool ToggleState;

        static Pointer FlyToggle = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x0, 0x8, 0x20, 0xB8, 0x8B8 });

        public static void Tick10()
        {
            Memory0.mem.WriteMemory(FlyToggle, 1);
        }
        public static void Disable()
        {
            Memory0.mem.WriteMemory(FlyToggle, 0);
        }
    }

}