using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class NoWeb
    {
        public static bool ToggleState;

        public static void Enable()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x12FE2A5, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });

        }

        public static void Disable()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x12FE2A5, new byte[] { 0xF3, 0x0F, 0x11, 0x89, 0x14, 0x02, 0, 0 });
        }
    }

}
