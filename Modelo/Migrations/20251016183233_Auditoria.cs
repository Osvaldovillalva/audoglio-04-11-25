using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class Auditoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auditorias",
                columns: table => new
                {
                    AuditoriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Entidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Accion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorAnterior = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorNuevo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditorias", x => x.AuditoriaId);
                });

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8128));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 10, 16, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 14, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 15, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8064), new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 6, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7989), new DateTime(2025, 10, 6, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 11, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7995), new DateTime(2025, 10, 11, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7998), new DateTime(2025, 10, 13, 15, 32, 32, 642, DateTimeKind.Local).AddTicks(7997) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auditorias");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 11, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 11, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 11, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 9, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 10, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2155), new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 1, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 3, 1, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 6, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2086), new DateTime(2025, 3, 6, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2088), new DateTime(2025, 3, 8, 12, 8, 26, 827, DateTimeKind.Local).AddTicks(2088) });
        }
    }
}
