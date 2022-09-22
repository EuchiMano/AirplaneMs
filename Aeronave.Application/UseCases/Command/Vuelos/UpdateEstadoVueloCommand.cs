using MediatR;

namespace Aeronave.Application.UseCases.Command.Vuelos;

public class UpdateEstadoVueloCommand : IRequest<Guid>
{
    private UpdateEstadoVueloCommand()
    {
    }

    public UpdateEstadoVueloCommand(Guid nroVuelo, string estadoVuelo)
    {
        vueloId = nroVuelo;
        estado = estadoVuelo;
    }

    public Guid vueloId { get; set; }
    public string estado { get; set; }
}