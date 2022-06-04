using Aeronave.Application.Dto.Vuelo;
using MediatR;

namespace Aeronave.Application.UseCases.Command.Vuelos
{
    public class CrearVueloCommand : IRequest<Guid>
    {
        public VueloDto Vuelo { get; }

        private CrearVueloCommand()
        {
        }

        public CrearVueloCommand(VueloDto vuelo)
        {
            Vuelo = vuelo;
        }
    }
}