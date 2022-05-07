using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;

namespace Aeronave.Infraestructure.MemoryRepository
{
    public class MemoryAeronaveRepository : IAeronaveRepository
    {
        private readonly MemoryDatabase _database;

        public MemoryAeronaveRepository(MemoryDatabase database)
        {
            _database = database;
        }

        public Task CreateAsync(AeronaveModel obj)
        {
            _database.Aeronave.Add(obj);
            return Task.CompletedTask;
        }

        public Task<AeronaveModel> FindByIdAsync(Guid id)
        {
            return Task.FromResult(_database.Aeronave.FirstOrDefault(x => x.Id == id));
        }

        public Task UpdateAsync(AeronaveModel obj)
        {
            return Task.CompletedTask;
        }
    }
}