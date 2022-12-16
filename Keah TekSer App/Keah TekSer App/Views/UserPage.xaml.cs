using Keah_TekSer_App.Helpers;
using Keah_TekSer_App.Models;
using Keah_TekSer_App.Services;
using Keah_TekSer_App.StaticModels;
using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Keah_TekSer_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        private readonly ApiServices _apiServices = new ApiServices();
        private static List<Call> unresponsedCalls;
        private static List<Call> allCalls;
        private static int index;
        public UserPage()
        {
            InitializeComponent();
            RefreshCalls();
            SetIndexValue();

            Device.StartTimer(TimeSpan.FromMinutes(10), () =>
            {
                RefreshCalls();
                if (unresponsedCalls.Count > index)
                {
                    var notification = new NotificationRequest
                    {
                        BadgeNumber = 1,
                        Description = "Yeni bir çağrınız var",
                        Title = "Bildirim!",
                    };
                    NotificationCenter.Current.Show(notification);
                    index = unresponsedCalls.Count; 
                }
                return true;
            });
        }

        // Button and Cell Events

        private async void CallViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (pageTopic.Text == "Cevaplanmamış Çağrılar:")
            {
                var action = await DisplayActionSheet("İşlem seçiniz", "İptal", "Cevapla", "Bu çağrıyı cevaplamak istiyor musunuz?");
                if (action == "Cevapla")
                {
                    var call = e.SelectedItem as Call;
                    StaticCallInfo.CIHAZ_BAKIM_ISTEK_SEQ = call.CIHAZ_BAKIM_ISTEK_SEQ;
                    StaticCallInfo.BAKIM_SEBEBI_STRING = call.BAKIM_SEBEBI_STRING;
                    StaticCallInfo.ACIKLAMA = call.CBI_ACIKLAMA;
                    await Navigation.PushAsync(new ResponsePage());
                }
            }
        }

        private async void CevaplanmamisCagrilarClicked(object sender, EventArgs e)
        {
            cevaplanmanmisCagrilar.BackgroundColor = Color.LightGreen;
            tumCagrilar.BackgroundColor = Color.White;
            pageTopic.Text = "Cevaplanmamış Çağrılar:";
            ViewUnresponsedCalls();
        }

        private async void TumCagrilarClicked(object sender, EventArgs e)
        {
            cevaplanmanmisCagrilar.BackgroundColor = Color.White;
            tumCagrilar.BackgroundColor = Color.LightGreen;
            pageTopic.Text = "Tüm Çağrılar:";
            ViewAllCalls();
        }
        private async void CikisButtonClicked(object sender, EventArgs e)
        {
            StaticUserInfo.PERSONEL_ID_NUMBER = "";
            StaticUserInfo.PERSONEL_TOKEN = "";
            await Navigation.PushAsync(new LoginScreen());
        }

        private async void RefreshButtonClicked(object sender, EventArgs e)
        {
            RefreshCalls();
        }

        // Other Methods

        private async void RefreshCalls()
        {
            var calls1 = await _apiServices.UnresponsedCalls(StaticUserInfo.PERSONEL_SEQ, StaticUserInfo.PERSONEL_TOKEN);
            if (calls1.Data != null)
            {
                foreach (var call in calls1.Data)
                {
                    var reason = await _apiServices.BakimSebebi(call.BAKIM_SEBEBI, StaticUserInfo.PERSONEL_TOKEN);
                    call.BAKIM_SEBEBI_STRING = reason.Data.BAKIM_SEBEBI;
                    call.CBI_ISTEK_TARIH_STRING = call.CBI_ISTEK_TARIH.ToShortDateString();
                }
                unresponsedCalls = calls1.Data.ToList();
            }
            else { unresponsedCalls = null; }


            var calls2 = await _apiServices.GetAllCalls(StaticUserInfo.PERSONEL_SEQ, StaticUserInfo.PERSONEL_TOKEN);
            if (calls2.Data != null)
            {
                foreach (var call in calls2.Data)
                {
                    var reason = await _apiServices.BakimSebebi(call.BAKIM_SEBEBI, StaticUserInfo.PERSONEL_TOKEN);
                    call.BAKIM_SEBEBI_STRING = reason.Data.BAKIM_SEBEBI;
                    call.CBI_ISTEK_TARIH_STRING = call.CBI_ISTEK_TARIH.ToShortDateString();
                }
                allCalls = calls2.Data.ToList();
            }
            else { allCalls = null; }



            if (pageTopic.Text == "Cevaplanmamış Çağrılar:")
            {
                ViewUnresponsedCalls();
            }
            else if (pageTopic.Text == "Tüm Çağrılar:")
            {
                ViewAllCalls();
            }
        }

        private async void ViewUnresponsedCalls()
        {
            if (unresponsedCalls != null)
            {
                cagriYokLabel.IsVisible = false;
                callView.ItemsSource = unresponsedCalls;
            }
            else
            {
                cagriYokLabel.IsVisible = true;
                callView.ItemsSource = null;
            }

        }

        private async void ViewAllCalls()
        {
            if (allCalls != null)
            {
                cagriYokLabel.IsVisible = false;
                callView.ItemsSource = allCalls;
            }
            else
            {
                cagriYokLabel.IsVisible = true;
                callView.ItemsSource = null;
            }
        }

        private async void SetIndexValue()
        {
            if (unresponsedCalls != null)
            {
                index = unresponsedCalls.Count;
            }
        }

    }
}
