using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class _3620241623 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Multas",
                keyColumn: "MultaId",
                keyValue: 1,
                columns: new[] { "FechaFinalizacion", "FechaInicio" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4079), new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 24, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 5, 24, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 5, 29, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4015) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4019), new DateTime(2024, 5, 31, 16, 23, 36, 729, DateTimeKind.Local).AddTicks(4018) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 1,
                column: "FechaDevolucion",
                value: new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 2,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 1, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Devoluciones",
                keyColumn: "DevolucionId",
                keyValue: 3,
                column: "FechaDevolucion",
                value: new DateTime(2024, 6, 2, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2592));

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
                values: new object[] { new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2622), new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 1,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 24, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2570), new DateTime(2024, 5, 24, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 2,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 29, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2572), new DateTime(2024, 5, 29, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "Prestamos",
                keyColumn: "PrestamoId",
                keyValue: 3,
                columns: new[] { "FechaDevolucion", "FechaPrestamo" },
                values: new object[] { new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2575), new DateTime(2024, 5, 31, 8, 46, 51, 495, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.InsertData(
                table: "Socios",
                columns: new[] { "SocioId", "Apellido", "CantidadLibros", "Dni", "Habilitado", "MultadoHasta", "Nombre" },
                values: new object[,]
                {
                    { 4, "Pérez", 0, 23456789, true, null, "Luis" },
                    { 5, "García", 0, 34567890, true, null, "Sofía" },
                    { 6, "Rodríguez", 0, 45678901, true, null, "Carlos" },
                    { 7, "Fernández", 0, 56789012, true, null, "Lucía" },
                    { 8, "Sánchez", 0, 67890123, true, null, "Miguel" },
                    { 9, "Martín", 0, 78901234, true, null, "Isabel" },
                    { 10, "Ruiz", 0, 89012345, true, null, "Fernando" },
                    { 11, "Hernández", 0, 90123456, true, null, "Patricia" }
                });
        }
    }
}
