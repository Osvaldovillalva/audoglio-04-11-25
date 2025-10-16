using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _22520240832 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 19, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4448));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 21, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 19, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 5, 19, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 12, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 5, 12, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 17, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4432), new DateTime(2024, 5, 17, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 19, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4434), new DateTime(2024, 5, 19, 8, 32, 43, 451, DateTimeKind.Local).AddTicks(4433) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 18, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 19, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7407), new DateTime(2024, 5, 18, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 11, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7336), new DateTime(2024, 5, 11, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 16, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7343), new DateTime(2024, 5, 16, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 18, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7345), new DateTime(2024, 5, 18, 20, 14, 36, 969, DateTimeKind.Local).AddTicks(7344) });
        }
    }
}
