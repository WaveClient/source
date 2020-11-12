using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class NoWeb
    {
        public static bool ToggleState;

        static Pointer nowebptr = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C - 4 });

        public static void Enable()
        {


        }
    }
    
