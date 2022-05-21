using Aeronave.Application.Dto.UseCases.Command.Aeronave;
using Aeronave.Test.Application.Dto;
using System;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Command
{
    public class CrearAeronaveCommand_Tests
    {
        [Fact]
        public void IsRequest_Valid()
        {
            var detalleListTest = MockFactoryGeneric.GetDetalleAeronave();
            var command = new CrearAeronaveCommand(detalleListTest);

            Assert.Equal(detalleListTest.NroAsientos, command.Detalle.NroAsientos);
        }

        [Fact]
        public void TestConstructor_IsPrivate()
        {
            var command = (CrearAeronaveCommand)Activator.CreateInstance(typeof(CrearAeronaveCommand), true);
            Assert.Null(command.Detalle);
        }
    }
}