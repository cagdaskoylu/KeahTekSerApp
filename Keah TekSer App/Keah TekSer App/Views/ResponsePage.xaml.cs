using Keah_TekSer_App.Helpers;
using Keah_TekSer_App.Models;
using Keah_TekSer_App.Services;
using Keah_TekSer_App.StaticModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Keah_TekSer_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResponsePage : ContentPage
    {
        private readonly ApiServices _apiServices = new ApiServices();

        public ResponsePage()
        {
            InitializeComponent();
            topicInputLabel.Text = StaticCallInfo.BAKIM_SEBEBI_STRING;
            descriptionInputLabel.Text = StaticCallInfo.ACIKLAMA;
        }

        private async void ResponseButtonClicked(object sender, EventArgs e)
        {
            var response = new Response();
            response.CIHAZ_BAKIM_ISTEK_SEQ = StaticCallInfo.CIHAZ_BAKIM_ISTEK_SEQ;
            response.CB_ONCESI_NOT = descriptionBeforeEditor.Text;
            if (response.CB_ONCESI_NOT == null)
            {
                response.CB_ONCESI_NOT = "";
            }

            response.CB_SONRASI_NOT = descriptionAfterEditor.Text;
            if (response.CB_SONRASI_NOT == null)
            {
                response.CB_SONRASI_NOT = "";
            }

            response.CB_YAPILAN_ISLEMLER = operationMadeEditor.Text;
            if (response.CB_YAPILAN_ISLEMLER == null)
            {
                response.CB_YAPILAN_ISLEMLER = "";
            }

            response.BASLANGIC_SAATI = Convert.ToDateTime(timeStart.Time.ToString());
            response.BITIS_SAATI = Convert.ToDateTime(timeEnd.Time.ToString());
            response.BAKIM_TARIHI = datePicker.Date;
            var result = await _apiServices.ResponseCall(response, StaticUserInfo.PERSONEL_TOKEN);
            DisplayAlert("Uyarı", result.Message, "Tamam");
            StaticCallInfo.CIHAZ_BAKIM_ISTEK_SEQ = 0;
            StaticCallInfo.BAKIM_SEBEBI_STRING = "";
            StaticCallInfo.ACIKLAMA = "";
            await Navigation.PushAsync(new UserPage());
        }
    }
}