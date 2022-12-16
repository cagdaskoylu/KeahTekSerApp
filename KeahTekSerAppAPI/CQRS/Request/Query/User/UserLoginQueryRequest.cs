using KeahTekSerAppAPI.CQRS.Response.Query.User;
using KeahTekSerAppAPI.Data.DTO;
using MediatR;

namespace KeahTekSerAppAPI.CQRS.Request.Query.User
{
    public class UserLoginQueryRequest: IRequest<ResponseBase<UserDto>>
    {
        public long PERSONEL_ID_NUMBER { get; set; }
        public string PERSONEL_SIFRE { get; set; }
    }
}
