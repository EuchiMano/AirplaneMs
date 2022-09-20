using Aeronave.ShareKernel.Core;

namespace Aeronave.ShareKernel.IntegrationEvents
{
    public record AeronaveCreado : IntegrationEvent
    {
        public Guid AeronaveId { get; set; }
    }
}