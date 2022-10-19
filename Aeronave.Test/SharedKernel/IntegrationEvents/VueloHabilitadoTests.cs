using System;
using SharedKernel.IntegrationEvents;
using Xunit;

namespace Aeronave.Test.SharedKernel.IntegrationEvents;

public class VueloHabilitadoTests
{
    [Fact]
    public void VueloHabilitadoCorrectly()
    {
        var horaLlegada = DateTime.Now;
        var horaSalida = DateTime.Now;
        var codRuta = Guid.NewGuid();
        var codAeronave = Guid.NewGuid();
        var activo = 1;
        var stockAsientos = 100;
        var estado = "A";
        var precio = 100;
        var fecha = DateTime.Now;
        var vueloId = Guid.NewGuid();

        var valueObject = new VueloHabilitado();
        valueObject.estado = estado;
        valueObject.precio = precio;
        valueObject.fecha = fecha;
        valueObject.vueloId = vueloId;
        valueObject.codRuta = codRuta;
        valueObject.horaSalida = horaSalida;
        valueObject.horaLLegada = horaLlegada;
        valueObject.activo = activo;
        valueObject.stockAsientos = stockAsientos;
        valueObject.codAeronave = codAeronave;

        Assert.Equal(estado, valueObject.estado);
        Assert.Equal(precio, valueObject.precio);
        Assert.Equal(fecha, valueObject.fecha);
        Assert.Equal(vueloId, valueObject.vueloId);
        Assert.Equal(codRuta, valueObject.codRuta);
        Assert.Equal(horaSalida, valueObject.horaSalida);
        Assert.Equal(horaLlegada, valueObject.horaLLegada);
        Assert.Equal(activo, valueObject.activo);
        Assert.Equal(stockAsientos, valueObject.stockAsientos);
        Assert.Equal(codAeronave, valueObject.codAeronave);
        Assert.IsType<Guid>(valueObject.EventId);
        Assert.IsType<DateTime>(valueObject.OccuredOn);
    }
}