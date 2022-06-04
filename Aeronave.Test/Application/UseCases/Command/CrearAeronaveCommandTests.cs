using System;
using Aeronave.Application.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronave.Domain.Model.Aeronaves;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Command
{
    public class CrearAeronaveCommandTests
    {
        [Fact]
        public void CrearAeronaveCommandDataValid()
        {
            const string marcaTest = "Marca Generico";
            const string modeloTest = "Modelo Generico";
            const int capacidadTest = 100;
            const int nroAsientosTest = 100;
            const int capacidadTanqueTest = 100;
            const Aeropuerto aeropuertoTest = Aeropuerto.LaPaz;
            var command = new CrearAeronaveCommand(marcaTest, modeloTest, capacidadTest, nroAsientosTest, capacidadTanqueTest, aeropuertoTest);

            Assert.Equal(capacidadTest, command.Capacidad);
            Assert.Equal(nroAsientosTest, command.NroAsientos);
            Assert.Equal(capacidadTanqueTest, command.CapacidadTanque);
            Assert.Equal(aeropuertoTest, command.Aeropuerto);
        }


        [Fact]
        public void TestConstructor_IsPrivate()
        {
            var command = (CrearAeronaveCommand)Activator.CreateInstance(typeof(CrearAeronaveCommand), true)!;
            Assert.Null(command.Marca);
            Assert.Equal(0, command.NroAsientos);
            Assert.Equal(Aeropuerto.SantaCruz, command.Aeropuerto);
        }
    }
}