using Aeronave.Application.UseCases.Command.Vuelos;
using Aeronave.Application.UseCases.Queries.Vuelos;
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


        [HttpGet]
        public async Task<IActionResult> GetAeronavesListAsync([FromRoute] GetVuelosQuery query)
        {
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
