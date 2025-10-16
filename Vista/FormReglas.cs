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
    public partial class FormReglas : Form
    {

        private ControladoraReglas controladoraReglas;
        public FormReglas()
        {
            InitializeComponent();

            controladoraReglas = new ControladoraReglas();
            dgvReglas.SelectionChanged += DgvReglas_SelectionChanged;
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

        private void dgvReglas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReglas_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }
        private void CargarDatosDataGridView()
        {
            // Carga las reglas desde la controladora
            var reglas = controladoraReglas.ObtenerTodasLasReglas();

            // Asigna las reglas como la fuente de datos del DataGridView
            dgvReglas.DataSource = reglas;

            // Oculta la columna "ReglaId"
            dgvReglas.Columns["ReglaId"].Visible = false;
        }


        private void textBoxDiasPrestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaximoPrestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos y contengan valores numéricos
            if (!string.IsNullOrEmpty(textBoxDiasPrestamo.Text) &&
                !string.IsNullOrEmpty(textBoxMaximoPrestamo.Text) &&
                !string.IsNullOrEmpty(textBoxDiasMulta.Text) &&
                !string.IsNullOrEmpty(textBoxDiasvenceCuota.Text) && // Nuevo campo de días de vencimiento de cuota
                !string.IsNullOrEmpty(textBoxPorcentajerecargo.Text) && // Nuevo campo de porcentaje de recargo de cuota
                int.TryParse(textBoxDiasPrestamo.Text, out int dias) &&
                int.TryParse(textBoxMaximoPrestamo.Text, out int maximo) &&
                int.TryParse(textBoxDiasMulta.Text, out int diasMulta) &&
                int.TryParse(textBoxDiasvenceCuota.Text, out int diasVenceCuota) && // Nuevo campo de días de vencimiento de cuota
                int.TryParse(textBoxPorcentajerecargo.Text, out int porcentajeRecargo)) // Nuevo campo de porcentaje de recargo de cuota
            {
                // Confirmar la modificación con un cuadro de diálogo
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas realizar los cambios?",
                                                       "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Obtener los nuevos valores de días de préstamo, máximo de libros por usuario, días de multa, días de vencimiento de cuota y porcentaje de recargo de cuota
                    int nuevosDiasPrestamo = int.Parse(textBoxDiasPrestamo.Text);
                    int nuevoMaximoPrestamo = int.Parse(textBoxMaximoPrestamo.Text);
                    int nuevosDiasMulta = int.Parse(textBoxDiasMulta.Text);
                    int nuevosDiasVenceCuota = int.Parse(textBoxDiasvenceCuota.Text); // Nuevo campo de días de vencimiento de cuota

                    // Llamar al método de la controladora de reglas para modificar las reglas
                    controladoraReglas.ModificarReglas(nuevosDiasPrestamo, nuevoMaximoPrestamo, nuevosDiasMulta, nuevosDiasVenceCuota, porcentajeRecargo);

                    // Mostrar un mensaje de éxito

                }
            }
            else
            {
                // Mostrar un mensaje de error si los campos están vacíos o no contienen valores numéricos
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos de días de préstamo, máximo de libros por usuario, días de multa, días de vencimiento de cuota y porcentaje de recargo de cuota.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDatosDataGridView();
        }


        private void DgvReglas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReglas.SelectedRows.Count > 0)
            {
                // Obtiene la primera fila seleccionada
                DataGridViewRow filaSeleccionada = dgvReglas.SelectedRows[0];

                // Obtiene los valores de las celdas correspondientes a las columnas
                object valorDiasPrestamo = filaSeleccionada.Cells["DiasPrestamo"].Value;
                object valorMaximoPrestamo = filaSeleccionada.Cells["MaxLibrosPorUsuario"].Value;
                object valorDiasMulta = filaSeleccionada.Cells["DiasMulta"].Value;
                object valorDiasVencimientoCuota = filaSeleccionada.Cells["DiasVencimientoCuota"].Value;
                object valorPorcentajeRecargoCuota = filaSeleccionada.Cells["PorcentajeRecargoCuota"].Value;

                // Asigna los valores obtenidos a los TextBox correspondientes
                textBoxDiasPrestamo.Text = valorDiasPrestamo?.ToString();
                textBoxMaximoPrestamo.Text = valorMaximoPrestamo?.ToString();
                textBoxDiasMulta.Text = valorDiasMulta?.ToString();
                textBoxDiasvenceCuota.Text = valorDiasVencimientoCuota?.ToString();
                textBoxPorcentajerecargo.Text = valorPorcentajeRecargoCuota?.ToString();
            }
            else
            {
                // Si no hay filas seleccionadas, limpia los TextBox
                textBoxDiasPrestamo.Clear();
                textBoxMaximoPrestamo.Clear();
                textBoxDiasMulta.Clear();
                textBoxDiasvenceCuota.Clear();
                textBoxPorcentajerecargo.Clear();
            }
        }


        private void textBoxDiasMulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxDiasvenceCuota_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPorcentajerecargo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
