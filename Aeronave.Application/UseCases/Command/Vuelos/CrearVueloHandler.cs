using Aeronave.Application.Services;
using Aeronave.Domain.Factories;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Model.Vuelos;
using Aeronave.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Aeronave.Application.UseCases.Command.Vuelos
{
    public class CrearVueloHandler : IRequestHandler<CrearVueloCommand, Guid>
    {
        private readonly IVueloRepository _vueloRepository;
        private readonly IAeronaveRepository _aeronaveRepository;
        private readonly ILogger<CrearVueloHandler> _logger;
        private readonly IVueloService _vueloService;
        private readonly IVueloFactory _vueloFactory;
        private readonly IUnitOfWork _unitOfWork;

        public CrearVueloHandler(IVueloRepository vueloRepository,
                                 ILogger<CrearVueloHandler> logger,
                                 IVueloService vueloService,
                                 IVueloFactory vueloFactory,
                                 IUnitOfWork unitOfWork,
                                 IAeronaveRepository aeronaveRepository)
        {
            _vueloRepository = vueloRepository;
            _logger = logger;
            _vueloService = vueloService;
            _vueloFactory = vueloFactory;
            _unitOfWork = unitOfWork;
            _aeronaveRepository = aeronaveRepository;
        }
        public async Task<Guid> Handle(CrearVueloCommand request, CancellationToken cancellationToken)
        {
            try
            {
                //string nroVuelo = await _vueloService.GenerarNroVueloAsync();
                //AeronaveModel aeronaveFound = await _aeronaveRepository.FindByIdAsync(request.Vuelo.AeronaveId);
                Vuelo objVuelo = _vueloFactory.Create(request.vueloId, request.codAeronave, request.estado, request.fecha, request.codOrigen, request.codDestino);

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
}