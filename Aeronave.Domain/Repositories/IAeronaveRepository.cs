using Aeronave.Domain.Model.Aeronaves;

namespace Aeronave.Domain.Repositories
{
    public interface IAeronaveRepository : IRepository<AeronaveModel, Guid>
    {
        Task UpdateAsync(AeronaveModel obj);
    }
}