using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _3620240846 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2622), new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 5, 24, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 29, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2572), new DateTime(2024, 5, 29, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2575), new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 1,
                column: "CantidadLibros",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 2,
                column: "CantidadLibros",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 3,
                column: "CantidadLibros",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3375), new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3305), new DateTime(2024, 5, 24, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 29, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3311), new DateTime(2024, 5, 29, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 5, 31, 8, 30, 21, 140, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 1,
                column: "CantidadLibros",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 2,
                column: "CantidadLibros",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 3,
                column: "CantidadLibros",
                value: 0);
        }
    }
}
