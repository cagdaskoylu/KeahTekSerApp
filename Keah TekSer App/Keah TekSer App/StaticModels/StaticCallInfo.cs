using Plugin.Settings.Abstractions;
using Plugin.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Keah_TekSer_App.StaticModels
{
    public static class StaticCallInfo
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static int CIHAZ_BAKIM_ISTEK_SEQ
        {
            get
            {
                return AppSettings.GetValueOrDefault("CIHAZ_BAKIM_ISTEK_SEQ", 0);
            }

            set
            {
                AppSettings.AddOrUpdateValue("CIHAZ_BAKIM_ISTEK_SEQ", value);
            }
        }

        public static string BAKIM_SEBEBI_STRING
        {
            get
            {
                return AppSettings.GetValueOrDefault("BAKIM_SEBEBI_STRING", "");
            }

            set
            {
                AppSettings.AddOrUpdateValue("BAKIM_SEBEBI_STRING", value);
            }
        }

        public static string ACIKLAMA
        {
            get
            {
                return AppSettings.GetValueOrDefault("ACIKLAMA", "");
            }

            set
            {
                AppSettings.AddOrUpdateValue("ACIKLAMA", value);
            }
        }
    }
}
