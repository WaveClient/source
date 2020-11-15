using WaveClient.ModuleManagment;
using WaveClient.ModuleManagment.ModuleExtensions;
using Wave.Cmr.MemoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using DiscordRPC;

namespace WaveClient.GUI
{
    /// <summary>
    /// Interaction logic for WaveClient.xaml
    /// </summary>
    public partial class MainWindow_ModulePage : Page
    {
        DispatcherTimer UpdateGUIDispatcherTimer;
        public string namespooftext;
        

        public MainWindow_ModulePage()
        {
            InitializeComponent();

            #region UpdateGUIDispatcherTimer
            UpdateGUIDispatcherTimer = new DispatcherTimer();
            UpdateGUIDispatcherTimer.Interval = TimeSpan.FromMilliseconds(10);
            UpdateGUIDispatcherTimer.Tick += new EventHandler(UpdateGUI);
            UpdateGUIDispatcherTimer.Start();
            #endregion

            
        }

        ~MainWindow_ModulePage()
        {
            UpdateGUIDispatcherTimer.Stop();

            

        }

        public void UpdateGUI(object sender, EventArgs e)
        {

            SModule_Airjump.Content = GUIExtensions.GetBoolStateText(Module.AirJump.ToggleState);
            SModule_AutoSneak.Content = GUIExtensions.GetBoolStateText(Module.AutoSneak.ToggleState);
            SModule_NoFall.Content = GUIExtensions.GetBoolStateText(Module.NoFall.ToggleState);
            SModule_Instabreak.Content = GUIExtensions.GetBoolStateText(Module.Instabreak.ToggleState);
            SModule_Reach.Content = GUIExtensions.GetBoolStateText(Module.Reach.ToggleState);
            SModule_NoSwing.Content = GUIExtensions.GetBoolStateText(Module.NoSwing.ToggleState);
            SModule_Coords.Content = GUIExtensions.GetBoolStateText(Module.Coords.ToggleState);
            SModule_AutoSprint.Content = GUIExtensions.GetBoolStateText(Module.AutoSprint.ToggleState);
            SModule_KillYourSelf.Content = GUIExtensions.GetBoolStateText(Module.KillYourSelf.ToggleState);
            SModule_Phase.Content = GUIExtensions.GetBoolStateText(Module.Phase.ToggleState);
            SModule_Noclip.Content = GUIExtensions.GetBoolStateText(Module.Noclip.ToggleState);
            SModule_AutoClicker.Content = GUIExtensions.GetBoolStateText(Module.AutoClicker.ToggleState);
            SModule_AnvilCost.Content = GUIExtensions.GetBoolStateText(Module.AnvilCost.ToggleState);
            SModule_HighJump.Content = GUIExtensions.GetBoolStateText(Module.HighJump.ToggleState);
            SModule_StickyGround.Content = GUIExtensions.GetBoolStateText(Module.StickyGround.ToggleState);
            SModule_AirWalk.Content = GUIExtensions.GetBoolStateText(Module.AirWalk.ToggleState);
            SModule_AutoWalk.Content = GUIExtensions.GetBoolStateText(Module.AutoWalk.ToggleState);
            SModule_NoWeb.Content = GUIExtensions.GetBoolStateText(Module.NoWeb.ToggleState);
            SModule_ClickTP.Content = GUIExtensions.GetBoolStateText(Module.ClickTP.ToggleState);
            SModule_Fly.Content = GUIExtensions.GetBoolStateText(Module.Fly.ToggleState);
            SModule_DownGlide.Content = GUIExtensions.GetBoolStateText(Module.DownGlide.ToggleState);
            SModule_BypassGlide.Content = GUIExtensions.GetBoolStateText(Module.BypassGlide.ToggleState);
            SModule_NameSpoof.Content = GUIExtensions.GetBoolStateText(Module.NameSpoof.ToggleState);
            //setting FullBright
            label_value_module_FullBright2.Content = SModule_FullBright.Value;
            Module.Fullbright.NewBrightness = (float)(SModule_FullBright.Value);

            //settingSpeed
            
            label_value_module_Speed2.Content = SModule_Speed.Value;
            /*
            if ((bool)(label_value_module_Speed2.Content = 0))
            {
                return;
            } */
            
            Module.Speed.NewSpeed = (float)(SModule_Speed.Value);


            /////
            ///
            //namespooftextbox.Text = namespooftext;



        }


        private void SModule_Airjump_Click(object sender, RoutedEventArgs e)
        {
            Module.AirJump.ToggleState = !Module.AirJump.ToggleState;
            SModule_Airjump.Content = GUIExtensions.GetBoolStateText(Module.AirJump.ToggleState);
        }

