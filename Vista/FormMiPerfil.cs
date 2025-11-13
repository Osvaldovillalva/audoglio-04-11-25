using Controladora;
using Entidades;
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
    public partial class FormMiPerfil : Form
    {
        public FormMiPerfil()
        {
            InitializeComponent();

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
        private void buttonrestearcontraseña_Click(object sender, EventArgs e)
        {

            FormCambiarContraseña formCambiar = new FormCambiarContraseña();
            formCambiar.Show(); // Muestra el formulario de cambio de contraseña

            this.Hide(); // Oculta el formulario actual
            formCambiar.FormClosed += (s, args) => this.Show(); // Cuando se cierre, vuelve a mostrar este


        }

        private void FormMiPerfil_Load(object sender, EventArgs e)
        {
            var usuarioSesion = UsuarioSesion.ObtenerInstancia();

            // Asignar los valores a las etiquetas
            lblNombre.Text = "Nombre: " + usuarioSesion.Usuario;
            lblApellido.Text = "Apellido: " + usuarioSesion.Apellido;
            lblDni.Text = "DNI: " + usuarioSesion.Dni;
            lblRol.Text = "Rol: " + usuarioSesion.Rol;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            ControladoraMultas controladora = new ControladoraMultas();

            // Pasar el objeto 'controladora' al constructor de FormMenu
            FormMenu menuForm = new FormMenu(controladora);
            menuForm.Show(); // Abre el formulario de Menu

            this.Close();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            var usuarioSesion = UsuarioSesion.ObtenerInstancia();

            // Registrar auditoría de logout solo si había sesión activa
            if (!string.IsNullOrEmpty(usuarioSesion.Usuario))
            {
                var controladoraAuditoria = new ControladoraAuditoria();
                controladoraAuditoria.Registrar(usuarioSesion.Usuario, "Logout", "Cierre de sesión del usuario");
            }

            // Restablecer los datos de la sesión
            usuarioSesion.CerrarSesion();

            // Mostrar nuevamente el formulario de inicio de sesión
            FormLogin formLogin = new FormLogin();
            formLogin.Show();

            // Cerrar el formulario actual
            this.Close();
        }

    }
}
