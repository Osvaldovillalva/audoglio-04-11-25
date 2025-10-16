using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _21520242014 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MultadoHasta",
                table: "Socios",
                type: "datetime2",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 1,
                column: "MultadoHasta",
                value: null);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 2,
                column: "MultadoHasta",
                value: null);

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 3,
                column: "MultadoHasta",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MultadoHasta",
                table: "Socios");

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 18, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 19, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6515), new DateTime(2024, 5, 18, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 11, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6438), new DateTime(2024, 5, 11, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 16, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6441), new DateTime(2024, 5, 16, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 18, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6443), new DateTime(2024, 5, 18, 20, 2, 9, 518, DateTimeKind.Local).AddTicks(6442) });
        }
    }
}
