using MediatR;

namespace SharedKernel.Core;

public class ConfirmedDomainEvent<T> : INotification where T : DomainEvent
{
    public ConfirmedDomainEvent(T domainEvent) => DomainEvent = domainEvent;
    public T DomainEvent { get; }
}