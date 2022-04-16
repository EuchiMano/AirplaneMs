using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Event
{
    public record AeronaveAgregada : DomainEvent
    {
        public Guid AeronaveId { get; }
        public string NroAeronave { get; }

        public AeronaveAgregada(Guid aeronaveId,
            string nroAeronave) : base(DateTime.Now)
        {
            AeronaveId = aeronaveId;
            NroAeronave = nroAeronave;
        }
    }
}