using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _20520240935 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DiasMulta",
                table: "Reglas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 17, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 18, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 19, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 10, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(979), new DateTime(2024, 5, 10, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 15, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(981), new DateTime(2024, 5, 15, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(981) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 17, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(983), new DateTime(2024, 5, 17, 9, 35, 10, 96, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Reglas",
                keyColumn: "ReglaId",
                keyValue: 1,
                column: "DiasMulta",
                value: 7);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiasMulta",
                table: "Reglas");

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 14, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 15, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 16, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 7, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7202), new DateTime(2024, 5, 7, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 12, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 5, 12, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 14, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7207), new DateTime(2024, 5, 14, 21, 10, 15, 899, DateTimeKind.Local).AddTicks(7206) });
        }
    }
}
