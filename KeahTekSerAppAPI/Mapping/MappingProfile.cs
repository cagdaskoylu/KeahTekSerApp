using AutoMapper;
using KeahTekSerAppAPI.CQRS.Request.Query.User;
using KeahTekSerAppAPI.CQRS.Response.Command.Call;
using KeahTekSerAppAPI.CQRS.Response.Query.User;
using KeahTekSerAppAPI.Data.DTO;
using KeahTekSerAppAPI.Database.DTO;
using KeahTekSerAppAPI.Database.Entites;
using System.Collections.Generic;

namespace KeahTekSerAppAPI.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CIHAZ_BAKIM_ISTEK, CallDto>().ReverseMap();
            CreateMap<ResponseCallCommandResponse, CIHAZ_BAKIM_ISTEK>().ReverseMap();

            CreateMap<PERSONEL_TABLOSU, UserCreateTokenQueryResponse>().ReverseMap();
            CreateMap<PERSONEL_TABLOSU, UserLoginQueryRequest>().ReverseMap();

            CreateMap<ForwardCallCommandResponse, CIHAZ_BAKIM_YONLENDIRME>().ReverseMap();

            CreateMap<ResponseCallCommandResponse, CIHAZ_BAKIM>().ReverseMap();

            CreateMap<CIHAZ_BAKIM_SEBEBI, BakimSebebiDto>().ReverseMap();
        }

    }
}
