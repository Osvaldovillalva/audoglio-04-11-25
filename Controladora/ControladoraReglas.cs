using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;

namespace Controladora
{
    public class ControladoraReglas
    {
        private SistemaBibliotecario contexto;


        public ControladoraReglas()
        {
            contexto = new SistemaBibliotecario(); // Inicializa el contexto de la base de datos
        }




        public List<Regla> ObtenerTodasLasReglas()
        {
            using (var contexto = new SistemaBibliotecario()) // Asume que tienes acceso al contexto
            {
                return contexto.Reglas.ToList();
            }
        }
        public void ModificarReglas(int nuevosDiasPrestamo, int nuevoMaximoPrestamo, int nuevosDiasMulta, int nuevosDiasVenceCuota, int nuevoPorcentajeRecargo)
        {
            // Obtener la regla existente (asumiendo que solo hay una regla en la base de datos)
            Regla reglaExistente = contexto.Reglas.FirstOrDefault();

            if (reglaExistente != null)
            {
                // Actualizar los valores de la regla existente
                reglaExistente.DiasPrestamo = nuevosDiasPrestamo;
                reglaExistente.MaxLibrosPorUsuario = nuevoMaximoPrestamo;
                reglaExistente.DiasMulta = nuevosDiasMulta;
                reglaExistente.DiasVencimientoCuota = nuevosDiasVenceCuota;
                reglaExistente.PorcentajeRecargoCuota = nuevoPorcentajeRecargo;

                // Guardar los cambios en la base de datos
                contexto.SaveChanges();
            }
        }


        public DateTime CalcularFechaDevolucion(DateTime fechaPrestamo)
        {
            // Obtener la regla existente (asumiendo que solo hay una regla en la base de datos)
            Regla reglaExistente = contexto.Reglas.FirstOrDefault();

            if (reglaExistente != null)
            {
                // Calcular la fecha de devolución sumando los días de préstamo a la fecha de préstamo
                return fechaPrestamo.AddDays(reglaExistente.DiasPrestamo);
            }
            else
            {
                // En caso de que no exista ninguna regla, lanzar una excepción o manejar el error de manera adecuada
                throw new InvalidOperationException("No se encontraron reglas en la base de datos.");
            }
        }
        public int ObtenerMaxLibrosPrestados()
        {
            // Obtener el valor de la columna MaxLibrosPorUsuario de la tabla Reglas
            Regla reglas = contexto.Reglas.FirstOrDefault(); // Suponiendo que solo hay un registro en la tabla
            if (reglas != null)
            {
                return reglas.MaxLibrosPorUsuario;
            }
            else
            {
                // Manejar el caso en que no se encuentre ninguna regla en la tabla
                // Puedes lanzar una excepción, devolver un valor predeterminado o manejarlo de alguna otra manera
                throw new InvalidOperationException("No se encontraron reglas en la base de datos.");
            }
        }

        public DateTime CalcularFechaMultaFinalizacion(int diasMulta)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcular la fecha de finalización sumando los días de multa a la fecha actual
            DateTime fechaFinalizacion = fechaActual.AddDays(diasMulta);

            return fechaFinalizacion;
        }
        public int ObtenerDiasMulta()
        {
            // Suponiendo que tienes una instancia de DbContext llamada 'contexto' que te permite acceder a tus datos
            Regla regla = contexto.Reglas.FirstOrDefault();

            if (regla != null)
            {
                return regla.DiasMulta;
            }
            else
            {
                // Manejar el caso en que no se encuentre ninguna regla en la tabla
                // En este caso, podrías lanzar una excepción, devolver un valor predeterminado o manejarlo de alguna otra manera
                throw new InvalidOperationException("No se encontraron reglas en la base de datos.");
            }
        }
        public int ObtenerDiasVencimientoCuotas()
        {
            try
            {
                // Obtener el valor de la columna DiasVencimientoCuota de la tabla Reglas
                Regla regla = contexto.Reglas.FirstOrDefault(); // Suponiendo que solo hay un registro en la tabla Reglas

                if (regla != null)
                {
                    return regla.DiasVencimientoCuota;
                }
                else
                {
                    // Manejar el caso en que no se encuentre ninguna regla en la tabla
                    throw new InvalidOperationException("No se encontraron reglas en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la obtención de los datos
                Console.WriteLine($"Error al obtener los días de vencimiento de las cuotas: {ex.Message}");
                throw; // Opcionalmente, podrías manejar el error de otra manera según tus requerimientos
            }
        }

        public int ObtenerPorcentajeRecargoCuota()
        {
            try
            {
                // Obtener el valor de la columna PorcentajeRecargoCuota de la tabla Reglas
                Regla regla = contexto.Reglas.FirstOrDefault(); // Suponiendo que solo hay un registro en la tabla Reglas

                if (regla != null)
                {
                    return regla.PorcentajeRecargoCuota;
                }
                else
                {
                    // Manejar el caso en que no se encuentre ninguna regla en la tabla
                    throw new InvalidOperationException("No se encontraron reglas en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la obtención de los datos
                Console.WriteLine($"Error al obtener el porcentaje de recargo de las cuotas: {ex.Message}");
                throw; // Opcionalmente, podrías manejar el error de otra manera según tus requerimientos
            }
        }




    }
}
