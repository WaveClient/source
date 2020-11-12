using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class NoWeb
    {
        public static bool ToggleState;

        static Pointer nowebptr = new Pointer("Minecraft.Windows.exe", 0x12FE2A5, new int[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });

        public static void Enable()
        {


        }
    }
    
