using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Model.Vuelos;

namespace Aeronave.Domain.Factories
{
    public interface IVueloFactory
    {
        Vuelo Create(string nroVuelo, DateTime horaLlegada, DateTime horaPartida, int idTripulacion, Guid aeronaveId, Aeropuerto aeropuertoOrigen, Aeropuerto aeropuertoDestino);
    }
}