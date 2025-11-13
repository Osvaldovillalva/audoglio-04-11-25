using Controladora;
using Entidades;
using Modelo;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Vista
{
    public partial class FormLogin : Form
    {
        private IUsuarioState estadoUsuario;
        private readonly ControladoraAuditoria controladoraAuditoria; // ✅ la dejamos como propiedad del form

        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);

            controladoraAuditoria = new ControladoraAuditoria(); // ✅ inicializamos una vez

            ConfigurarEventosMouseBotones(this);
        }

        private void ConfigurarEventosMouseBotones(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    button.MouseEnter += (sender, e) => CambiarColorBoton(button, Color.MediumVioletRed);
                    button.MouseLeave += (sender, e) => CambiarColorBoton(button, Color.Black);
                }
            }
        }

        private void CambiarColorBoton(Button button, Color color)
        {
            button.BackColor = color;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxContraseña.Clear();
            textBoxUsuario.Clear();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = textBoxUsuario.Text.Trim();
            string claveIngresada = textBoxContraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuarioIngresado) || string.IsNullOrEmpty(claveIngresada))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- 🔹 LOGIN ADMINISTRADOR ---
            if (usuarioIngresado == "admin" && claveIngresada == "123")
            {
                ControladoraMultas controladoraMultas = new ControladoraMultas();
                controladoraMultas.VerificarYActualizarEstadoSociosMultados();

                var usuarioSesion = UsuarioSesion.ObtenerInstancia();
                usuarioSesion.Usuario = "admin";
                usuarioSesion.Clave = "123";
                usuarioSesion.Rol = "Admin";
                usuarioSesion.Apellido = "Administrador";

                usuarioSesion.PuedeBorrarSocios = true;
                usuarioSesion.PuedeModificarSocios = true;
                usuarioSesion.PuedeBorrarLibros = true;
                usuarioSesion.PuedeModificarLibros = true;
                usuarioSesion.PuedeModificarValorCuota = true;
                usuarioSesion.PuedeCobrarCuotas = true;
                usuarioSesion.PuedeCambiarReglas = true;
                usuarioSesion.PuedeVerRegistros = true;
                usuarioSesion.PuedeGestionarUsuarios = true;

                // ✅ Auditoría
                controladoraAuditoria.Registrar("admin", "Login", "Inicio de sesión del administrador");

                MostrarFormMenu(controladoraMultas);
                return;
            }

            // --- 🔹 LOGIN USUARIO NORMAL ---
            using (var context = new SistemaBibliotecario())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Dni == usuarioIngresado);

                if (usuario == null)
                {
                    MessageBox.Show("El nombre de usuario no existe.");
                    textBoxUsuario.Clear();
                    textBoxContraseña.Clear();
                    return;
                }

                if (claveIngresada != usuario.Clave)
                {
                    MessageBox.Show("La contraseña es incorrecta.");
                    textBoxContraseña.Clear();
                    return;
                }

                estadoUsuario = usuario.Activo ? (IUsuarioState)new UsuarioActivoState() : new UsuarioInactivoState();

                if (!estadoUsuario.PuedeIniciarSesion(usuario))
                {
                    MessageBox.Show("El usuario está inactivo, no puede iniciar sesión.");
                    textBoxUsuario.Clear();
                    textBoxContraseña.Clear();
                    return;
                }

                // ✅ Crear sesión del usuario
                var usuarioSesion = UsuarioSesion.ObtenerInstancia();
                usuarioSesion.Usuario = usuario.Nombre;
                usuarioSesion.Clave = usuario.Clave;
                usuarioSesion.Dni = usuario.Dni;
                usuarioSesion.Rol = usuario.Rol;
                usuarioSesion.Apellido = usuario.Apellido;

                usuarioSesion.PuedeBorrarSocios = usuario.PuedeBorrarSocios;
                usuarioSesion.PuedeModificarSocios = usuario.PuedeModificarSocios;
                usuarioSesion.PuedeBorrarLibros = usuario.PuedeBorrarLibros;
                usuarioSesion.PuedeModificarLibros = usuario.PuedeModificarLibros;
                usuarioSesion.PuedeModificarValorCuota = usuario.PuedeModificarValorCuota;
                usuarioSesion.PuedeCobrarCuotas = usuario.PuedeCobrarCuotas;
                usuarioSesion.PuedeCambiarReglas = usuario.PuedeCambiarReglas;
                usuarioSesion.PuedeVerRegistros = usuario.PuedeVerRegistros;
                usuarioSesion.PuedeGestionarUsuarios = usuario.PuedeGestionarUsuarios;

                ControladoraMultas controladoraMultas = new ControladoraMultas();
                controladoraMultas.VerificarYActualizarEstadoSociosMultados();

                // ✅ Auditoría
                controladoraAuditoria.Registrar(usuarioSesion.Usuario, "Login", "Inicio de sesión exitoso");

                MostrarFormMenu(controladoraMultas);
            }
        }

        private void MostrarFormMenu(ControladoraMultas controladoraMultas)
        {
            FormMenu formMenu = new FormMenu(controladoraMultas);
            formMenu.FormClosed += (s, args) => this.Show();
            formMenu.Show();
            this.Hide();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            var usuarioSesion = UsuarioSesion.ObtenerInstancia();

            // ✅ Registrar auditoría de logout solo si había sesión activa
            if (!string.IsNullOrEmpty(usuarioSesion.Usuario))
            {
                controladoraAuditoria.Registrar(usuarioSesion.Usuario, "Logout", "Cierre de sesión del usuario");
            }

            usuarioSesion.CerrarSesion();
            Application.Exit();
        }

        private void buttonolvidecontraseña_Click(object sender, EventArgs e)
        {
            FormCambiarContraseña formCambiarContraseña = new FormCambiarContraseña();
            formCambiarContraseña.FormClosed += (s, args) => this.Show();
            formCambiarContraseña.Show();
        }
    }
}
