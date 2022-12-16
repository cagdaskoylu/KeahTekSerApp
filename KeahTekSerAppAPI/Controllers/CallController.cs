 using KeahTekSerAppAPI.CQRS.Request.Command.Call;
using KeahTekSerAppAPI.CQRS.Request.Query.Call;
using KeahTekSerAppAPI.CQRS.Request.Query.CallView;
using KeahTekSerAppAPI.Database.Entites;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KeahTekSerAppAPI.Controllers
{
    [Route("call")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CallController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CallController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll([FromQuery] AllCallsViewQueryRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("getDetailBySeq")]
        public async Task<IActionResult> GetDetailBySeq([FromQuery] GetCallDetailBySeqQueryRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("getUnresponsedCalls")]
        public async Task<IActionResult> GetUnresponsed([FromQuery] UnresponsedCallsViewQueryRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpPut("forwardCall")]
        public async Task<IActionResult> ForwardCall([FromBody] ForwardCallCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpPost("responseCall")]
        public async Task<IActionResult> ResponseCall([FromBody] ResponseCallCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpGet("getBakimSebebi")]
        public async Task<IActionResult> GetBakimSebebi([FromQuery] GetBakimSebebiQueryRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }
    }
}
