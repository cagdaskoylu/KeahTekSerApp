using MediatR;
using System;

namespace KeahTekSerAppAPI.CQRS.Request.Command.Call
{
    public class ResponseCallCommandRequest : IRequest<ResponseBase>
    {
        public int CIHAZ_BAKIM_ISTEK_SEQ { get; set; }
        public DateTime BAKIM_TARIHI { get; set; }
        public DateTime BASLANGIC_SAATI { get; set; }
        public DateTime BITIS_SAATI { get; set; }
        public string CB_ONCESI_NOT { get; set; }
        public string CB_SONRASI_NOT { get; set; }
        public string CB_YAPILAN_ISLEMLER { get; set; }
    }
}
