using AutoMapper;
using KeahTekSerAppAPI.CQRS.Request.Query.CallView;
using KeahTekSerAppAPI.Database.DTO;
using KeahTekSerAppAPI.Database.Entites;
using KeahTekSerAppAPI.Repositories.BAKIM_ISTEK;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.CQRS.Handler.Query.CallView
{
    public class AllCallsViewQueryHandler : IRequestHandler<AllCallsViewQueryRequest, ResponseBase<List<CallDto>>>
    {
        private readonly ICallRepository _istekRepository;
        private IMapper _mapper;

        public AllCallsViewQueryHandler(IMapper mapper, ICallRepository istekRepository)
        {
            _mapper = mapper;
            _istekRepository = istekRepository;
        }

        public async Task<ResponseBase<List<CallDto>>> Handle(AllCallsViewQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new ResponseBase<List<CallDto>>();
            var calls = await _istekRepository.GetByPersonelSeq(request.PERSONEL_SEQ);

            if (calls.Count==0)
            {
                response.StatusCode = 200;
                response.Success = true;
                response.Message = "Çağrı yok";
                return response;
            }
            else
            {
                var callList = _mapper.Map<IEnumerable<CIHAZ_BAKIM_ISTEK>,IEnumerable<CallDto>>(calls);
                response.StatusCode = 200;
                response.Success = true;
                response.Message = "Çağrılar getirildi";
                response.Data = callList.ToList();
            }
            return response;
        }
    }
}
