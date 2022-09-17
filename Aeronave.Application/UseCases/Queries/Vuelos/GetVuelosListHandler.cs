using Aeronave.Application.Dto.Vuelo;
using Aeronave.Domain.Model.Vuelos;
using Aeronave.Domain.Repositories;
using MediatR;

namespace Aeronave.Application.UseCases.Queries.Vuelos;

public class GetVuelosListHandler : IRequestHandler<GetVuelosQuery, ICollection<VueloDto>>
{
    private readonly IVueloRepository _vueloRepository;
    private readonly List<VueloDto> objVueloModelDto;
    private List<Vuelo> objVueloModels;

    public GetVuelosListHandler(IVueloRepository vueloRepository)
    {
        _vueloRepository = vueloRepository;
        objVueloModels = new List<Vuelo>();
        objVueloModelDto = new List<VueloDto>();
    }

    public async Task<ICollection<VueloDto>> Handle(GetVuelosQuery request, CancellationToken cancellationToken)
    {
        objVueloModels = await _vueloRepository.GetAllVuelos();
        foreach (var vuelo in objVueloModels)
            objVueloModelDto.Add(new VueloDto
            {
                NroVuelo = vuelo.NroVuelo,
                Estado = vuelo.Estado,
                AeronaveId = vuelo.AeronaveId,
                AeropuertoDestino = vuelo.AeropuertoDestino,
                AeropuertoOrigen = vuelo.AeropuertoOrigen,
                Fecha = vuelo.Fecha
            });
        return objVueloModelDto;
    }
}