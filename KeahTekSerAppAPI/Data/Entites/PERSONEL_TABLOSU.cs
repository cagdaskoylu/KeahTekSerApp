using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class PERSONEL_TABLOSU
    {
        [Key]
        public int PERSONEL_SEQ { get; set; }
        public long PERSONEL_ID_NUMBER { get; set; }
        public string PERSONEL_SIFRE { get; set; }
        public string PERSONEL_ADI { get; set; }
        public string PERSONEL_SOYADI { get; set; }
        public string PERSONEL_BIRIMI { get; set; }
        public string PERSONEL_ROLU { get; set; }
    }
}
