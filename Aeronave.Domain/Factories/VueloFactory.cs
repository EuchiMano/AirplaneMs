using Aeronave.Domain.Model.Vuelos;

namespace Aeronave.Domain.Factories;

public class VueloFactory : IVueloFactory
{
    public Vuelo Create(Guid nroVuelo, Guid aeronaveId, string estado, DateTime fecha, Guid aeropuertoOrigen,
        Guid aeropuertoDestino)
    {
        return new Vuelo(nroVuelo, aeronaveId, estado, fecha, aeropuertoOrigen, aeropuertoDestino);
    }
}