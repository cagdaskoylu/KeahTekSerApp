using Keah_TekSer_App.Helpers;
using Keah_TekSer_App.Services;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Keah_TekSer_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreen : ContentPage
    {
        private readonly ApiServices _apiServices = new ApiServices();
        public LoginScreen()
        {
            InitializeComponent();
            hospitalLogo.Source = ImageSource.FromResource("Keah_TekSer_App.Images.hastaneLogo.png");
        }

        private async void LoginButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
            {
                DisplayAlert("Uyarı", "Kullanıcı adı veya şifre boş bırakılamaz", "Tamam");
            }
            else
            {
                var user = await _apiServices.Login(Convert.ToInt64(idEntry.Text), passwordEntry.Text);
                if(user.Success == false)
                {
                    DisplayAlert("Uyarı", user.Message, "Tamam");
                }
                else
                {
                    StaticUserInfo.PERSONEL_ID_NUMBER = idEntry.Text;
                    StaticUserInfo.PERSONEL_ADI = user.Data.PERSONEL_ADI;
                    StaticUserInfo.PERSONEL_SOYADI = user.Data.PERSONEL_SOYADI;
                    StaticUserInfo.PERSONEL_BIRIMI = user.Data.PERSONEL_BIRIMI;
                    StaticUserInfo.PERSONEL_SEQ = user.Data.PERSONEL_SEQ.ToString();
                    StaticUserInfo.PERSONEL_TOKEN = user.Token;
                    await Navigation.PushAsync(new UserPage());
                }
            }
        }
    }
}