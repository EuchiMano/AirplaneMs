using Aeronave.Application.Dto.Aeronave;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Aeronave.Application.UseCases.Queries.Aeronaves.GetAeronaveById
{
    public class GetAeronaveByIdHandler : IRequestHandler<GetAeronaveByIdQuery, AeronaveDto>
    {
        private readonly IAeronaveRepository _aeronaveRepository;
        private readonly ILogger<GetAeronaveByIdQuery> _logger;

        public GetAeronaveByIdHandler(IAeronaveRepository aeronaveRepository, ILogger<GetAeronaveByIdQuery> logger)
        {
            _aeronaveRepository = aeronaveRepository;
            _logger = logger;
        }

        public async Task<AeronaveDto> Handle(GetAeronaveByIdQuery request, CancellationToken cancellationToken)
        {
            AeronaveDto result = null;
            try
            {
                AeronaveModel objAeronave = await _aeronaveRepository.FindByIdAsync(request.Id);

                result = new AeronaveDto()
                {
                    Id = objAeronave.Id,
                };

                result.Detalle = new AeronaveDetalleDto()
                {
                    Capacidad = objAeronave._detalle.Capacidad,
                    Aeropuerto = (int)objAeronave._detalle.Aeropuerto,
                    CapacidadTanque = objAeronave._detalle.CapacidadTanque,
                    Marca = objAeronave._detalle.Marca,
                    Modelo = objAeronave._detalle.Modelo,
                    NroAsientos = objAeronave._detalle.NroAsientos
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener Aeronave con id: { AeronaveId }", request.Id);
            }

            return result;
        }
    }
}