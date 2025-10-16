using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioSesion
    {
        private static UsuarioSesion _instancia;

        // Propiedades para almacenar los datos del usuario
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Dni { get; set; }
        public string Apellido { get; set; }
        public string Rol { get; set; }

        // Propiedades para almacenar los permisos
        public bool PuedeBorrarSocios { get; set; }
        public bool PuedeModificarSocios { get; set; }
        public bool PuedeBorrarLibros { get; set; }
        public bool PuedeModificarLibros { get; set; }
        public bool PuedeModificarValorCuota { get; set; }
        public bool PuedeCobrarCuotas { get; set; }
        public bool PuedeCambiarReglas { get; set; }
        public bool PuedeVerRegistros { get; set; }
        public bool PuedeGestionarUsuarios { get; set; }

        // Constructor privado para evitar instanciación externa
        private UsuarioSesion() { }

        // Método para obtener la instancia única del usuario
        public static UsuarioSesion ObtenerInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new UsuarioSesion();
            }
            return _instancia;
        }

        // Método para cerrar sesión (limpiar la sesión)
        public void CerrarSesion()
        {
            _instancia = null;
        }
    }
}


