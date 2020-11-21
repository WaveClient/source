using System;
using System.Collections.Generic;
using System.Linq;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Text;
using WaveClient.SDK;
using System.Threading.Tasks;

namespace WaveClient.Module
{
    public static class AutoClicker
    {
        public static bool ToggleState;

        static Pointer ClickDelay = new Pointer("Minecraft.Windows.exe", 0x0368EE98, new int[] { 0x80, 0x0, 0x8, 0x440, 0x2A4, 0x8, 0x50 });

        public static void Tick10()
        {
            while (true)
            {
                int Click = Memory0.mem.ReadInt(ClickDelay);
                if (Click == 1)
                {
                    Memory0.mem.WriteMemory(ClickDelay, 0);
                }
            }
        }
    }
}