using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormDevoluciones : Form
    {
        private ControladoraPrestamos controladoraPrestamos;

        private ControladoraLibros controladoraLibros;
        private ControladoraReglas controladoraReglas;
        private ControladoraSocios controladoraSocios;
        private ControladoraMultas controladoraMultas;

        public FormDevoluciones()
        {
            InitializeComponent();
            controladoraPrestamos = new ControladoraPrestamos();

            controladoraLibros = new ControladoraLibros();
            controladoraSocios = new ControladoraSocios();
            controladoraReglas = new ControladoraReglas();
            controladoraMultas = new ControladoraMultas();
            // Inicializar la variable miembro correctamente
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


        private void FormDevoluciones_Load(object sender, EventArgs e)
        {


            CargarDatosDataGridView();
        }





        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDatosDataGridView()
        {
            try
            {
                using (var contexto = new SistemaBibliotecario())
                {
                    var prestamosConDetalles = from p in contexto.Prestamos
                                               join s in contexto.Socios on p.SocioId equals s.SocioId
                                               join l in contexto.Libros on p.LibroId equals l.LibroId
                                               select new
                                               {
                                                   p.PrestamoId,
                                                   p.FechaPrestamo,
                                                   p.FechaDevolucion,
                                                   SocioDni = s.Dni,
                                                   LibroTitulo = l.Titulo,
                                                   p.CarritoId,
                                                   p.EnPrestamo
                                               };

                    // Asignar el DataSource del DataGridView al listado de préstamos con detalles
                    dgvPrestamos.DataSource = prestamosConDetalles.ToList();

                    // Configurar las columnas visibles e invisibles según sea necesario
                    dgvPrestamos.Columns["PrestamoId"].Visible = false;
                    dgvPrestamos.Columns["CarritoId"].Visible = false;
                    dgvPrestamos.Columns["EnPrestamo"].Visible = false;

                    // Renombrar columnas para claridad si es necesario
                    dgvPrestamos.Columns["SocioDni"].HeaderText = "DNI del Socio";
                    dgvPrestamos.Columns["LibroTitulo"].HeaderText = "Título del Libro";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscar.Text.Trim().ToLower(); // Convertir a minúsculas para comparación case-insensitive

            // Recorrer todas las filas del DataGridView
            foreach (DataGridViewRow row in dgvPrestamos.Rows)
            {
                bool mostrarFila = false; // Variable para determinar si la fila debe mostrarse

                // Verificar cada celda en las columnas específicas
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.Name == "SocioDni" || cell.OwningColumn.Name == "LibroTitulo")
                    {
                        string cellValue = cell.Value?.ToString().ToLower() ?? ""; // Obtener el valor de la celda y convertir a minúsculas
                        if (cellValue.Contains(textoBusqueda)) // Comprobar si el texto de búsqueda está en la celda
                        {
                            mostrarFila = true;
                            break; // Salir del bucle si se encuentra una coincidencia
                        }
                    }
                }

                // Establecer la visibilidad de la fila
                row.Visible = mostrarFila;
            }
        }








        private void buttonGenerarDevolucion_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                int prestamoId = Convert.ToInt32(dgvPrestamos.SelectedRows[0].Cells["PrestamoId"].Value);
                Prestamo prestamo = controladoraPrestamos.ObtenerPrestamoPorId(prestamoId);

                // Verificar si el préstamo ya ha sido devuelto
                if (!prestamo.EnPrestamo)
                {
                    MessageBox.Show("El préstamo ya ha sido devuelto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmar con el usuario si desea realizar la devolución
                DialogResult result = MessageBox.Show("¿Está seguro de realizar la devolución?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return; // Salir del método si el usuario elige "No"
                }

                // Cambiar el estado del préstamo
                controladoraPrestamos.CambiarEstadoPrestamo(prestamoId);

                // Obtener el ID del libro asociado al préstamo
                int libroId = controladoraPrestamos.ObtenerIdLibroDePrestamo(prestamoId);

                // Cambiar el estado de disponibilidad del libro
                controladoraLibros.CambiarEstadoDisponibilidadLibro(libroId);

                // Decrementar la cantidad de libros prestados del socio
                controladoraPrestamos.DecrementarCantidadLibrosPrestados(prestamoId);

                // Calcular la fecha de devolución
                DateTime fechaDevolucion = DateTime.Now;
                if (prestamo.FechaDevolucion < fechaDevolucion)
                {
                    // Si la devolución es tardía, generar una multa
                    Multa multa = new Multa
                    {
                        SocioId = prestamo.SocioId,
                        FechaInicio = prestamo.FechaDevolucion,
                        FechaFinalizacion = controladoraReglas.CalcularFechaMultaFinalizacion(controladoraReglas.ObtenerDiasMulta()),
                        Pagada = false // La multa se marca como no pagada inicialmente
                    };

                    // Guardar la multa en la base de datos
                    controladoraMultas.AgregarMulta(multa);

                    // Mostrar mensaje de multa
                    MessageBox.Show("¡El socio ha sido multado por devolución tardía!", "Multa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Guardar los cambios en la tabla Libros y Prestamos
                controladoraLibros.SaveChanges();
                controladoraPrestamos.SaveChanges();

                // Mostrar mensaje de éxito
                MessageBox.Show("¡Devolución realizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar el DataGridView para reflejar los cambios
                CargarDatosDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un préstamo de la lista.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
