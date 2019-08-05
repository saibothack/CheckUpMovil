using System;
using CheckUpMovil.Helpers;
using CheckUpMovil.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CheckUpMovil
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if(Settings.isLogin)
                MainPage = new HomePage();
            else 
                MainPage = new IntroPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
