using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Domain.Repositories
{
    public interface IRepository<T, TX>
    {
        Task UpdateAsync(AeronaveModel obj);
    }
}