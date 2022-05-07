using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Infraestructure.EF.ReadModel
{
    public class AeronaveReadModel
    {
        public Guid Id { get; set; }
        public Estado EstadoAeronave { get; set; }
        public DetalleAeronaveReadModel Detalle { get; set; }
    }
}