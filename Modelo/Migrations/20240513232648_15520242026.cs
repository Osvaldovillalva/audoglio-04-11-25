using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _15520242026 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 10, 20, 26, 48, 534, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 11, 20, 26, 48, 534, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 12, 20, 26, 48, 534, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 3, 20, 26, 48, 534, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 8, 20, 26, 48, 534, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 10, 20, 26, 48, 534, DateTimeKind.Local).AddTicks(2332));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 10, 20, 22, 27, 947, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 11, 20, 22, 27, 947, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 12, 20, 22, 27, 947, DateTimeKind.Local).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 3, 20, 22, 27, 947, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 8, 20, 22, 27, 947, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 10, 20, 22, 27, 947, DateTimeKind.Local).AddTicks(9683));
        }
    }
}
