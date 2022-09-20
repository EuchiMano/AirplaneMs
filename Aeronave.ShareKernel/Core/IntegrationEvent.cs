namespace Aeronave.ShareKernel.Core
{
    public abstract record IntegrationEvent
    {
        public DateTime OccuredOn { get; }
        public Guid EventId { get; set; }
        public IntegrationEvent()
        {
            EventId = Guid.NewGuid();
            OccuredOn = DateTime.UtcNow;
        }
    }
}