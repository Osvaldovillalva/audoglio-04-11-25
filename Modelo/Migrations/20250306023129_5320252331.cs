using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _5320252331 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PuedeBorrarLibros",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PuedeBorrarSocios",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PuedeCambiarReglas",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PuedeCobrarCuotas",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PuedeGestionarUsuarios",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PuedeModificarLibros",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PuedeModificarSocios",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PuedeModificarValorCuota",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PuedeVerRegistros",
                table: "Usuarios",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 1,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 2,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "DetallePagoId",
                keyValue: 3,
                column: "FechaPago",
                value: new DateTime(2025, 3, 5, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 3, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2025, 3, 4, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(946), new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 23, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(876), new DateTime(2025, 2, 23, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 2, 28, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(879), new DateTime(2025, 2, 28, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(881), new DateTime(2025, 3, 2, 23, 31, 28, 791, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Apellido", "Clave", "Dni", "Nombre", "PalabraDeSeguridad", "PuedeBorrarLibros", "PuedeBorrarSocios", "PuedeCambiarReglas", "PuedeCobrarCuotas", "PuedeGestionarUsuarios", "PuedeModificarLibros", "PuedeModificarSocios", "PuedeModificarValorCuota", "PuedeVerRegistros" },
                values: new object[] { "Villalva", "pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=", "27029674", "Javier", "HqnzlPUQ4r60PLCzFyWLCbzp9PzO9pQHNgSDaQrJt0Y=", true, true, true, true, true, true, true, true, true });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                columns: new[] { "PuedeBorrarLibros", "PuedeBorrarSocios", "PuedeCambiarReglas", "PuedeCobrarCuotas", "PuedeGestionarUsuarios", "PuedeModificarLibros", "PuedeModificarSocios", "PuedeModificarValorCuota", "PuedeVerRegistros" },
                values: new object[] { false, false, false, false, false, false, false, false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PuedeBorrarLibros",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PuedeBorrarSocios",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PuedeCambiarReglas",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PuedeCobrarCuotas",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PuedeGestionarUsuarios",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PuedeModificarLibros",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PuedeModificarSocios",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PuedeModificarValorCuota",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PuedeVerRegistros",
                table: "Usuarios");

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
                columns: new[] { "Apellido", "Clave", "Dni", "Nombre", "PalabraDeSeguridad" },
                values: new object[] { "Principal", "JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3THIKk=", "00000000", "Admin", "IgyUaIC/xkPO2HypTkdqQOkkcLpR5oEX5nnunsS7kFg=" });
        }
    }
}
