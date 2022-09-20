using MediatR;

namespace Aeronave.ShareKernel.Core;

public abstract record DomainEvent : INotification
{
    protected DomainEvent(DateTime occuredOn)
    {
        OccuredOn = occuredOn;
        Id = Guid.NewGuid();
    }

    public DateTime OccuredOn { get; }
    public Guid Id { get; }
}