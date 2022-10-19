using System.Collections.Generic;
using System.Threading;
using Aeronave.Application.Dto.Aeronave;
using Aeronave.Application.UseCases.Queries.Aeronaves.GetAeronavesList;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;
using Moq;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Queries;

public class GetAeronaveListHandlerTests
{
    private readonly Mock<IAeronaveRepository> _aeronaveRepositoryMock;
    private readonly Aeropuerto aeropuertoTest = Aeropuerto.LaPaz;
    private readonly int capacidadTanqueTest = 100;
    private readonly int capacidadTest = 100;
    private readonly string marcaTest = "Marca Generico";
    private readonly string modeloTest = "Modelo Generico";
    private readonly int nroAsientosTest = 100;


    private readonly List<AeronaveModel> objAeronaveModel;

    public GetAeronaveListHandlerTests()
    {
        _aeronaveRepositoryMock = new Mock<IAeronaveRepository>();
        objAeronaveModel = new List<AeronaveModel>
        {
            new(marcaTest, modeloTest, capacidadTest, nroAsientosTest, capacidadTanqueTest, aeropuertoTest)
        };
    }

    [Fact]
    public void Handle_Correctly()
    {
        _aeronaveRepositoryMock.Setup(factory => factory.GetAllOperativeAeronaves())
            .ReturnsAsync(objAeronaveModel);

        var objHandler = new GetAeronaveListHandler(
            _aeronaveRepositoryMock.Object);


        var objRequest = new GetAeronavesListByQuery();

        var tcs = new CancellationTokenSource(1000);
        var result = objHandler.Handle(objRequest, tcs.Token);
        Assert.IsAssignableFrom<ICollection<AeronaveDto>>(result.Result);
    }
}