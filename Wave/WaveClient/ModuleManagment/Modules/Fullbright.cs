using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Windows.Forms;

namespace WaveClient.Module
{

    public static class Fullbright
    {
        public static bool ToggleState;
        static Pointer fullbrightptr = new Pointer("Minecraft.Windows", 0x, new int[] { 0x0 });


        public static void Tick100()
        {
            Console.WriteLine("Coming soon!");
            //Memory0.mem.WriteMemory(fullbrightptr, 100f);
        }

    }

}
