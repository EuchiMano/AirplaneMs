using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aeronave.Application.UseCases.Command.Vuelos;
using Aeronave.Application.UseCases.Consumers;
using MediatR;
using Moq;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Consumers
{
    public class VueloConcluidoConsumerTests
    {
        private readonly Mock<IMediator> _mediator;

        private readonly Guid nroVuelo = Guid.NewGuid();
        private readonly string estadoVuelo = "B";

        public VueloConcluidoConsumerTests()
        {
            _mediator = new Mock<IMediator>();
        }

        [Fact]
        public void VueloConcluidoConsumer_HandleCorrectly()
        {
            var objConsumer = new VueloConcluidoConsumer(_mediator.Object);
            var objRequested = new UpdateEstadoVueloCommand(
                nroVuelo,
                estadoVuelo);
            var result = objConsumer.Consume(null);
        }
    }
}
