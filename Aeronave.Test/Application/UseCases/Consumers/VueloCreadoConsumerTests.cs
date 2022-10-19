using System;
using Aeronave.Application.UseCases.Command.Vuelos;
using Aeronave.Application.UseCases.Consumers;
using MediatR;
using Moq;
using Xunit;

namespace Aeronave.Test.Application.UseCases.Consumers;

public class VueloCreadoConsumerTests
{
    private readonly Mock<IMediator> _mediator;
    private readonly Guid aeronaveIdTest = Guid.NewGuid();
    private readonly Guid aeropuertoDestinoTest = Guid.NewGuid();
    private readonly Guid aeropuertoOrigenTest = Guid.NewGuid();
    private readonly string estadoTest = "A";
    private readonly DateTime fechaTest = DateTime.Now;

    private readonly Guid nroVuelo = Guid.NewGuid();

    public VueloCreadoConsumerTests()
    {
        _mediator = new Mock<IMediator>();
    }

    [Fact]
    public void VueloCreadoConsumer_HandleCorrectly()
    {
        var objConsumer = new VueloCreadoConsumer(_mediator.Object);
        var objRequested = new CrearVueloCommand(
            nroVuelo,
            aeronaveIdTest,
            estadoTest,
            fechaTest,
            aeropuertoOrigenTest,
            aeropuertoDestinoTest);
        var result = objConsumer.Consume(null);
    }
}