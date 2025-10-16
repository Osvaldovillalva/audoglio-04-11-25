using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _4620240830 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AddColumn<int>(
                name: "Año",
                table: "CuotasMensuales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumeroMes",
                table: "CuotasMensuales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Año", "NumeroMes" },
                values: new object[] { 2024, 1 });

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Año", "NumeroMes" },
                values: new object[] { 2024, 2 });

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Año", "NumeroMes" },
                values: new object[] { 2024, 3 });

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Año", "NumeroMes" },
                values: new object[] { 2024, 4 });

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Año", "NumeroMes" },
                values: new object[] { 2024, 5 });

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Año", "NumeroMes" },
                values: new object[] { 2024, 6 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Año",
                table: "CuotasMensuales");

            migrationBuilder.DropColumn(
                name: "NumeroMes",
                table: "CuotasMensuales");

            migrationBuilder.InsertData(
                table: "CuotasMensuales",
                columns: new[] { "Id", "Mes", "Valor" },
                values: new object[,]
                {
                    { 7, "Julio", 0m },
                    { 8, "Agosto", 0m },
                    { 9, "Septiembre", 0m },
                    { 10, "Octubre", 0m },
                    { 11, "Noviembre", 0m },
                    { 12, "Diciembre", 0m }
                });

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3674), new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 24, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 5, 24, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 29, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 5, 29, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 5, 31, 20, 7, 36, 743, DateTimeKind.Local).AddTicks(3601) });
        }
    }
}
