using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Data.DTO
{
    public class BakimSebebiDto
    {
        public string BAKIM_SEBEBI { get; set; }
        public int BAKIM_SEBEBI_SEQ { get; set; }
        public string KUNYENO_ZORUNLU { get; set; }
        public int YETKILI_PER_SEQ { get; set; }
        public int YETKILI_PER_SEQ2 { get; set; }
        public int BAKIM_YETKILI_PER_SEQ3 { get; set; }
    }
}
