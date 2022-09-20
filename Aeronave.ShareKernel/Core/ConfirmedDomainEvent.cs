using MediatR;

namespace Aeronave.ShareKernel.Core;

public class ConfirmedDomainEvent<T> : INotification where T : DomainEvent
{
    public ConfirmedDomainEvent(T domainEvent) => this.DomainEvent = domainEvent;
    public T DomainEvent { get; }
}