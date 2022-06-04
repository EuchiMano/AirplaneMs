using Aeronave.Application.UseCases.Command.Vuelos;
using Aeronave.Test.Application.Dto;
using System;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Command
{
    public class CrearVueloCommandTests
    {
        [Fact]
        public void IsRequest_Valid()
        {
            var vueloTest = MockFactoryGeneric.GetVuelo();
            var command = new CrearVueloCommand(vueloTest);
            Assert.NotNull(command.Vuelo);
        }

        [Fact]
        public void TestConstructor_IsPrivate()
        {
            var command = (CrearVueloCommand)Activator.CreateInstance(typeof(CrearVueloCommand), true)!;
            Assert.Null(command.Vuelo);
        }
    }
}