using System;
using System.Collections.Generic;
using System.Text;

namespace Keah_TekSer_App.Models
{
    internal class Call
    {
        public int CIHAZ_BAKIM_ISTEK_SEQ { get; set; }
        public int BAKIM_SEBEBI { get; set; }
        public string BAKIM_SEBEBI_STRING { get; set; } 
        public string CBI_ACIKLAMA { get; set; }
        public int CBI_BIRIM { get; set; }
        public string CBI_BLOK { get; set; }
        public bool CBI_CAGRI_DURUMU { get; set; }
        public string CBI_DAHILI_NO { get; set; }
        public DateTime CBI_ISTEK_TARIH { get; set; }
        public string CBI_ISTEK_TARIH_STRING { get; set; }  
        public int CBI_ISTEYEN_PER_SEQ { get; set; }
        public bool CBI_ONCELIK { get; set; }
        public string CBI_RED_NEDENI { get; set; }
        public bool CBI_YAZDIRILDI { get; set; }
        public int CBI_YOLLANAN_BIRIM { get; set; }
        public int CBI_YOLLANAN_PER { get; set; }
        public int CIHAZ_SEQ { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public int CREATE_PER_SEQ { get; set; }
        public string CREATE_USER { get; set; }
        public string IPNO { get; set; }
        public string KUNYENO { get; set; }
        public DateTime PLANLANAN_BASLANGIC { get; set; }
        public DateTime PLANLANAN_BITIS { get; set; }
        public DateTime PLANLANAN_TARIH { get; set; }
        public string STATU { get; set; }
        public int SUBE_SEQ { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public int UPDATE_PER_SEQ { get; set; }
        public string UPDATE_USER { get; set; }
        public DateTime YONLENDIRME_TARIH { get; set; }
        public string YONLENDIRME_USER { get; set; }
    }
}
