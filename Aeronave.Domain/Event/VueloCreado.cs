using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Event;

public record VueloCreado : DomainEvent
{
    public VueloCreado(Guid nroVuelo, Guid aeronaveId, string estadoVuelo, DateTime fechaVuelo,
        Guid aeropuertoOrigen, Guid aeropuertoDestino) : base(DateTime.Now)
    {
        vueloId = nroVuelo;
        estado = estadoVuelo;
        codAeronave = aeronaveId;
        fecha = fechaVuelo;
        codDestino = aeropuertoOrigen;
        codOrigen = aeropuertoDestino;
    }

    public Guid vueloId { get; set; }
    public Guid codAeronave { get; set; }
    public string estado { get; set; }
    public DateTime fecha { get; set; }
    public Guid codDestino { get; set; }
    public Guid codOrigen { get; set; }
}