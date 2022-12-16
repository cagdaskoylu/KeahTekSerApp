using KeahTekSerAppAPI.Data.DTO;
using KeahTekSerAppAPI.Database.DTO;
using MediatR;
using System.Collections.Generic;

namespace KeahTekSerAppAPI.CQRS.Request.Query.Call
{
    public class GetBakimSebebiQueryRequest : IRequest<ResponseBase<BakimSebebiDto>>
    {
        public int BAKIM_SEBEBI_SEQ { get; set; }   
    }
}
