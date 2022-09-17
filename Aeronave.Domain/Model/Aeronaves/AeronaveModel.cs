using Aeronave.Domain.Event;
using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Model.Aeronaves;

public class AeronaveModel : AggregateRoot<Guid>
{
    private AeronaveModel()
    {
        Capacidad = 0;
        NroAsientos = 0;
        CapacidadTanque = 0;
    }

    public AeronaveModel(EstadoAeronave estadoAeronave, string marca, string modelo, int capacidad, int nroAsientos,
        int capacidadTanque, Aeropuerto aeropuerto)
    {
        Id = Guid.NewGuid();
        EstadoAeronave = EstadoAeronave.Operativo;
        Marca = marca;
        Modelo = modelo;
        Capacidad = capacidad;
        NroAsientos = nroAsientos;
        CapacidadTanque = capacidadTanque;
        Aeropuerto = aeropuerto;
    }

    public EstadoAeronave EstadoAeronave { get; }
    public string Marca { get; }
    public string Modelo { get; }
    public int Capacidad { get; }
    public int NroAsientos { get; }
    public int CapacidadTanque { get; }
    public Aeropuerto Aeropuerto { get; private set; }

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

public enum EstadoAeronave
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