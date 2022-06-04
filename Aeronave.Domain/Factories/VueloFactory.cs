using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Model.Vuelos;

namespace Aeronave.Domain.Factories
{
    public class VueloFactory : IVueloFactory
    {
        public Vuelo Create(string nroVuelo, DateTime horaLlegada, DateTime horaPartida, int idTripulacion, Guid aeronaveId, Aeropuerto aeropuertoOrigen, Aeropuerto aeropuertoDestino)
        {
            return new Vuelo(nroVuelo, horaLlegada, horaPartida, idTripulacion, aeronaveId, aeropuertoOrigen, aeropuertoDestino);
        }
    }
}