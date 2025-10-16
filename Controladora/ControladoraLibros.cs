using Entidades;
using FuzzySharp;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraLibros
    {
        private SistemaBibliotecario contexto; // Referencia al DbContext

        public ControladoraLibros()
        {
            contexto = new SistemaBibliotecario(); // Inicializa el DbContext
        }

        public bool EliminarLibro(int id)
        {
            try
            {
                using (var context = new SistemaBibliotecario())
                {
                    // Buscar el libro por su Id
                    var libro = context.LibrosParaComprar.FirstOrDefault(l => l.Id == id);

                    if (libro != null)
                    {
                        // Eliminar el libro
                        context.LibrosParaComprar.Remove(libro);
                        context.SaveChanges(); // Guardar los cambios en la base de datos

                        return true; // Si todo fue exitoso
                    }
                    else
                    {
                        return false; // Si no se encontró el libro
                    }
                }
            }
            catch (Exception)
            {
                return false; // Si ocurre algún error en la base de datos
            }
        }






        public List<ClassLibrosParaComprar> ObtenerLibrosParaComprar()
        {
            return contexto.LibrosParaComprar.ToList();
        }
        public List<Libro> ObtenerTodosLosLibros()
        {
            // Utiliza el DbContext para obtener todos los libros
            return contexto.Libros.ToList();
        }
        public void AgregarLibro(Libro nuevoLibro)
        {
            contexto.Libros.Add(nuevoLibro);
            contexto.SaveChanges();
        }
        public void BorrarLibro(int libroId)
        {
            // Buscar el libro por su ID
            Libro libroABorrar = contexto.Libros.FirstOrDefault(libro => libro.LibroId == libroId);

            // Verificar si el libro existe
            if (libroABorrar != null)
            {
                // Remover el libro de la base de datos
                contexto.Libros.Remove(libroABorrar);
                contexto.SaveChanges();
            }
        }

       


        public List<string> GenerarUbicaciones(string autor, int cantidad)
        {
            char primeraLetra = autor.ToUpper()[0]; // Obtener la primera letra del autor en mayúscula
            var ubicaciones = new List<string>();

            // Buscar la última ubicación que comience con la misma letra en la base de datos
            var librosConMismaLetra = contexto.Libros.Where(libro => libro.Ubicacion.StartsWith(primeraLetra.ToString())).ToList();
            if (librosConMismaLetra.Any())
            {
                var ultimaUbicacion = librosConMismaLetra.Select(libro => int.Parse(libro.Ubicacion.Substring(1))).Max();
                for (int i = 1; i <= cantidad; i++)
                {
                    ubicaciones.Add($"{primeraLetra}{ultimaUbicacion + i}");
                }
            }
            else
            {
                for (int i = 1; i <= cantidad; i++)
                {
                    ubicaciones.Add($"{primeraLetra}{i}");
                }
            }

            return ubicaciones;
        }
        public Libro ObtenerLibroPorId(int libroId)
        {
            // Utiliza el DbContext para obtener el libro con el ID proporcionado
            return contexto.Libros.FirstOrDefault(libro => libro.LibroId == libroId);
        }

        public int ContarLibrosMismoTituloAutor(string titulo, string autor)
        {
            // Utiliza el DbContext para contar cuántos libros tienen el mismo título y autor
            return contexto.Libros.Count(libro => libro.Titulo == titulo && libro.Autor == autor);
        }

        public void ActualizarLibro(Libro libro)
        {
            // Marcar el libro como modificado en el contexto
            contexto.Entry(libro).State = EntityState.Modified;

            // Guardar los cambios en la base de datos
            contexto.SaveChanges();
        }

        public void ActualizarLibrosMismoTituloAutor(Libro libro)
        {
            // Buscar todos los libros con el mismo título y autor
            var librosMismoTituloAutor = contexto.Libros.Where(l => l.Titulo == libro.Titulo && l.Autor == libro.Autor);

            // Actualizar cada libro encontrado con los nuevos valores, si son diferentes del libro proporcionado
            foreach (var libroEncontrado in librosMismoTituloAutor)
            {
                if (libroEncontrado.LibroId != libro.LibroId) // Evitar actualizar el libro proporcionado
                {
                    libroEncontrado.Titulo = libro.Titulo;
                    libroEncontrado.Autor = libro.Autor;
                }
            }

            // Guardar los cambios en la base de datos
            contexto.SaveChanges();
        }

        public List<Libro> BuscarLibros(string textoBusqueda)
        {
            // Convertir el texto de búsqueda a minúsculas para hacer la búsqueda insensible a mayúsculas/minúsculas
            string textoBusquedaMinusculas = textoBusqueda.ToLower();

            // Realizar la búsqueda en la base de datos
            var resultadosBusqueda = contexto.Libros
                .Where(libro =>
                    libro.Titulo.ToLower().Contains(textoBusquedaMinusculas) || // Buscar por título
                    libro.Autor.ToLower().Contains(textoBusquedaMinusculas) ||  // Buscar por autor
                    libro.Ubicacion.ToLower().Contains(textoBusquedaMinusculas)) // Buscar por ubicación
                .ToList();

            return resultadosBusqueda;
        }


        public List<Libro> BuscarLibrosPorCoincidencia(string textoBusqueda)
        {
            // Verificar si el texto de búsqueda no está vacío
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                // Si el texto de búsqueda está vacío, devolver todos los libros disponibles
                return contexto.Libros.Where(libro => libro.Disponible).ToList();
            }

            // Convertir el texto de búsqueda a minúsculas para hacer la búsqueda insensible a mayúsculas y minúsculas
            textoBusqueda = textoBusqueda.ToLower();

            // Filtrar los libros cuyos títulos, autores, o ubicaciones contengan el texto de búsqueda y estén disponibles
            List<Libro> librosFiltrados = contexto.Libros.Where(libro =>
                (libro.Titulo.ToLower().Contains(textoBusqueda) ||
                libro.Autor.ToLower().Contains(textoBusqueda) ||
                libro.Ubicacion.ToLower().Contains(textoBusqueda)) &&
                libro.Disponible
            ).ToList();

            return librosFiltrados;
        }

        public bool VerificarDisponibilidadLibro(int libroId)
        {
            // Busca el libro en la base de datos por su ID
            Libro libro = contexto.Libros.FirstOrDefault(l => l.LibroId == libroId);

            // Verifica si se encontró el libro y si está disponible
            return libro != null && libro.Disponible;
        }

        public void CambiarEstadoDisponibilidadLibro(int libroId)
        {
            // Busca el libro en la base de datos por su ID
            Libro libro = contexto.Libros.FirstOrDefault(l => l.LibroId == libroId);

            // Verifica si se encontró el libro
            if (libro != null)
            {
                // Cambia el estado de disponibilidad del libro
                libro.Disponible = !libro.Disponible;

                // Guarda los cambios en la base de datos
                contexto.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }
        public ClassLibrosParaComprar BuscarLibroOAgregar(string textoCompleto)
        {
            using (var context = new SistemaBibliotecario())
            {
                var libro = context.LibrosParaComprar
                                  .FirstOrDefault(l => l.TextoCompleto.ToLower() == textoCompleto.ToLower());

                if (libro == null)
                {
                    libro = new ClassLibrosParaComprar
                    {
                        TextoCompleto = textoCompleto,
                        Contador = 1
                    };
                    context.LibrosParaComprar.Add(libro);
                }
                else
                {
                    libro.Contador++;
                }

                context.SaveChanges();
                return libro;
            }
        }






        public List<ClassLibrosParaComprar> BuscarLibrosSimilares(string textoCompleto)
        {
            using (var context = new SistemaBibliotecario())
            {
                // Realizar búsqueda y devolver lista de libros similares
                return context.LibrosParaComprar
                              .Where(l => l.TextoCompleto.Contains(textoCompleto))
                              .ToList();
            }
        }

        public void IncrementarContadorLibro(ClassLibrosParaComprar libro)
        {
            using (var context = new SistemaBibliotecario())
            {
                var libroParaComprar = context.LibrosParaComprar.FirstOrDefault(l => l.TextoCompleto == libro.TextoCompleto);
                if (libroParaComprar != null)
                {
                    libroParaComprar.Contador++;
                    context.SaveChanges();
                }
            }
        }
        public void AgregarLibroNuevo(string textoCompleto)
        {
            using (var context = new SistemaBibliotecario())
            {
                var nuevoLibro = new ClassLibrosParaComprar
                {
                    TextoCompleto = textoCompleto,
                    Contador = 1
                };
                context.LibrosParaComprar.Add(nuevoLibro);
                context.SaveChanges();
            }
        }



    }

}

