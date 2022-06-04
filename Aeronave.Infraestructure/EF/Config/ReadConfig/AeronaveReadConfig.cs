using Aeronave.Infraestructure.EF.ReadModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeronave.Infraestructure.EF.Config.ReadConfig
{
    public class AeronaveReadConfig : IEntityTypeConfiguration<AeronaveReadModel>
    {
        public void Configure(EntityTypeBuilder<AeronaveReadModel> builder)
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
        }
    }
}