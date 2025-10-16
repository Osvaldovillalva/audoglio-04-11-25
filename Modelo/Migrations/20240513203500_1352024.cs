using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _1352024 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ubicacion",
                table: "Libros",
                newName: "Ubicacion");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ubicacion",
                table: "Libros",
                newName: "ubicacion");

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 9, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 10, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 11, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 2, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 7, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                column: "FechaPrestamo",
                value: new DateTime(2024, 5, 9, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9342));
        }
    }
}
