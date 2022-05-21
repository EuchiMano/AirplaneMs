using Aeronave.Application.Dto.Aeronave;
using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Test.Application.Dto
{
    public class MockFactoryGeneric
    {
        public static AeronaveDetalleDto GetDetalleAeronave()
        {
            return new AeronaveDetalleDto
            {
                Marca = "Marca 1",
                Modelo = "Modelo 1",
                NroAsientos = 100,
                Aeropuerto = (int)Aeropuerto.Santa_Cruz,
                Capacidad = 100,
                CapacidadTanque = 100,
            };
        }
    }
}