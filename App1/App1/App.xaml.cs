using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static string RUTA_DB;
        public App(string ruta_bdd)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            RUTA_DB = ruta_bdd;

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
