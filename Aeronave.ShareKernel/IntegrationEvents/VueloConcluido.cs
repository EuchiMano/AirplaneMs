using SharedKernel.Core;

namespace SharedKernel.IntegrationEvents;

public record VueloConcluido : IntegrationEvent
{
    public DateTime horaLLegada { get; set; }
    public string estado { get; set; }
    public decimal precio { get; set; }
    public DateTime fecha { get; set; }
    public Guid vueloId { get; set; }
    public Guid codAeronave { get; set; }
}