using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Control_IMC
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Home();
            //Background color
            //MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.White);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
