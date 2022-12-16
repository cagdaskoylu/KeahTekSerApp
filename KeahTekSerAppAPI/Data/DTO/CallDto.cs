using System;

namespace KeahTekSerAppAPI.Database.DTO
{
    public class CallDto
    {
        public double CIHAZ_BAKIM_ISTEK_SEQ { get; set; }
        public double BAKIM_SEBEBI { get; set; }
        public string CBI_ACIKLAMA { get; set; }
        public double CBI_BIRIM { get; set; }
        public string CBI_BLOK { get; set; }
        public bool CBI_CAGRI_DURUMU { get; set; }
        public string CBI_DAHILI_NO { get; set; }
        public DateTime CBI_ISTEK_TARIH { get; set; }
        public double CBI_ISTEYEN_PER_SEQ { get; set; }
        public bool CBI_ONCELIK { get; set; }
        public string CBI_RED_NEDENI { get; set; }
        public bool CBI_YAZDIRILDI { get; set; }
        public double CBI_YOLLANAN_BIRIM { get; set; }
        public double CBI_YOLLANAN_PER { get; set; }
        public double CIHAZ_SEQ { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public double CREATE_PER_SEQ { get; set; }
        public string CREATE_USER { get; set; }
        public string IPNO { get; set; }
        public string KUNYENO { get; set; }
        public DateTime PLANLANAN_BASLANGIC { get; set; }
        public DateTime PLANLANAN_BITIS { get; set; }
        public DateTime PLANLANAN_TARIH { get; set; }
        public string STATU { get; set; }
        public double SUBE_SEQ { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public double UPDATE_PER_SEQ { get; set; }
        public string UPDATE_USER { get; set; }
        public DateTime YONLENDIRME_TARIH { get; set; }
        public string YONLENDIRME_USER { get; set; }
    }
}
