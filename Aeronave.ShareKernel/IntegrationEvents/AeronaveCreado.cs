using SharedKernel.Core;

namespace SharedKernel.IntegrationEvents
{
    public record AeronaveCreado : IntegrationEvent
    {
        public Guid AeronaveId { get; set; }
    }
}