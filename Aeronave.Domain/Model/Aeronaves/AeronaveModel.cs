using Aeronave.Domain.Event;
using SharedKernel.Core;

namespace Aeronave.Domain.Model.Aeronaves;

public class AeronaveModel : AggregateRoot<Guid>
{
    private AeronaveModel()
    {
        Capacidad = 0;
        NroAsientos = 0;
        CapacidadTanque = 0;
    }

    public AeronaveModel(string marca, string modelo, int capacidad, int nroAsientos,
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
    public Aeropuerto Aeropuerto { get; }

    public void ConsolidarAeronave()
    {
        var evento = new AeronaveCreado(Id);
        AddDomainEvent(evento);
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