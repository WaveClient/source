using Wave.Cmr;
using Wave.Cmr.Font;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DiscordRPC;

namespace WaveClient
{
    public static class WaveClientConsole
    {
        public static DiscordRpcClient client;

        public static void Start(string[] args)
        {
            cmr.MaximizeConsole();
            cmr_font.SetConsoleFont("Cascadia Code", 12, 24);
            Console.WriteLine($"{cmr.cf(89, 122, 255)}Welcome to WaveClient!");
            Console.WriteLine($"{cmr.cf(200, 200, 200)}Thanks for using it :D");
            Thread.Sleep(1000);
            cmr.MinimizeConsole();
            cmr.clogl($"{cmr.cf(100, 108, 143)}WaveClient", "Loading Modules");
            Console.WriteLine($"{cmr.cf(100, 108, 143)}Made by Milo and the Wave Development Team!");
            client = new DiscordRpcClient("774759053834321961");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "Using Wave Client!",
                State = "Updated Daily!",
                Assets = new Assets()
                {
                    LargeImageKey = "wave",
                    LargeImageText = "Wave Client on Top!",
                    SmallImageKey = "wave"
                }
            });
            Thread.Sleep(100);
            ModuleManagment.ModuleManager.MemoryUpdate.StartTickThread();
        }

        public static class Application
        {
            public static Thread ConsoleThread;

            public static string[] args = Environment.GetCommandLineArgs();

            public static void InitializeThread()
            {
                ConsoleThread = new Thread(new ThreadStart(ConsoleMain));
                ConsoleThread.SetApartmentState(ApartmentState.STA);
                ConsoleThread.Start();
            }

            public static void ConsoleMain()
            {
                Start(args);
            }
        }
    }
}
