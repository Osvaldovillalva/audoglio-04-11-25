using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _5320252021 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 2, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 2, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8782), new DateTime(2025, 3, 2, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 23, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8725), new DateTime(2025, 2, 23, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 28, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8727), new DateTime(2025, 2, 28, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 2, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8730), new DateTime(2025, 3, 2, 20, 21, 1, 253, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Apellido", "Clave", "Dni", "Nombre", "Rol" },
                values: new object[,]
                {
                    { 1, "Principal", "admin123", "00000000", "Admin", "Administrador" },
                    { 2, "Pérez", "bibliotecario123", "12345678", "Carlos", "Bibliotecario" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2024, 6, 5, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 3, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 4, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5618), new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5564), new DateTime(2024, 5, 26, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5545) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5567), new DateTime(2024, 5, 31, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 6, 2, 9, 19, 9, 76, DateTimeKind.Local).AddTicks(5569) });
        }
    }
}
