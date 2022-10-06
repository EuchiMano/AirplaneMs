using MediatR;

namespace Aeronave.Application.UseCases.Command.Vuelos;

public class CrearVueloCommand : IRequest<Guid>
{
    private CrearVueloCommand()
    {
    }

    public CrearVueloCommand(Guid nroVuelo, Guid aeronaveId, string estadoVuelo, DateTime fechaVuelo,
        Guid aeropuertoOrigen, Guid aeropuertoDestino)
    {
        vueloId = nroVuelo;
        estado = estadoVuelo;
        codAeronave = aeronaveId;
        fecha = fechaVuelo;
        codDestino = aeropuertoDestino;
        codOrigen = aeropuertoOrigen;
    }

    public Guid vueloId { get; set; }
    public Guid codAeronave { get; set; }
    public string estado { get; set; }
    public DateTime fecha { get; set; }
    public Guid codDestino { get; set; }
    public Guid codOrigen { get; set; }
}