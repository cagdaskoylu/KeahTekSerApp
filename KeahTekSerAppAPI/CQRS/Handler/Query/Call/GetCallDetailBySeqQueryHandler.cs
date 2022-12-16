using AutoMapper;
using KeahTekSerAppAPI.CQRS.Request.Query.Call;
using KeahTekSerAppAPI.Database.DTO;
using KeahTekSerAppAPI.Database.Entites;
using KeahTekSerAppAPI.Repositories.BAKIM_ISTEK;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.CQRS.Handler.Query.Call
{
    public class GetCallDetailBySeqQueryHandler : IRequestHandler<GetCallDetailBySeqQueryRequest, ResponseBase<CallDto>>
    {
        private readonly ICallRepository _istekRepository;
        private IMapper _mapper;

        public GetCallDetailBySeqQueryHandler(IMapper mapper, ICallRepository istekRepository)
        {
            _mapper = mapper;
            _istekRepository = istekRepository;
        }

        public async Task<ResponseBase<CallDto>> Handle(GetCallDetailBySeqQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new ResponseBase<CallDto>();
            var call = await _istekRepository.GetDetailBySeq(request.CIHAZ_BAKIM_ISTEK_SEQ);

            if (call == null)
            {
                response.Success = false;
                response.StatusCode = 400;
                response.Message = "Çağrı bulunamadı";
            }
            else
            {
                response.Success = true;
                response.StatusCode = 200;
                response.Message = "Çağrı detayları getirildi";
                response.Data = _mapper.Map<CIHAZ_BAKIM_ISTEK, CallDto>(call);
            }
            return response;
        }
    }
}
