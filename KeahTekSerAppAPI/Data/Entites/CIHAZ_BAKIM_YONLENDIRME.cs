using System;
using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class CIHAZ_BAKIM_YONLENDIRME
    {
        [Key]
        public int CIHAZ_BAKIM_ISTEK_SEQ { get; set; }
        public string DEVIRETME_NEDENI { get; set; }
        public int YONLENDIRILEN_PER_SEQ { get; set; }
        public DateTime YONLENDIRME_TARIHI { get; set; }
    }
}
