using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Model.Vuelos;
using Aeronave.Infraestructure.EF.Config.WriteConfig;
using Aeronave.ShareKernel.Core;
using Aeronave.ShareKernel.IntegrationEvents;
using Microsoft.EntityFrameworkCore;

namespace Aeronave.Infraestructure.EF.Context
{
    public class WriteDbContext : DbContext
    {
        public virtual DbSet<AeronaveModel> Aeronave { get; set; }
        public virtual DbSet<Vuelo> Vuelo { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var aeronaveConfig = new AeronaveWriteConfig();
            modelBuilder.ApplyConfiguration<AeronaveModel>(aeronaveConfig);

            var vueloConfig = new VueloWriteConfig();
            modelBuilder.ApplyConfiguration<Vuelo>(vueloConfig);

            modelBuilder.Ignore<DomainEvent>();
            modelBuilder.Ignore<VueloHabilitado>();
            modelBuilder.Ignore<VueloConcluido>();
        }
    }
}