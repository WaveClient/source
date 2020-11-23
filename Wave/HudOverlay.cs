using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wave.cmr;

namespace WaveClient
{
    public partial class HudOverlay : Form
    {
        Graphics g;
        Pen BluePen = new Pen(Color.Blue);
        SolidBrush BackGround = new SolidBrush(Color.White);
        SolidBrush ForeGround = new SolidBrush(Color.Blue);
        System.Drawing.Font font = new System.Drawing.Font("Arial", 15);
        
        public const string WINDOW_NAME = "Minecraft";

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);

        public static IntPtr handle = FindWindow(null, WINDOW_NAME);

        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]

        public static extern bool GetWindowRect(IntPtr hwnd, out RECT IpRect);

        public static RECT rect;

        public struct RECT
        {
            public int left, top, right, bottom;
        }
        public HudOverlay()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                GetWindowRect(handle, out rect);
                this.Size = new Size(rect.right - rect.left, rect.bottom - rect.top);

                this.Left = rect.left;
                this.Top = rect.top;
                Thread.Sleep(15);
                
            }
        }

        private void HudOverlay_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            this.BackColor = Color.Wheat;
            this.TransparencyKey = Color.Wheat;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;

            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x8000 | 0x20);
            
        }

        private void HudOverlay_Paint(object sender, PaintEventArgs e)
        {
            
            g = e.Graphics;
            g.DrawRectangle(BluePen, 15,30,220,100);
            g.FillRectangle(BackGround, 15, 30, 220, 100);
            g.DrawString("WaveClient Utility mod", font, ForeGround, 15, 30);
            
            g.DrawString("Dev Build", font, ForeGround, 15, 55);
            g.DrawRectangle(BluePen, 1300, 500, 200, 100);
            g.FillRectangle(BackGround, 1300, 500, 200, 100);
        }
        public static void OpenClickgui()
        {
            
        }
    }
}
