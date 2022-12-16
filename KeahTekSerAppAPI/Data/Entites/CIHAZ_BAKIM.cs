using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class CIHAZ_BAKIM
    {
        public string BAKIM_FIRMA_YETKILISI { get; set; }
        public int CB_BAKIM_SEBEBI { get; set; }
        public DateTime CB_BASLANGIC_SAAT { get; set; }
        public DateTime CB_BITIS_SAAT { get; set; }
        public double CB_MALIYET { get; set; }
        public string CB_ONCESI_NOT { get; set; }
        public string CB_SONRASI_NOT { get; set; }
        public DateTime CB_TARIH { get; set; }
        public int CB_YAPAN_FIRMA { get; set; }
        public int CB_YAPAN_KISI { get; set; }
        public string CB_YAPILAN_ISLEMLER { get; set; }
        public int CIHAZ_BAKIM_ISTEK_SEQ { get; set; }
        public int CIHAZ_BAKIM_PLAN_SEQ { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CIHAZ_BAKIM_SEQ { get; set; }
        public int CIHAZ_SEQ { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public int CREATE_PER_SEQ { get; set; }
        public string CREATE_USER { get; set; }
        public int DEGERLENDIREN_PER_SEQ { get; set; }
        public int DEGERLENDIRME_NOTU { get; set; }
        public string DEGERLENDIRME_SONUC { get; set; }
        public DateTime DEGERLENDIRME_TARIHI { get; set; }
        public string DEGISEN_PARCALAR { get; set; }
        public double GUNLUK_KUR { get; set; }
        public double MALIYET_ISCILIK { get; set; }
        public double MALIYET_PARCA { get; set; }
        public string MONEY_TYPE { get; set; }
        public DateTime PLANLANAN_BASLANGIC { get; set; }
        public DateTime PLANLANAN_BITIS { get; set; }
        public DateTime PLANLANAN_TARIH { get; set; }
        public int SUBE_SEQ { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public int UPDATE_PER_SEQ { get; set; }
        public string UPDATE_USER { get; set; }
    }
}
