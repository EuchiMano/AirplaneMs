using Aeronave.Application.Dto.Aeronave;
using Aeronave.Domain.Model.Aeronaves;
using Xunit;

namespace Aeronave.Test.Application.Dto;

public class AeronaveDtoTests
{
    [Fact]
    public void IsData_Valid()
    {
        var marca = "marca";
        var modelo = "modelo";
        const int capacidadTest = 100;
        const int nroAsientosTest = 100;
        const int capacidadTanqueTest = 100;
        var aeropuerto = Aeropuerto.SantaCruz;
        var aeronave = new AeronaveDto();

        Assert.Equal(default, aeronave.EstadoAeronave);
        Assert.Null(aeronave.Marca);
        Assert.Null(aeronave.Modelo);
        Assert.Equal(0, aeronave.Capacidad);
        Assert.Equal(0, aeronave.NroAsientos);
        Assert.Equal(0, aeronave.CapacidadTanque);
        Assert.Equal(default, aeronave.Aeropuerto);

        aeronave.EstadoAeronave = EstadoAeronave.Operativo;
        aeronave.Capacidad = capacidadTest;
        aeronave.NroAsientos = nroAsientosTest;
        aeronave.CapacidadTanque = nroAsientosTest;
        aeronave.Marca = marca;
        aeronave.Modelo = modelo;
        aeronave.Aeropuerto = aeropuerto;

        Assert.Equal(capacidadTest, aeronave.Capacidad);
        Assert.Equal(nroAsientosTest, aeronave.NroAsientos);
        Assert.Equal(capacidadTanqueTest, aeronave.CapacidadTanque);
        Assert.Equal(EstadoAeronave.Operativo, aeronave.EstadoAeronave);
        Assert.Equal(marca, aeronave.Marca);
        Assert.Equal(modelo, aeronave.Modelo);
        Assert.Equal(aeropuerto, aeronave.Aeropuerto);
    }
}