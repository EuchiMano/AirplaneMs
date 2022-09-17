using Aeronave.Domain.Model.Vuelos;

namespace Aeronave.Domain.Factories
{
    public interface IVueloFactory
    {
        Vuelo Create(Guid nroVuelo, Guid aeronaveId, string estado, DateTime fecha, Guid aeropuertoOrigen, Guid aeropuertoDestino);
    }
}