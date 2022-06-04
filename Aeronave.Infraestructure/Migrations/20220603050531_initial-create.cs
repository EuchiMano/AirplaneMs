using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aeronave.Infraestructure.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aeronave",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    estadoAeronave = table.Column<int>(type: "int", nullable: false),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    capacidad = table.Column<int>(type: "int", nullable: false),
                    nroAsientos = table.Column<int>(type: "int", nullable: false),
                    capacidadTanque = table.Column<int>(type: "int", nullable: false),
                    aeropuerto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vuelo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nroVuelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    horaLlegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaPartida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    idTripulacion = table.Column<int>(type: "int", nullable: false),
                    aeronaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    aeropuertoOrigen = table.Column<int>(type: "int", nullable: false),
                    aeropuertoDestino = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aeronave");

            migrationBuilder.DropTable(
                name: "Vuelo");
        }
    }
}
