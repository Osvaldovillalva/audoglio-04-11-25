using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _23520242139 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarritoId",
                table: "Prestamos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 21, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 22, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "CarritoId", "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { 1, new DateTime(2024, 5, 13, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3524), new DateTime(2024, 5, 13, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "CarritoId", "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { 2, new DateTime(2024, 5, 18, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3531), new DateTime(2024, 5, 18, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "CarritoId", "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { 3, new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3534), new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3533) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarritoId",
                table: "Prestamos");

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 21, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 22, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1157), new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 13, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 5, 13, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 18, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1087), new DateTime(2024, 5, 18, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 5, 20, 19, 30, 57, 855, DateTimeKind.Local).AddTicks(1088) });
        }
    }
}
