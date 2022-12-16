using KeahTekSerAppAPI.CQRS.Request.Query.User;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.Controllers
{
    [Route("user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginQueryRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
