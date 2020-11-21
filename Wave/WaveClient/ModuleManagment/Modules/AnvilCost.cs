using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{

    public static class AnvilCost
    {
        public static bool ToggleState;

        static Pointer anvilcostptr = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x0, 0x18, 0x80, 0x5A8, 0x50, 0x20, 0xA8 });

        public static void Tick100()
        {
        //value is set to 1
            Memory0.mem.WriteMemory(anvilcostptr, 0);
            
        }

    }

}
