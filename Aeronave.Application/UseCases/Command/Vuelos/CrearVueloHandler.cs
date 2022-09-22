using Aeronave.Domain.Factories;
using Aeronave.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Aeronave.Application.UseCases.Command.Vuelos;

public class CrearVueloHandler : IRequestHandler<CrearVueloCommand, Guid>
{
    private readonly ILogger<CrearVueloHandler> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IVueloFactory _vueloFactory;
    private readonly IVueloRepository _vueloRepository;

    public CrearVueloHandler(IVueloRepository vueloRepository,
        ILogger<CrearVueloHandler> logger,
        IVueloFactory vueloFactory,
        IUnitOfWork unitOfWork)
    {
        _vueloRepository = vueloRepository;
        _logger = logger;
        _vueloFactory = vueloFactory;
        _unitOfWork = unitOfWork;
    }

    public async Task<Guid> Handle(CrearVueloCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var objVuelo = _vueloFactory.Create(request.vueloId, request.codAeronave, request.estado, request.fecha,
                request.codOrigen, request.codDestino);

            await _vueloRepository.CreateAsync(objVuelo);
            await _unitOfWork.Commit();

            return objVuelo.Id;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al crear vuelo");
        }

        return Guid.Empty;
    }
}