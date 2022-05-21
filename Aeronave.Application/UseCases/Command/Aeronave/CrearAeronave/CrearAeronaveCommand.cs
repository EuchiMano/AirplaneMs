using Aeronave.Application.Dto.Aeronave;
using MediatR;

namespace Aeronave.Application.Dto.UseCases.Command.Aeronave
{
    public class CrearAeronaveCommand : IRequest<Guid>
    {
        private CrearAeronaveCommand(){ }
        public CrearAeronaveCommand(AeronaveDetalleDto detalle)
        {
            Detalle = detalle;
        }
        public AeronaveDetalleDto Detalle { get; set; }
    }
}