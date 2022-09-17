using Aeronave.Application.Dto.Vuelo;
using MediatR;

namespace Aeronave.Application.UseCases.Command.Aeronaves.EliminarAeronave;

public class EliminarAeronaveCommand : IRequest<ICollection<VueloDto>>
{
    public Guid Id { get; set; }
}