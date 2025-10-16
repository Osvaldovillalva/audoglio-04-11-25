using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _030620240826 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 31, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "LibroId", "Autor", "Disponible", "Titulo", "Ubicacion" },
                values: new object[,]
                {
                    { 4, "George Orwell", true, "1984", "F2" },
                    { 5, "Harper Lee", true, "Matar a un ruiseñor", "A3" },
                    { 6, "Homero", true, "La Odisea", "G4" },
                    { 7, "Fiódor Dostoyevski", true, "Crimen y castigo", "H5" },
                    { 8, "Jane Austen", true, "Orgullo y prejuicio", "J6" },
                    { 9, "Homero", true, "La Ilíada", "K7" },
                    { 10, "Marcel Proust", true, "En busca del tiempo perdido", "L8" },
                    { 11, "James Joyce", true, "Ulises", "M9" }
                });

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(526), new DateTime(2024, 5, 31, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(524) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(476), new DateTime(2024, 5, 24, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(462) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 29, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(479), new DateTime(2024, 5, 29, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(481), new DateTime(2024, 5, 31, 8, 26, 22, 999, DateTimeKind.Local).AddTicks(480) });

            migrationBuilder.InsertData(
                table: "Socios",
                columns: new[] { "SocioId", "Apellido", "CantidadLibros", "Dni", "Habilitado", "MultadoHasta", "Nombre" },
                values: new object[,]
                {
                    { 4, "Pérez", 2, 23456789, true, null, "Luis" },
                    { 5, "García", 0, 34567890, true, null, "Sofía" },
                    { 6, "Rodríguez", 3, 45678901, true, null, "Carlos" },
                    { 7, "Fernández", 1, 56789012, true, null, "Lucía" },
                    { 8, "Sánchez", 0, 67890123, true, null, "Miguel" },
                    { 9, "Martín", 2, 78901234, true, null, "Isabel" },
                    { 10, "Ruiz", 1, 89012345, true, null, "Fernando" },
                    { 11, "Hernández", 0, 90123456, true, null, "Patricia" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Libros",
                keyColumn: "LibroId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Socios",
                keyColumn: "SocioId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 21, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 22, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 13, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3524), new DateTime(2024, 5, 13, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 18, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3531), new DateTime(2024, 5, 18, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3534), new DateTime(2024, 5, 20, 21, 39, 32, 87, DateTimeKind.Local).AddTicks(3533) });
        }
    }
}
