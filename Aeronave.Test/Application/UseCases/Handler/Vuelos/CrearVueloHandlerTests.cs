using Aeronave.Application.Dto.Vuelo;
using Aeronave.Application.UseCases.Command.Vuelos;
using Aeronave.Domain.Event;
using Aeronave.Domain.Factories;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Model.Vuelos;
using Aeronave.Domain.Repositories;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SharedKernel.Core;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Handler
{
    public class CrearVueloHandlerTests
    {
        private readonly Mock<ILogger<CrearVueloHandler>> _logger;
        private readonly Mock<IUnitOfWork> _unitOfWork;
        private readonly Mock<IVueloRepository> _vueloRepository;
        private readonly Mock<IVueloFactory> _vueloFactory;
        private readonly Vuelo vueloTest;

        private readonly Guid vueloIdTest = Guid.NewGuid();
        private readonly Guid aeronaveIdTest = Guid.NewGuid();
        private readonly string estadoTest = "A";
        private readonly DateTime fechaTest = DateTime.Now;
        private readonly Guid aeropuertoOrigenTest = Guid.NewGuid();
        private readonly Guid aeropuertoDestinoTest = Guid.NewGuid();

        public CrearVueloHandlerTests()
        {
            _vueloRepository = new Mock<IVueloRepository>();
            _unitOfWork = new Mock<IUnitOfWork>();
            _logger = new Mock<ILogger<CrearVueloHandler>>();
            _vueloFactory = new Mock<IVueloFactory>();

            vueloTest = new VueloFactory().Create(
                vueloIdTest,
                aeronaveIdTest,
                estadoTest,
                fechaTest,
                aeropuertoOrigenTest,
                aeropuertoDestinoTest
            );
        }

        [Fact]
        public void Handle_Correctly()
        {

            _vueloFactory.Setup(factory => factory.Create(
                    vueloIdTest,
                    aeronaveIdTest,
                    estadoTest,
                    fechaTest,
                    aeropuertoOrigenTest,
                    aeropuertoDestinoTest))
                .Returns(vueloTest);

            var objHandler = new CrearVueloHandler(
                _vueloRepository.Object,
                _logger.Object,
                _vueloFactory.Object,
                _unitOfWork.Object);


            var objRequest = new CrearVueloCommand(
                vueloIdTest,
                aeronaveIdTest,
                estadoTest,
                fechaTest,
                aeropuertoOrigenTest,
                aeropuertoDestinoTest
            );

            var tcs = new CancellationTokenSource(1000);
            var result = objHandler.Handle(objRequest, tcs.Token);
            Assert.IsType<Guid>(result.Result);

            var domainEventList = (List<DomainEvent>)vueloTest.DomainEvents;
            Assert.Empty(domainEventList);
        }

        [Fact]
        public void CrearAeronaveHandlerHandleFail()
        {
            var objHandler = new CrearVueloHandler(
                _vueloRepository.Object,
                _logger.Object,
                _vueloFactory.Object,
                _unitOfWork.Object
            );
            var objRequest = new CrearVueloCommand(
                vueloIdTest,
                aeronaveIdTest,
                estadoTest,
                fechaTest,
                aeropuertoOrigenTest,
                aeropuertoDestinoTest
            );
            var tcs = new CancellationTokenSource(1000);
            var result = objHandler.Handle(objRequest, tcs.Token);
            _logger.Verify(mock => mock.Log(
                    It.Is<LogLevel>(logLevel => logLevel == LogLevel.Error),
                    It.Is<EventId>(eventId => eventId.Id == 0),
                    It.Is<It.IsAnyType>((@object, type) => @object.ToString() == "Error al crear vuelo"),
                    It.IsAny<Exception>(),
                    It.IsAny<Func<It.IsAnyType, Exception, string>>()!)
                , Times.Once);
        }
    }
}