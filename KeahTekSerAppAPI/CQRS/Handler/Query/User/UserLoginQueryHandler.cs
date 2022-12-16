using AutoMapper;
using KeahTekSerAppAPI.CQRS.Request.Query.User;
using KeahTekSerAppAPI.CQRS.Response.Query.User;
using KeahTekSerAppAPI.Data.DTO;
using KeahTekSerAppAPI.Database.Entites;
using KeahTekSerAppAPI.Repositories.User;
using KeahTekSerAppAPI.Security;
using MediatR;
using System;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.CQRS.Handler.Query.User
{
    public class UserLoginQueryHandler : IRequestHandler<UserLoginQueryRequest, ResponseBase<UserDto>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserLoginQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<ResponseBase<UserDto>> Handle(UserLoginQueryRequest request, CancellationToken cancellationToken)
        {
            var response = new ResponseBase<UserDto>();
            var check = _mapper.Map<UserLoginQueryRequest, PERSONEL_TABLOSU>(request);
            var user = await _userRepository.Login(check);

            if (user == null)
            {
                response.StatusCode = 404;
                response.Success = false;
                response.Message = "Bu TC numarasına sahip bir personel mevcut değil";
            }
            else if (user.PERSONEL_ID_NUMBER == request.PERSONEL_ID_NUMBER && user.PERSONEL_SIFRE != request.PERSONEL_SIFRE)
            {
                response.Success = false;
                response.StatusCode = 400;
                response.Message = "Şifre Hatalı";
            }
            else if (user.PERSONEL_ID_NUMBER == request.PERSONEL_ID_NUMBER && user.PERSONEL_SIFRE == request.PERSONEL_SIFRE)
            {
                var token = CreateToken.CreateTokenRegister(_mapper.Map<PERSONEL_TABLOSU, UserCreateTokenQueryResponse>(user));
                var userDto = new UserDto();
                // NULL EXCEPTION FIRLATIYOR BAKILACAK


                userDto.PERSONEL_SEQ = user.PERSONEL_SEQ;
                userDto.PERSONEL_ID_NUMBER = user.PERSONEL_ID_NUMBER;
                userDto.PERSONEL_SIFRE = "";
                userDto.PERSONEL_ADI = user.PERSONEL_ADI;
                userDto.PERSONEL_SOYADI = user.PERSONEL_SOYADI;
                userDto.PERSONEL_BIRIMI = user.PERSONEL_BIRIMI;
                response.Success = true;
                response.StatusCode = 200;
                response.Message = "Giriş Başarılı";
                response.Data = userDto;
                response.Token = token;
            }
            return response;
        }
    }
}
