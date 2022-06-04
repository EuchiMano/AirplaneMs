using Aeronave.Application.UseCases.Command.Vuelos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AeronaveApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VueloController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VueloController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearVueloCommand command)
        {
            Guid id = await _mediator.Send(command);

            if (id == Guid.Empty)
                return BadRequest();

            return Ok(id);
        }
    }
}
