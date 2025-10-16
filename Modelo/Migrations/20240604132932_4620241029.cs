using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _4620241029 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DetallesPagos",
                columns: table => new
                {
                    DetallePagoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuotaMensualId = table.Column<int>(type: "int", nullable: false),
                    MontoCobrado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SocioId = table.Column<int>(type: "int", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesPagos", x => x.DetallePagoId);
                    table.ForeignKey(
                        name: "FK_DetallesPagos_CuotasMensuales_CuotaMensualId",
                        column: x => x.CuotaMensualId,
                        principalTable: "CuotasMensuales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesPagos_Socios_SocioId",
                        column: x => x.SocioId,
                        principalTable: "Socios",
                        principalColumn: "SocioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 5,
                column: "Valor",
                value: 2000.00m);

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 6,
                column: "Valor",
                value: 2000m);

            migrationBuilder.InsertData(
                table: "DetallesPagos",
                columns: new[] { "DetallePagoId", "CuotaMensualId", "FechaPago", "MontoCobrado", "SocioId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 4, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4693), 2000.00m, 1 },
                    { 2, 2, new DateTime(2024, 6, 4, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4695), 2000.00m, 2 },
                    { 3, 3, new DateTime(2024, 6, 4, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4696), 2000.00m, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 3, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 25, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 5, 25, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 30, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4603), new DateTime(2024, 5, 30, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 6, 1, 10, 29, 32, 85, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPagos_CuotaMensualId",
                table: "DetallesPagos",
                column: "CuotaMensualId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPagos_SocioId",
                table: "DetallesPagos",
                column: "SocioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesPagos");

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 5,
                column: "Valor",
                value: 200.00m);

            migrationBuilder.UpdateData(
                table: "CuotasMensuales",
                keyColumn: "Id",
                keyValue: 6,
                column: "Valor",
                value: 0m);

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
        }
    }
}
