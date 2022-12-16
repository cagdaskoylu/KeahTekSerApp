using System;
using System;
using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class CIHAZ_BAKIM_PLAN
    {
        public string CBP_ACIKLAMA { get; set; }
        public DateTime CBP_BASLANGIC_SAAT { get; set; }
        public DateTime CBP_BITIS_SAAT { get; set; }
        public DateTime CBP_TARIH { get; set; }
        [Key]
        public int CIHAZ_BAKIM_PLAN_SEQ { get; set; }
        [Required]
        public int CIHAZ_SEQ { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public int CREATE_PER_SEQ { get; set; }
        public string CREATE_USER { get; set; }
        public int SOZLESME_SEQ { get; set; }
        public int SUBE_SEQ { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public int UPDATE_PER_SEQ { get; set; }
        public string UPDATE_USER { get; set; }

    }
}
