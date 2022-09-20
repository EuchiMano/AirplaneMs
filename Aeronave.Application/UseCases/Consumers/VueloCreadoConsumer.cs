using Aeronave.Application.UseCases.Command.Vuelos;
using MassTransit;
using MassTransit.Mediator;
using SharedKernel.IntegrationEvents;

namespace Aeronave.Application.UseCases.Consumers;

public class VueloCreadoConsumer : IConsumer<VueloHabilitado>
{
    public const string ExchangeName = "articulo-creado-exchange";
    public const string QueueName = "VueloHabilitado";
    private readonly IMediator _mediator;

    public async Task Consume(ConsumeContext<VueloHabilitado> context)
    {
        VueloHabilitado @event = context.Message;
        var command = new CrearVueloCommand(@event.vueloId, @event.codAeronave, @event.estado, @event.fecha,
            @event.codOrigen, @event.codDestino);
        await _mediator.Send(command);
    }
}