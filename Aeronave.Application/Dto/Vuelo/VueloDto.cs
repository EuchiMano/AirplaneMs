using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Application.Dto.Vuelo
{
    public class VueloDto
    {
        public DateTime HoraLlegada { get; set; }
        public DateTime HoraPartida { get; set; }
        public int IdTripulacion { get; set; }
        public Guid AeronaveId { get; set; }
        public Aeropuerto AeropuertoDestino { get; set; }
    }
}