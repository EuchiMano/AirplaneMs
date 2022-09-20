using Aeronave.Domain.Enums;
using Aeronave.Domain.Event;
using Aeronave.Domain.Model.Aeronaves;
using SharedKernel.Core;

namespace Aeronave.Domain.Model.Vuelos
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public Guid NroVuelo { get; private set; }
        public Guid AeronaveId { get; private set; }
        public string Estado { get; private set; }
        public DateTime Fecha { get; private set; }
        public Guid AeropuertoOrigen { get; private set; }
        public Guid AeropuertoDestino { get; private set; }

        private Vuelo()
        {
        }

        internal Vuelo(Guid nroVuelo, Guid aeronaveId, string estado, DateTime fecha, Guid aeropuertoOrigen, Guid aeropuertoDestino)
        {
            Id = Guid.NewGuid();
            NroVuelo = nroVuelo;
            AeronaveId = aeronaveId;
            Estado = estado;
            Fecha = fecha;
            AeropuertoOrigen = aeropuertoOrigen;
            AeropuertoDestino = aeropuertoDestino;
        }
    }
}