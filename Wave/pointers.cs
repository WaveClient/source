using System;
using System.Runtime.InteropServices;
using System.Windows.Input;
using Wave;
using Wave.cmr;

namespace WaveClient.Module
{
    public static class pointers
    {
        public static bool ToggleState;

        //movement
        public static Pointer OnGround = new Pointer("Minecraft.Windows.exe", 0x035868E0, new int[] { 0x10, 0x128, 0x0, 0x130 });
        public static Pointer FallDistance = new Pointer("Minecraft.Windows.exe", 0x03623910, new int[] { 0xA0, 0x30, 0x0, 0x0, 0x180, 0x0, 0x1BC });
        public static Pointer Speed = new Pointer("Minecraft.Windows.exe", 0x035F9470, new int[] { 0x70, 0x460, 0x40, 0xC8, 0x18, 0x1F8, 0x9C });

        //pos 1
        public static Pointer posX1 = new Pointer("Minecraft.Windows.exe", 0x035866E0, new int[] { 0x130, 0x0, 0x8, 0x1F0, 0x0, 0x138, 0x480 });
        public static Pointer posY1 = new Pointer("Minecraft.Windows.exe", 0x035866E0, new int[] { 0x130, 0x0, 0x8, 0x1F0, 0x0, 0x138, 0x484 });
        public static Pointer posZ1 = new Pointer("Minecraft.Windows.exe", 0x035866E0, new int[] { 0x130, 0x0, 0x8, 0x1F0, 0x0, 0x138, 0x488 });

        //pos 2


        //velocity
        public static Pointer velocityX = new Pointer("Minecraft.Windows.exe", 0x035F9470, new int[] { 0x70, 0x460, 0x18, 0x20, 0x78, 0x20, 0x4C8 });
        public static Pointer velocityY = new Pointer("Minecraft.Windows.exe", 0x035F9470, new int[] { 0x70, 0x460, 0x18, 0x20, 0x78, 0x20, 0x4CC });
        public static Pointer velocityZ = new Pointer("Minecraft.Windows.exe", 0x035F9470, new int[] { 0x70, 0x460, 0x18, 0x20, 0x78, 0x20, 0x4D0 });

        //Player
        public static Pointer Brightness = new Pointer("Minecraft.Windows.exe", 0x035DF8E8, new int[] { 0x28, 0x838, 0x1A8, 0x820, 0x1A8, 0x138, 0x1E8 });
        public static Pointer FOV = new Pointer("Minecraft.Windows.exe", 0x035DF8E8, new int[] { 0x20, 0x860, 0xF8, 0x60, 0x20, 0x120, 0x1E8 });

    }

}
