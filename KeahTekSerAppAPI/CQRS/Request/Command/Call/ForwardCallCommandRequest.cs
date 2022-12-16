using MediatR;
using System;

namespace KeahTekSerAppAPI.CQRS.Request.Command.Call
{
    public class ForwardCallCommandRequest : IRequest<ResponseBase>
    {
        public int CIHAZ_BAKIM_ISTEK_SEQ { get; set; }
        public string DEVIRETME_NEDENI { get; set; }
        public int YONLENDIRILEN_PERSONEL_SEQ { get; set; }
    }
}
