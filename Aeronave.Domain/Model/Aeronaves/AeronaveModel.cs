using Aeronave.Domain.Event;
using Aeronave.ShareKernel.Core;
using System;

namespace Aeronave.Domain.Model.Aeronaves
{
    public class AeronaveModel : AggregateRoot<Guid>
    {
        public Estado EstadoAeronave { get; set; }
        public AeronaveDetalle _detalle { get; set; }
        internal AeronaveModel()
        {
            Id = Guid.NewGuid();
            _detalle = new AeronaveDetalle();
        }

        public void AgregarDetalle(string marca, string modelo, float capacidad, int nroAsientos, float capacidadTanque, Aeropuerto aeropuerto)
        {
            _detalle = new AeronaveDetalle(marca, modelo, capacidad, nroAsientos, capacidadTanque, aeropuerto);
        }

        public void ConsolidarAeronave()
        {
            var evento = new AeronaveCreado(Id);
            AddDomainEvent(evento);
        }
    }

    public enum Estado
    {
        Operativo,
        Mantenimiento
    }
}