using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Cmr.MemoryManagement;
using WaveClient.ModuleManagment;

namespace WaveClient.Module
{
    class DownGlide
    {
        public static bool ToggleState;
        static Pointer ypos = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C });
        static Pointer ypos2 = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C + 12 });
        static Pointer yvelo = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x68, 0x8, 0x18, 0x88, 0x80, 0xBB8, 0x498 });

        public static void Tick10()
        {
            float Y1 = Memory0.mem.ReadFloat(ypos);
            float Y2 = Memory0.mem.ReadFloat(ypos2);

            Memory0.mem.WriteMemory(yvelo, -0.02f);
            Memory0.mem.WriteMemory(ypos, Y1);
            Memory0.mem.WriteMemory(ypos2, Y2);
        }
    }
}
