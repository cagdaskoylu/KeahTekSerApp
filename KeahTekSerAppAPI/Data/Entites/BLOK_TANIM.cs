using Microsoft.EntityFrameworkCore;

namespace KeahTekSerAppAPI.Database.Entites
{
    [Keyless]
    public class BLOK_TANIM
    {
        public string BLOK_ADI { get; set; }
        public int BLOK_SEQ { get; set; }
    }
}
