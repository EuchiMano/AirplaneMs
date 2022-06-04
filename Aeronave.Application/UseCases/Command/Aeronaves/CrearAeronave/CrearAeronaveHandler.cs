using Aeronave.Domain.Factories;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Aeronave.Application.UseCases.Command.Aeronaves.CrearAeronave
{
    public class CrearAeronaveHandler : IRequestHandler<CrearAeronaveCommand, Guid>
    {
        private readonly IAeronaveRepository _aeronaveRepository;
        private readonly ILogger<CrearAeronaveHandler> _logger;
        private readonly IAeronaveFactory _aeronaveFactory;
        private readonly IUnitOfWork _unitOfWork;

        public CrearAeronaveHandler(IAeronaveRepository aeronaveRepository,
            ILogger<CrearAeronaveHandler> logger,
            IAeronaveFactory aeronaveFactory,
            IUnitOfWork unitOfWork)
        {
            _aeronaveRepository = aeronaveRepository;
            _logger = logger;
            _aeronaveFactory = aeronaveFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CrearAeronaveCommand request, CancellationToken cancellationToken)
        {
            try
            {
                AeronaveModel objAeronave = _aeronaveFactory.Create(request.Marca,
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
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al crear aeronave");
            }
            return Guid.Empty;
        }
    }
}