using Aeronave.Domain.Model.Vuelos;
using Aeronave.ShareKernel.Core;

namespace Aeronave.Domain.Repositories
{
    public interface IVueloRepository : IRepository<Vuelo, Guid>
    {
        Task<List<Vuelo>> GetAllVuelos();
        Task UpdateAsync(Vuelo obj);
    }
}