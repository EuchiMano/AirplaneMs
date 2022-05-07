using Aeronave.Domain.Model.Aeronaves;
using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Repositories
{
    public interface IAeronaveRepository : IRepository<AeronaveModel, Guid>
    {
        Task UpdateAsync(AeronaveModel obj);
    }
}