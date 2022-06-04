using Aeronave.Domain.Event;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Model.Vuelos
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public string NroVuelo { get; private set; }
        public DateTime HoraLlegada { get; private set; }
        public DateTime HoraPartida { get; private set; }
        public int IdTripulacion { get; private set; }
        public Guid AeronaveId { get; private set; }
        public Aeropuerto AeropuertoOrigen { get; private set; }
        public Aeropuerto AeropuertoDestino { get; private set; }

        private Vuelo()
        {
        }

        internal Vuelo(string nroVuelo, DateTime horaLlegada, DateTime horaPartida, int idTripulacion, Guid aeronaveId, Aeropuerto aeropuertoOrigen, Aeropuerto aeropuertoDestino)
        {
            Id = Guid.NewGuid();
            NroVuelo = nroVuelo;
            HoraLlegada = horaLlegada;
            HoraPartida = horaPartida;
            IdTripulacion = idTripulacion;
            AeronaveId = aeronaveId;
            AeropuertoOrigen = aeropuertoOrigen;
            AeropuertoDestino = aeropuertoDestino;
        }

        public void ConsolidarVuelo()
        {
            var evento = new VueloCreado(Id, NroVuelo, AeronaveId, AeropuertoDestino);
            AddDomainEvent(evento);
        }
    }
}