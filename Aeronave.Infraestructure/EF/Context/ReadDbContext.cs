﻿using Aeronave.Domain.Event;
using Aeronave.Infraestructure.EF.Config.ReadConfig;
using Aeronave.Infraestructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using SharedKernel.Core;
using SharedKernel.IntegrationEvents;

namespace Aeronave.Infraestructure.EF.Context
{
    public class ReadDbContext : DbContext
    {
        public virtual DbSet<AeronaveReadModel> Aeronave { set; get; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var aeronaveConfig = new AeronaveReadConfig();
            modelBuilder.ApplyConfiguration<AeronaveReadModel>(aeronaveConfig);
            modelBuilder.Ignore<DomainEvent>();
            modelBuilder.Ignore<VueloCreado>();
            modelBuilder.Ignore<VueloConcluido>();
        }
    }
}