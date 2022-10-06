using System;
using Aeronave.Application.UseCases.Command.Vuelos;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Command.Vuelos;

public class UpdateEstadoVueloCommandTests
{
    [Fact]
    public void IsRequest_Valid()
    {
        var vueloId = Guid.NewGuid();
        var estado = "A";
        var command = new UpdateEstadoVueloCommand(
            vueloId,
            estado
        );
        Assert.Equal(estado, command.estado);
        Assert.Equal(vueloId, command.vueloId);
    }
}