using Aeronave.Domain.Event;
using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Infraestructure.EF.Config.WriteConfig;
using Aeronave.ShareKernel.Core;
using Microsoft.EntityFrameworkCore;

namespace Aeronave.Infraestructure.EF.Context
{
    public class WriteDbContext : DbContext
    {
        public virtual DbSet<AeronaveModel> Aeronave { get; set; }

        public WriteDbContext(DbContextOptions<WriteDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var aeronaveConfig = new AeronaveWriteConfig();
            modelBuilder.ApplyConfiguration<AeronaveModel>(aeronaveConfig);
            modelBuilder.ApplyConfiguration<AeronaveDetalle>(aeronaveConfig);

            modelBuilder.Ignore<DomainEvent>();
            modelBuilder.Ignore<AeronaveCreado>();
        }
    }
}