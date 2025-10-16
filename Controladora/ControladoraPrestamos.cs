using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraPrestamos
    {
        private SistemaBibliotecario contexto; // Necesitas una referencia al contexto de la base de datos

        public ControladoraPrestamos()
        {
            contexto = new SistemaBibliotecario(); // Inicializa el contexto
        }

        public List<Prestamo> ObtenerTodosLosPrestamos()
        {
            // Utiliza el DbContext para obtener todos los préstamos
            return contexto.Prestamos.ToList();
        }
        public void GuardarPrestamos(List<Prestamo> prestamos)
        {
            foreach (var prestamo in prestamos)
            {
                contexto.Prestamos.Add(prestamo);
            }

            contexto.SaveChanges(); // Guardar los cambios en la base de datos
        }
       
        public void ActualizarPrestamo(Prestamo prestamo)
        {
            using (var contexto = new SistemaBibliotecario())
            {
                var prestamoExistente = contexto.Prestamos.FirstOrDefault(p => p.PrestamoId == prestamo.PrestamoId);

                if (prestamoExistente != null)
                {
                    prestamoExistente.FechaPrestamo = prestamo.FechaPrestamo;
                    prestamoExistente.FechaDevolucion = prestamo.FechaDevolucion;
                    prestamoExistente.EnPrestamo = prestamo.EnPrestamo;

                    contexto.SaveChanges();
                }
            }
        }
        public List<Prestamo> BuscarPrestamos(string criterio)
        {
            string criterioBusqueda = criterio.ToLower();

            var prestamos = contexto.Prestamos
                .Include(p => p.Libro)
                .Include(p => p.Socio)
                .Where(p => p.PrestamoId.ToString().Contains(criterioBusqueda) ||
                            p.FechaPrestamo.ToString().ToLower().Contains(criterioBusqueda) ||
                            p.FechaDevolucion.ToString().ToLower().Contains(criterioBusqueda) ||
                            p.EnPrestamo.ToString().ToLower().Contains(criterioBusqueda) ||
                            p.Libro.Titulo.ToLower().Contains(criterioBusqueda) ||
                            p.Socio.Apellido.ToLower().Contains(criterioBusqueda) ||
                            p.Socio.Dni.ToString().Contains(criterio))
                .ToList();

            return prestamos;
        }

        public int ObtenerIdLibroDePrestamo(int prestamoId)
        {
            // Buscar el préstamo en la base de datos por su ID
            Prestamo prestamo = contexto.Prestamos.FirstOrDefault(p => p.PrestamoId == prestamoId);

            // Verificar si se encontró el préstamo
            if (prestamo != null)
            {
                // Retornar el ID del libro asociado al préstamo
                return prestamo.LibroId;
            }
            else
            {
                // En caso de que no se encuentre el préstamo, retornar un valor por defecto (podría ser -1 o cualquier otro valor que indique un error)
                return -1;
            }
        }
        public void CambiarEstadoPrestamo(int prestamoId)
        {






            var prestamo = contexto.Prestamos.FirstOrDefault(p => p.PrestamoId == prestamoId);

            if (prestamo != null)
            {
                prestamo.EnPrestamo = !prestamo.EnPrestamo;
                contexto.SaveChanges();
            }
        }


        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
        public void IncrementarCantidadLibrosPrestados(int socioId)
        {
            // Obtener el socio de la base de datos
            Socio socio = contexto.Socios.FirstOrDefault(s => s.SocioId == socioId);

            if (socio != null)
            {
                // Incrementar la cantidad de libros prestados
                socio.CantidadLibros++;

                // Guardar los cambios en la base de datos
                contexto.SaveChanges();
            }
        }
        public void DecrementarCantidadLibrosPrestados(int prestamoId)
        {
            // Obtener el préstamo de la base de datos
            Prestamo prestamo = contexto.Prestamos.FirstOrDefault(p => p.PrestamoId == prestamoId);

            if (prestamo != null)
            {
                // Obtener el socio asociado al préstamo
                Socio socio = contexto.Socios.FirstOrDefault(s => s.SocioId == prestamo.SocioId);

                if (socio != null)
                {
                    // Decrementar la cantidad de libros prestados
                    if (socio.CantidadLibros > 0)
                    {
                        socio.CantidadLibros--;

                        // Guardar los cambios en la base de datos
                        contexto.SaveChanges();
                    }
                }
            }
        }
        public Prestamo ObtenerPrestamoPorId(int prestamoId)
        {
            return contexto.Prestamos.FirstOrDefault(p => p.PrestamoId == prestamoId);
        }
       

        public int ObtenerIdSocioDePrestamo(int prestamoId)
        {
            // Suponiendo que tienes una instancia de DbContext llamada 'contexto' que te permite acceder a tus datos
            Prestamo prestamo = contexto.Prestamos.FirstOrDefault(p => p.PrestamoId == prestamoId);

            if (prestamo != null)
            {
                return prestamo.SocioId;
            }
            else
            {
                // Manejar el caso en que no se encuentre el préstamo con el ID especificado
                // En este caso, podrías lanzar una excepción, devolver un valor predeterminado o manejarlo de alguna otra manera
                throw new InvalidOperationException($"No se encontró ningún préstamo con el ID {prestamoId}.");
            }
        }
        



    }
}
