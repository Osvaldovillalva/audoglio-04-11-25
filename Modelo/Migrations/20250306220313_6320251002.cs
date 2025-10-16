using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _6320251002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NombreDeUsuario",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "Clave", "ClaveModificada", "NombreDeUsuario" },
                values: new object[] { "vVb03QnII4BdzPlJ9RpvowjSTGvnDHxrfkniDF9Gnw4=", false, "27029674" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "NombreDeUsuario",
                value: "12345678");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreDeUsuario",
                table: "Usuarios");

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 6, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 5, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9396), new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 24, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9292), new DateTime(2025, 2, 24, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 1, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9297), new DateTime(2025, 3, 1, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9296) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9300), new DateTime(2025, 3, 3, 12, 29, 13, 181, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Clave", "ClaveModificada" },
                values: new object[] { "pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=", true });
        }
    }
}
