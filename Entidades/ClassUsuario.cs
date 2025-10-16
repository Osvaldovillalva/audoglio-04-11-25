using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Rol { get; set; }
        public string Clave { get; set; }
        public string PalabraDeSeguridad { get; set; }
        public bool ClaveModificada { get; set; }
        public bool Activo { get; set; }

        // Permisos del usuario
        public bool PuedeBorrarSocios { get; set; }
        public bool PuedeModificarSocios { get; set; }
        public bool PuedeBorrarLibros { get; set; }
        public bool PuedeModificarLibros { get; set; }
        public bool PuedeModificarValorCuota { get; set; }
        public bool PuedeCobrarCuotas { get; set; }
        public bool PuedeCambiarReglas { get; set; }
        public bool PuedeVerRegistros { get; set; }
        public bool PuedeGestionarUsuarios { get; set; }

        // Propiedad para el nombre de usuario
        public string NombreDeUsuario { get; set; }
    }

}







