using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{

    public static class ClickTP
    {
        public static bool ToggleState;

        static Pointer lookingblockyptr = new Pointer("Minecraft.Windows.exe", 0x0, new int[] { 0x0 });
        static float LOOKINGBLOCKY = Memory.mem.ReadFloat(lookingblockyptr)

        public static void Tick10()
        {/*
        // if leftclick {
            if(LOOKINGBLOCKY > 0)
            {
            
            }
            } */
        }

    }

}
