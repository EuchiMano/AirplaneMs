using Aeronave.Domain.Event;
using Aeronave.ShareKernel.Core;
using MassTransit;
using MediatR;

namespace Aeronave.Application.UseCases.Command.Aeronaves.CambiarAeropuertoAeronaveWhenVueloCreado;

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
        var evento = new ShareKernel.IntegrationEvents.AeronaveCreado
        {
            AeronaveId = notification.DomainEvent.AeronaveId
        };
        await _publishEndpoint.Publish<ShareKernel.IntegrationEvents.AeronaveCreado>(evento);
    }
}