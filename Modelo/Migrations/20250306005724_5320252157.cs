using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _5320252157 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 2, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 2, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8947), new DateTime(2025, 3, 2, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 23, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8825), new DateTime(2025, 2, 23, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 28, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8833), new DateTime(2025, 2, 28, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 2, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8837), new DateTime(2025, 3, 2, 21, 57, 23, 803, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Activo",
                value: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "Activo",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 2, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 2, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8397), new DateTime(2025, 3, 2, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8397) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 23, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8326), new DateTime(2025, 2, 23, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 28, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8329), new DateTime(2025, 2, 28, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 2, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8331), new DateTime(2025, 3, 2, 21, 32, 26, 978, DateTimeKind.Local).AddTicks(8331) });
        }
    }
}
