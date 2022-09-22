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
using Xunit;

namespace Aeronave.Test.Application.UseCases.Handler
{
    public class CrearVueloHandlerTests
    {
        private readonly Mock<IVueloRepository> _vueloRepository;
        private readonly Mock<IAeronaveRepository> _aeronaveRepository;
        private readonly Mock<ILogger<CrearVueloHandler>> _logger;
        private readonly Mock<IVueloFactory> _vueloFactory;
        private readonly Mock<IUnitOfWork> _unitOfWork;

        private string marcaTest = "test";
        private string modeloTest = "test";
        private int capacidadTest = 100;
        private int nroAsientosTest = 100;
        private int capacidadTanqueTest = 100;
        private Aeropuerto aeropuertoTest = Aeropuerto.LaPaz;



        private string nroVueloTest = "ABC";
        private DateTime horaPartida = new DateTime(2022, 06, 04, 02, 00, 00);
        private DateTime horaLlegada = new DateTime(2022, 06, 04, 04, 00, 00);
        private Guid aeronaveId = Guid.NewGuid();
        private Aeropuerto aeropuertoDestino = Aeropuerto.Cochabamba;
        private Aeropuerto aeropuertoOrigen = Aeropuerto.SantaCruz;
        private int idTripulacion = 1;

        private Vuelo vueloTest;
        private VueloDto vueloDtoTest = MockFactoryGeneric.GetVuelo();

        public CrearVueloHandlerTests()
        {
            //_vueloRepository = new Mock<IVueloRepository>();
            //_logger = new Mock<ILogger<CrearVueloHandler>>();
            //_vueloService = new Mock<IVueloService>();
            //_vueloFactory = new Mock<IVueloFactory>();
            //_unitOfWork = new Mock<IUnitOfWork>();
            //_aeronaveRepository = new Mock<IAeronaveRepository>();
            //vueloTest = new VueloFactory().Create(nroVueloTest, horaLlegada, horaPartida, idTripulacion, aeronaveId, aeropuertoOrigen, aeropuertoDestino);

        }

        //[Fact]
        //public void CrearAeronaveHandler_HandleCorrectly()
        //{
        //    var newAeronaveModel = new AeronaveModel(marcaTest, modeloTest, capacidadTest, nroAsientosTest, capacidadTanqueTest, aeropuertoTest);

        //    _vueloService.Setup(vueloService => vueloService.GenerarNroVueloAsync()).Returns(Task.FromResult(nroVueloTest));
        //    _aeronaveRepository.Setup(aeronaveRepository => aeronaveRepository.FindByIdAsync(vueloDtoTest.AeronaveId)).Returns(Task.FromResult(newAeronaveModel));
        //    _vueloFactory.Setup(vueloFactory => vueloFactory.Create(nroVueloTest, horaLlegada, horaPartida, idTripulacion, newAeronaveModel.Id, newAeronaveModel.Aeropuerto, aeropuertoDestino)).Returns(vueloTest);
        //    var objHandler = new CrearVueloHandler(
        //        _vueloRepository.Object,
        //        _logger.Object,
        //        _vueloService.Object,
        //        _vueloFactory.Object,
        //        _unitOfWork.Object,
        //        _aeronaveRepository.Object
        //    );
        //    var objRequest = new CrearVueloCommand(
        //        vueloDtoTest
        //    );
        //    var tcs = new CancellationTokenSource(1000);
        //    var result = objHandler.Handle(objRequest, tcs.Token);

        //    _vueloRepository.Verify(mock => mock.CreateAsync(It.IsAny<Vuelo>()), Times.Once);
        //    _unitOfWork.Verify(mock => mock.Commit(), Times.Once);
        //    Assert.IsType<Guid>(result.Result);

        //    var domainEventList = (List<DomainEvent>)vueloTest.DomainEvents;
        //    Assert.Equal(1, domainEventList.Count);
        //    Assert.IsType<VueloHabilitado>(domainEventList[0]);
        //}

        [Fact]
        public void CrearVueloHandlerFail()
        {
            //var objHandler = new CrearVueloHandler(
            //       _vueloRepository.Object,
            //       _logger.Object,
            //       _vueloService.Object,
            //       _vueloFactory.Object,
            //       _unitOfWork.Object,
            //       _aeronaveRepository.Object
            //   );
            //   var objRequest = new CrearVueloCommand(
            //       vueloDtoTest
            //   );
            //   var tcs = new CancellationTokenSource(1000);
            //   var result = objHandler.Handle(objRequest, tcs.Token);
            //   _logger.Verify(mock => mock.Log(
            //           It.Is<LogLevel>(logLevel => logLevel == LogLevel.Error),
            //           It.Is<EventId>(eventId => eventId.Id == 0),
            //           It.Is<It.IsAnyType>((@object, @type) => @object.ToString() == "Error al crear vuelo"),
            //           It.IsAny<Exception>(),
            //           It.IsAny<Func<It.IsAnyType, Exception, string>>()!)
            //       , Times.Once);
        }
    }
}