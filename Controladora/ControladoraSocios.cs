using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class ControladoraSocios
    {
        private SistemaBibliotecario contexto; // Referencia al DbContext

        public ControladoraSocios()
        {
            contexto = new SistemaBibliotecario(); // Inicializa el DbContext
        }

        public List<Socio> ObtenerTodosLosSocios()
        {
            // Utiliza el DbContext para obtener todos los libros
            return contexto.Socios.ToList();
        }
        public void AgregarSocio(Socio socio)
        {
            // Agregar el socio al contexto y guardar los cambios en la base de datos
            contexto.Socios.Add(socio);
            contexto.SaveChanges();
        }
        public void BorrarSocio(int socioId)
        {
            // Buscar el socio en la base de datos utilizando su ID
            Socio socio = contexto.Socios.FirstOrDefault(s => s.SocioId == socioId);

            if (socio != null)
            {
                // Remover el socio de la base de datos
                contexto.Socios.Remove(socio);

                // Guardar los cambios en la base de datos
                contexto.SaveChanges();
            }
            else
            {
                // Si el socio no se encuentra en la base de datos, mostrar un mensaje de error o manejar la situación según sea necesario
                Console.WriteLine("El socio no existe en la base de datos.");
            }
        }

        public Socio ObtenerSocioPorId(int id)
        {
            // Consulta la base de datos para obtener el socio con el ID proporcionado
            return contexto.Socios.FirstOrDefault(s => s.SocioId == id);
        }
        public void ActualizarSocio(Socio socio)
        {
            // Buscar el socio en la base de datos por su ID
            Socio socioEncontrado = contexto.Socios.FirstOrDefault(s => s.SocioId == socio.SocioId);

            // Verificar si se encontró el socio en la base de datos
            if (socioEncontrado != null)
            {
                // Actualizar los datos del socio encontrado con los datos del socio proporcionado
                socioEncontrado.Nombre = socio.Nombre;
                socioEncontrado.Apellido = socio.Apellido;
                socioEncontrado.Dni = socio.Dni;

                // Guardar los cambios en la base de datos
                contexto.SaveChanges();
            }
        }
        public List<Socio> ObtenerSociosPorCoincidencia(string textoBusqueda)
        {
            // Verificar si el texto de búsqueda no está vacío
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                // Si el texto de búsqueda está vacío, devolver todos los socios
                return contexto.Socios.ToList();
            }

            // Convertir el texto de búsqueda a minúsculas para hacer la búsqueda insensible a mayúsculas y minúsculas
            textoBusqueda = textoBusqueda.ToLower();

            // Filtrar los socios cuyos nombres, apellidos o DNI contengan el texto de búsqueda
            List<Socio> sociosFiltrados = contexto.Socios.Where(s =>
                s.Nombre.ToLower().Contains(textoBusqueda) ||
                s.Apellido.ToLower().Contains(textoBusqueda) ||
                s.Dni.ToString().Contains(textoBusqueda) // Convertir el DNI a cadena para buscar coincidencias parciales
            ).ToList();

            return sociosFiltrados;
        }
        // En tu clase ControladoraSocios
        public List<Socio> BuscarSociosPorDniParcial(string dniBusqueda)
        {
            // Convertir el texto de búsqueda a minúsculas para hacer la búsqueda insensible a mayúsculas y minúsculas
            dniBusqueda = dniBusqueda.ToLower();

            // Filtrar los socios cuyos DNIs contengan el texto de búsqueda parcialmente y que estén habilitados
            List<Socio> sociosFiltrados = contexto.Socios.Where(s =>
                s.Dni.ToString().Contains(dniBusqueda) && s.Habilitado
            ).ToList();

            return sociosFiltrados;
        }
        public bool SocioEstaHabilitado(int socioId)
        {
            // Busca el socio en la base de datos por su ID
            Socio socio = contexto.Socios.FirstOrDefault(s => s.SocioId == socioId);

            // Verifica si se encontró el socio y si está habilitado
            return socio != null && socio.Habilitado;
        }

        public void CambiarEstadoSocio(int socioId)
        {
            // Busca el socio en la base de datos por su ID
            Socio socio = contexto.Socios.FirstOrDefault(s => s.SocioId == socioId);

            // Verifica si se encontró el socio
            if (socio != null)
            {
                // Cambia el estado de habilitado
                socio.Habilitado = !socio.Habilitado;

                // Guarda los cambios en la base de datos
                contexto.SaveChanges();
            }
        }
        public void GuardarCambios()
        {
            contexto.SaveChanges();
        }
        public void ActualizarFechaMultaFinalizacion(int socioId, DateTime fechaMultaFinalizacion)
        {
            // Suponiendo que tienes una instancia de DbContext llamada 'contexto' que te permite acceder a tus datos
            Socio socio = contexto.Socios.FirstOrDefault(s => s.SocioId == socioId);

            if (socio != null)
            {
                socio.MultadoHasta = fechaMultaFinalizacion;
                contexto.SaveChanges();
            }
            else
            {
                // Manejar el caso en que no se encuentre el socio con el ID especificado
                // En este caso, podrías lanzar una excepción, devolver un valor predeterminado o manejarlo de alguna otra manera
                throw new InvalidOperationException($"No se encontró ningún socio con el ID {socioId}.");
            }
        }


    }
}
