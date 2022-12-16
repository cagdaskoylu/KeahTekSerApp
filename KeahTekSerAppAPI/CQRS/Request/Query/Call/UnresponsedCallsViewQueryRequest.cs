using KeahTekSerAppAPI.Database.DTO;
using MediatR;
using System.Collections.Generic;

namespace KeahTekSerAppAPI.CQRS.Request.Query.Call
{
    public class UnresponsedCallsViewQueryRequest: IRequest<ResponseBase<List<CallDto>>>
    {
        public int PERSONEL_SEQ { get; set; }
    }
}
