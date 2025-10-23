using Microsoft.EntityFrameworkCore;
using System;
using Entidades;

namespace Modelo
{
    public class SistemaBibliotecario : DbContext
    {
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Devolucion> Devoluciones { get; set; }
        public DbSet<Regla> Reglas { get; set; }
        public DbSet<Multa> Multas { get; set; }
        public DbSet<CuotaMensual> CuotasMensuales { get; set; }
        public DbSet<DetallePago> DetallesPagos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ClassLibrosParaComprar> LibrosParaComprar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;
               Initial Catalog=DataBase120524;
               Integrated Security=True;
               Persist Security Info=False;
               Pooling=False;
               MultipleActiveResultSets=True;
               Encrypt=False;
               TrustServerCertificate=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // --- Claves y relaciones principales ---
            modelBuilder.Entity<Auditoria>().HasKey(a => a.AuditoriaId);

            modelBuilder.Entity<Prestamo>().HasKey(p => p.PrestamoId);

            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Libro)
                .WithMany()
                .HasForeignKey(p => p.LibroId);

            modelBuilder.Entity<Prestamo>()
                .HasOne(p => p.Socio)
                .WithMany()
                .HasForeignKey(p => p.SocioId);

            // --- Semillas existentes ---
            modelBuilder.Entity<Libro>().HasData(
                new Libro { LibroId = 1, Titulo = "Cien años de soledad", Autor = "Gabriel García Márquez", Ubicacion = "M1", Disponible = true },
                new Libro { LibroId = 2, Titulo = "Don Quijote de la Mancha", Autor = "Miguel de Cervantes", Ubicacion = "C1", Disponible = true },
                new Libro { LibroId = 3, Titulo = "El principito", Autor = "Antoine de Saint-Exupéry", Ubicacion = "S1", Disponible = true }
            );

            modelBuilder.Entity<Socio>().HasData(
                new Socio { SocioId = 1, Nombre = "Ana", Apellido = "González", Dni = 12345678, CantidadLibros = 1, MultadoHasta = null, Habilitado = true, FechaIngreso = new DateTime(2024, 2, 15) },
                new Socio { SocioId = 2, Nombre = "Juan", Apellido = "Martínez", Dni = 87654321, CantidadLibros = 1, MultadoHasta = null, Habilitado = true, FechaIngreso = new DateTime(2024, 3, 20) },
                new Socio { SocioId = 3, Nombre = "María", Apellido = "López", Dni = 98765432, CantidadLibros = 1, MultadoHasta = null, Habilitado = true, FechaIngreso = new DateTime(2024, 4, 10) }
            );

            modelBuilder.Entity<Prestamo>().HasData(
                new Prestamo { PrestamoId = 1, FechaPrestamo = DateTime.Now.AddDays(-10), FechaDevolucion = DateTime.Now.AddDays(-10), LibroId = 1, SocioId = 1, CarritoId = 1, EnPrestamo = true },
                new Prestamo { PrestamoId = 2, FechaPrestamo = DateTime.Now.AddDays(-5), FechaDevolucion = DateTime.Now.AddDays(-5), LibroId = 2, SocioId = 2, CarritoId = 2, EnPrestamo = true },
                new Prestamo { PrestamoId = 3, FechaPrestamo = DateTime.Now.AddDays(-3), FechaDevolucion = DateTime.Now.AddDays(-3), LibroId = 3, SocioId = 3, CarritoId = 3, EnPrestamo = true }
            );

            modelBuilder.Entity<Devolucion>().HasData(
                new Devolucion { DevolucionId = 1, FechaDevolucion = DateTime.Now.AddDays(-3), PrestamoId = 1 },
                new Devolucion { DevolucionId = 2, FechaDevolucion = DateTime.Now.AddDays(-2), PrestamoId = 2 },
                new Devolucion { DevolucionId = 3, FechaDevolucion = DateTime.Now.AddDays(-1), PrestamoId = 3 }
            );

            modelBuilder.Entity<Regla>().HasData(
                new Regla { ReglaId = 1, DiasPrestamo = 7, MaxLibrosPorUsuario = 3, DiasMulta = 7, DiasVencimientoCuota = 10, PorcentajeRecargoCuota = 10 }
            );

            modelBuilder.Entity<Multa>().HasData(
                new Multa { MultaId = 1, SocioId = 1, FechaInicio = DateTime.Now.AddDays(-3), FechaFinalizacion = DateTime.Now.AddDays(-3), Pagada = true }
            );

            modelBuilder.Entity<CuotaMensual>()
                .Property(c => c.Valor)
                .HasPrecision(18, 2);

