using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SuperEconomicoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Views.LoginView();
            //MainPage = new NavigationPage(new Views.LoginView());
            //MainPage = new NavigationPage(new Views.SettingsPage());

            string uname = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(uname))
            {
                MainPage = new Views.LoginView();
            }
            else
            {
                MainPage = new Views.ProductsView();
            }

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
