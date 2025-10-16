using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _210520242001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 18, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 19, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8208), new DateTime(2024, 5, 18, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 11, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8153), new DateTime(2024, 5, 11, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8156), new DateTime(2024, 5, 16, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8156) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 18, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8158), new DateTime(2024, 5, 18, 8, 57, 44, 252, DateTimeKind.Local).AddTicks(8158) });
        }
    }
}
