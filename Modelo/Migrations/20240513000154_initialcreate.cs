using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    LibroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Disponible = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.LibroId);
                });

            migrationBuilder.CreateTable(
                name: "Socios",
                columns: table => new
                {
                    SocioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<int>(type: "int", nullable: false),
                    Habilitado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socios", x => x.SocioId);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    PrestamoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaPrestamo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LibroId = table.Column<int>(type: "int", nullable: false),
                    SocioId = table.Column<int>(type: "int", nullable: false),
                    EnPrestamo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.PrestamoId);
                    table.ForeignKey(
                        name: "FK_Prestamos_Libros_LibroId",
                        column: x => x.LibroId,
                        principalTable: "Libros",
                        principalColumn: "LibroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamos_Socios_SocioId",
                        column: x => x.SocioId,
                        principalTable: "Socios",
                        principalColumn: "SocioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devoluciones",
                columns: table => new
                {
                    DevolucionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrestamoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devoluciones", x => x.DevolucionId);
                    table.ForeignKey(
                        name: "FK_Devoluciones_Prestamos_PrestamoId",
                        column: x => x.PrestamoId,
                        principalTable: "Prestamos",
                        principalColumn: "PrestamoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Libros",
                columns: new[] { "LibroId", "Autor", "Disponible", "Titulo", "ubicacion" },
                values: new object[,]
                {
                    { 1, "Gabriel García Márquez", true, "Cien años de soledad", "M1" },
                    { 2, "Miguel de Cervantes", true, "Don Quijote de la Mancha", "C1" },
                    { 3, "Antoine de Saint-Exupéry", true, "El principito", "S1" }
                });

            migrationBuilder.InsertData(
                table: "Socios",
                columns: new[] { "SocioId", "Apellido", "Dni", "Habilitado", "Nombre" },
                values: new object[,]
                {
                    { 1, "González", 12345678, true, "Ana" },
                    { 2, "Martínez", 87654321, true, "Juan" },
                    { 3, "López", 98765432, true, "María" }
                });

            migrationBuilder.InsertData(
                table: "Prestamos",
                columns: new[] { "PrestamoId", "EnPrestamo", "FechaPrestamo", "LibroId", "SocioId" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2024, 5, 2, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9321), 1, 1 },
                    { 2, true, new DateTime(2024, 5, 7, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9340), 2, 2 },
                    { 3, true, new DateTime(2024, 5, 9, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9342), 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Devoluciones",
                columns: new[] { "DevolucionId", "FechaDevolucion", "PrestamoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 9, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9363), 1 },
                    { 2, new DateTime(2024, 5, 10, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9365), 2 },
                    { 3, new DateTime(2024, 5, 11, 21, 1, 54, 613, DateTimeKind.Local).AddTicks(9367), 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devoluciones_PrestamoId",
                table: "Devoluciones",
                column: "PrestamoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_LibroId",
                table: "Prestamos",
                column: "LibroId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_SocioId",
                table: "Prestamos",
                column: "SocioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devoluciones");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Socios");
        }
    }
}
