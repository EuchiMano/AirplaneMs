using System;
using Aeronave.Application.UseCases.Command.Aeronaves.EliminarAeronave;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Command.Aeronaves;

public class EliminarAeronaveCommandTests
{
    [Fact]
    public void IsRequest_Valid()
    {
        var id = Guid.NewGuid();
        var command = new EliminarAeronaveCommand();
        command.Id = id;

        Assert.Equal(id, command.Id);
    }
}