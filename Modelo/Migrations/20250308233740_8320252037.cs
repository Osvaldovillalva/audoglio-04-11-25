using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _8320252037 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibrosParaComprar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextoCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contador = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibrosParaComprar", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 8, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 8, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 8, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 6, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 7, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.InsertData(
                table: "LibrosParaComprar",
                columns: new[] { "Id", "Contador", "TextoCompleto" },
                values: new object[] { 1, 0, "Título Genérico 1 - Autor Genérico 1" });

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1387), new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 26, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1292), new DateTime(2025, 2, 26, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1276) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 3, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1296), new DateTime(2025, 3, 3, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1300), new DateTime(2025, 3, 5, 20, 37, 39, 393, DateTimeKind.Local).AddTicks(1299) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibrosParaComprar");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 5, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 3, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6731), new DateTime(2025, 3, 3, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6729) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 24, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6640), new DateTime(2025, 2, 24, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 1, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6645), new DateTime(2025, 3, 1, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6644) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 3, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6647), new DateTime(2025, 3, 3, 20, 44, 19, 111, DateTimeKind.Local).AddTicks(6646) });
        }
    }
}
