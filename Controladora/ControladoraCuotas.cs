using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controladora;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace Controladora
{
    public class ControladoraCuotas
    {
        private SistemaBibliotecario contexto;
        private ControladoraReglas controladoraReglas;

        public ControladoraCuotas()
        {
            contexto = new SistemaBibliotecario();
            controladoraReglas = new ControladoraReglas();
        }

        public List<CuotaMensual> ObtenerTodasLasCuotas()
        {
            try
            {
                // Utiliza el DbContext para obtener todas las cuotas mensuales
                return contexto.CuotasMensuales.ToList();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la obtención de las cuotas
                Console.WriteLine("Error al obtener las cuotas: " + ex.Message);
                return new List<CuotaMensual>();
            }
        }
        public List<DetallePago> ObtenerTodosLosPagos()
        {
            try
            {
                // Utiliza el DbContext para obtener todas las cuotas mensuales
                return contexto.DetallesPagos.ToList();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la obtención de las cuotas
                Console.WriteLine("Error al obtener las cuotas: " + ex.Message);
                return new List<DetallePago>();
            }
        }
        public bool AgregarCuota(int año, int numeroMes, string nombreMes, decimal valorCuota)
        {
            try
            {
                // Verificar si ya existe una cuota para el mismo año y mes
                var cuotaExistente = contexto.CuotasMensuales.FirstOrDefault(c => c.Año == año && c.NumeroMes == numeroMes);

                if (cuotaExistente != null)
                {
                    // Si la cuota ya existe, mostrar un mensaje de advertencia en la consola
                    Console.WriteLine($"Ya existe una cuota para el año {año} y el mes {nombreMes}.");
                    return false;
                }

                // Si no existe, agregar una nueva cuota
                var nuevaCuota = new CuotaMensual
                {
                    Año = año,
                    NumeroMes = numeroMes,
                    Mes = nombreMes,
                    Valor = valorCuota
                };

                contexto.CuotasMensuales.Add(nuevaCuota);

                // Guardar los cambios en la base de datos
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar la cuota: " + ex.Message);
                return false;
            }
        }

        public bool ExisteCuota(int año, int numeroMes)
        {
            // Verificar si existe una cuota para el año y el número de mes dado
            return contexto.CuotasMensuales.Any(c => c.Año == año && c.NumeroMes == numeroMes);
        }

        public CuotaMensual ObtenerCuotaPorId(int cuotaId)
        {
            try
            {
                // Utiliza LINQ para buscar la cuota por su ID en el DbSet de CuotasMensuales
                return contexto.CuotasMensuales.FirstOrDefault(c => c.CuotaMensualId == cuotaId);
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante la obtención de la cuota
                Console.WriteLine("Error al obtener la cuota: " + ex.Message);
                return null;
            }
        }
        public bool EliminarCuota(int cuotaId)
        {
            try
            {
                // Buscar la cuota por su ID en la base de datos
                var cuota = contexto.CuotasMensuales.FirstOrDefault(c => c.CuotaMensualId == cuotaId);

                if (cuota != null)
                {
                    // Eliminar la cuota de la base de datos
                    contexto.CuotasMensuales.Remove(cuota);
                    contexto.SaveChanges();
                    return true; // Indicar que la eliminación fue exitosa
                }
                else
                {
                    // Si no se encuentra la cuota, devolver false
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la eliminación
                Console.WriteLine("Error al eliminar la cuota: " + ex.Message);
                return false;
            }
        }
        public bool ModificarCuota(int cuotaId, int año, string mes, decimal valor)
        {
            try
            {
                // Verificar si la cuota con el ID especificado existe en la base de datos
                var cuota = contexto.CuotasMensuales.FirstOrDefault(c => c.CuotaMensualId == cuotaId);

                if (cuota != null)
                {
                    // Actualizar los campos de la cuota
                    cuota.Año = año;
                    cuota.Mes = mes;
                    cuota.Valor = valor;

                    // Guardar los cambios en la base de datos
                    contexto.SaveChanges();

                    return true; // Modificación exitosa
                }
                else
                {
                    // Si no se encuentra la cuota con el ID especificado, devolver false
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que pueda ocurrir durante la modificación
                Console.WriteLine("Error al modificar la cuota: " + ex.Message);
                return false;
            }
        }
        public List<CuotaMensual> ObtenerCuotasPendientes(int socioId)
        {
            using (var context = new SistemaBibliotecario())
            {
                // Obtener la fecha de ingreso del socio
                var socio = context.Socios.FirstOrDefault(s => s.SocioId == socioId);
                if (socio == null) return new List<CuotaMensual>();

                var fechaIngreso = socio.FechaIngreso;
                var añoIngreso = fechaIngreso.Year;
                var mesIngreso = fechaIngreso.Month;

                // Obtener los IDs de las cuotas que ya han sido pagadas por el socio
                var cuotasPagadasIds = context.DetallesPagos
                    .Where(dp => dp.SocioId == socioId)
                    .Select(dp => dp.CuotaMensualId)
                    .ToList();

                // Obtener todas las cuotas mensuales
                var todasLasCuotas = context.CuotasMensuales.ToList();

                // Filtrar las cuotas pendientes
                var cuotasPendientes = todasLasCuotas
                    .Where(cm => (cm.Año > añoIngreso || (cm.Año == añoIngreso && cm.NumeroMes >= mesIngreso))
                                  && !cuotasPagadasIds.Contains(cm.CuotaMensualId))
                    .ToList();

                // Filtrar las cuotas pendientes por su valor
                cuotasPendientes = cuotasPendientes
                    .Where(cm => CuotaEsValida(cm.Valor))
                    .ToList();

                return cuotasPendientes;
            }
        }



        public bool CuotaEsValida(decimal? valorCuota)
        {
            return valorCuota.HasValue && valorCuota.Value > 0;
        }

        public void VerificarYDeshabilitarSociosConCuotasPendientes()
        {
            using (var context = new SistemaBibliotecario())
            {
                // Obtener todos los socios
                var todosLosSocios = context.Socios.ToList();

                // Recorrer todos los socios
                foreach (var socio in todosLosSocios)
                {
                    // Obtener las cuotas pendientes del socio
                    var cuotasPendientes = ObtenerCuotasPendientes(socio.SocioId);

                    // Si el socio tiene cuotas pendientes, cambiar su estado a deshabilitado
                    if (cuotasPendientes.Any())
                    {
                        socio.Habilitado = false;
                    }
                }

                // Guardar los cambios en la base de datos
                context.SaveChanges();
            }
        }

        public bool CuotaEstaVencida(CuotaMensual cuota)
        {
            int diasVencimiento = controladoraReglas.ObtenerDiasVencimientoCuotas();

            DateTime fechaActual = DateTime.Today;
            DateTime fechaVencimiento = new DateTime(cuota.Año, cuota.NumeroMes, DateTime.DaysInMonth(cuota.Año, cuota.NumeroMes));

            // La cuota está vencida si la fecha actual es mayor a la fecha de vencimiento más los días de vencimiento permitidos
            return fechaActual > fechaVencimiento.AddDays(diasVencimiento);
        }

        public decimal CalcularRecargo(CuotaMensual cuota)
        {
            int porcentajeRecargo = controladoraReglas.ObtenerPorcentajeRecargoCuota();
            decimal recargo = (cuota.Valor ?? 0m) * (porcentajeRecargo / 100.0m);
            decimal recargoRedondeado = Math.Ceiling(recargo / 10) * 10; // Redondear hacia arriba a múltiplos de 10
            return recargoRedondeado;
        }
        public bool RegistrarPago(int socioId, int cuotaMensualId, DateTime fechaPago, decimal montoCobrado)
        {
            try
            {
                // Verificar si el socio y la cuota existen
                var socio = contexto.Socios.FirstOrDefault(s => s.SocioId == socioId);
                var cuota = contexto.CuotasMensuales.FirstOrDefault(c => c.CuotaMensualId == cuotaMensualId);

                if (socio == null || cuota == null)
                {
                    Console.WriteLine("No se pudo encontrar el socio o la cuota especificada.");
                    return false;
                }

                // Crear un nuevo detalle de pago
                var nuevoDetallePago = new DetallePago
                {
                    SocioId = socioId,
                    CuotaMensualId = cuotaMensualId,
                    FechaPago = fechaPago,
                    MontoCobrado = montoCobrado
                };

                // Agregar el detalle de pago al contexto y guardar los cambios
                contexto.DetallesPagos.Add(nuevoDetallePago);
                contexto.SaveChanges();

                Console.WriteLine("Pago registrado correctamente.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el pago: " + ex.Message);
                return false;
            }
        }

        public List<(string Apellido, int Dni, string Mes, int Año)> ObtenerDetallesPagosConInformacion()
        {
            try
            {
                // Unir las tablas DetallesPagos, Socios y CuotasMensuales
                var detallesPagosConInfo = from detallePago in contexto.DetallesPagos
                                           join socio in contexto.Socios on detallePago.SocioId equals socio.SocioId
                                           join cuota in contexto.CuotasMensuales on detallePago.CuotaMensualId equals cuota.CuotaMensualId
                                           select new
                                           {
                                               socio.Apellido,
                                               socio.Dni,
                                               cuota.Mes,
                                               cuota.Año
                                           };

                // Convertir a una lista de tuplas y retornar
                return detallesPagosConInfo
                    .ToList()
                    .Select(x => (x.Apellido, x.Dni, x.Mes, x.Año))
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener los detalles de pagos con información: " + ex.Message);
                return new List<(string Apellido, int Dni, string Mes, int Año)>();
            }
        }

    }

}




