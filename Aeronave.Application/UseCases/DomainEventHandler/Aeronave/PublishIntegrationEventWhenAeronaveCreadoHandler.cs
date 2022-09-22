using Aeronave.Domain.Event;
using MassTransit;
using MediatR;
using SharedKernel.Core;

namespace Aeronave.Application.UseCases.DomainEventHandler.Aeronave;

public class
    PublishIntegrationEventWhenAeronaveCreadoHandler : INotificationHandler<ConfirmedDomainEvent<AeronaveCreado>>
{
    private readonly IPublishEndpoint _publishEndpoint;

    public PublishIntegrationEventWhenAeronaveCreadoHandler(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }

    public async Task Handle(ConfirmedDomainEvent<AeronaveCreado> notification, CancellationToken cancellationToken)
    {
        var evento = new SharedKernel.IntegrationEvents.AeronaveCreado
        {
            AeronaveId = notification.DomainEvent.AeronaveId
        };
        await _publishEndpoint.Publish<SharedKernel.IntegrationEvents.AeronaveCreado>(evento);
    }
}