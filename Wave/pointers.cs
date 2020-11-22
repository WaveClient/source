using System;
using System.Runtime.InteropServices;
using System.Windows.Input;
using Wave;

namespace WaveClient.Module
{
    public static class pointers
    {
        public static bool ToggleState;

        public static Pointer OnGround = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x0, 0x20, 0x90, 0x5B0, 0xD8, 0x18, 0x1A0 }); //0x0, 0x20, 0x90, 0x5B0, 0xD8, 0x18, 0x1A0

    }

}
