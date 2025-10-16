using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AjusteDecimalValor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 13, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 14, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 15, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8671), new DateTime(2025, 10, 13, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 6, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8600), new DateTime(2025, 10, 6, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 11, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8602), new DateTime(2025, 10, 11, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8605), new DateTime(2025, 10, 13, 15, 37, 32, 939, DateTimeKind.Local).AddTicks(8604) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 14, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 15, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8064), new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 6, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7989), new DateTime(2025, 10, 6, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 11, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7995), new DateTime(2025, 10, 11, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7998), new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7997) });
        }
    }
}
