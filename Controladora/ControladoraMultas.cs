using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Controladora
{
    public class ControladoraMultas
    {
        private SistemaBibliotecario contexto;

        public ControladoraMultas()
        {
            contexto = new SistemaBibliotecario();
        }

        public List<Multa> ObtenerTodasLasMultas()
        {
            // Utiliza el DbContext para obtener todas las multas
            return contexto.Multas.Include(m => m.Socio).ToList();
        }

        public void VerificarYActualizarEstadoSocios()
        {
            using (var contexto = new SistemaBibliotecario())
            {
                var prestamosVencidos = contexto.Prestamos
                    .Where(p => p.FechaDevolucion < DateTime.Now && p.EnPrestamo)
                    .ToList();

                foreach (var prestamo in prestamosVencidos)
                {
                    var socio = contexto.Socios.FirstOrDefault(s => s.SocioId == prestamo.SocioId);
                    if (socio != null && socio.Habilitado)
                    {
                        socio.Habilitado = false;
                    }
                }
                contexto.SaveChanges(); // Guardar los cambios fuera del bucle
            }
        }

        public void VerificarYActualizarEstadoSociosMultados()
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Obtener todos los socios multados
            List<Socio> sociosMultados = contexto.Socios.Where(s => s.MultadoHasta != null && s.MultadoHasta <= fechaActual).ToList();

            // Verificar cada socio multado
            foreach (var socio in sociosMultados)
            {
                // Verificar si ya ha pasado la fecha de multa
                if (socio.MultadoHasta <= fechaActual)
                {
                    // Actualizar el estado del socio a habilitado
                    socio.Habilitado = true;
                    socio.MultadoHasta = null; // Limpiar la fecha de multa
                }
            }

            // Guardar los cambios en la base de datos
            contexto.SaveChanges();
        }

        public void AgregarMulta(Multa multa)
        {
            // Agregar la multa a la tabla de multas en el contexto
            contexto.Multas.Add(multa);

            // Guardar los cambios en la base de datos
            contexto.SaveChanges();
        }

    }
}
