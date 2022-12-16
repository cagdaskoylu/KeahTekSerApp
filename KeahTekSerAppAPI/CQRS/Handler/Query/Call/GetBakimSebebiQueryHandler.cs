using AutoMapper;
using KeahTekSerAppAPI.CQRS.Request.Query.Call;
using KeahTekSerAppAPI.Data.DTO;
using KeahTekSerAppAPI.Database.DTO;
using KeahTekSerAppAPI.Database.Entites;
using KeahTekSerAppAPI.Repositories.BAKIM_ISTEK;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.CQRS.Handler.Query.Call
{
    public class GetBakimSebebiQueryHandler : IRequestHandler<GetBakimSebebiQueryRequest, ResponseBase<BakimSebebiDto>>
    {
        private readonly ICallRepository _istekRepository;
        private IMapper _mapper;

        public GetBakimSebebiQueryHandler(IMapper mapper, ICallRepository istekRepository)
        {
            _mapper = mapper;
            _istekRepository = istekRepository;
        }
        public async Task<ResponseBase<BakimSebebiDto>> Handle(GetBakimSebebiQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new ResponseBase<BakimSebebiDto>();
            var reason = await _istekRepository.CihazBakimSebebi(request.BAKIM_SEBEBI_SEQ);

            if (reason == null)
            {
                response.Success = false;
                response.StatusCode = 400;
                response.Message = "Sebep bulunamadı";
            }
            else
            {
                response.Success = true;
                response.StatusCode = 200;
                response.Message = "Sebep getirildi";
                response.Data = _mapper.Map<CIHAZ_BAKIM_SEBEBI, BakimSebebiDto>(reason);
            }
            return response;
        }
    }
}
