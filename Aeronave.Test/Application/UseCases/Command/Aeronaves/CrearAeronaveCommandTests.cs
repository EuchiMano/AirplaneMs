using Aeronave.Application.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronave.Domain.Model.Aeronaves;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Command;

public class CrearAeronaveCommandTests
{
    [Fact]
    public void IsRequest_Valid()
    {
        const string marca = "Marca Generico";
        const string modelo = "Modelo Generico";
        const int capacidadTest = 100;
        const int nroAsientosTest = 100;
        const int capacidadTanqueTest = 100;
        const Aeropuerto aeropuertoTest = Aeropuerto.LaPaz;
        var command = new CrearAeronaveCommand(
            EstadoAeronave.Operativo,
            marca,
            modelo,
            capacidadTest,
            nroAsientosTest,
            capacidadTanqueTest,
            aeropuertoTest
        );

        Assert.Equal(EstadoAeronave.Operativo, command.EstadoAeronave);
        Assert.Equal(marca, command.Marca);
        Assert.Equal(modelo, command.Modelo);
        Assert.Equal(capacidadTest, command.Capacidad);
        Assert.Equal(nroAsientosTest, command.NroAsientos);
        Assert.Equal(capacidadTanqueTest, command.CapacidadTanque);
        Assert.Equal(aeropuertoTest, command.Aeropuerto);
    }
}