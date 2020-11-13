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
           
        static Pointer yveloptr = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x68, 0x8, 0x18, 0x88, 0x80, 0xBB8, 0x498 });
        static Pointer ongroundptr = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x0, 0x20, 0x90, 0x5B0, 0xD8, 0x18, 0x1A0 });
        static float ongroundvalue = Memory0.mem.ReadFloat(ongroundptr);
        static float jumpvalue = 4f;
        
        public void Tick10()
        {
//
        }

    }

}
