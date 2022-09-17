using Aeronave.Domain.Model.Vuelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeronave.Infraestructure.EF.Config.WriteConfig
{
    public class VueloWriteConfig : IEntityTypeConfiguration<Vuelo>
    {
        public void Configure(EntityTypeBuilder<Vuelo> builder)
        {
            builder.ToTable("Vuelo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NroVuelo)
                .HasColumnName("nroVuelo");
            builder.Property(x => x.AeronaveId)
                .HasColumnName("aeronaveId");
            builder.Property(x => x.Estado)
                .HasColumnName("estado");
            builder.Property(x => x.Fecha)
                .HasColumnName("fecha");
            builder.Property(x => x.AeropuertoOrigen)
                .HasColumnName("aeropuertoOrigen");
            builder.Property(x => x.AeropuertoDestino)
                .HasColumnName("aeropuertoDestino");

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}

