using System;
using Aeronave.Domain.Event;
using Xunit;

namespace Aeronave.Test.Domain.Event;

public class VueloCreadoTests
{
    [Fact]
    public void VueloCreadoCorrectly()
    {
        var nroVuelo = Guid.NewGuid();
        var aeronaveId = Guid.NewGuid();
        var estadoVuelo = "A";
        var fechaVuelo = DateTime.Now;
        var aeropuertoOrigen = Guid.NewGuid();
        var aeropuertoDestino = Guid.NewGuid();

        var command = new VueloCreado(
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
        Assert.IsType<Guid>(command.Id);
        Assert.IsType<DateTime>(command.OccuredOn);


    }
}