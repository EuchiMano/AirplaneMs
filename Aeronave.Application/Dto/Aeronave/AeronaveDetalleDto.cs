namespace Aeronave.Application.Dto.Aeronave
{
    public class AeronaveDetalleDto
    {
        public Guid AeronaveId { get; set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public float Capacidad { get; private set; }
        public int NroAsientos { get; private set; }
        public float CapacidadTanque { get; private set; }
        public int Aeropuerto { get; private set; }
    }
}