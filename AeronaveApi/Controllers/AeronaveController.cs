using Aeronave.Application.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronave.Application.UseCases.Command.Aeronaves.EliminarAeronave;
using Aeronave.Application.UseCases.Queries.Aeronaves.GetAeronavesList;
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
        public async Task<IActionResult> CreateAsync([FromBody] CrearAeronaveCommand command)
        {
            Guid id = await _mediator.Send(command);

            if (id == Guid.Empty)
                return BadRequest();

            return Ok(id);
        }

        [HttpGet]
        public async Task<IActionResult> GetAeronavesListAsync([FromQuery] GetAeronavesListByQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAeronaveAsync([FromRoute] EliminarAeronaveCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
