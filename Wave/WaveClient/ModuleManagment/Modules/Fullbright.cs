using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
namespace WaveClient.Module
{
    class Fullbright
    {
        public static bool ToggleState = true;
        static Pointer Brightness = new Pointer("Minecraft.Windows.exe", 0x03694A80, new int[] { 0xF0, 0xE0, 0x8, 0x138, 0xF0 });

        public static float NewBrightness;
        public static void Tick10()
        {
            Memory0.mem.WriteMemory(Brightness, NewBrightness);
        }
        public static void Disable()
        {
            Memory0.mem.WriteMemory(Brightness, 1f);
        }
    }
}
