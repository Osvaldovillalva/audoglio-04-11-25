using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _6320251228 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 5, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9396), new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 24, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9292), new DateTime(2025, 2, 24, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 1, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9297), new DateTime(2025, 3, 1, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9300), new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9299) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(946), new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 23, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(876), new DateTime(2025, 2, 23, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(879), new DateTime(2025, 2, 28, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(881), new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(880) });
        }
    }
}
