using Aeronave.Application.Dto.UseCases.Command.Aeronave;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AeronaveApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AeronaveController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AeronaveController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearAeronaveCommand command)
        {
            Guid id = await _mediator.Send(command);

            if (id == Guid.Empty)
                return BadRequest();

            return Ok(id);
        }
    }
}
