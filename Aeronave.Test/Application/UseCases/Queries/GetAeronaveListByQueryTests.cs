using Aeronave.Application.UseCases.Queries.Aeronaves.GetAeronavesList;
using Aeronave.Domain.Model.Aeronaves;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Queries;

public class GetAeronaveListByQueryTests
{
    [Fact]
    public void IsRequest_Valid()
    {
        var aeropuertoTest = Aeropuerto.SantaCruz;
        var estadoTest = EstadoAeronave.Operativo;


        var command = new GetAeronavesListByQuery();
        command.Aeropuerto = aeropuertoTest;
        command.Estado = estadoTest;

        Assert.Equal(aeropuertoTest, command.Aeropuerto);
        Assert.Equal(estadoTest, command.Estado);
    }
}