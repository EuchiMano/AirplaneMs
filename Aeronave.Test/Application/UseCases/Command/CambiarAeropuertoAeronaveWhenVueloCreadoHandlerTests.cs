using System;
using System.Threading;
using System.Threading.Tasks;
using Aeronave.Application.UseCases.Command.Aeronaves.CambiarAeropuertoAeronaveWhenVueloCreado;
using Aeronave.Domain.Event;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;
using Moq;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Command
{
    public class CambiarAeropuertoAeronaveWhenVueloCreadoHandlerTests
    {
        private readonly Mock<IAeronaveRepository> _aeronaveRepository;

        public CambiarAeropuertoAeronaveWhenVueloCreadoHandlerTests()
        {
            _aeronaveRepository = new Mock<IAeronaveRepository>();
        }

        //[Fact]
        //public void Handle_Correctly()
        //{
        //    var aeronaveIdTest = Guid.NewGuid();
        //    var vueloIdTest = Guid.NewGuid();
        //    var nroVueloTest = "ABC";
        //    var aeropuertoDestinoTest = Aeropuerto.Cochabamba;

        //    const string marcaTest = "Marca Generico";
        //    const string modeloTest = "Modelo Generico";
        //    const int capacidadTest = 100;
        //    const int nroAsientosTest = 100;
        //    const int capacidadTanqueTest = 100;
        //    const Aeropuerto aeropuertoTest = Aeropuerto.LaPaz;
        //    var aeronaveTest = new AeronaveModel(marcaTest, modeloTest, capacidadTest, nroAsientosTest, capacidadTanqueTest, aeropuertoTest);
        //    var tcs = new CancellationTokenSource(1000);

        //    _aeronaveRepository.Setup(mock => mock.FindByIdAsync(aeronaveIdTest))
        //        .Returns(Task.FromResult(aeronaveTest));

        //    var handler = new CambiarAeropuertoAeronaveWhenVueloCreadoHandler(_aeronaveRepository.Object);
        //    var objRequest = new VueloHabilitado(
        //        vueloIdTest, nroVueloTest, aeronaveIdTest, aeropuertoDestinoTest);
        //    var result = handler.Handle(objRequest, tcs.Token);
        //    Assert.Equal(Aeropuerto.Cochabamba, aeronaveTest.Aeropuerto);
        //}
    }
}