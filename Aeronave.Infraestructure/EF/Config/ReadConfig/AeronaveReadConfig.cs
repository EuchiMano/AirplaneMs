using Aeronave.Infraestructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeronave.Infraestructure.EF.Config.ReadConfig
{
    public class AeronaveReadConfig : IEntityTypeConfiguration<AeronaveReadModel>,
        IEntityTypeConfiguration<DetalleAeronaveReadModel>
    {
        public void Configure(EntityTypeBuilder<AeronaveReadModel> builder)
        {
            builder.ToTable("Aeronave");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Detalle)
              .WithOne(x => x.Aeronave)
              .HasForeignKey<DetalleAeronaveReadModel>(c => c.AeronaveId);
            builder.Property(x => x.EstadoAeronave)
                .HasColumnName("estadoAeronave");
        }

        public void Configure(EntityTypeBuilder<DetalleAeronaveReadModel> builder)
        {
            builder.ToTable("AeronaveDetalle");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Marca)
                .HasColumnName("marca");
            builder.Property(x => x.Modelo)
                .HasColumnName("modelo");
            builder.Property(x => x.Capacidad)
                .HasColumnName("capacidadCarga");
            builder.Property(x => x.NroAsientos)
               .HasColumnName("nroAsientos");
            builder.Property(x => x.CapacidadTanque)
                .HasColumnName("capacidadTanque");
            builder.Property(x => x.Aeropuerto)
                .HasColumnName("aeropuerto");
        }
    }
}