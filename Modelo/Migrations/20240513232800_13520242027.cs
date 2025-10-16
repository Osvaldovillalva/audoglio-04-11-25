using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _13520242027 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 10, 20, 28, 0, 38, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 11, 20, 28, 0, 38, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 12, 20, 28, 0, 38, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 3, 20, 28, 0, 38, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 8, 20, 28, 0, 38, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 10, 20, 28, 0, 38, DateTimeKind.Local).AddTicks(818));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
