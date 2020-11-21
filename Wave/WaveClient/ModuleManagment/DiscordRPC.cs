using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveClientData
{
    class DiscordRPC
    {
        public static bool UsingDiscord = true;
        public static void RPC()
        {
            WaveClient.Data.RPC.Start();
        }
    }
}
