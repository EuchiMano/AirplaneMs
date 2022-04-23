using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Domain.Factories
{
    public class AeronaveFactory : IAeronaveFactory
    {
        public AeronaveModel Create(string nroAeronave)
        {
            return new AeronaveModel(nroAeronave);
        }
    }
}