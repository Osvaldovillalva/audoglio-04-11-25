using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _16520241814 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reglas",
                columns: table => new
                {
                    ReglaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiasPrestamo = table.Column<int>(type: "int", nullable: false),
                    MaxLibrosPorUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reglas", x => x.ReglaId);
                });

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 13, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 14, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 15, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 6, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5212), new DateTime(2024, 5, 6, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 11, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5219), new DateTime(2024, 5, 11, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 13, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 5, 13, 18, 14, 20, 174, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.InsertData(
                table: "Reglas",
                columns: new[] { "ReglaId", "DiasPrestamo", "MaxLibrosPorUsuario" },
                values: new object[] { 1, 7, 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reglas");

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 13, 17, 39, 58, 963, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 14, 17, 39, 58, 963, DateTimeKind.Local).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 15, 17, 39, 58, 963, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 6, 17, 39, 58, 963, DateTimeKind.Local).AddTicks(1151), new DateTime(2024, 5, 6, 17, 39, 58, 963, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 39, 58, 963, DateTimeKind.Local).AddTicks(1154), new DateTime(2024, 5, 11, 17, 39, 58, 963, DateTimeKind.Local).AddTicks(1154) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 13, 17, 39, 58, 963, DateTimeKind.Local).AddTicks(1157), new DateTime(2024, 5, 13, 17, 39, 58, 963, DateTimeKind.Local).AddTicks(1156) });
        }
    }
}
