using SharedKernel.Core;

namespace Aeronave.Domain.Event
{
    public record AeronaveCreado : DomainEvent
    {
        public Guid AeronaveId { get; set; }

        public AeronaveCreado(Guid aeronaveId) : base(DateTime.Now)
        {
            AeronaveId = aeronaveId;
        }
    }
}