            modelBuilder.Entity<CuotaMensual>().HasData(
                new CuotaMensual { CuotaMensualId = 1, Año = 2024, NumeroMes = 1, Mes = "Enero", Valor = 2000.00m },
                new CuotaMensual { CuotaMensualId = 2, Año = 2024, NumeroMes = 2, Mes = "Febrero", Valor = 2000.00m },
                new CuotaMensual { CuotaMensualId = 3, Año = 2024, NumeroMes = 3, Mes = "Marzo", Valor = 2000.00m },
                new CuotaMensual { CuotaMensualId = 4, Año = 2024, NumeroMes = 4, Mes = "Abril", Valor = 2000.00m },
                new CuotaMensual { CuotaMensualId = 5, Año = 2024, NumeroMes = 5, Mes = "Mayo", Valor = 2000.00m },
                new CuotaMensual { CuotaMensualId = 6, Año = 2024, NumeroMes = 6, Mes = "Junio", Valor = 2000m }
            );

            modelBuilder.Entity<DetallePago>()
                .Property(d => d.MontoCobrado)
                .HasPrecision(18, 2);

            modelBuilder.Entity<DetallePago>().HasData(
                new DetallePago { DetallePagoId = 1, SocioId = 1, CuotaMensualId = 1, MontoCobrado = 2000.00m, FechaPago = DateTime.Now },
                new DetallePago { DetallePagoId = 2, SocioId = 2, CuotaMensualId = 2, MontoCobrado = 2000.00m, FechaPago = DateTime.Now },
                new DetallePago { DetallePagoId = 3, SocioId = 3, CuotaMensualId = 3, MontoCobrado = 2000.00m, FechaPago = DateTime.Now }
            );

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    UsuarioId = 1,
                    Nombre = "Javier",
                    Apellido = "Villalva",
                    Dni = "27029674",
                    Rol = "Administrador",
                    NombreDeUsuario = "27029674",
                    Clave = "27029674",
                    PalabraDeSeguridad = "seguridad",
                    Activo = true,
                    ClaveModificada = false,
                    PuedeBorrarSocios = true,
                    PuedeModificarSocios = true,
                    PuedeBorrarLibros = true,
                    PuedeModificarLibros = true,
                    PuedeModificarValorCuota = true,
                    PuedeCobrarCuotas = true,
                    PuedeCambiarReglas = true,
                    PuedeVerRegistros = true,
                    PuedeGestionarUsuarios = true
                },
                new Usuario
                {
                    UsuarioId = 2,
                    Nombre = "Carlos",
                    Apellido = "Pérez",
                    Dni = "12345678",
                    Rol = "Bibliotecario",
                    NombreDeUsuario = "12345678",
                    Clave = "12345678",
                    PalabraDeSeguridad = "otraPalabraSegura456",
                    Activo = true,
                    ClaveModificada = false,
                    PuedeBorrarSocios = false,
                    PuedeModificarSocios = false,
                    PuedeBorrarLibros = false,
                    PuedeModificarLibros = false,
                    PuedeModificarValorCuota = false,
                    PuedeCobrarCuotas = false,
                    PuedeCambiarReglas = false,
                    PuedeVerRegistros = false,
                    PuedeGestionarUsuarios = false
                }
            );

            modelBuilder.Entity<ClassLibrosParaComprar>().HasData(
                new ClassLibrosParaComprar
                {
                    Id = 1,
                    TextoCompleto = "Título Genérico 1 - Autor Genérico 1",
                    Contador = 0
                }
            );

            modelBuilder.Entity<Auditoria>().HasData(
     new Auditoria
     {
         AuditoriaId = 1,
         Usuario = "Javier Villalva",
         Entidad = "Usuario",
         Accion = "Login",
         ValorAnterior = "",
         ValorNuevo = "Inicio de sesión exitoso",
         FechaHora = DateTime.Now.AddDays(-2)
     },
     new Auditoria
     {
         AuditoriaId = 2,
         Usuario = "Carlos Pérez",
         Entidad = "Prestamo",
         Accion = "Alta",
         ValorAnterior = "",
         ValorNuevo = "Prestamo del libro 'El principito' a María López",
         FechaHora = DateTime.Now.AddDays(-1)
     },
     new Auditoria
     {
         AuditoriaId = 3,
         Usuario = "Javier Villalva",
         Entidad = "Socio",
         Accion = "Modificación",
         ValorAnterior = "Socio habilitado = false",
         ValorNuevo = "Socio habilitado = true",
         FechaHora = DateTime.Now
     }
 );

        }
    }
}
