using System;
using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class CIHAZ_BAKIM_SOZLESME
    {
        public string ACIKLAMA { get; set; }
        public DateTime BASLANGIC_TARIHI { get; set; }
        public DateTime BITIS_TARIHI { get; set; }
        [Key]
        public int CIHAZ_SEQ { get; set; }
        public int FIRM_SEQ { get; set; }
        public string MONEY_TYPE { get; set; }
        public string MUDAHALE_KISI { get; set; }
        public string MUDAHALE_SURESI { get; set; }
        public int PERIYOD_BIRIM { get; set; }
        public int PERIYOD_SURESI { get; set; }
        public double SOZLESME_BEDELI { get; set; }
        public int SOZLESME_SEQ { get; set; }
        public string SOZLESME_VAR { get; set; }

    }
}
