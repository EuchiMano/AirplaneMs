using Aeronave.Domain.Event;
using Aeronave.Domain.Model.Aeronaves.ValueObjects;
using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Model.Aeronaves
{
    public class AeronaveModel : AggregateRoot<Guid>
    {
        public Estado EstadoAeronave { get; set; }
        public NumeroAeronave NroAeronave { get; private set; }
        public AeronaveDetalle Detalle { get; private set; }

        public AeronaveModel(string nroAeronave)
        {
            Id = Guid.NewGuid();
            NroAeronave = nroAeronave;
    
        }
        public void AgregarDetalle(string marca, string modelo, float capacidad, int nroAsientos, float capacidadTanque, Aeropuerto aeropuerto)
        {
            if (Detalle is null)
            {
                Detalle = new AeronaveDetalle(marca, modelo, capacidad, nroAsientos, capacidadTanque, aeropuerto);
            }
            AddDomainEvent(new AeronaveAgregada(Id, NroAeronave));
        }
    }

    public enum Estado
    {
        Operativo,
        Mantenimiento
    }
}