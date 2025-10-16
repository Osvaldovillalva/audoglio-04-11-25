using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vista
{
    public partial class FormCuota : Form
    {
        private ControladoraCuotas controladoraCuotas;
        public FormCuota()
        {
            InitializeComponent();
            controladoraCuotas = new ControladoraCuotas();
            dgvValorCuota.SelectionChanged += dgvValorCuota_SelectionChanged;
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

        private void FormCuota_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }
        private void CargarDatosDataGridView()
        {
            try
            {
                // Obtener todas las cuotas desde la controladora de cuotas
                var cuotas = controladoraCuotas.ObtenerTodasLasCuotas();

                // Configurar el origen de datos del DataGridView
                dgvValorCuota.DataSource = cuotas;

                // Ocultar la columna CuotaMensualId
                dgvValorCuota.Columns["CuotaMensualId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void dgvValorCuota_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada en el DataGridView
            if (dgvValorCuota.SelectedRows.Count > 0)
            {
                // Obtener el ID de la cuota seleccionada en el DataGridView
                int cuotaId = Convert.ToInt32(dgvValorCuota.SelectedRows[0].Cells["CuotaMensualId"].Value);

                // Obtener la cuota seleccionada de la base de datos utilizando su ID
                CuotaMensual cuotaSeleccionada = controladoraCuotas.ObtenerCuotaPorId(cuotaId);

                // Verificar si se encontró la cuota en la base de datos
                if (cuotaSeleccionada != null)
                {
                    // Mostrar los datos de la cuota seleccionada en los TextBox correspondientes
                    textBoxAño.Text = cuotaSeleccionada.Año.ToString();
                    comboBoxMes.SelectedItem = cuotaSeleccionada.Mes;
                    textBoxValorCuota.Text = cuotaSeleccionada.Valor.ToString();
                }
            }
        }






        private void textBoxValorCuota_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Validar el campo Año
            if (string.IsNullOrWhiteSpace(textBoxAño.Text) || !int.TryParse(textBoxAño.Text, out int año) || textBoxAño.Text.Length != 4)
            {
                MessageBox.Show("El campo Año debe ser un número entero de 4 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un mes
            if (comboBoxMes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un mes.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar el campo Valor Cuota
            if (string.IsNullOrWhiteSpace(textBoxValorCuota.Text) || !decimal.TryParse(textBoxValorCuota.Text, out decimal valorCuota))
            {
                MessageBox.Show("El campo Valor Cuota debe ser un número decimal y no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si ya existe una cuota para el mismo año y mes
            string nombreMes = comboBoxMes.SelectedItem.ToString();
            int numeroMes = comboBoxMes.SelectedIndex + 1; // Enero es 1, Febrero es 2, etc.
            bool cuotaExistente = controladoraCuotas.ExisteCuota(año, numeroMes);

            if (cuotaExistente)
            {
                MessageBox.Show($"Ya existe una cuota para el año {año} y el mes {nombreMes}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si todas las validaciones son correctas y no existe una cuota para el mismo año y mes, preguntar al usuario si desea guardar la cuota
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea guardar la cuota?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Agregar la cuota
                bool guardadoExitoso = controladoraCuotas.AgregarCuota(año, numeroMes, nombreMes, valorCuota);

                if (guardadoExitoso)
                {
                    MessageBox.Show("Cuota guardada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar los campos después de guardar
                    textBoxAño.Clear();
                    comboBoxMes.SelectedIndex = -1;
                    textBoxValorCuota.Clear();
                    dgvValorCuota.DataSource = null; // Limpiar el DataSource
                    dgvValorCuota.DataSource = controladoraCuotas.ObtenerTodasLasCuotas();
                }
                else
                {
                    MessageBox.Show("Error al guardar la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una fila en el DataGridView
            if (dgvValorCuota.SelectedRows.Count > 0)
            {
                // Obtener el ID de la cuota seleccionada en el DataGridView
                int cuotaId = Convert.ToInt32(dgvValorCuota.SelectedRows[0].Cells["CuotaMensualId"].Value);

                // Preguntar al usuario si realmente desea eliminar la cuota
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar la cuota seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Eliminar la cuota de la base de datos usando el ID obtenido
                    bool eliminacionExitosa = controladoraCuotas.EliminarCuota(cuotaId);

                    if (eliminacionExitosa)
                    {
                        MessageBox.Show("Cuota eliminada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Actualizar el DataGridView después de eliminar
                        CargarDatosDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cuota para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado una cuota
            if (dgvValorCuota.SelectedRows.Count > 0)
            {
                // Obtener el ID de la cuota seleccionada en el DataGridView
                int cuotaId = Convert.ToInt32(dgvValorCuota.SelectedRows[0].Cells["CuotaMensualId"].Value);

                // Obtener los nuevos valores de los campos desde los TextBox y ComboBox
                int nuevoAño;
                if (!int.TryParse(textBoxAño.Text, out nuevoAño) || textBoxAño.Text.Length != 4)
                {
                    MessageBox.Show("El año debe ser un número entero de 4 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string nuevoMes = comboBoxMes.SelectedItem.ToString();

                decimal nuevoValor;
                if (!decimal.TryParse(textBoxValorCuota.Text, out nuevoValor) || nuevoValor <= 0)
                {
                    MessageBox.Show("El valor de la cuota debe ser un número decimal positivo y no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirmar con el usuario si realmente desea modificar la cuota
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea modificar la cuota seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Realizar la modificación de la cuota
                    bool modificacionExitosa = controladoraCuotas.ModificarCuota(cuotaId, nuevoAño, nuevoMes, nuevoValor);

                    if (modificacionExitosa)
                    {
                        MessageBox.Show("Cuota modificada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Actualizar el DataGridView después de la modificación
                        CargarDatosDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar la cuota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una cuota para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
