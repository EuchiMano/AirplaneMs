using Aeronave.Application.Dto.Vuelo;
using MediatR;

namespace Aeronave.Application.UseCases.Queries.Vuelos;

public class GetVuelosQuery : IRequest<ICollection<VueloDto>>
{
}