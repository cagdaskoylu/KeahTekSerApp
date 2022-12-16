using AutoMapper;
using KeahTekSerAppAPI.CQRS.Request.Command.Call;
using KeahTekSerAppAPI.CQRS.Response.Command.Call;
using KeahTekSerAppAPI.Database.Entites;
using KeahTekSerAppAPI.Repositories.BAKIM_ISTEK;
using MediatR;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.CQRS.Handler.Command.Call
{
    public class ResponseCallCommandHandler : IRequestHandler<ResponseCallCommandRequest, ResponseBase>
    {
        private readonly IMapper _mapper;
        private readonly ICallRepository _callRepository;
        public ResponseCallCommandHandler(IMapper mapper, ICallRepository callRepository)
        {
            _mapper = mapper;
            _callRepository = callRepository;
        }

        public async Task<ResponseBase> Handle(ResponseCallCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new ResponseBase();
            var call = await _callRepository.FindByAsync(x => x.CIHAZ_BAKIM_ISTEK_SEQ == request.CIHAZ_BAKIM_ISTEK_SEQ && (x.STATU == "Cevaplanmadı" || x.STATU == "Yönlendirildi"));
            if (call == null)
            {
                response.StatusCode = 400;
                response.Success = false;
                response.Message = "Çağrı bulunamadı";
            }
            else
            {
                var callResponse = new ResponseCallCommandResponse();
                callResponse.CIHAZ_BAKIM_ISTEK_SEQ = call.CIHAZ_BAKIM_ISTEK_SEQ;
                callResponse.CB_BAKIM_SEBEBI = call.BAKIM_SEBEBI;
                callResponse.CB_ONCESI_NOT = request.CB_ONCESI_NOT;
                callResponse.CB_SONRASI_NOT = request.CB_SONRASI_NOT;
                callResponse.CB_TARIH = request.BAKIM_TARIHI;
                callResponse.CB_BASLANGIC_SAAT = request.BASLANGIC_SAATI;
                callResponse.CB_BITIS_SAAT = request.BITIS_SAATI;




                callResponse.CB_YAPAN_KISI = call.CBI_YOLLANAN_PER;
                callResponse.CB_YAPILAN_ISLEMLER = request.CB_YAPILAN_ISLEMLER;
                call.STATU = "Cevaplandı";
                await _callRepository.Put(call);
                await _callRepository.PostCb(_mapper.Map<ResponseCallCommandResponse, CIHAZ_BAKIM>(callResponse));
                response.StatusCode = 200;
                response.Success = true;
                response.Message = "Cevap kaydedildi";
            }
            return response;
        }
    }
}