namespace Aeronave.Infraestructure.EF.ReadModel
{
    public class DetalleAeronaveReadModel
    {
        public Guid Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Capacidad { get; set; }
        public int NroAsientos { get; set; }
        public float CapacidadTanque { get; set; }
        public int Aeropuerto { get; set; }
        public Guid AeronaveId { get; set; }
        public AeronaveReadModel Aeronave { get; set; }
    }
}