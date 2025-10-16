using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class UsuarioActivoState : IUsuarioState
    {
        public bool PuedeIniciarSesion(Usuario usuario)
        {
            return usuario.Activo;  // Si el usuario está activo, puede iniciar sesión.
        }
    }
}
