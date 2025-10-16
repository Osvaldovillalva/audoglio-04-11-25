using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _5320252132 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PalabraDeSeguridad",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                columns: new[] { "Clave", "PalabraDeSeguridad" },
                values: new object[] { "JAvlGPq9JyTdtvBO6x2llnRI1+gxwIyPqCKAn3THIKk=", "IgyUaIC/xkPO2HypTkdqQOkkcLpR5oEX5nnunsS7kFg=" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                columns: new[] { "Clave", "PalabraDeSeguridad" },
                values: new object[] { "bszGH0dcoCk1PBOJa/4mtKuRGfBnAgpTN5Pl/eev/6w=", "AlAeR1FQ6K7QfkAQjlLKRzLnDwAT6xlGeAkMATwHUyU=" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PalabraDeSeguridad",
                table: "Usuarios");

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

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 1,
                column: "Clave",
                value: "admin123");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioId",
                keyValue: 2,
                column: "Clave",
                value: "bibliotecario123");
        }
    }
}
