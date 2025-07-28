using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace bcompass
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            if (!Compass.IsMonitoring)
                Compass.Start(SensorSpeed.Game);
            if (!Accelerometer.IsMonitoring)
                Accelerometer.Start(SensorSpeed.UI);
        }

        protected override void OnSleep()
        {
            if (Compass.IsMonitoring)
                Compass.Stop();
            if (Accelerometer.IsMonitoring)
                Accelerometer.Stop();
        }

        protected override void OnResume()
        {
            if (!Compass.IsMonitoring)
                Compass.Start(SensorSpeed.Game);
            if (!Accelerometer.IsMonitoring)
                Accelerometer.Start(SensorSpeed.UI);
        }
    }
}

