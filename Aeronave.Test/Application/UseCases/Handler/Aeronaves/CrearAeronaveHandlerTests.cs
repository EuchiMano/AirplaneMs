using System;
using System.Collections.Generic;
using System.Threading;
using Aeronave.Application.UseCases.Command.Aeronaves.CrearAeronave;
using Aeronave.Domain.Event;
using Aeronave.Domain.Factories;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;
using Microsoft.Extensions.Logging;
using Moq;
using SharedKernel.Core;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Handler;

public class CrearAeronaveHandlerTests
{
    private readonly Mock<IAeronaveFactory> _aeronaveFactory;
    private readonly Mock<IAeronaveRepository> _aeronaveRepository;
    private readonly Mock<ILogger<CrearAeronaveHandler>> _logger;
    private readonly Mock<IUnitOfWork> _unitOfWork;


    private readonly EstadoAeronave estado = EstadoAeronave.Operativo;
    private readonly AeronaveModel aeronaveTest;
    private readonly Aeropuerto aeropuertoTest = Aeropuerto.LaPaz;
    private readonly int capacidadTanqueTest = 100;
    private readonly int capacidadTest = 100;
    private readonly string marcaTest = "Marca Generico";
    private readonly string modeloTest = "Modelo Generico";
    private readonly int nroAsientosTest = 100;

    public CrearAeronaveHandlerTests()
    {
        _aeronaveRepository = new Mock<IAeronaveRepository>();
        _unitOfWork = new Mock<IUnitOfWork>();
        _aeronaveFactory = new Mock<IAeronaveFactory>();
        _logger = new Mock<ILogger<CrearAeronaveHandler>>();

        aeronaveTest = new AeronaveFactory().Create(
            marcaTest,
            modeloTest,
            capacidadTest,
            nroAsientosTest,
            capacidadTanqueTest,
            aeropuertoTest);
    }

    [Fact]
    public void CrearAeronaveHandler_HandleCorrectly()
    {
        _aeronaveFactory.Setup(factory => factory.Create(
                marcaTest,
                modeloTest,
                capacidadTest,
                nroAsientosTest,
                capacidadTanqueTest,
                aeropuertoTest))
            .Returns(aeronaveTest);

        var objHandler = new CrearAeronaveHandler(
            _aeronaveRepository.Object,
            _aeronaveFactory.Object,
            _unitOfWork.Object,
            _logger.Object
        );

        var objRequest = new CrearAeronaveCommand(
            estado,
            marcaTest,
            modeloTest,
            capacidadTest,
            nroAsientosTest,
            capacidadTanqueTest,
            aeropuertoTest);

        var tcs = new CancellationTokenSource(1000);
        var result = objHandler.Handle(objRequest, tcs.Token);
        Assert.IsType<Guid>(result.Result);

        var domainEventList = (List<DomainEvent>)aeronaveTest.DomainEvents;
        Assert.Single(domainEventList);
        Assert.IsType<AeronaveCreado>(domainEventList[0]);
    }

    [Fact]
    public void CrearAeronaveHandlerHandleFail()
    {
        var objHandler = new CrearAeronaveHandler(
            _aeronaveRepository.Object,
            _aeronaveFactory.Object,
            _unitOfWork.Object,
            _logger.Object
        );
        var objRequest = new CrearAeronaveCommand(
            estado,
            marcaTest,
            modeloTest,
            capacidadTest,
            nroAsientosTest,
            capacidadTanqueTest,
            aeropuertoTest
        );
        var tcs = new CancellationTokenSource(1000);
        var result = objHandler.Handle(objRequest, tcs.Token);
        _logger.Verify(mock => mock.Log(
                It.Is<LogLevel>(logLevel => logLevel == LogLevel.Error),
                It.Is<EventId>(eventId => eventId.Id == 0),
                It.Is<It.IsAnyType>((@object, type) => @object.ToString() == "Error al crear aeronave"),
                It.IsAny<Exception>(),
                It.IsAny<Func<It.IsAnyType, Exception, string>>()!)
            , Times.Once);
    }
}