using Controladora;
using Modelo;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormCambiarContraseña : Form
    {
        private ControladoraUsuarios _controladoraUsuarios;

        public FormCambiarContraseña()
        {
            InitializeComponent();
            // Inicializamos la controladora correctamente
            _controladoraUsuarios = new ControladoraUsuarios(new SistemaBibliotecario());
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
        private void FormCambiarContraseña_Load(object sender, EventArgs e)
        {
            OcultarCamposCambio();
        }

        private void OcultarCamposCambio()
        {
            // Ocultamos los campos de cambio de contraseña al inicio
            textBoxContraseñanueva.Visible = false;
            textBoxconfrimacioncontraseña.Visible = false;
            textBoxnuevapalabra.Visible = false;
            textBoxconfirmapalabra.Visible = false;
            buttonguardarcontraseñas.Visible = false;
        }

        private void MostrarCamposCambio()
        {
            // Mostramos los campos de cambio de contraseña cuando la verificación sea exitosa
            textBoxContraseñanueva.Visible = true;
            textBoxconfrimacioncontraseña.Visible = true;
            textBoxnuevapalabra.Visible = true;
            textBoxconfirmapalabra.Visible = true;
            buttonguardarcontraseñas.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show(); // Abre el formulario de login

            this.Close(); // Cierra toda la aplicación, incluyendo el formulario actual
        }



        private void buttonverificar_Click(object sender, EventArgs e)
        {
            // Obtener valores ingresados por el usuario
            string dniIngresado = textBoxdni.Text.Trim();
            string palabraIngresada = textBoxPalabrasegura.Text.Trim();

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(dniIngresado) || string.IsNullOrEmpty(palabraIngresada))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Buscar el usuario en la base de datos
            var usuario = _controladoraUsuarios.ObtenerUsuarioPorDni(dniIngresado);

            if (usuario == null)
            {
                MessageBox.Show("El DNI ingresado no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar la palabra de seguridad
            if (usuario.PalabraDeSeguridad == palabraIngresada)
            {
                MessageBox.Show("Verificación exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarCamposCambio(); // Si la verificación es correcta, mostrar los campos
            }
            else
            {
                MessageBox.Show("La palabra de seguridad es incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonguardarcontraseñas_Click(object sender, EventArgs e)
        {
            // Obtener las contraseñas y palabras de seguridad del formulario
            string nuevaContraseña = textBoxContraseñanueva.Text.Trim();
            string confirmarContraseña = textBoxconfrimacioncontraseña.Text.Trim();
            string nuevaPalabra = textBoxnuevapalabra.Text.Trim();
            string confirmarPalabra = textBoxconfirmapalabra.Text.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(nuevaContraseña) || string.IsNullOrEmpty(confirmarContraseña) ||
                string.IsNullOrEmpty(nuevaPalabra) || string.IsNullOrEmpty(confirmarPalabra))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que las contraseñas coincidan
            if (nuevaContraseña != confirmarContraseña)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que las contraseñas sean numéricas (si así se requiere)
            if (!Regex.IsMatch(nuevaContraseña, @"^\d+$"))
            {
                MessageBox.Show("La contraseña debe ser solo numérica.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que la palabra de seguridad solo contenga letras
            if (!Regex.IsMatch(nuevaPalabra, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("La palabra de seguridad debe contener solo letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que las palabras de seguridad coincidan
            if (nuevaPalabra != confirmarPalabra)
            {
                MessageBox.Show("Las palabras de seguridad no coinciden.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el DNI ingresado por el usuario
            string dniIngresado = textBoxdni.Text.Trim();

            try
            {
                // Obtener el usuario actual
                var usuarioActual = _controladoraUsuarios.ObtenerUsuarioPorDni(dniIngresado);

                if (usuarioActual != null)
                {
                    // Actualizar la contraseña y la palabra de seguridad en el usuario
                    usuarioActual.Clave = nuevaContraseña;
                    usuarioActual.PalabraDeSeguridad = nuevaPalabra;

                    // Registrar los cambios en la base de datos
                    _controladoraUsuarios.ModificarUsuario(usuarioActual);

                    // Notificar al usuario
                    MessageBox.Show("Las contraseñas y la palabra de seguridad se han actualizado correctamente.", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El usuario no se encuentra registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
