using Aeronave.Application.UseCases.Command.Vuelos;
using Aeronave.Domain.Event;
using MassTransit;
using MassTransit.Mediator;

namespace Aeronave.Application.UseCases.Consumers;

public class VueloCreadoConsumer : IConsumer<VueloCreado>
{
    public const string ExchangeName = "articulo-creado-exchange";
    public const string QueueName = "vuelo-creado";
    private readonly IMediator _mediator;

    public async Task Consume(ConsumeContext<VueloCreado> context)
    {
        var @event = context.Message;
        var command = new CrearVueloCommand(@event.vueloId, @event.codAeronave, @event.estado, @event.fecha,
            @event.codOrigen, @event.codDestino);
        await _mediator.Send(command);
    }
}