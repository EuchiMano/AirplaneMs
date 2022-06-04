using Aeronave.Domain.Event;
using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Model.Aeronaves
{
    public class AeronaveModel : AggregateRoot<Guid>
    {
        public Estado EstadoAeronave { get; private set; }
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Capacidad { get; private set; }
        public int NroAsientos { get; private set; }
        public int CapacidadTanque { get; private set; }
        public Aeropuerto Aeropuerto { get; private set; }

        private AeronaveModel()
        {
            Capacidad = 0;
            NroAsientos = 0;
            CapacidadTanque = 0;
        }

        public AeronaveModel(string marca, string modelo, int capacidad, int nroAsientos, int capacidadTanque, Aeropuerto aeropuerto)
        {
            Id = Guid.NewGuid();
            EstadoAeronave = Estado.Operativo;
            Marca = marca;
            Modelo = modelo;
            Capacidad = capacidad;
            NroAsientos = nroAsientos;
            CapacidadTanque = capacidadTanque;
            Aeropuerto = aeropuerto;
        }

        public void ConsolidarAeronave()
        {
            var evento = new AeronaveCreado(Id);
            AddDomainEvent(evento);
        }

        public void CambiarAeropuertoActualAeronave(Aeropuerto aeropuerto)
        {
            Aeropuerto = aeropuerto;
        }
    }

    public enum Estado
    {
        Mantenimiento,
        Operativo
    }

    public enum Aeropuerto
    {
        SantaCruz,
        Cochabamba,
        LaPaz,
        Tarija
    }
}