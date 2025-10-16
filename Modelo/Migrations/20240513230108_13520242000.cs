using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _13520242000 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 10, 20, 1, 8, 131, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 11, 20, 1, 8, 131, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 12, 20, 1, 8, 131, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 3, 20, 1, 8, 131, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 8, 20, 1, 8, 131, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 10, 20, 1, 8, 131, DateTimeKind.Local).AddTicks(3262));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 10, 17, 35, 0, 367, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 11, 17, 35, 0, 367, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 12, 17, 35, 0, 367, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 3, 17, 35, 0, 367, DateTimeKind.Local).AddTicks(9229));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 8, 17, 35, 0, 367, DateTimeKind.Local).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 10, 17, 35, 0, 367, DateTimeKind.Local).AddTicks(9247));
        }
    }
}
