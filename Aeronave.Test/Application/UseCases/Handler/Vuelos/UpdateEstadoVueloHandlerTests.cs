using System;
using System.Threading;
using System.Threading.Tasks;
using Aeronave.Application.UseCases.Command.Vuelos;
using Aeronave.Domain.Factories;
using Aeronave.Domain.Repositories;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Handler;

public class UpdateEstadoVueloHandlerTests
{
    private readonly Mock<ILogger<UpdateEstadoVueloHandler>> _logger;
    private readonly Mock<IUnitOfWork> _unitOfWork;
    private readonly Mock<IVueloRepository> _vueloRepository;

    public UpdateEstadoVueloHandlerTests()
    {
        _vueloRepository = new Mock<IVueloRepository>();
        _unitOfWork = new Mock<IUnitOfWork>();
        _logger = new Mock<ILogger<UpdateEstadoVueloHandler>>();
    }

    [Fact]
    public void Handle_Correctly()
    {
        var vueloIdTest = Guid.NewGuid();
        var aeronaveIdTest = Guid.NewGuid();
        var estadoTest = "A";
        var fechaTest = DateTime.Now;
        var aeropuertoOrigenTest = Guid.NewGuid();
        var aeropuertoDestinoTest = Guid.NewGuid();

        var estadoActualizadoTest = "B";

        var vueloFactory = new VueloFactory().Create(
            vueloIdTest,
            aeronaveIdTest,
            estadoTest,
            fechaTest,
            aeropuertoOrigenTest,
            aeropuertoDestinoTest);
        var tcs = new CancellationTokenSource(1000);

        _vueloRepository.Setup(mock => mock.GetByVueloId(vueloIdTest))
            .Returns(Task.FromResult(vueloFactory));

        var handler = new UpdateEstadoVueloHandler(
            _vueloRepository.Object,
            _unitOfWork.Object,
            _logger.Object);
        var objRequest = new UpdateEstadoVueloCommand(
            vueloIdTest,
            estadoActualizadoTest
        );
        var result = handler.Handle(objRequest, tcs.Token);

        Assert.Equal(estadoActualizadoTest, vueloFactory.Estado);
    }
}