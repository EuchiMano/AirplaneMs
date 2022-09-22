using Aeronave.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Aeronave.Application.UseCases.Command.Vuelos;

public class UpdateEstadoVueloHandler : IRequestHandler<UpdateEstadoVueloCommand, Guid>
{
    private readonly ILogger<UpdateEstadoVueloHandler> _logger;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IVueloRepository _vueloRepository;

    public UpdateEstadoVueloHandler(IVueloRepository vueloRepository, IUnitOfWork unitOfWork, ILogger<UpdateEstadoVueloHandler> logger)
    {
        _vueloRepository = vueloRepository;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<Guid> Handle(UpdateEstadoVueloCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var vueloFound = await _vueloRepository.GetByVueloId(request.vueloId);
            vueloFound.ActualizarEstadoVuelo(request.estado);
            await _vueloRepository.UpdateAsync(vueloFound);
            await _unitOfWork.Commit();
            return vueloFound.Id;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error al actualizar vuelo");
        }

        return Guid.Empty;
    }
}