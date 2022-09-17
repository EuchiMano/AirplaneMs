using Aeronave.Application.Dto.Aeronave;
using Aeronave.Application.Dto.Vuelo;
using Aeronave.Domain.Model.Aeronaves;
using MediatR;

namespace Aeronave.Application.UseCases.Queries.Aeronaves.GetAeronavesList;

public class GetAeronavesListByQuery : IRequest<ICollection<AeronaveDto>>
{
    public EstadoAeronave Estado { get; set; }
    public Aeropuerto Aeropuerto { get; set; }
}