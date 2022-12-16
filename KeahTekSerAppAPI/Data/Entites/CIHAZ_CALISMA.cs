using System;
using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class CIHAZ_CALISMA
    {
        public DateTime CC_BASLANGIC_SAAT { get; set; }
        public DateTime CC_BITIS_SAAT { get; set; }
        [Key]
        public int CIHAZ_CALISMA_SEQ { get; set; }
        public int CIHAZ_SEQ { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public int CREATE_PER_SEQ { get; set; }
        public string CREATE_USER { get; set; }
        public int HIZMET_BIRIMLERI_SEQ { get; set; }
        public int SUBE_SEQ { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public int UPDATE_PER_SEQ { get; set; }
        public string UPDATE_USER { get; set; }

    }
}
