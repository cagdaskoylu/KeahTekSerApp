using System;
using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class CIHAZ_KALIBRASYON
    {
        public DateTime BAS_SAAT { get; set; }
        public DateTime BIT_SAAT { get; set; }
        public int CIHAZ_SEQ { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public string CREATE_USER { get; set; }
        public string FIRMA_YETKILISI { get; set; }
        public DateTime GELECEL_KALIBRASYON_TARIH { get; set; }
        public string KALIBRASYON_ACIKLAMA { get; set; }
        public int KALIBRASYON_FIRMA_SEQ { get; set; }
        public string KALIBRASYON_NO { get; set; }
        public int KALIBRASYON_PLAN_SEQ { get; set; }
        [Key]
        public int KALIBRASYON_SEQ { get; set; }
        public int KALIBRASYON_SIRA_NO { get; set; }
        public string KALIBRASYON_SONUC { get; set; }
        public DateTime KALIBRASYON_TARIH { get; set; }
        public double MALIYET { get; set; }
        public string MONEY_TYPE { get; set; }
        public int PER_SEQ { get; set; }
        public DateTime PLANLANAN_BAS_SAAT { get; set; }
        public DateTime PLANLANAN_BIT_SAAT { get; set; }
        public int SUBE_SEQ { get; set; }   
        public DateTime UPDATE_DATE { get; set; }
        public string UPDATE_USER { get; set; }

    }
}
