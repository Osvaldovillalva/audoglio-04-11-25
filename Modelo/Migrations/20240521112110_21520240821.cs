using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _21520240821 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidadlibros",
                table: "Socios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Multas",
                columns: table => new
                {
                    MultaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocioId = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pagada = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Multas", x => x.MultaId);
                    table.ForeignKey(
                        name: "FK_Multas_Socios_SocioId",
                        column: x => x.SocioId,
                        principalTable: "Socios",
                        principalColumn: "SocioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 19, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.InsertData(
                table: "Multas",
                columns: new[] { "MultaId", "FechaFinalizacion", "FechaInicio", "Pagada", "SocioId" },
                values: new object[] { 1, new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3487), new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3486), true, 1 });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 11, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 5, 11, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3430), new DateTime(2024, 5, 16, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 1,
                column: "Cantidadlibros",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 2,
                column: "Cantidadlibros",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 3,
                column: "Cantidadlibros",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Multas_SocioId",
                table: "Multas",
                column: "SocioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Multas");

            migrationBuilder.DropColumn(
                name: "Cantidadlibros",
                table: "Socios");

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 17, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 18, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 19, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 10, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(979), new DateTime(2024, 5, 10, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(981), new DateTime(2024, 5, 15, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 17, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(983), new DateTime(2024, 5, 17, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(983) });
        }
    }
}