        private void SModule_NoFall_Click(object sender, RoutedEventArgs e)
        {
            Module.NoFall.ToggleState = !Module.NoFall.ToggleState;
            SModule_NoFall.Content = GUIExtensions.GetBoolStateText(Module.NoFall.ToggleState);
        }
        private void SModule_Instabreak_Click(object sender, RoutedEventArgs e)
        {
            Module.Instabreak.ToggleState = !Module.Instabreak.ToggleState;
            SModule_Instabreak.Content = GUIExtensions.GetBoolStateText(Module.Instabreak.ToggleState);
        }
        private void SModule_Reach_Click(object sender, RoutedEventArgs e)
        {
            Module.Reach.ToggleState = !Module.Reach.ToggleState;
            SModule_Reach.Content = GUIExtensions.GetBoolStateText(Module.Reach.ToggleState);
        }
        private void SModule_NoSwing_Click(object sender, RoutedEventArgs e)
        {
            Module.NoSwing.ToggleState = !Module.NoSwing.ToggleState;
            SModule_NoSwing.Content = GUIExtensions.GetBoolStateText(Module.NoSwing.ToggleState);
        }
        private void SModule_Coords_Click(object sender, RoutedEventArgs e)
        {
            Module.Coords.ToggleState = !Module.Coords.ToggleState;
            SModule_Coords.Content = GUIExtensions.GetBoolStateText(Module.Coords.ToggleState);
        }
        private void SModule_AutoSprint_Click(object sender, RoutedEventArgs e)
        {
            Module.AutoSprint.ToggleState = !Module.AutoSprint.ToggleState;
            SModule_AutoSprint.Content = GUIExtensions.GetBoolStateText(Module.AutoSprint.ToggleState);
        }
        private void SModule_KillYourSelf_Click(object sender, RoutedEventArgs e)
        {
            Module.KillYourSelf.ToggleState = !Module.KillYourSelf.ToggleState;
            SModule_KillYourSelf.Content = GUIExtensions.GetBoolStateText(Module.KillYourSelf.ToggleState);
        }
        private void SModule_Phase_Click(object sender, RoutedEventArgs e)
        {
            Module.Phase.ToggleState = !Module.Phase.ToggleState;
            SModule_Phase.Content = GUIExtensions.GetBoolStateText(Module.Phase.ToggleState);
        }
        private void SModule_Noclip_Click(object sender, RoutedEventArgs e)
        {
            Module.Noclip.ToggleState = !Module.Noclip.ToggleState;
            SModule_Noclip.Content = GUIExtensions.GetBoolStateText(Module.Noclip.ToggleState);
        }
        private void SModule_AutoClicker_Click(object sender, RoutedEventArgs e)
        {
            Module.AutoClicker.ToggleState = !Module.AutoClicker.ToggleState;
            SModule_AutoClicker.Content = GUIExtensions.GetBoolStateText(Module.AutoClicker.ToggleState);
        }
        private void SModule_AnvilCost_Click(object sender, RoutedEventArgs e)
        {
            Module.AnvilCost.ToggleState = !Module.AnvilCost.ToggleState;
            SModule_AnvilCost.Content = GUIExtensions.GetBoolStateText(Module.AnvilCost.ToggleState);
        }
        private void SModule_HighJump_Click(object sender, RoutedEventArgs e)
        {
            //if (e.Key == Key.Space)
            Module.HighJump.ToggleState = !Module.HighJump.ToggleState;
            SModule_HighJump.Content = GUIExtensions.GetBoolStateText(Module.HighJump.ToggleState);
        }
        private void SModule_StickyGround_Click(object sender, RoutedEventArgs e)
        {
            Module.StickyGround.ToggleState = !Module.StickyGround.ToggleState;
            SModule_StickyGround.Content = GUIExtensions.GetBoolStateText(Module.StickyGround.ToggleState);
        }
        private void SModule_AirWalk_Click(object sender, RoutedEventArgs e)
        {
            Module.AirWalk.ToggleState = !Module.AirWalk.ToggleState;
            SModule_StickyGround.Content = GUIExtensions.GetBoolStateText(Module.AirWalk.ToggleState);
        }
        private void SModule_AutoWalk_Click(object sender, RoutedEventArgs e)
        {
            Module.AutoWalk.ToggleState = !Module.AutoWalk.ToggleState;
            SModule_AutoWalk.Content = GUIExtensions.GetBoolStateText(Module.AutoWalk.ToggleState);
        }
        private void SModule_NoWeb_Click(object sender, RoutedEventArgs e)
        {
            Module.NoWeb.ToggleState = !Module.NoWeb.ToggleState;
            SModule_NoWeb.Content = GUIExtensions.GetBoolStateText(Module.NoWeb.ToggleState);
        }
        private void SModule_ClickTP_Click(object sender, RoutedEventArgs e)
        {
            Module.ClickTP.ToggleState = !Module.ClickTP.ToggleState;
            SModule_ClickTP.Content = GUIExtensions.GetBoolStateText(Module.ClickTP.ToggleState);
        }
        private void SModule_AutoSneak_Click(object sender, RoutedEventArgs e)
        {
            Module.AutoSneak.ToggleState = !Module.AutoSneak.ToggleState;
            SModule_AutoSneak.Content = GUIExtensions.GetBoolStateText(Module.AutoSneak.ToggleState);
        }
        private void SModule_Fly_Click(object sender, RoutedEventArgs e)
        {
            Module.Fly.ToggleState = !Module.Fly.ToggleState;
            SModule_Fly.Content = GUIExtensions.GetBoolStateText(Module.Fly.ToggleState);
        }
        private void SModuleDownGlide_Click(object sender, RoutedEventArgs e)
        {
            Module.DownGlide.ToggleState = !Module.DownGlide.ToggleState;
            SModule_DownGlide.Content = GUIExtensions.GetBoolStateText(Module.DownGlide.ToggleState);
        }
        private void SModuleBypassGlide_Click(object sender, RoutedEventArgs e)
        {
            Module.BypassGlide.ToggleState = !Module.BypassGlide.ToggleState;
            SModule_BypassGlide.Content = GUIExtensions.GetBoolStateText(Module.BypassGlide.ToggleState);
        }

        private void SModule_NameSpoof_Click(object sender, RoutedEventArgs e)
        {
           
            Module.NameSpoof.ToggleState = !Module.NameSpoof.ToggleState;
            SModule_NameSpoof.Content = GUIExtensions.GetBoolStateText(Module.NameSpoof.ToggleState);
            //Console.WriteLine(namespooftext);
        }



    }
}
