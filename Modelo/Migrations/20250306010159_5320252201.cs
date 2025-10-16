using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _5320252201 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ClaveModificada",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 2, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 2, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5875), new DateTime(2025, 3, 2, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 23, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5794), new DateTime(2025, 2, 23, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 28, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5798), new DateTime(2025, 2, 28, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 2, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5801), new DateTime(2025, 3, 2, 22, 1, 59, 177, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "ClaveModificada",
                value: true);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                columns: new[] { "Clave", "ClaveModificada" },
                values: new object[] { "73l8gRjwLftklgfdXT+MdiMEjJwGPVMsyVxe16iYpk8=", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClaveModificada",
                table: "Usuarios");

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
                keyValue: 2,
                column: "Clave",
                value: "bszGH0dcoCk1PBOJa/4mtKuRGfBnAgpTN5Pl/eev/6w=");
        }
    }
}
