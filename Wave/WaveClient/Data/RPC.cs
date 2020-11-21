using DiscordRPC;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using WaveClient.ModuleManagment;
using Wave.Cmr.MemoryManagement;
using System.Runtime.InteropServices;
using System.Windows.Input;
using WaveClient.SDK;

namespace WaveClient.Data
{
    public static class RPC
    {
        public static DiscordRpcClient client;

        public static void Start()
        {
            client = new DiscordRpcClient("774759053834321961");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "Using Wave Beta!",
                State = "Updated Daily!",
                Assets = new Assets()
                {
                    LargeImageKey = "wave",
                    LargeImageText = "Wave Client on Top!",
                    SmallImageKey = "wave"
                }
            });
            client.Invoke();
        }
        public static void exitrpc()
        {
            client.Dispose();
        }

    }

}