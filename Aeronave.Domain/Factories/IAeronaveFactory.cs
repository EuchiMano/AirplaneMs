using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Domain.Factories
{
    public interface IAeronaveFactory
    {
        AeronaveModel Create(string nroAeronave);
    }
}