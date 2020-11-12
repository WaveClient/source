using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;

namespace WaveClient.Module
{

    public static class NameSpoof
    {
        public static bool ToggleState;

        static Pointer namespoofptr = new Pointer("Minecraft.Windows.exe", 0x0, new int[] { 0x0 });
        public static string newname = "InputText";

        public static void Tick10()
        {
            //Memory0.mem.WriteMemory(namespoofptr, newname);
        }

    }

}
