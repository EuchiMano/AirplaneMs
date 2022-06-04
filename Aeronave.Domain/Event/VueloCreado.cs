using Aeronave.Domain.Model.Aeronaves;
using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Event
{
    public record VueloCreado : DomainEvent
    {
        public Guid VueloId { get; }
        public string NroVuelo { get; }
        public Guid AeronaveId { get; }
        public Aeropuerto AeropuertoDestino { get; }
        public VueloCreado(Guid vueloId, string nroVuelo, Guid aeronaveId, Aeropuerto aeropuertoDestino) : base(DateTime.Now)
        {
            VueloId = vueloId;
            NroVuelo = nroVuelo;
            AeronaveId = aeronaveId;
            AeropuertoDestino = aeropuertoDestino;
        }
    }
}