using KeahTekSerAppAPI.Database.DTO;
using KeahTekSerAppAPI.Database.Entites;
using MediatR;
using System;
using System.Collections.Generic;

namespace KeahTekSerAppAPI.CQRS.Request.Query.CallView
{
    public class AllCallsViewQueryRequest : IRequest<ResponseBase<List<CallDto>>>
    {
        public int PERSONEL_SEQ { get; set; }    
    }
}
