using Aeronave.Domain.Factories;
using Aeronave.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Aeronave.Application.UseCases.Command.Aeronaves.CrearAeronave;

public class CrearAeronaveHandler : IRequestHandler<CrearAeronaveCommand, Guid>
{
    private readonly IAeronaveFactory _aeronaveFactory;
    private readonly IAeronaveRepository _aeronaveRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CrearAeronaveHandler(IAeronaveRepository aeronaveRepository,
        IAeronaveFactory aeronaveFactory,
        IUnitOfWork unitOfWork)
    {
        _aeronaveRepository = aeronaveRepository;
        _aeronaveFactory = aeronaveFactory;
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(CrearAeronaveCommand request, CancellationToken cancellationToken)
    {
        var objAeronave = _aeronaveFactory.Create(request.Marca,
            request.Modelo,
            request.Capacidad,
            request.NroAsientos,
            request.CapacidadTanque,
            request.Aeropuerto);
        objAeronave.ConsolidarAeronave();
        await _aeronaveRepository.CreateAsync(objAeronave);
        await _unitOfWork.Commit();

        return objAeronave.Id;
    }
}