using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _5620240818 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CuotasMensuales",
                newName: "CuotaMensualId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CuotaMensualId",
                table: "CuotasMensuales",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2024, 6, 4, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2024, 6, 4, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2024, 6, 4, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 3, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 25, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 5, 25, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 30, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4603), new DateTime(2024, 5, 30, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4604) });
        }
    }
}
