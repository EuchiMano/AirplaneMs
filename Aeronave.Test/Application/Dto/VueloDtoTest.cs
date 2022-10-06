using System;
using Aeronave.Application.Dto.Vuelo;
using Xunit;

namespace Aeronave.Test.Application.Dto;

public class VueloDtoTest
{
    [Fact]
    public void IsData_Valid()
    {
        var nroVuelo = Guid.NewGuid();
        var aeronaveId = Guid.NewGuid();
        var estado = "A";
        var fecha = DateTime.Now;
        var aeropuertoOrigen = Guid.NewGuid();
        var aeropuertoDestino = Guid.NewGuid();
        var vueloDto = new VueloDto();

        Assert.Equal(Guid.Empty, vueloDto.NroVuelo);
        Assert.Equal(Guid.Empty, vueloDto.AeronaveId);
        Assert.Null(vueloDto.Estado);
        Assert.Equal(default, vueloDto.Fecha);
        Assert.Equal(Guid.Empty, vueloDto.AeropuertoOrigen);
        Assert.Equal(Guid.Empty, vueloDto.AeropuertoDestino);

        vueloDto.NroVuelo = nroVuelo;
        vueloDto.AeronaveId = aeronaveId;
        vueloDto.Estado = estado;
        vueloDto.Fecha = fecha;
        vueloDto.AeropuertoOrigen = aeropuertoOrigen;
        vueloDto.AeropuertoDestino = aeropuertoDestino;

        Assert.Equal(nroVuelo, vueloDto.NroVuelo);
        Assert.Equal(aeronaveId, vueloDto.AeronaveId);
        Assert.Equal(estado, vueloDto.Estado);
        Assert.Equal(fecha, vueloDto.Fecha);
        Assert.Equal(aeropuertoOrigen, vueloDto.AeropuertoOrigen);
        Assert.Equal(aeropuertoDestino, vueloDto.AeropuertoDestino);
    }


}