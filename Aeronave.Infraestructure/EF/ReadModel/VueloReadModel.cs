namespace Aeronave.Infraestructure.EF.ReadModel
{
    public class VueloReadModel
    {
        public Guid Id { get; set; }
        public string NroVuelo { get; private set; }
        public DateTime HoraLlegada { get; private set; }
        public DateTime HoraPartida { get; private set; }
        public int IdTripulacion { get; private set; }
        public Guid AeronaveId { get; set; }
    }
}