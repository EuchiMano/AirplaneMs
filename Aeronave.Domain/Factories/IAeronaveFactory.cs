using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Domain.Factories
{
    public interface IAeronaveFactory
    {
        AeronaveModel Create(EstadoAeronave estadoAeronave, string marca, string modelo, int capacidad, int nroAsientos, int capacidadTanque, Aeropuerto aeropuerto);
    }
}