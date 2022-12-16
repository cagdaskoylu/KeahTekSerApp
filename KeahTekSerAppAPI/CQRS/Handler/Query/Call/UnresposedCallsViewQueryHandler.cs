using AutoMapper;
using KeahTekSerAppAPI.CQRS.Request.Query.CallView;
using KeahTekSerAppAPI.Database.DTO;
using KeahTekSerAppAPI.Database.Entites;
using KeahTekSerAppAPI.Repositories.BAKIM_ISTEK;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using KeahTekSerAppAPI.CQRS.Request.Query.Call;
using System.Linq;

namespace KeahTekSerAppAPI.CQRS.Handler.Query.Call
{
    public class UnresposedCallsViewQueryHandler : IRequestHandler<UnresponsedCallsViewQueryRequest, ResponseBase<List<CallDto>>>
    {
        private readonly ICallRepository _istekRepository;
        private IMapper _mapper;

        public UnresposedCallsViewQueryHandler(IMapper mapper, ICallRepository istekRepository)
        {
            _mapper = mapper;
            _istekRepository = istekRepository;
        }

        public async Task<ResponseBase<List<CallDto>>> Handle(UnresponsedCallsViewQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new ResponseBase<List<CallDto>>();
            var calls = await _istekRepository.GetUnreponsedCallsByPersonelSeq(request.PERSONEL_SEQ);

            if (calls.Count == 0)
            {
                response.StatusCode = 200;
                response.Success = true;
                response.Message = "Çağrı yok";
                return response;
            }
            else
            {
                var callList = _mapper.Map<IEnumerable<CIHAZ_BAKIM_ISTEK>, IEnumerable<CallDto>>(calls);
                response.StatusCode = 200;
                response.Success = true;
                response.Message = "Çağrılar getirildi";
                response.Data = callList.ToList();
            }
            return response;
        }
    }
}
