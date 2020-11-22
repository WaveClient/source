using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaveClient.Properties;
using WaveClient.Module;
using Wave;
using Wave.Module;
using System.Net;
using DiscordRPC;

namespace WaveClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updatecoords();
            updatetxts();
            StartRPC();
        }
        public static DiscordRpcClient client;
        //public static Timestamps FromTimeSpan(double seconds)
        public static void StartRPC()
        {
            client = new DiscordRpcClient("774759053834321961");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "Using Wave Client!",
                State = "https://discord.gg/W3ypCeb7P2",

                Assets = new Assets()
                {
                    LargeImageKey = "wave",
                    LargeImageText = "Big thanks to GAMERB!!!",
                    SmallImageKey = "minecraft",
                    SmallImageText = "R3coil is a dumbass!"
                    
                }
            });
            client.Invoke();
        }
        public void updatetxts()
        {
            WebClient web = new WebClient();
            System.IO.Stream stream = web.OpenRead(Constants.bugurl);
            using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
            {
                string text = reader.ReadToEnd();
                buglabel.Text = text;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length > 0)
            {
                string text = textBox1.Text;
                //string newtext = text.Substring(4,10);
                string input = text;
                string[] output = input.Split(' ');
                string prefix = output[0];
                string tp = "tp";
                string speed = "speed";

                //tp command 
                if(prefix.Equals(tp))
                {
                    float xcrd = float.Parse(output[1]);
                    float ycrd = float.Parse(output[2]);
                    float zcrd = float.Parse(output[3]);

                    //pointers 
                    Pointer XPOS = new Pointer("Minecraft.Windows.exe", 0x035866E0, new int[] { 0x130, 0x0, 0x8, 0x1F0, 0x0, 0x138, 0x484 - 4 });
                    Pointer XPOS2 = new Pointer("Minecraft.Windows.exe", 0x035866E0, new int[] { 0x130, 0x0, 0x8, 0x1F0, 0x0, 0x138, 0x484 + 8 });
                    Pointer YPOS = new Pointer("Minecraft.Windows.exe", 0x035866E0, new int[] { 0x130, 0x0, 0x8, 0x1F0, 0x0, 0x138, 0x484 });
                    Pointer YPOS2 = new Pointer("Minecraft.Windows.exe", 0x035866E0, new int[] { 0x130, 0x0, 0x8, 0x1F0, 0x0, 0x138, 0x484 + 12 });
                    Pointer ZPOS = new Pointer("Minecraft.Windows.exe", 0x035866E0, new int[] { 0x130, 0x0, 0x8, 0x1F0, 0x0, 0x138, 0x484 + 4 });
                    Pointer ZPOS2 = new Pointer("Minecraft.Windows.exe", 0x035866E0, new int[] { 0x130, 0x0, 0x8, 0x1F0, 0x0, 0x138, 0x484 + 13 });
                    //

                    Memory0.mem.WriteMemory(XPOS, xcrd - 0.3f);
                    Memory0.mem.WriteMemory(YPOS, ycrd);
                    Memory0.mem.WriteMemory(ZPOS, zcrd - 0.3f);
                    Memory0.mem.WriteMemory(XPOS2, xcrd + 0.3f);
                    Memory0.mem.WriteMemory(YPOS2, ycrd + 1.8f);
                    Memory0.mem.WriteMemory(ZPOS2, zcrd + 0.3f);
                } else
                {
                    if(prefix.Equals(speed))
                    {

                    }
                }
                //label4.Text = output[0];//tp
                //label5.Text = output[1];//x coord
                //label6.Text = output[2];//y coord
               // label7.Text = output[2];//z coord


            } else
            {
                MessageBox.Show("Please input some text, smh!");
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Pointer OnGround = pointers.OnGround;
            if (checkBox1.Checked)
            {
                Memory0.mem.WriteMemory(OnGround, 16777473);
            } else
            {
                
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void updatecoords()
        {
            Timer _timer = new Timer();
            _timer.Interval = 50;
            _timer.Tick += realcoordupdate;
            _timer.Enabled = true;
 
        }

        void realcoordupdate(object sender, EventArgs e)
        {
            //pointers
            Pointer YPOS = pointers.posY1;
            Pointer XPOS = pointers.posX1;
            Pointer ZPOS = pointers.posZ1;
            float ycoordf = Memory0.mem.ReadFloat(YPOS);
            string ycoord = ycoordf.ToString();
            float xcoordf = Memory0.mem.ReadFloat(XPOS);
            string xcoord = xcoordf.ToString();
            float zcoordf = Memory0.mem.ReadFloat(ZPOS);
            string zcoord = zcoordf.ToString();
            coordlabel.Text = "Coords: \nX:" + xcoord + "\nY: " + ycoord + "\nZ: " + zcoord;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Main Developer: JavaScript#8785\nMajor Contributor: gamerb.class#8316\nModular Contributor: No c990#8724");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A minecraft client made by JavaScript#8785 and gamerb.class#8316");
        }
    }
}
