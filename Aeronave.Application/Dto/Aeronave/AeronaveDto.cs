using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Application.Dto.Aeronave
{
    public class AeronaveDto
    {
        public EstadoAeronave EstadoAeronave { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public int NroAsientos { get; set; }
        public int CapacidadTanque { get; set; }
        public Aeropuerto Aeropuerto { get; set; }
    }
}