using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class SeedAuditoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Auditorias",
                columns: new[] { "AuditoriaId", "Accion", "Entidad", "FechaHora", "Usuario", "ValorAnterior", "ValorNuevo" },
                values: new object[,]
                {
                    { 1, "Login", "Usuario", new DateTime(2025, 10, 21, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9806), "Javier Villalva", "", "Inicio de sesión exitoso" },
                    { 2, "Alta", "Prestamo", new DateTime(2025, 10, 22, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9810), "Carlos Pérez", "", "Prestamo del libro 'El principito' a María López" },
                    { 3, "Modificación", "Socio", new DateTime(2025, 10, 23, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9811), "Javier Villalva", "Socio habilitado = false", "Socio habilitado = true" }
                });

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 20, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 21, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 22, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 10, 20, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9185), new DateTime(2025, 10, 20, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 13, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9099), new DateTime(2025, 10, 13, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9061) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 18, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9104), new DateTime(2025, 10, 18, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 20, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9110), new DateTime(2025, 10, 20, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9109) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Auditorias",
                keyColumn: "AuditoriaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Auditorias",
                keyColumn: "AuditoriaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Auditorias",
                keyColumn: "AuditoriaId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 21, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 22, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2207), new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 13, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2141), new DateTime(2025, 10, 13, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 18, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2144), new DateTime(2025, 10, 18, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2146), new DateTime(2025, 10, 20, 15, 29, 8, 756, DateTimeKind.Local).AddTicks(2146) });
        }
    }
}
