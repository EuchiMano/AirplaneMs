using Aeronave.ShareKernel.Core;
using System;

namespace Aeronave.Domain.Event
{
    public record AeronaveCreado : DomainEvent
    {
        public Guid AeronaveId { get; }

        public AeronaveCreado(Guid aeronaveId) : base(DateTime.Now)
        {
            AeronaveId = aeronaveId;
        }
    }
}