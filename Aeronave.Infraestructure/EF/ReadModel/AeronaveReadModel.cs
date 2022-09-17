using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Infraestructure.EF.ReadModel
{
    public class AeronaveReadModel
    {
        public Guid Id { get; set; }
        public EstadoAeronave EstadoAeronave { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public int NroAsientos { get; set; }
        public int CapacidadTanque { get; set; }
    }
}