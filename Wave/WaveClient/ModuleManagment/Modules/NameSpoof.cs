using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using WaveClient.GUI;

namespace WaveClient.Module
{

    public static class NameSpoof
    {
        public static bool ToggleState;

        static Pointer namespoofptr = new Pointer("Minecraft.Windows.exe", 0x036938C8, new int[] { 0x40, 0x0, 0x48, 0x18, 0x40, 0x20, 0x28 });
        public static readonly string newname = "Wave";

        //namespooftextbox.Text = namespooftext;

        public static void Tick10()
        {
            Memory0.mem.WriteMemory(namespoofptr, newname);
        }

    }

}
