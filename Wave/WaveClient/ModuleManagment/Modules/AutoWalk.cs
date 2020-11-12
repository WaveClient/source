using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Net.NetworkInformation;

namespace WaveClient.Module
{
    public static class AutoWalk
    {
        public static bool ToggleState;

        //static Pointer yaw = new Pointer("Minecraft.Windows.exe", 0x0, new int[] { 0x0 });
        public static void Enable()
        {
            float cYaw = (yaw + 90f) * ((float)Math.PI / 180f);
            
            float walkval = 1f;
            float velX = (float)Math.Cos(cYaw) * walkval;
            float velZ = (float)Math.Sin(cYaw) * walkval;
            Memory0.mem.WriteMemory(yaw, velX);
        }
    }
    
}
