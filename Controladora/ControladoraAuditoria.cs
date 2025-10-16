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
        private readonly SistemaBibliotecario _contexto;

        public ControladoraAuditoria()
        {
            _contexto = new SistemaBibliotecario();
        }

        /// <summary>
        /// Registra un evento de auditoría
        /// </summary>
        /// <param name="usuario">Nombre del bibliotecario</param>
        /// <param name="entidad">Entidad afectada (DetallePago, Sistema, etc.)</param>
        /// <param name="accion">Tipo de acción (Alta, Modificación, Eliminación, Login, Logout)</param>
        /// <param name="valorAnterior">Datos previos (opcional)</param>
        /// <param name="valorNuevo">Datos nuevos (opcional)</param>
        public void Registrar(string usuario, string entidad, string accion, string valorAnterior = null, string valorNuevo = null)
        {
            try
            {
                var registro = new Auditoria
                {
                    Usuario = usuario,
                    Entidad = entidad,
                    Accion = accion,
                    FechaHora = DateTime.Now,
                    ValorAnterior = valorAnterior,
                    ValorNuevo = valorNuevo
                };

                _contexto.Auditorias.Add(registro);
                _contexto.SaveChanges();
            }
            catch (Exception ex)
            {
                // Opcional: manejar errores de auditoría, log local, etc.
                Console.WriteLine("Error al registrar auditoría: " + ex.Message);
            }
        }
    }
}
