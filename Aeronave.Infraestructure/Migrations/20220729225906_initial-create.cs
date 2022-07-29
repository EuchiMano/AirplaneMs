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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    estadoAeronave = table.Column<int>(type: "integer", nullable: false),
                    marca = table.Column<string>(type: "text", nullable: false),
                    modelo = table.Column<string>(type: "text", nullable: false),
                    capacidad = table.Column<int>(type: "integer", nullable: false),
                    nroAsientos = table.Column<int>(type: "integer", nullable: false),
                    capacidadTanque = table.Column<int>(type: "integer", nullable: false),
                    aeropuerto = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vuelo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    nroVuelo = table.Column<string>(type: "text", nullable: false),
                    horaLlegada = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    horaPartida = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    idTripulacion = table.Column<int>(type: "integer", nullable: false),
                    aeronaveId = table.Column<Guid>(type: "uuid", nullable: false),
                    aeropuertoOrigen = table.Column<int>(type: "integer", nullable: false),
                    aeropuertoDestino = table.Column<int>(type: "integer", nullable: false)
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
