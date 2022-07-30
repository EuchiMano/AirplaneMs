using Aeronave.Application.UseCases.Command.Aeronaves.CrearAeronave;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AeronaveApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            //Guid id = await _mediator.Send(command);

            //if (id == Guid.Empty)
            //    return BadRequest();
            ////Comentary
            //return Ok(id);
            return BadRequest("Changed");
        }
    }
}
