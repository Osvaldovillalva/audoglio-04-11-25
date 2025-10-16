using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _3620242007 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Año",
                table: "CuotasMensuales");

            migrationBuilder.InsertData(
                table: "CuotasMensuales",
                columns: new[] { "Id", "Mes", "Valor" },
                values: new object[,]
                {
                    { 5, "Mayo", 200.00m },
                    { 6, "Junio", 0m },
                    { 7, "Julio", 0m },
                    { 8, "Agosto", 0m },
                    { 9, "Septiembre", 0m },
                    { 10, "Octubre", 0m },
                    { 11, "Noviembre", 0m },
                    { 12, "Diciembre", 0m }
                });

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3674), new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 24, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 5, 24, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 5, 29, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3601) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AddColumn<int>(
                name: "Año",
                table: "CuotasMensuales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 1,
                column: "Año",
                value: 2024);

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 2,
                column: "Año",
                value: 2024);

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 3,
                column: "Año",
                value: 2024);

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 4,
                column: "Año",
                value: 2024);

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
    }
}
