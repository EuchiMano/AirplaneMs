using SharedKernel.Core;

namespace Aeronave.Domain.Model.Vuelos;

public class Vuelo : AggregateRoot<Guid>
{
    internal Vuelo(Guid nroVuelo, Guid aeronaveId, string estado, DateTime fecha, Guid aeropuertoOrigen,
        Guid aeropuertoDestino)
    {
        Id = Guid.NewGuid();
        NroVuelo = nroVuelo;
        AeronaveId = aeronaveId;
        Estado = estado;
        Fecha = fecha;
        AeropuertoOrigen = aeropuertoOrigen;
        AeropuertoDestino = aeropuertoDestino;
    }

    public Guid NroVuelo { get; }
    public Guid AeronaveId { get; }
    public string Estado { get; private set; }
    public DateTime Fecha { get; }
    public Guid AeropuertoOrigen { get; }
    public Guid AeropuertoDestino { get; }

    public void ActualizarEstadoVuelo(string estado)
    {
        Estado = estado;
    }
}

public record VueloHabilitado : IntegrationEvent
{
    public DateTime horaSalida { get; set; }
    public DateTime horaLLegada { get; set; }
    public string estado { get; set; }
    public decimal precio { get; set; }
    public DateTime fecha { get; set; }
    public Guid codRuta { get; set; }
    public Guid codAeronave { get; set; }
    public int activo { get; set; }
    public int stockAsientos { get; set; }
    public Guid vueloId { get; set; }
}

public record VueloConcluido : IntegrationEvent
{
    public DateTime horaLLegada { get; set; }
    public string estado { get; set; }
    public decimal precio { get; set; }
    public string fechaInicio { get; set; }
    public Guid vueloId { get; set; }
    public DateTime horaConcluido { get; set; }
    public string fechaConcluido { get; set; }
}