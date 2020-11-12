using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Net.NetworkInformation;

namespace WaveClient.Module
{
    public static class HighJump
    {
        public static bool ToggleState;


        public static void Tick10()
        {
            Memory0.mem.PatchMemory("Minecraft.Windows.exe", 0x154E0DF, new byte[] { 0x0 });
        }

    }

}