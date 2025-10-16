using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _3620241656 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CuotasMensuales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Año = table.Column<int>(type: "int", nullable: false),
                    Mes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuotasMensuales", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CuotasMensuales",
                columns: new[] { "Id", "Año", "Mes", "Valor" },
                values: new object[,]
                {
                    { 1, 2024, "Enero", 2000.00m },
                    { 2, 2024, "Febrero", 2000.00m },
                    { 3, 2024, "Marzo", 2000.00m },
                    { 4, 2024, "Abril", 2000.00m }
                });

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 31, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1768), new DateTime(2024, 5, 31, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1614), new DateTime(2024, 5, 24, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 5, 29, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1624), new DateTime(2024, 5, 31, 16, 57, 20, 903, DateTimeKind.Local).AddTicks(1623) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CuotasMensuales");

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4079), new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 5, 24, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 5, 29, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4019), new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4018) });
        }
    }
}
