using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Dispatcher_example
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer dispatcherTimer;
        private int timeTicked = 0;
        private int timeToTick = 10;




        public MainPage()
        {
            this.InitializeComponent();

            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0,0,1);
            TimerLog.Text = "Start()";
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, object e)
        {
            timeTicked++;
            TimerLog.Text += "Dispatchertimer_Tick_Called!" + Environment.NewLine;
            if(timeTicked >= timeToTick)
            {
                TimerLog.Text += "Stop()";
                dispatcherTimer.Stop();
                    
            }
        }
    }
}
