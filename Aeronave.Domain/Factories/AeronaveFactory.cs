using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Domain.Factories
{
    public class AeronaveFactory : IAeronaveFactory
    {
        public AeronaveModel Create(string marca, string modelo, int capacidad, int nroAsientos, int capacidadTanque, Aeropuerto aeropuerto)
        {
            return new AeronaveModel(marca,modelo,capacidad,nroAsientos,capacidadTanque, aeropuerto);
        }
    }
}