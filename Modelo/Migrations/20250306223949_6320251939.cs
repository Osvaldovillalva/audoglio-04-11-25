using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _6320251939 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Clave", "Sal" },
                values: new object[] { "u4MqA1bk82Vsn9E40tmzyCPXex6BtyYszEv8PwYWMmY=", "UPLjKJWa2iDcYzZe1sDrfTDlkyWMY0lv3K3jDzl+Lds=" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                columns: new[] { "Clave", "Sal" },
                values: new object[] { "Punb7Lm/vDiQLwyr1+iM356mggXG53h6LuJQEpHTM/M=", "N5jslfnR9jXoM0ZnMlMs17N9RKXno9cfO9BP4eH0s3k=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sal",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 5, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 3, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5507), new DateTime(2025, 3, 3, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 24, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5431), new DateTime(2025, 2, 24, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 1, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5434), new DateTime(2025, 3, 1, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 3, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5437), new DateTime(2025, 3, 3, 19, 3, 12, 676, DateTimeKind.Local).AddTicks(5436) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Clave",
                value: "vVb03QnII4BdzPlJ9RpvowjSTGvnDHxrfkniDF9Gnw4=");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "Clave",
                value: "73l8gRjwLftklgfdXT+MdiMEjJwGPVMsyVxe16iYpk8=");
        }
    }
}
