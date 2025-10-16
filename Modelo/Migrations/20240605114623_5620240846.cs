using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _5620240846 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiasVencimientoCuota",
                table: "Reglas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PorcentajeRecargoCuota",
                table: "Reglas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 3, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 4, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 6, 2, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2223), new DateTime(2024, 6, 2, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2089), new DateTime(2024, 5, 26, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2099), new DateTime(2024, 5, 31, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 6, 2, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2105), new DateTime(2024, 6, 2, 8, 46, 23, 739, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Reglas",
                keyColumn: "ReglaId",
                keyValue: 1,
                columns: new[] { "DiasVencimientoCuota", "PorcentajeRecargoCuota" },
                values: new object[] { 10, 10m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiasVencimientoCuota",
                table: "Reglas");

            migrationBuilder.DropColumn(
                name: "PorcentajeRecargoCuota",
                table: "Reglas");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 3, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 4, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 6, 2, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 6, 2, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8313), new DateTime(2024, 5, 26, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8316), new DateTime(2024, 5, 31, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8315) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 6, 2, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8318), new DateTime(2024, 6, 2, 8, 19, 0, 171, DateTimeKind.Local).AddTicks(8317) });
        }
    }
}
