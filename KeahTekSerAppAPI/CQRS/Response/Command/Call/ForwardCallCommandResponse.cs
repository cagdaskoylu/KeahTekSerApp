using System;

namespace KeahTekSerAppAPI.CQRS.Response.Command.Call
{
    public class ForwardCallCommandResponse
    {
        public int CIHAZ_BAKIM_ISTEK_SEQ { get; set; }
        public string DEVIRETME_NEDENI { get; set; }
        public double YONLENDIRILEN_PERSONEL_SEQ { get; set; }
        public DateTime YONLENDIRME_TARIHI { get; set; }
    }
}
