using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladora;
using Entidades;// Asegúrate de importar el espacio de nombres donde está la controladora

namespace Vista
{
    public partial class FormLibros : Form
    {
        private ControladoraLibros controladoraLibros; // Tu controladora de libros
        private Stack<string[]> pilaDeshacer = new Stack<string[]>();
        private Stack<string[]> pilaRehacer = new Stack<string[]>();
        private List<Libro> librosAgregados = new List<Libro>();

        public FormLibros()
        {
            InitializeComponent();
            controladoraLibros = new ControladoraLibros(); // Inicializa la controladora
            dgvLibros.SelectionChanged += dgvLibros_SelectionChanged;
            this.StartPosition = FormStartPosition.Manual;

            // Establecer la ubicación del formulario en la pantalla (por ejemplo, en las coordenadas 100, 100)
            this.Location = new Point(100, 100);
            ConfigurarEventosMouseBotones(this);
        }
        private void GuardarEstado()
        {
            // Guardamos el estado actual solo si hay cambios.
            string[] estado = new string[3]
            {
        textBoxTitulo.Text,
        textBoxAutor.Text,
        textBoxCantidad.Text
            };

            // Verifica si realmente hay algún cambio, para evitar guardar estados innecesarios
            if (pilaDeshacer.Count == 0 || !estado.SequenceEqual(pilaDeshacer.Peek()))
            {
                // Si no es igual al último estado guardado, lo guardamos
                pilaDeshacer.Push(estado);
            }
        }

