using Controladora;
using Entidades;

namespace Vista
{
    public partial class FormRegistros : Form
    {
        private ControladoraDevoluciones controladoraDevoluciones;
        private ControladoraMultas controladoraMultas;
        private ControladoraPrestamos controladoraPrestamos;
        private ControladoraLibros controladoraLibros;
        private ControladoraSocios controladoraSocios;
        private ControladoraCuotas controladoraCuotas;
        public FormRegistros()
        {
            InitializeComponent();
            controladoraDevoluciones = new ControladoraDevoluciones();
            controladoraMultas = new ControladoraMultas();
            controladoraPrestamos = new ControladoraPrestamos();
            controladoraSocios = new ControladoraSocios();
            controladoraLibros = new ControladoraLibros();
            controladoraCuotas = new ControladoraCuotas();
            this.StartPosition = FormStartPosition.Manual;

            // Establecer la ubicación del formulario en la pantalla (por ejemplo, en las coordenadas 100, 100)
            this.Location = new Point(100, 100);
            ConfigurarEventosMouseBotones(this);
        }
        private void ConfigurarEventosMouseBotones(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    // Asociar eventos MouseEnter y MouseLeave al botón
                    button.MouseEnter += (sender, e) => CambiarColorBoton(button, Color.MediumVioletRed);
                    button.MouseLeave += (sender, e) => CambiarColorBoton(button, Color.Black);
                }
            }
        }

        // Método para cambiar el color de fondo del botón
        private void CambiarColorBoton(Button button, Color color)
        {
            button.BackColor = color;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }


        private void CargarDatosDataGridView()
        {
            // Obtener los datos de la tabla Devoluciones
            List<Devolucion> devoluciones = controladoraDevoluciones.ObtenerTodasLasDevoluciones();

            // Crear una lista para almacenar los datos completos de devoluciones incluyendo info de prestamo
            List<object> devolucionesCompletas = new List<object>();

            // Iterar sobre cada devolución para obtener info de prestamo
            foreach (var devolucion in devoluciones)
            {
                // Obtener el prestamo asociado a la devolución
                Prestamo prestamo = controladoraPrestamos.ObtenerPrestamoPorId(devolucion.PrestamoId);

                // Verificar si el prestamo no es nulo (debería existir si hay devolución)
                if (prestamo != null)
                {
                    // Obtener el socio y el libro asociados al prestamo
                    Socio socio = controladoraSocios.ObtenerSocioPorId(prestamo.SocioId);
                    Libro libro = controladoraLibros.ObtenerLibroPorId(prestamo.LibroId);

                    // Verificar que socio y libro no sean nulos (deberían existir si hay prestamo)
                    if (socio != null && libro != null)
                    {
                        // Crear un objeto anónimo con los datos de la devolución, socio y libro
                        var devolucionCompleta = new
                        {
                            DevolucionId = devolucion.DevolucionId,
                            FechaDevolucion = devolucion.FechaDevolucion,
                            PrestamoId = devolucion.PrestamoId,
                            ApellidoSocio = socio.Apellido,
                            DniSocio = socio.Dni,
                            TituloLibro = libro.Titulo
                        };

                        // Agregar el objeto completo a la lista
                        devolucionesCompletas.Add(devolucionCompleta);
                    }
                }
            }

            // Asignar el DataSource del DataGridView al listado de devoluciones completas
            dgvDevoluciones.DataSource = devolucionesCompletas;

            // Ocultar las columnas que no queremos mostrar
            dgvDevoluciones.Columns["DevolucionId"].Visible = false;
            dgvDevoluciones.Columns["PrestamoId"].Visible = false;

            // Obtener los datos de la tabla Multas
            List<Multa> multas = controladoraMultas.ObtenerTodasLasMultas();

            // Crear una lista para almacenar los datos completos de multas incluyendo info de socio
            List<object> multasCompletas = new List<object>();

            // Iterar sobre cada multa para obtener info de socio
            foreach (var multa in multas)
            {
                // Obtener el socio asociado a la multa
                Socio socio = controladoraSocios.ObtenerSocioPorId(multa.SocioId);

                // Verificar si el socio no es nulo (debería existir si hay multa)
                if (socio != null)
                {
                    // Crear un objeto anónimo con los datos de la multa y el socio
                    var multaCompleta = new
                    {
                        MultaId = multa.MultaId,
                        SocioId = multa.SocioId,
                        ApellidoSocio = socio.Apellido,
                        DniSocio = socio.Dni,
                        FechaInicio = multa.FechaInicio,
                        FechaFinalizacion = multa.FechaFinalizacion,
                        Pagada = multa.Pagada
                    };

                    // Agregar el objeto completo a la lista
                    multasCompletas.Add(multaCompleta);
                }
            }

            // Asignar el DataSource del DataGridView de Multas al listado de multas completas
            dgvMultas.DataSource = multasCompletas;

            // Ocultar las columnas que no queremos mostrar
            dgvMultas.Columns["SocioId"].Visible = false;
            dgvMultas.Columns["MultaId"].Visible = false;

            dgvCuotasPagadas.DataSource = multasCompletas;



            var detallesPagosConInfo = controladoraCuotas.ObtenerDetallesPagosConInformacion();

            // Desvincular el DataGridView de la fuente de datos actual
            dgvCuotasPagadas.DataSource = null;

            // Crear nuevas columnas para Dni, Apellido, Mes y Año si no existen
            if (!dgvCuotasPagadas.Columns.Contains("Apellido"))
            {
                dgvCuotasPagadas.Columns.Add("Apellido", "Apellido");
            }
            if (!dgvCuotasPagadas.Columns.Contains("Dni"))
            {
                dgvCuotasPagadas.Columns.Add("Dni", "Dni");
            }
            if (!dgvCuotasPagadas.Columns.Contains("Mes"))
            {
                dgvCuotasPagadas.Columns.Add("Mes", "Mes");
            }
            if (!dgvCuotasPagadas.Columns.Contains("Año"))
            {
                dgvCuotasPagadas.Columns.Add("Año", "Año");
            }

            // Limpiar las filas existentes en el DataGridView
            dgvCuotasPagadas.Rows.Clear();

            // Rellenar el DataGridView con los datos obtenidos
            foreach (var detalle in detallesPagosConInfo)
            {
                dgvCuotasPagadas.Rows.Add(detalle.Apellido, detalle.Dni, detalle.Mes, detalle.Año);
            }

            // Ocultar las columnas innecesarias
            if (dgvCuotasPagadas.Columns.Contains("DetallePagoId"))
            {
                dgvCuotasPagadas.Columns["DetallePagoId"].Visible = false;
            }
            if (dgvCuotasPagadas.Columns.Contains("SocioId"))
            {
                dgvCuotasPagadas.Columns["SocioId"].Visible = false;
            }
            if (dgvCuotasPagadas.Columns.Contains("CuotaMensualId"))
            {
                dgvCuotasPagadas.Columns["CuotaMensualId"].Visible = false;
            }
            if (dgvCuotasPagadas.Columns.Contains("Socio"))
            {
                dgvCuotasPagadas.Columns["Socio"].Visible = false;
            }
            if (dgvCuotasPagadas.Columns.Contains("CuotaMensual"))
            {
                dgvCuotasPagadas.Columns["CuotaMensual"].Visible = false;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}



  

