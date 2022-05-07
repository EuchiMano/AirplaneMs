﻿// <auto-generated />
using System;
using Aeronave.Infraestructure.EF.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Aeronave.Infraestructure.Migrations
{
    [DbContext(typeof(ReadDbContext))]
    [Migration("20220507100002_initial-create")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Aeronave.Infraestructure.EF.ReadModel.AeronaveReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EstadoAeronave")
                        .HasColumnType("int")
                        .HasColumnName("estadoAeronave");

                    b.HasKey("Id");

                    b.ToTable("Aeronave", (string)null);
                });

            modelBuilder.Entity("Aeronave.Infraestructure.EF.ReadModel.DetalleAeronaveReadModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AeronaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Aeropuerto")
                        .HasColumnType("int")
                        .HasColumnName("aeropuerto");

                    b.Property<float>("Capacidad")
                        .HasColumnType("real")
                        .HasColumnName("capacidadCarga");

                    b.Property<float>("CapacidadTanque")
                        .HasColumnType("real")
                        .HasColumnName("capacidadTanque");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("marca");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("modelo");

                    b.Property<int>("NroAsientos")
                        .HasColumnType("int")
                        .HasColumnName("nroAsientos");

                    b.HasKey("Id");

                    b.HasIndex("AeronaveId")
                        .IsUnique();

                    b.ToTable("AeronaveDetalle", (string)null);
                });

            modelBuilder.Entity("Aeronave.Infraestructure.EF.ReadModel.DetalleAeronaveReadModel", b =>
                {
                    b.HasOne("Aeronave.Infraestructure.EF.ReadModel.AeronaveReadModel", "Aeronave")
                        .WithOne("Detalle")
                        .HasForeignKey("Aeronave.Infraestructure.EF.ReadModel.DetalleAeronaveReadModel", "AeronaveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aeronave");
                });

            modelBuilder.Entity("Aeronave.Infraestructure.EF.ReadModel.AeronaveReadModel", b =>
                {
                    b.Navigation("Detalle")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
