using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{
    public static class StickyGround
    {
        public static bool ToggleState;

        static Pointer yvelo = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x68, 0x8, 0x18, 0x88, 0x80, 0xBB8, 0x498 });

        static float val = Memory0.mem.ReadFloat(yvelo);

        public static void Tick10()
        {
            float yelov = val;
            float idk = -0.10f;
            float idfk = 0.5f;
            if (yelov <= idk) yelov = idfk;
            Memory0.mem.WriteMemory(yvelo, yelov);
        }

    }

}