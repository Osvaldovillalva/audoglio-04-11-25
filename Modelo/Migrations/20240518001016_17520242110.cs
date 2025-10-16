using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _17520242110 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 14, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 15, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 16, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 7, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7202), new DateTime(2024, 5, 7, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 12, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 5, 12, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 14, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7207), new DateTime(2024, 5, 14, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7206) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 13, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 14, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 15, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5212), new DateTime(2024, 5, 6, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 11, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 5, 11, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 5, 13, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5220) });
        }
    }
}
