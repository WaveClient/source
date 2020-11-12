using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class AutoWalk
    {
        public static bool ToggleState;

        static Pointer yawptr = new Pointer("Minecraft.Windows.exe", 0x0, new int[] { 0x0 });
        static Pointer yvelo = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x68, 0x8, 0x18, 0x88, 0x80, 0xBB8, 0x498 });
        static Pointer velx = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x68, 0x8, 0x18, 0x88, 0x80, 0xBB8, 0x498 - 4 });
        static Pointer velz = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x68, 0x8, 0x18, 0x88, 0x80, 0xBB8, 0x498 + 4 });
        
        public static void Tick10()
        {
            float yaw = Memory0.mem.ReadFloat(yawptr);
            float cYaw = (yaw + 90f) * ((float)Math.PI / 180f);
            
            float walkval = 1f;
            float velXval = (float)Math.Cos(cYaw) * walkval;
            float velZval = (float)Math.Sin(cYaw) * walkval;
            Memory0.mem.WriteMemory(velx, velXval);
            Memory0.mem.WriteMemoy(velz, velZval);
        }
    }
    
}
