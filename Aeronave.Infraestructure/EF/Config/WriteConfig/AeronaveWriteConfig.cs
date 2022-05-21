using Aeronave.Domain.Model.Aeronaves;
using Aeronave.Domain.Model.Aeronaves.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aeronave.Infraestructure.EF.Config.WriteConfig
{
    public class AeronaveWriteConfig : IEntityTypeConfiguration<AeronaveModel>,
        IEntityTypeConfiguration<AeronaveDetalle>
    {
        public void Configure(EntityTypeBuilder<AeronaveModel> builder)
        {
            builder.ToTable("Aeronave");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.EstadoAeronave)
                .HasColumnName("estadoAeronave");

            builder.HasOne(x => x._detalle)
                .WithOne(x => x.AeronaveModel)
                .HasForeignKey<AeronaveDetalle>(b => b.AeronaveModelId);
            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }

        public void Configure(EntityTypeBuilder<AeronaveDetalle> builder)
        {
            builder.ToTable("AeronaveDetalle");
            builder.HasKey(x => x.Id);

            var nroAsientosConverter = new ValueConverter<CantidadAsientos, int>(
                nroAsientosValue => nroAsientosValue.Value,
                nrodadAsientos => new CantidadAsientos(nrodadAsientos)
            );
            builder.Property(x => x.NroAsientos)
               .HasConversion(nroAsientosConverter)
               .HasColumnName("nroAsientos");

            builder.Property(x => x.Marca)
                .HasColumnName("marca");
            builder.Property(x => x.Modelo)
                .HasColumnName("modelo");
            builder.Property(x => x.Capacidad)
                .HasColumnName("capacidadCarga");
            
            builder.Property(x => x.CapacidadTanque)
                .HasColumnName("capacidadTanque");
            builder.Property(x => x.Aeropuerto)
                .HasColumnName("aeropuerto");
            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}