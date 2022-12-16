using KeahTekSerAppAPI.Database.DTO;
using MediatR;
using System.Collections.Generic;

namespace KeahTekSerAppAPI.CQRS.Request.Query.Call
{
    public class GetCallDetailBySeqQueryRequest : IRequest<ResponseBase<CallDto>>
    {
        public int CIHAZ_BAKIM_ISTEK_SEQ { get; set; }
    }
}
