using Aeronave.Domain.Event;
using Aeronave.Domain.Repositories;
using MediatR;

namespace Aeronave.Application.UseCases.Command.Aeronaves.CambiarAeropuertoAeronaveWhenVueloCreado
{
    public class CambiarAeropuertoAeronaveWhenVueloCreadoHandler : INotificationHandler<VueloCreado>
    {
        private readonly IAeronaveRepository _aeronaveRepository;

        public CambiarAeropuertoAeronaveWhenVueloCreadoHandler(IAeronaveRepository aeronaveRepository)
        {
            _aeronaveRepository = aeronaveRepository;
        }
        public async Task Handle(VueloCreado notification, CancellationToken cancellationToken)
        {
            var objAeronave = await _aeronaveRepository.FindByIdAsync(notification.AeronaveId);
            objAeronave.CambiarAeropuertoActualAeronave(notification.AeropuertoDestino);

            await _aeronaveRepository.UpdateAsync(objAeronave);
        }
    }
}