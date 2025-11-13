using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class AuditoriaInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Auditorias",
                keyColumn: "AuditoriaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Auditorias",
                keyColumn: "AuditoriaId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Entidad",
                table: "Auditorias");

            migrationBuilder.DropColumn(
                name: "ValorAnterior",
                table: "Auditorias");

            migrationBuilder.DropColumn(
                name: "ValorNuevo",
                table: "Auditorias");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                table: "Auditorias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Accion",
                table: "Auditorias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Detalle",
                table: "Auditorias",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Auditorias",
                keyColumn: "AuditoriaId",
                keyValue: 1,
                columns: new[] { "Accion", "Detalle", "FechaHora", "Usuario" },
                values: new object[] { "Inicialización", "Creación inicial de la base de datos y prueba de auditoría", new DateTime(2025, 10, 23, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(6416), "Sistema" });

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 10, 23, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 20, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 21, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 10, 22, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 10, 20, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5422), new DateTime(2025, 10, 20, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 13, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5352), new DateTime(2025, 10, 13, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5338) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 18, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5355), new DateTime(2025, 10, 18, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5354) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 10, 20, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5357), new DateTime(2025, 10, 20, 19, 31, 23, 145, DateTimeKind.Local).AddTicks(5356) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Detalle",
                table: "Auditorias");

            migrationBuilder.AlterColumn<string>(
                name: "Usuario",
                table: "Auditorias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Accion",
                table: "Auditorias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "Entidad",
                table: "Auditorias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ValorAnterior",
                table: "Auditorias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ValorNuevo",
                table: "Auditorias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Auditorias",
                keyColumn: "AuditoriaId",
                keyValue: 1,
                columns: new[] { "Accion", "Entidad", "FechaHora", "Usuario", "ValorAnterior", "ValorNuevo" },
                values: new object[] { "Login", "Usuario", new DateTime(2025, 10, 21, 16, 11, 12, 304, DateTimeKind.Local).AddTicks(9806), "Javier Villalva", "", "Inicio de sesión exitoso" });

            migrationBuilder.InsertData(
                table: "Auditorias",
                columns: new[] { "AuditoriaId", "Accion", "Entidad", "FechaHora", "Usuario", "ValorAnterior", "ValorNuevo" },
                values: new object[,]
                {
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
    }
}
