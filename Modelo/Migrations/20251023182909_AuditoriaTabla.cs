using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AuditoriaTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 21, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 22, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2207), new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2141), new DateTime(2025, 10, 13, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 18, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2144), new DateTime(2025, 10, 18, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2146), new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2146) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 13, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 14, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 15, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8649), new DateTime(2025, 10, 13, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 6, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8575), new DateTime(2025, 10, 6, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 11, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8578), new DateTime(2025, 10, 11, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8581), new DateTime(2025, 10, 13, 15, 39, 36, 30, DateTimeKind.Local).AddTicks(8580) });
        }
    }
}
