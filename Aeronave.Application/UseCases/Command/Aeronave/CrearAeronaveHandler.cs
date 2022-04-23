using Aeronave.Application.Services;
using Aeronave.Domain.Factories;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;
using MediatR;

namespace Aeronave.Application.Dto.UseCases.Command.Aeronave
{
    public class CrearAeronaveHandler : IRequestHandler<CrearAeronaveCommand, Guid>
    {
        private readonly IAeronaveRepository _aeronaveRepository;
        private readonly IAeronaveService _aeronaveService;
        private readonly IAeronaveFactory _aeronaveFactory;

        public CrearAeronaveHandler(IAeronaveRepository aeronaveRepository, IAeronaveService aeronaveService, IAeronaveFactory aeronaveFactory)
        {
            _aeronaveRepository = aeronaveRepository;
            _aeronaveService = aeronaveService;
            _aeronaveFactory = aeronaveFactory;
        }
        public async Task<Guid> Handle(CrearAeronaveCommand request, CancellationToken cancellationToken)
        {
            try
            {
                string nroAeronave = await _aeronaveService.GenerarNroAeronaveAsync();
                AeronaveModel objAeronave = _aeronaveFactory.Create(nroAeronave);

                await _aeronaveRepository.UpdateAsync(objAeronave);
            }
            catch
            {

            }
        }
    }
}