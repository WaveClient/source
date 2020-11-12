using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class AutoSneak
    {
        public static bool ToggleState;

        static Pointer autosneakptr = new Pointer("Minecraft.Windows.exe", 0x10513A0, new int[] { 0xEB });
        static Pointer autosneakptrdisabled = new Pointer("Minecraft.Windows.exe", 0x10513A0, new int[] { 0x75 });
        static float sneakvalue;

        public static void Enable()
        {

            Memory0.mem.WriteMemoryNoValue(autosneakptr);
        }
        
    }
    
