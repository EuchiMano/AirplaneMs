using System;
using Aeronave.Application.Dto.Aeronave;
using Aeronave.Application.Dto.Vuelo;
using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Test.Application.Dto
{
    public class MockFactoryGeneric
    {
        public static VueloDto GetVuelo()
        {
            return new VueloDto()
            {
                HoraPartida = new DateTime(2022, 06, 04, 02, 00, 00),
                HoraLlegada = new DateTime(2022, 06, 04, 04, 00, 00),
                AeronaveId = Guid.NewGuid(),
                AeropuertoDestino = Aeropuerto.Cochabamba,
                IdTripulacion = 1
            };
        }
    }
}