using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _4620240947 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaIngreso",
                table: "Socios",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 3, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 6, 1, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 6, 1, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 5, 25, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 30, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4760), new DateTime(2024, 5, 30, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 6, 1, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4766), new DateTime(2024, 6, 1, 9, 47, 58, 889, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 1,
                column: "FechaIngreso",
                value: new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 2,
                column: "FechaIngreso",
                value: new DateTime(2024, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 3,
                column: "FechaIngreso",
                value: new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaIngreso",
                table: "Socios");

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 3, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 6, 1, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9511), new DateTime(2024, 6, 1, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 25, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9459), new DateTime(2024, 5, 25, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9446) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 30, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9462), new DateTime(2024, 5, 30, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 6, 1, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9464), new DateTime(2024, 6, 1, 8, 30, 9, 208, DateTimeKind.Local).AddTicks(9464) });
        }
    }
}
