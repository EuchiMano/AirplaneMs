using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Repositories;
using Aeronave.Infraestructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace Aeronave.Infraestructure.EF.Repository
{
    public class AeronaveRepository : IAeronaveRepository
    {
        public readonly DbSet<AeronaveModel> _aeronave;
        public AeronaveRepository(WriteDbContext context)
        {
            _aeronave = context.Aeronave;
        }
        public async Task CreateAsync(AeronaveModel obj)
        {
            await _aeronave.AddAsync(obj);
        }

        public async Task<AeronaveModel> FindByIdAsync(Guid id)
        {
            return await _aeronave.Include("_detalle")
                    .SingleAsync(x => x.Id == id);
        }

        public Task UpdateAsync(AeronaveModel obj)
        {
            _aeronave.Update(obj);

            return Task.CompletedTask;
        }
    }
}