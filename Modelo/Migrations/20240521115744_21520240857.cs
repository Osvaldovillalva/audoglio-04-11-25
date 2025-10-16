using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _21520240857 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cantidadlibros",
                table: "Socios",
                newName: "CantidadLibros");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CantidadLibros",
                table: "Socios",
                newName: "Cantidadlibros");

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 19, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3487), new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 11, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 5, 11, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 16, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3430), new DateTime(2024, 5, 16, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 5, 18, 8, 21, 10, 439, DateTimeKind.Local).AddTicks(3431) });
        }
    }
}
