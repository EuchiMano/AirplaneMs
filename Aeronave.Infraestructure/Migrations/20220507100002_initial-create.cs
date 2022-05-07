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
                    estadoAeronave = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AeronaveDetalle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    capacidadCarga = table.Column<float>(type: "real", nullable: false),
                    nroAsientos = table.Column<int>(type: "int", nullable: false),
                    capacidadTanque = table.Column<float>(type: "real", nullable: false),
                    aeropuerto = table.Column<int>(type: "int", nullable: false),
                    AeronaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AeronaveDetalle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AeronaveDetalle_Aeronave_AeronaveId",
                        column: x => x.AeronaveId,
                        principalTable: "Aeronave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AeronaveDetalle_AeronaveId",
                table: "AeronaveDetalle",
                column: "AeronaveId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AeronaveDetalle");

            migrationBuilder.DropTable(
                name: "Aeronave");
        }
    }
}
