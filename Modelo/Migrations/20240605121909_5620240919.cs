using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _5620240919 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PorcentajeRecargoCuota",
                table: "Reglas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 3, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 4, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5564), new DateTime(2024, 5, 26, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5567), new DateTime(2024, 5, 31, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Reglas",
                keyColumn: "ReglaId",
                keyValue: 1,
                column: "PorcentajeRecargoCuota",
                value: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentajeRecargoCuota",
                table: "Reglas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                column: "PorcentajeRecargoCuota",
                value: 10m);
        }
    }
}
