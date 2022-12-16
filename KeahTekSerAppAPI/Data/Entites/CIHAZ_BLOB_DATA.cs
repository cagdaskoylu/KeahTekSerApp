using System.ComponentModel.DataAnnotations;

namespace KeahTekSerAppAPI.Database.Entites
{
    public class CIHAZ_BLOB_DATA
    {
        [Key]
        public int CIHAZ_SEQ { get; set; }
        public byte[] DOK_BLOB { get; set; }
        [Required]
        public string DOK_TYPE { get; set; }

    }
}
