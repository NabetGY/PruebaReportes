using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AvisosSapPm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EventoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UbicacionTecnica = table.Column<string>(type: "TEXT", nullable: true),
                    UbicacionTecnicaImg = table.Column<string>(type: "TEXT", nullable: true),
                    ParteObjectoAfectada = table.Column<string>(type: "TEXT", nullable: true),
                    ParteObjectoAfectadaImg = table.Column<string>(type: "TEXT", nullable: true),
                    ModoFalla = table.Column<string>(type: "TEXT", nullable: true),
                    ModoFallaImg = table.Column<string>(type: "TEXT", nullable: true),
                    DescripcionCorta = table.Column<string>(type: "TEXT", nullable: true),
                    FechaIncioAveria = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    HoraInicioAveria = table.Column<TimeOnly>(type: "TEXT", nullable: false),
                    EquipoContinuaOperando = table.Column<bool>(type: "INTEGER", nullable: false),
                    SolucionadoPorBEC = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvisosSapPm", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AvisosY2",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    IdEvento = table.Column<Guid>(type: "TEXT", nullable: false),
                    NumeroAvisoY2 = table.Column<int>(type: "INTEGER", nullable: false),
                    CorregidoPorMantenimiento = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvisosY2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    EventoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirmaImagen = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AvisosSapPm");

            migrationBuilder.DropTable(
                name: "AvisosY2");

            migrationBuilder.DropTable(
                name: "Firmas");
        }
    }
}
