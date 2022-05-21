using Aeronave.Application.Dto.Aeronave;
using Aeronave.Application.Dto.UseCases.Command.Aeronave;
using Aeronave.Domain.Event;
using Aeronave.Domain.Factories;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;
using Aeronave.ShareKernel.Core;
using Aeronave.Test.Application.Dto;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Aeronave.Test.Application.Handler
{
    public class CrearAeronaveHandler_Tests
    {
        private readonly Mock<IAeronaveRepository> aeronaveRepository;
        private readonly Mock<ILogger<CrearAeronaveHandler>> logger;
        private readonly Mock<IAeronaveFactory> aeronaveFactory;
        private readonly Mock<IUnitOfWork> unitOfWork;
        private AeronaveModel aeronaveTest;
        private AeronaveDetalleDto detalleAeronaveTest = MockFactoryGeneric.GetDetalleAeronave();
        public CrearAeronaveHandler_Tests()
        {
            aeronaveRepository = new Mock<IAeronaveRepository>();
            logger = new Mock<ILogger<CrearAeronaveHandler>>();
            aeronaveFactory = new Mock<IAeronaveFactory>();
            unitOfWork = new Mock<IUnitOfWork>();
            aeronaveTest = new AeronaveFactory().Create();
        }

        [Fact]
        public void CrearPedidoHandler_HandleCorrectly()
        {

            aeronaveFactory.Setup(aeronaveFactory => aeronaveFactory.Create()).Returns(aeronaveTest);
            var objHandler = new CrearAeronaveHandler(
                aeronaveRepository.Object,
                logger.Object,
                aeronaveFactory.Object,
                unitOfWork.Object);

            var objRequest = new CrearAeronaveCommand(
                detalleAeronaveTest
            );
            var tcs = new CancellationTokenSource(1000);
            var result = objHandler.Handle(objRequest, tcs.Token);

            //aeronaveRepository.Verify(mock => mock.CreateAsync(IsAny<AeronaveDetalle>()), Times.Once);
            unitOfWork.Verify(mock => mock.Commit(), Times.Once);
            Assert.IsType<Guid>(result.Result);

            var domainEventList = (List<DomainEvent>)aeronaveTest.DomainEvents;
            Assert.Single(domainEventList);
            Assert.IsType<AeronaveCreado>(domainEventList[0]);
        }
    }
}