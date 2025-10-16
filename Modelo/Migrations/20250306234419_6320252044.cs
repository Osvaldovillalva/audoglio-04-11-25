using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _6320252044 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sal",
                table: "Usuarios");

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

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Clave", "PalabraDeSeguridad" },
                values: new object[] { "27029674", "seguridad" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                columns: new[] { "Clave", "PalabraDeSeguridad" },
                values: new object[] { "12345678", "otraPalabraSegura456" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sal",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 5, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 3, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7304), new DateTime(2025, 3, 3, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 24, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7138), new DateTime(2025, 2, 24, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 1, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7145), new DateTime(2025, 3, 1, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 3, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7148), new DateTime(2025, 3, 3, 19, 39, 49, 393, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Clave", "PalabraDeSeguridad", "Sal" },
                values: new object[] { "u4MqA1bk82Vsn9E40tmzyCPXex6BtyYszEv8PwYWMmY=", "HqnzlPUQ4r60PLCzFyWLCbzp9PzO9pQHNgSDaQrJt0Y=", "UPLjKJWa2iDcYzZe1sDrfTDlkyWMY0lv3K3jDzl+Lds=" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                columns: new[] { "Clave", "PalabraDeSeguridad", "Sal" },
                values: new object[] { "Punb7Lm/vDiQLwyr1+iM356mggXG53h6LuJQEpHTM/M=", "AlAeR1FQ6K7QfkAQjlLKRzLnDwAT6xlGeAkMATwHUyU=", "N5jslfnR9jXoM0ZnMlMs17N9RKXno9cfO9BP4eH0s3k=" });
        }
    }
}
