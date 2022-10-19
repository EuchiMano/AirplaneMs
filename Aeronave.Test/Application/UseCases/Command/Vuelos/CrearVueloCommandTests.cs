using System;
using Aeronave.Application.UseCases.Command.Vuelos;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Command;

public class CrearVueloCommandTests
{
    [Fact]
    public void IsRequest_Valid()
    {
        var nroVuelo = Guid.NewGuid();
        var aeronaveId = Guid.NewGuid();
        var estadoVuelo = "A";
        var fechaVuelo = DateTime.Now;
        var aeropuertoOrigen = Guid.NewGuid();
        var aeropuertoDestino = Guid.NewGuid();

        var command = new CrearVueloCommand(
            nroVuelo,
            aeronaveId,
            estadoVuelo,
            fechaVuelo,
            aeropuertoOrigen,
            aeropuertoDestino);

        Assert.Equal(nroVuelo, command.vueloId);
        Assert.Equal(aeronaveId, command.codAeronave);
        Assert.Equal(estadoVuelo, command.estado);
        Assert.Equal(fechaVuelo, command.fecha);
        Assert.Equal(aeropuertoOrigen, command.codOrigen);
        Assert.Equal(aeropuertoDestino, command.codDestino);
    }
}