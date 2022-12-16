using Microsoft.EntityFrameworkCore;
using System;

namespace KeahTekSerAppAPI.Database.Entites
{
    [Keyless]
    public class CIHAZ_AKTARIM
    {
        public string CIHAZ_ADI { get; set; }
        public long DEM_NO { get; set; }
        public string MARKA { get; set; }
        public string MAT_CODE { get; set; }
        public int MAT_SEQ { get; set; }
        public string MODEL { get; set; }
        public string RISK { get; set; }
        public int SAYMANLIK { get; set; }
        public string SERI_NO { get; set; }
        public DateTime TARIH { get; set; }

    }
}
