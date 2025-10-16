using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _1132025 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 11, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 11, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 11, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 9, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 10, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2155), new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 1, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 3, 1, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 6, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2086), new DateTime(2025, 3, 6, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2088), new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2088) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 8, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 8, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 8, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 6, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 7, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1387), new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 26, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1292), new DateTime(2025, 2, 26, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 3, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1296), new DateTime(2025, 3, 3, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1300), new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1299) });
        }
    }
}
