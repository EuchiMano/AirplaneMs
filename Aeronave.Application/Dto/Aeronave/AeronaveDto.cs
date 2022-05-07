using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Application.Dto.Aeronave
{
    public class AeronaveDto
    {
        public Guid Id { get; set; }
        public Estado EstadoAeronave { get; set; }
        public AeronaveDetalleDto Detalle { get; set; }

        public AeronaveDto()
        {
            Detalle = new AeronaveDetalleDto();
        }
    }
}