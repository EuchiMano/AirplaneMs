using Aeronave.Domain.Model.Vuelos;
using Aeronave.Domain.Repositories;
using Aeronave.Infraestructure.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace Aeronave.Infraestructure.EF.Repository;

public class VueloRepository : IVueloRepository
{
    public readonly DbSet<Vuelo> _vuelos;

    public VueloRepository(WriteDbContext context)
    {
        _vuelos = context.Vuelo;
    }

    public async Task CreateAsync(Vuelo obj)
    {
        await _vuelos.AddAsync(obj);
    }

    public async Task<Vuelo> FindByIdAsync(Guid id)
    {
        return await _vuelos.SingleOrDefaultAsync(x => x.Id == id);
    }

    public async Task<Vuelo> GetByVueloId(Guid vueloId)
    {
        return await _vuelos.SingleOrDefaultAsync(x => x.NroVuelo == vueloId);
    }

    public async Task<List<Vuelo>> GetAllVuelos()
    {
        return await _vuelos.OrderByDescending(d => d.Fecha).ToListAsync();
    }

    public Task UpdateAsync(Vuelo obj)
    {
        _vuelos.Update(obj);
        return Task.CompletedTask;
    }
}