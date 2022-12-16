using AutoMapper;
using KeahTekSerAppAPI.CQRS.Request.Command.Call;
using KeahTekSerAppAPI.CQRS.Response.Command.Call;
using KeahTekSerAppAPI.Database.Entites;
using KeahTekSerAppAPI.Repositories.BAKIM_ISTEK;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.CQRS.Handler.Command.Call
{
    public class ForwardCallCommandHandler : IRequestHandler<ForwardCallCommandRequest, ResponseBase>
    {
        private readonly IMapper _mapper;
        private readonly ICallRepository _callRepository;
        public ForwardCallCommandHandler(IMapper mapper, ICallRepository callRepository)
        {
            _mapper = mapper;
            _callRepository = callRepository;
        }

        public async Task<ResponseBase> Handle(ForwardCallCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new ResponseBase();
            var call = await _callRepository.FindByAsync(x => x.CIHAZ_BAKIM_ISTEK_SEQ == request.CIHAZ_BAKIM_ISTEK_SEQ);
            if (call == null)
            {
                response.Success = false;
                response.StatusCode = 400;
                response.Message = "Çağrı bulunamadı";
            }
            else if (call.CBI_YOLLANAN_PER == request.YONLENDIRILEN_PERSONEL_SEQ)
            {
                response.Success = false;
                response.StatusCode = 400;
                response.Message = "Çağrıyı kendinize  yönlendiremezsiniz";
            }
            else
            {
                call.UPDATE_PER_SEQ = request.YONLENDIRILEN_PERSONEL_SEQ;
                call.YONLENDIRME_TARIH = DateTime.Now;
                call.UPDATE_DATE = DateTime.Now;
                call.CBI_YOLLANAN_PER = request.YONLENDIRILEN_PERSONEL_SEQ;
                call.STATU = "Yönlendirildi";
                ForwardCallCommandResponse forwardCallCommandResponse = new ForwardCallCommandResponse();
                forwardCallCommandResponse.CIHAZ_BAKIM_ISTEK_SEQ = request.CIHAZ_BAKIM_ISTEK_SEQ;
                forwardCallCommandResponse.DEVIRETME_NEDENI = request.DEVIRETME_NEDENI;
                forwardCallCommandResponse.YONLENDIRILEN_PERSONEL_SEQ = request.YONLENDIRILEN_PERSONEL_SEQ;
                forwardCallCommandResponse.YONLENDIRME_TARIHI = DateTime.Now;
                await _callRepository.YonlendirmeDetay(_mapper.Map<ForwardCallCommandResponse, CIHAZ_BAKIM_YONLENDIRME>(forwardCallCommandResponse));
                await _callRepository.Forward(call);
                response.Success = true;
                response.StatusCode = 200;
                response.Message = "Çağrı yönlendirildi";
            }
            return response;
        }
    }
}
