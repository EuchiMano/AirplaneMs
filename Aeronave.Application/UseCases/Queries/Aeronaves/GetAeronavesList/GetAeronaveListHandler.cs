using Aeronave.Application.Dto.Aeronave;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;
using MediatR;

namespace Aeronave.Application.UseCases.Queries.Aeronaves.GetAeronavesList;

public class GetAeronaveListHandler : IRequestHandler<GetAeronavesListByQuery, ICollection<AeronaveDto>>
{
    private readonly IAeronaveRepository _aeronaveRepository;
    private List<AeronaveModel> objAeronaveModel;
    private readonly List<AeronaveDto> objAeronaveModelDto;

    public GetAeronaveListHandler(IAeronaveRepository aeronaveRepository)
    {
        _aeronaveRepository = aeronaveRepository;
        objAeronaveModel = new List<AeronaveModel>();
        objAeronaveModelDto = new List<AeronaveDto>();
    }

    public async Task<ICollection<AeronaveDto>> Handle(GetAeronavesListByQuery request,
        CancellationToken cancellationToken)
    {
        objAeronaveModel = await _aeronaveRepository.GetAllOperativeAeronaves();
        foreach (var aeronave in objAeronaveModel)
            objAeronaveModelDto.Add(new AeronaveDto
            {
                Aeropuerto = aeronave.Aeropuerto,
                Capacidad = aeronave.Capacidad,
                CapacidadTanque = aeronave.CapacidadTanque,
                EstadoAeronave = aeronave.EstadoAeronave,
                Marca = aeronave.Marca,
                Modelo = aeronave.Modelo,
                NroAsientos = aeronave.NroAsientos
            });
        return objAeronaveModelDto;
    }
}