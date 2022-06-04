using Aeronave.Domain.Model.Aeronaves;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeronave.Infraestructure.EF.Config.WriteConfig
{
    public class AeronaveWriteConfig : IEntityTypeConfiguration<AeronaveModel>
    {
        public void Configure(EntityTypeBuilder<AeronaveModel> builder)
        {
            builder.ToTable("Aeronave");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.EstadoAeronave)
                .HasColumnName("estadoAeronave");
            builder.Property(x => x.Marca)
                .HasColumnName("marca");
            builder.Property(x => x.Modelo)
                .HasColumnName("modelo");
            builder.Property(x => x.Capacidad)
                .HasColumnName("capacidad");
            builder.Property(x => x.NroAsientos)
                .HasColumnName("nroAsientos");
            builder.Property(x => x.CapacidadTanque)
                .HasColumnName("capacidadTanque");
            builder.Property(x => x.Aeropuerto)
                .HasColumnName("aeropuerto");
            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}