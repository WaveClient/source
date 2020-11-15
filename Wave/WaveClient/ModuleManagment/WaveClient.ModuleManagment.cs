using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using WaveClient.Module;
using Wave.Cmr.MemoryManagement;
using WaveClient.ModuleManagment;


namespace WaveClient.ModuleManagment
{
    public static class ModuleManager
    {
        public static class MemoryUpdate
        {

            //
            public static void Tick10()
            {
            while (!ExitTickThread)
                {
                    if(Module.AirJump.ToggleState == true)
                    {
                        Module.AirJump.Tick10();
                    }
                    if(Module.BypassGlide.ToggleState == true)
                    {
                        Module.BypassGlide.Tick10();
                    }
                    if(Module.DownGlide.ToggleState == true)
                    {
                        Module.DownGlide.Tick10();
                    }
                    
                    if (Module.AirWalk.ToggleState == true)
                    {
                        Module.AirWalk.Tick10();
                    }
                    if (Module.AnvilCost.ToggleState == true)
                    {
                        Module.AnvilCost.Tick100();
                    }
                    if (Module.AutoClicker.ToggleState == true)
                    {
                        Module.AutoClicker.Tick10();
                    }
                    if (Module.AutoSneak.ToggleState == true)
                    {
                        Module.AutoSneak.Enable();
                    }
                    if (Module.AutoSprint.ToggleState == true)
                    {
                        Module.AutoSprint.Tick10();
                    }
                    if (Module.AutoWalk.ToggleState == true)
                    {
                        Module.AutoWalk.Tick10();
                    }
                    if (Module.ClickTP.ToggleState == true)
                    {
                        Module.ClickTP.Tick10();
                    }
                    if (Module.Coords.ToggleState == true)
                    {
                        Module.Coords.Tick10();
                    }
                    if (Module.Fly.ToggleState == true)
                    {
                        Module.Fly.Tick10();
                    }
                    if (Module.HighJump.ToggleState == true)
                    {
                        Module.HighJump.Tick10();
                    }
                    if (Module.Instabreak.ToggleState == true)
                    {
                        Module.Instabreak.Tick10();
                    }
                    if (Module.KillYourSelf.ToggleState == true)
                    {
                        Module.KillYourSelf.Enable();
                    }
                    if (Module.Noclip.ToggleState == true)
                    {
                        Module.Noclip.Tick10();
                    }
                    if (Module.NoFall.ToggleState == true)
                    {
                        Module.NoFall.Tick10();
                    }
                    if (Module.NoSwing.ToggleState == true)
                    {
                        Module.NoSwing.Tick10();
                    }
                    if (Module.NoWeb.ToggleState == true)
                    {
                        Module.NoWeb.Enable();
                    }
                    if (Module.Phase.ToggleState == true)
                    {
                        Module.Phase.Tick10();
                    }
                    if (Module.Speed.ToggleState == true)
                    {
                        Module.Speed.Tick10();
                    }
                    if (Module.StickyGround.ToggleState == true)
                    {
                        Module.StickyGround.Tick10();
                    }
                    if (Module.NameSpoof.ToggleState == true)
                    {
                        Module.NameSpoof.Tick10();
                    }
                    //////////////////////////////
                    //////////////////////////////
                    ///////////////////////////////
                    //////////////////////////////////
                    ///////////////////////////////////
                    if (Module.DownGlide.ToggleState == false)
                    {

                    }
                    if (Module.BypassGlide.ToggleState == false)
                    {

                    }
                    if (Module.AirJump.ToggleState == false)
                    {

                    }
                    if (Module.AirWalk.ToggleState == false)
                    {

                    }
                    if (Module.AnvilCost.ToggleState == false)
                    {

                    }
                    if (Module.AutoClicker.ToggleState == false)
                    {

                    }
                    if (Module.AutoSneak.ToggleState == false)
                    {
                        Module.AutoSneak.Disable();
                    }
                    if (Module.AutoSprint.ToggleState == false)
                    {

                    }
                    if (Module.AutoWalk.ToggleState == false)
                    {

                    }
                    if (Module.ClickTP.ToggleState == false)
                    {

                    }
                    if (Module.Coords.ToggleState == false)
                    {
                        Module.Coords.Disable();
                    }
                    if (Module.Fly.ToggleState == false)
                    {
                        Module.Fly.Disable();
                    }
                    if (Module.HighJump.ToggleState == false)
                    {

                    }
                    if (Module.Instabreak.ToggleState == false)
                    {
                        Module.Instabreak.Disable();
                    }
                    if (Module.KillYourSelf.ToggleState == false)
                    {

                    }
                    if (Module.Noclip.ToggleState == false)
                    {
                        Module.Noclip.Disable();
                    }
                    if (Module.NoFall.ToggleState == false)
                    {

                    }
                    if (Module.NoSwing.ToggleState == false)
                    {
                        Module.NoSwing.Disable();
                    }
                    if (Module.NoWeb.ToggleState == false)
                    {
                        Module.NoWeb.Disable();
                    }
                    if (Module.Phase.ToggleState == false)
                    {
                        Module.Phase.Disable();
                    }
                    if (Module.Speed.ToggleState == false)
                    {

                    }
                    if (Module.StickyGround.ToggleState == false)
                    {

                    }
                    if (Module.NameSpoof.ToggleState == false)
                    {
                        //
                    }

                }
            }

            public static void Tick100()
            {
                while (!ExitTickThread)
                {
                    Thread.Sleep(10);
                }
            }

            public static void Tick1000()
            {
                while (!ExitTickThread)
                {
                    Thread.Sleep(10);
                }
            }

            #region Def
            public static void StartTickThread()
            {
                ThreadTimerTick10 = new Thread(new ThreadStart(Tick10));
                ThreadTimerTick100 = new Thread(new ThreadStart(Tick100));
                ThreadTimerTick1000 = new Thread(new ThreadStart(Tick1000));

                ThreadTimerTick10.Priority = ThreadPriority.Normal;
                ThreadTimerTick100.Priority = ThreadPriority.Normal;
                ThreadTimerTick1000.Priority = ThreadPriority.BelowNormal;

                ThreadTimerTick10.Start();
                ThreadTimerTick100.Start(); 
                ThreadTimerTick1000.Start();
            }

            public static void RestartTickThread()
            {
                ThreadTimerTick10.Abort();
                ThreadTimerTick100.Abort();
                ThreadTimerTick1000.Abort();

                StartTickThread();
            }

            public static bool ExitTickThread = false;

            static Thread ThreadTimerTick10;
            static Thread ThreadTimerTick100;
            static Thread ThreadTimerTick1000;
            #endregion
        }
    }
}
