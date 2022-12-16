using Keah_TekSer_App.Models;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Keah_TekSer_App.Helpers
{
    public static class StaticUserInfo
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static string PERSONEL_ID_NUMBER 
        {
            get
            {
                return AppSettings.GetValueOrDefault("PERSONEL_ID_NUMBER", "");
            }

            set
            {
                AppSettings.AddOrUpdateValue("PERSONEL_ID_NUMBER", value);
            }
        }

        public static string PERSONEL_SEQ
        {
            get
            {
                return AppSettings.GetValueOrDefault("PERSONEL_SEQ", "");
            }

            set
            {
                AppSettings.AddOrUpdateValue("PERSONEL_SEQ", value);
            }
        }

        public static string PERSONEL_ADI
        {
            get
            {
                return AppSettings.GetValueOrDefault("PERSONEL_ADI", "");
            }

            set
            {
                AppSettings.AddOrUpdateValue("PERSONEL_ADI", value);
            }
        }
        public static string PERSONEL_SOYADI 
        {
            get
            {
                return AppSettings.GetValueOrDefault("PERSONEL_SOYADI", "");
            }

            set
            {
                AppSettings.AddOrUpdateValue("PERSONEL_SOYADI", value);
            }
        }
        public static string PERSONEL_BIRIMI 
        {
            get
            {
                return AppSettings.GetValueOrDefault("PERSONEL_BIRIMI", "");
            }

            set
            {
                AppSettings.AddOrUpdateValue("PERSONEL_BIRIMI", value);
            }
        }

        public static string PERSONEL_TOKEN
        {
            get
            {
                return AppSettings.GetValueOrDefault("PERSONEL_TOKEN", "");
            }

            set
            {
                AppSettings.AddOrUpdateValue("PERSONEL_TOKEN", value);
            }
        }
    }
}
