using Aeronave.Application.Dto.Aeronave;
using Aeronave.Domain.Model.Aeronaves;
using System;
using Xunit;

namespace Aeronave.Test.Application.Dto
{
    public class AeronaveDtoTests
    {
        [Fact]
        public void IsData_Valid()
        {
            const int capacidadTest = 100;
            const int nroAsientosTest = 100;
            const int capacidadTanqueTest = 100;
            var aeronave = new AeronaveDto();

            Assert.Equal(Estado.Mantenimiento,aeronave.EstadoAeronave);
            Assert.Null(aeronave.Marca);
            Assert.Null(aeronave.Modelo);
            Assert.Equal(0, aeronave.Capacidad);
            Assert.Equal(0, aeronave.NroAsientos);
            Assert.Equal(0, aeronave.CapacidadTanque);
            Assert.Equal(Aeropuerto.SantaCruz, aeronave.Aeropuerto);

            aeronave.Capacidad = capacidadTest;
            aeronave.NroAsientos = nroAsientosTest;
            aeronave.CapacidadTanque = nroAsientosTest;

            Assert.Equal(capacidadTest, aeronave.Capacidad);
            Assert.Equal(nroAsientosTest, aeronave.NroAsientos);
            Assert.Equal(capacidadTanqueTest, aeronave.CapacidadTanque);
        }
    }
}