        private void buttonDeshacer_Click(object sender, EventArgs e)
        {
            if (pilaDeshacer.Count == 0)
            {
                MessageBox.Show("No hay cambios para deshacer.", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Si no hay cambios para deshacer, no hacer nada
            }

            // Recuperar el último estado de la pila de deshacer
            string[] estadoDeshacer = pilaDeshacer.Pop();

            // Guardamos el estado actual en la pila de rehacer antes de deshacer
            pilaRehacer.Push(new string[] { textBoxTitulo.Text, textBoxAutor.Text, textBoxCantidad.Text });

            // Restaurar los valores de los TextBox con los valores de la pila de deshacer
            textBoxTitulo.Text = estadoDeshacer[0];
            textBoxAutor.Text = estadoDeshacer[1];
            textBoxCantidad.Text = estadoDeshacer[2];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pilaRehacer.Count == 0)
            {
                MessageBox.Show("No hay cambios para rehacer.", "Sin cambios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Si no hay cambios para rehacer, no hacer nada
            }

            // Recuperar el último estado de la pila de rehacer
            string[] estadoRehacer = pilaRehacer.Pop();

            // Guardar el estado actual en la pila de deshacer, ya que estamos rehaciendo un cambio
            pilaDeshacer.Push(new string[] { textBoxTitulo.Text, textBoxAutor.Text, textBoxCantidad.Text });

            // Restaurar los valores de los TextBox con los valores de la pila de rehacer
            textBoxTitulo.Text = estadoRehacer[0];
            textBoxAutor.Text = estadoRehacer[1];
            textBoxCantidad.Text = estadoRehacer[2];
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



        private void FormLibros_Load(object sender, EventArgs e)
        {

            var usuarioSesion = UsuarioSesion.ObtenerInstancia();

            buttonModificar.Enabled = usuarioSesion.PuedeModificarLibros;
            buttonBorrar.Enabled = usuarioSesion.PuedeBorrarLibros;


            // Llama al método para cargar los datos en el DataGridView
            CargarDatosDataGridView();
        }

        private void CargarDatosDataGridView()
        {
            try
            {
                // Cargar los libros desde la controladora
                var libros = controladoraLibros.ObtenerTodosLosLibros();

                // Asignar los libros como la fuente de datos del DataGridView
                dgvLibros.DataSource = libros;

                // Ocultar la columna LibroId si existe en el DataGridView
                if (dgvLibros.Columns.Contains("LibroId"))
                {
                    dgvLibros.Columns["LibroId"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {
            GuardarEstado(); // Guardar el estado cada vez que cambie el texto
        }

        private void textBoxAutor_TextChanged(object sender, EventArgs e)
        {
            GuardarEstado(); // Guardar el estado cada vez que cambie el texto
        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            GuardarEstado(); // Guardar el estado cada vez que cambie el texto
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

            GuardarEstado();

            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(textBoxTitulo.Text) || string.IsNullOrWhiteSpace(textBoxAutor.Text) || string.IsNullOrWhiteSpace(textBoxCantidad.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si algún campo está vacío
            }

            // Obtener los valores de los TextBox
            string titulo = textBoxTitulo.Text;
            string autor = textBoxAutor.Text;
            int cantidad = int.Parse(textBoxCantidad.Text); // Obtener la cantidad desde el TextBox

            // Generar las ubicaciones de los nuevos libros
            List<string> ubicaciones = controladoraLibros.GenerarUbicaciones(autor, cantidad);

            // Construir el mensaje de ubicaciones asignadas
            StringBuilder message = new StringBuilder();
            message.AppendLine("Las ubicaciones asignadas a los nuevos libros son:");
            foreach (string ubicacion in ubicaciones)
            {
                message.AppendLine(ubicacion);
            }

            // Mostrar un MessageBox con las ubicaciones generadas
            MessageBox.Show(message.ToString(), "Ubicaciones Generadas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Agregar los libros a la base de datos
            foreach (string ubicacion in ubicaciones)
            {
                // Crear un nuevo libro con los datos proporcionados
                Libro nuevoLibro = new Libro
                {
                    Titulo = titulo,
                    Autor = autor,
                    Ubicacion = ubicacion,
                    Disponible = true // Por defecto, establecer como disponible
                };

                librosAgregados.Add(nuevoLibro); // Agregar el nuevo libro utilizando la controladora
                controladoraLibros.AgregarLibro(nuevoLibro);
            }

            // Mostrar un MessageBox indicando que los libros han sido agregados exitosamente

            CargarDatosDataGridView();
            // Limpiar los TextBox después de agregar los libros
            textBoxTitulo.Clear();
            textBoxAutor.Clear();
            textBoxCantidad.Clear();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                // Obtener el ID del libro seleccionado en el DataGridView
                int libroId = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells["LibroId"].Value);

                // Obtener el libro seleccionado de la base de datos utilizando su ID
                Libro libroSeleccionado = controladoraLibros.ObtenerLibroPorId(libroId);

                // Verificar si se encontró el libro en la base de datos
                if (libroSeleccionado != null)
                {
                    // Verificar si el libro está disponible
                    if (!libroSeleccionado.Disponible)
                    {
                        MessageBox.Show("El libro está en préstamo y no se puede eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Obtener el título del libro seleccionado para mostrar en el mensaje de confirmación
                    string tituloLibro = dgvLibros.SelectedRows[0].Cells["Titulo"].Value.ToString();

                    // Mostrar un mensaje de confirmación
                    DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas eliminar el libro \"{tituloLibro}\"?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Si el usuario confirma la eliminación, borrar el libro
                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método BorrarLibro de la controladora de libros
                        controladoraLibros.BorrarLibro(libroId);

                        // Actualizar los datos del DataGridView después de borrar el libro
                        CargarDatosDataGridView();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada en el DataGridView
            if (dgvLibros.SelectedRows.Count > 0)
            {
                // Obtener el ID del libro seleccionado en el DataGridView
                int libroId = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells["LibroId"].Value);

                // Obtener el libro seleccionado de la base de datos utilizando su ID
                Libro libroSeleccionado = controladoraLibros.ObtenerLibroPorId(libroId);

                // Verificar si se encontró el libro en la base de datos
                if (libroSeleccionado != null)
                {
                    // Mostrar los datos del libro seleccionado en los TextBox correspondientes
                    textBoxTitulo.Text = libroSeleccionado.Titulo;
                    textBoxAutor.Text = libroSeleccionado.Autor;

                    // Contar cuántos libros tienen el mismo título y autor en la base de datos
                    int cantidadLibros = controladoraLibros.ContarLibrosMismoTituloAutor(libroSeleccionado.Titulo, libroSeleccionado.Autor);
                    textBoxCantidad.Text = cantidadLibros.ToString();
                }
            }
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Clear();
            textBoxAutor.Clear();
            textBoxCantidad.Clear();
            textBoxBuscar.Clear();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                // Obtener el ID del libro seleccionado en el DataGridView
                int libroId = Convert.ToInt32(dgvLibros.SelectedRows[0].Cells["LibroId"].Value);

                // Obtener el libro seleccionado de la base de datos utilizando su ID
                Libro libroSeleccionado = controladoraLibros.ObtenerLibroPorId(libroId);

                // Verificar si se encontró el libro en la base de datos
                if (libroSeleccionado != null)
                {
                    // Verificar si el libro está disponible
                    if (!libroSeleccionado.Disponible)
                    {
                        MessageBox.Show("El libro está en préstamo y no se puede modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Obtener los nuevos valores del título y el autor desde los TextBox
                    string nuevoTitulo = textBoxTitulo.Text;
                    string nuevoAutor = textBoxAutor.Text;

                    // Verificar si los valores son diferentes y si no están vacíos
                    if (!string.IsNullOrWhiteSpace(nuevoTitulo) && nuevoTitulo != libroSeleccionado.Titulo)
                    {
                        libroSeleccionado.Titulo = nuevoTitulo;
                    }

                    if (!string.IsNullOrWhiteSpace(nuevoAutor) && nuevoAutor != libroSeleccionado.Autor)
                    {
                        libroSeleccionado.Autor = nuevoAutor;
                    }

                    // Verificar si se han realizado cambios
                    if (!string.IsNullOrWhiteSpace(nuevoTitulo) || !string.IsNullOrWhiteSpace(nuevoAutor))
                    {
                        // Guardar el libro modificado en la base de datos
                        controladoraLibros.ActualizarLibrosMismoTituloAutor(libroSeleccionado);

                        // Actualizar el DataGridView después de guardar los cambios
                        CargarDatosDataGridView();

                        // Mostrar un mensaje indicando que los cambios han sido guardados
                        MessageBox.Show("Los cambios han sido guardados correctamente.", "Cambios Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Mostrar un mensaje de error si no se han realizado cambios
                        MessageBox.Show("No se han realizado cambios en el libro.", "Sin Cambios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscar.Text.Trim();

            // Verificar si el texto de búsqueda no está vacío
            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                // Realizar la búsqueda en la base de datos
                List<Libro> resultadosBusqueda = controladoraLibros.BuscarLibros(textoBusqueda);

                // Actualizar el DataGridView con los resultados de la búsqueda
                dgvLibros.DataSource = resultadosBusqueda;
            }
            else
            {
                // Si el texto de búsqueda está vacío, cargar todos los libros en el DataGridView
                CargarDatosDataGridView();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}

