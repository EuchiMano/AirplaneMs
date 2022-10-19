using System;
using System.Collections.Generic;
using System.Threading;
using Aeronave.Application.Dto.Vuelo;
using Aeronave.Application.UseCases.Queries.Vuelos;
using Aeronave.Domain.Factories;
using Aeronave.Domain.Model.Vuelos;
using Aeronave.Domain.Repositories;
using Moq;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Queries;

public class GetVuelosListHandlerTests
{
    private readonly Mock<IVueloRepository> _vueloRepositoryMock;
    private readonly Guid aeronaveIdTest = Guid.NewGuid();
    private readonly Guid aeropuertoDestinoTest = Guid.NewGuid();
    private readonly Guid aeropuertoOrigenTest = Guid.NewGuid();
    private readonly string estadoTest = "A";
    private readonly DateTime fechaTest = DateTime.Now;
    private readonly Guid vueloIdTest = Guid.NewGuid();
    private readonly List<Vuelo> vueloTest;

    public GetVuelosListHandlerTests()
    {
        _vueloRepositoryMock = new Mock<IVueloRepository>();
        vueloTest =
            vueloTest = new List<Vuelo>
            {
                new VueloFactory().Create(
                    vueloIdTest,
                    aeronaveIdTest,
                    estadoTest,
                    fechaTest,
                    aeropuertoOrigenTest,
                    aeropuertoDestinoTest
                )
            };
    }

    [Fact]
    public void Handle_Correctly()
    {
        _vueloRepositoryMock.Setup(factory => factory.GetAllVuelos())
            .ReturnsAsync(vueloTest);

        var objHandler = new GetVuelosListHandler(
            _vueloRepositoryMock.Object);


        var objRequest = new GetVuelosQuery();

        var tcs = new CancellationTokenSource(1000);
        var result = objHandler.Handle(objRequest, tcs.Token);
        Assert.IsAssignableFrom<ICollection<VueloDto>>(result.Result);
    }
}