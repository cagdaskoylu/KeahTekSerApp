using Keah_TekSer_App.Helpers;
using Keah_TekSer_App.Views;
using System;
using Xamarin.Forms;

namespace Keah_TekSer_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //NavigationPage navigationPage = new NavigationPage(new LoginScreen());
            //navigationPage.BarBackgroundColor = Color.Red;
            //MainPage = navigationPage;

            SetMainPage();
        }

        private void SetMainPage()
        {
            if (string.IsNullOrEmpty(StaticUserInfo.PERSONEL_TOKEN))
            {
                NavigationPage navigationPage = new NavigationPage(new LoginScreen());
                navigationPage.BarBackgroundColor = Color.Red;
                MainPage = navigationPage;
            }
            else
            {
                NavigationPage navigationPage = new NavigationPage(new UserPage());
                navigationPage.BarBackgroundColor = Color.Red;
                MainPage = navigationPage;
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
