using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Wave.Cmr.MemoryManagement;
using WaveClient.ModuleManagment;
using Wave.Cmr;
namespace WaveClient.Module
{
    class Jetpack
    {
        public static bool ToggleState;

        static Pointer xpos = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X458 });
        static Pointer xpos2 = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X458 + 12 });
        static Pointer xvelo = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x68, 0x8, 0x18, 0x88, 0x80, 0xBB8, 0x494 });

        static Pointer ypos = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C });
        static Pointer ypos2 = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X45C + 12 });
        static Pointer yvelo = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x68, 0x8, 0x18, 0x88, 0x80, 0xBB8, 0x498 });

        static Pointer zpos = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X460 });
        static Pointer zpos2 = new Pointer("Minecraft.Windows.exe", 0x036A0278, new int[] { 0x8, 0x18, 0x80, 0x5B0, 0xB0, 0xF8, 0X460 + 12 });
        static Pointer zvelo = new Pointer("Minecraft.Windows.exe", 0x036A0288, new int[] { 0x68, 0x8, 0x18, 0x88, 0x80, 0xBB8, 0x49C });

        public static float SpeedValue = 0.4f;

        public static void Tick10()
        {
            if (cmr_input.GetKeyStateDown(Wave.Cmr.Win32API.Win32.VirtualKeys.Space))
            {
                Memory0.mem.WriteMemory(yvelo, +SpeedValue);

            }else if (cmr_input.GetKeyStateDown(Wave.Cmr.Win32API.Win32.VirtualKeys.LeftShift))
            {
                Memory0.mem.WriteMemory(yvelo, -SpeedValue);
            }
            else { 

            }
        }
    }
}
