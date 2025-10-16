using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInactivoState : IUsuarioState
    {
        public bool PuedeIniciarSesion(Usuario usuario)
        {
            return false;  // Si el usuario está inactivo, no puede iniciar sesión.
        }
    }
}
