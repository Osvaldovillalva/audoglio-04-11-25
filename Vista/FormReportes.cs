using Controladora;
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
    public partial class FormReportes : Form
    {
        private ControladoraLibros controladoraLibros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibros;
        public FormReportes()
        {
            InitializeComponent();
            controladoraLibros = new ControladoraLibros();

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

        private void CambiarColorBoton(Button button, Color color)
        {
            button.BackColor = color;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewLibrosparacomprar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReportes_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }

        private void CargarDatosDataGridView()
        {
            // Carga los datos de los libros desde la controladora
            var libros = controladoraLibros.ObtenerLibrosParaComprar();

            // Ordena los libros de mayor a menor según el Contador
            var librosOrdenados = libros.OrderByDescending(libro => libro.Contador).ToList();

            // Asigna los libros ordenados al DataGridView
            dataGridViewLibrosparacomprar.DataSource = librosOrdenados;

            // Configura las columnas del DataGridView
            dataGridViewLibrosparacomprar.Columns["Id"].HeaderText = "ID";
            dataGridViewLibrosparacomprar.Columns["TextoCompleto"].HeaderText = "Título y Autor";
            dataGridViewLibrosparacomprar.Columns["Contador"].HeaderText = "Contador";

            // Ajustar el ancho de la columna "TextoCompleto"
            dataGridViewLibrosparacomprar.Columns["TextoCompleto"].Width = 300; // Ajusta según necesidad

            // Opcional: Ajustar automáticamente el ancho de las columnas
            dataGridViewLibrosparacomprar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }



        private void FormReportes_Load_1(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila
            if (dataGridViewLibrosparacomprar.SelectedRows.Count > 0)
            {
                // Obtener el Id del libro seleccionado
                int idSeleccionado = Convert.ToInt32(dataGridViewLibrosparacomprar.SelectedRows[0].Cells["Id"].Value);

                // Preguntar al usuario si desea eliminar el libro
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este libro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Llamar a la controladora para eliminar el libro
                    bool exito = controladoraLibros.EliminarLibro(idSeleccionado);

                    if (exito)
                    {
                        // Si la eliminación fue exitosa, recargar los datos
                        MessageBox.Show("El libro fue eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatosDataGridView();
                    }
                    else
                    {
                        // Si no se encontró o no se pudo eliminar el libro
                        MessageBox.Show("No se pudo eliminar el libro. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si no se ha seleccionado un libro
                MessageBox.Show("Por favor, seleccione un libro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonvergraficas_Click(object sender, EventArgs e)
        {
            // Limpia el panel para evitar que se agreguen más barras cada vez que se hace clic
            panelGrafico.Controls.Clear();

            // Activa el auto-scroll para permitir el desplazamiento vertical
            panelGrafico.AutoScroll = true;

            // Obtén los libros de la base de datos
            var libros = controladoraLibros.ObtenerLibrosParaComprar();

            // Ordenar los libros por contador de mayor a menor
            var librosOrdenados = libros.OrderByDescending(libro => libro.Contador).ToList();

            int posicionY = 10;  // Posición inicial de las barras en el eje Y (arriba hacia abajo)

            // Determinar el valor máximo y mínimo de los contadores
            int maxContador = librosOrdenados.Max(libro => libro.Contador);
            int minContador = librosOrdenados.Min(libro => libro.Contador);

            // Iterar a través de los libros ordenados
            foreach (var libro in librosOrdenados)
            {
                // Crear el Label dentro de la barra antes de usarla para calcular el ancho de la barra
                Label labelTexto = new Label();
                labelTexto.Text = libro.TextoCompleto;  // Usamos el texto completo del libro
                labelTexto.ForeColor = Color.Black;  // Color del texto
                labelTexto.Font = new Font("Arial Black", 10, FontStyle.Bold);  // Fuente Arial Black, negrita
                labelTexto.AutoSize = true;

                // Crear una nueva barra para cada libro
                Panel barra = new Panel();

                // Ajustar el ancho de la barra (puede ser el 80% del ancho del panel)
                barra.Width = panelGrafico.Width - 40;  // 20px de margen a ambos lados

                // Calcular el largo de la barra dependiendo del color
                int largoBarra = 0;
                Color colorBarra = Color.Green; // Default color (verde)

                if (libro.Contador == maxContador)  // Rojo - 100% del ancho
                {
                    largoBarra = barra.Width;
                    colorBarra = Color.Red;
                }
                else if (libro.Contador >= (maxContador * 0.9))  // Amarillo - 90% del ancho
                {
                    largoBarra = (int)(barra.Width * 0.90);
                    colorBarra = Color.Orange; // Cambié esto para asegurarme de que las barras con 90% sean amarillas
                }
                else if (libro.Contador >= (maxContador * 0.8))  // Verde - 80% del ancho
                {
                    largoBarra = (int)(barra.Width * 0.80);
                    colorBarra = Color.Yellow;
                }
                else  // Si el contador es muy bajo, aún se muestra, pero con un tamaño pequeño
                {
                    largoBarra = (int)(barra.Width * 0.60); // Tamaño pequeño para los contadores más bajos
                    colorBarra = Color.Green;
                }

                // Asignar el alto y el ancho de la barra
                int alturaBarra = 40;  // Ajustable para hacer la barra más alta o más baja
                barra.Height = alturaBarra;
                barra.Width = largoBarra;

                // Asignar color a la barra
                barra.BackColor = colorBarra;

                // Posicionar las barras en el eje Y
                barra.Top = posicionY;

                // Colocar el texto alineado a la izquierda dentro de la barra
                labelTexto.Left = 10;  // Posicionar el texto a la izquierda dentro de la barra
                labelTexto.Top = (barra.Height - labelTexto.Height) / 2;  // Centrado verticalmente

                // Agregar el Label a la barra
                barra.Controls.Add(labelTexto);

                // Agregar la barra al panel
                panelGrafico.Controls.Add(barra);

                // Aumentar la posición Y para la siguiente barra
                posicionY += alturaBarra + 10;  // Espaciado entre barras
            }
        }









        private void chartLibrosacomprar_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }






}
