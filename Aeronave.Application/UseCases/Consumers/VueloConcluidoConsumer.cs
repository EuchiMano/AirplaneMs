using Aeronave.Application.UseCases.Command.Vuelos;
using MassTransit;
using MediatR;
using SharedKernel.IntegrationEvents;

namespace Aeronave.Application.UseCases.Consumers;

public class VueloConcluidoConsumer : IConsumer<VueloConcluido>
{
    public const string ExchangeName = "articulo-creado-exchange";
    public const string QueueName = "vuelo-concluido-aeronave";
    private readonly IMediator _mediator;

    public VueloConcluidoConsumer(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task Consume(ConsumeContext<VueloConcluido> context)
    {
        var @event = context.Message;
        var command = new UpdateEstadoVueloCommand(@event.vueloId, @event.estado);
        await _mediator.Send(command);
    }
}