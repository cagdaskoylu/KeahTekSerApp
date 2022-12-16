using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class CIHAZ_BAKIM_SEBEBI
    {
        [Required]
        public string BAKIM_SEBEBI { get; set; }
        [Key]
        public int BAKIM_SEBEBI_SEQ { get; set; }
        [Required]
        public string KUNYENO_ZORUNLU { get; set; }
        public int YETKILI_PER_SEQ { get; set; }
        public int YETKILI_PER_SEQ2 { get; set; }
        public int BAKIM_YETKILI_PER_SEQ3 { get; set; }
    }
}
