using Aeronave.Application.Dto.Aeronave;
using Aeronave.Domain.Model.Aeronaves;
using MediatR;

namespace Aeronave.Application.UseCases.Command.Aeronaves.CrearAeronave
{
    public class CrearAeronaveCommand : IRequest<Guid>
    {
        public string Marca { get; }
        public string Modelo { get; }
        public int Capacidad { get; }
        public int NroAsientos { get; }
        public int CapacidadTanque { get; }
        public Aeropuerto Aeropuerto { get; }

        private CrearAeronaveCommand()
        {
        }
        public CrearAeronaveCommand(string marca, string modelo, int capacidad, int nroAsientos, int capacidadTanque, Aeropuerto aeropuerto)
        {
            Marca = marca;
            Modelo = modelo;
            Capacidad = capacidad;
            NroAsientos = nroAsientos;
            CapacidadTanque = capacidadTanque;
            Aeropuerto = aeropuerto;
        }
    }
}