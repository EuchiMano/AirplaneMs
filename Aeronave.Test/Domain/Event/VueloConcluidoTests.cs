using System;
using Aeronave.Domain.Model.Vuelos;
using Xunit;

namespace Aeronave.Test.Domain.Event;

public class VueloConcluidoTests
{
    [Fact]
    public void VueloConcluidoCorrectly()
    {
        var nroAsientos = 100;
        var horaLlegada = DateTime.Now;
        var estado = "A";
        var precio = 100;
        var fechaInicio = DateTime.Now.ToString();
        var vueloId = Guid.NewGuid();
        var horaConcluido = DateTime.Now;
        var fechaConcluido = DateTime.Now.ToString();

        var valueObject = new VueloConcluido();
        valueObject.estado = estado;
        valueObject.precio = precio;
        valueObject.fechaInicio = fechaInicio;
        valueObject.vueloId = vueloId;
        valueObject.fechaConcluido = fechaConcluido;
        valueObject.horaConcluido = horaConcluido;
        valueObject.horaLLegada = horaLlegada;

        Assert.Equal(estado, valueObject.estado);
        Assert.Equal(precio, valueObject.precio);
        Assert.Equal(fechaInicio, valueObject.fechaInicio);
        Assert.Equal(vueloId, valueObject.vueloId);
        Assert.Equal(fechaConcluido, valueObject.fechaConcluido);
        Assert.Equal(horaConcluido, valueObject.horaConcluido);
        Assert.Equal(horaLlegada, valueObject.horaLLegada);


        Assert.Equal(horaLlegada, valueObject.horaLLegada);
        Assert.Equal(horaLlegada, valueObject.horaLLegada);

    }
}