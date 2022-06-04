using Moq;
using System;
using Aeronave.Application.Dto.Vuelo;
using Aeronave.Domain.Model.Aeronaves;
using Xunit;

namespace Aeronave.Test.Application.Dto
{
    public class VueloDtoTest
    {
        [Fact]
        public void VueloDtoCheckPropertiesValid()
        {
            var idTripulacionTest = 10;
            var objVuelo = new VueloDto();

            Assert.Equal(default, objVuelo.HoraLlegada);
            Assert.Equal(default, objVuelo.HoraPartida);
            Assert.Equal(0, objVuelo.IdTripulacion);
            Assert.Equal(Guid.Empty, objVuelo.AeronaveId);
            Assert.Equal(Aeropuerto.SantaCruz, objVuelo.AeropuertoDestino);

            objVuelo.IdTripulacion = idTripulacionTest;
            Assert.Equal(idTripulacionTest, objVuelo.IdTripulacion);
        }
    }
}