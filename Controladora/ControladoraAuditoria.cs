using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Controladora
{
    public class ControladoraAuditoria
    {
        public void Registrar(string usuario, string accion, string detalle = null)
        {
            using (var context = new SistemaBibliotecario())
            {
                var registro = new Auditoria
                {
                    Usuario = usuario,
                    Accion = accion,
                    Detalle = detalle,
                    FechaHora = DateTime.Now
                };

                context.Auditorias.Add(registro);
                context.SaveChanges();
            }
        }
    }
}
