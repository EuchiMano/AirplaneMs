using Aeronave.Application.Dto.Aeronave;
using MediatR;

namespace Aeronave.Application.Dto.UseCases.Command.Aeronave
{
    public class CrearAeronaveCommand : IRequest<Guid>
    {
        public List<AeronaveDetalleDto> Detalle { get; private set; }
        public CrearAeronaveCommand(List<AeronaveDetalleDto> detalle)
        {
            Detalle = detalle;
        }


    }
}