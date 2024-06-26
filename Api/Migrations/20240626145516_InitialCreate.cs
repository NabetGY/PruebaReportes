using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Categoria = table.Column<string>(type: "TEXT", nullable: true),
                    Prioridad = table.Column<string>(type: "TEXT", nullable: true),
                    PuestoSeguridad = table.Column<string>(type: "TEXT", nullable: true),
                    CreadoPor = table.Column<string>(type: "TEXT", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CerradoPor = table.Column<string>(type: "TEXT", nullable: true),
                    FechaFin = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Coordenadas = table.Column<string>(type: "TEXT", nullable: true),
                    MapaUrl = table.Column<string>(type: "TEXT", nullable: true),
                    TipoEvento = table.Column<string>(type: "TEXT", nullable: true),
                    TipoEventoImagen = table.Column<string>(type: "TEXT", nullable: true),
                    Impacto = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
