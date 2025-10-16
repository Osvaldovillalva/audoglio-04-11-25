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
        public FormLogin()
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

            // Si el acceso es con admin y 123
            if (usuarioIngresado == "admin" && claveIngresada == "123")
            {
                // Acción para administrador (sin consultar la base de datos)
                ControladoraMultas controladoraMultas = new ControladoraMultas();
                controladoraMultas.VerificarYActualizarEstadoSociosMultados();

                // Guardar el usuario en la sesión
                var usuarioSesion = UsuarioSesion.ObtenerInstancia();
                usuarioSesion.Usuario = "admin";
                usuarioSesion.Clave = "123";
                usuarioSesion.Rol = "Admin";  // Rol de admin
                usuarioSesion.Apellido = "Administrador";

                // Asignar permisos para el admin
                usuarioSesion.PuedeBorrarSocios = true;
                usuarioSesion.PuedeModificarSocios = true;
                usuarioSesion.PuedeBorrarLibros = true;
                usuarioSesion.PuedeModificarLibros = true;
                usuarioSesion.PuedeModificarValorCuota = true;
                usuarioSesion.PuedeCobrarCuotas = true;
                usuarioSesion.PuedeCambiarReglas = true;
                usuarioSesion.PuedeVerRegistros = true;
                usuarioSesion.PuedeGestionarUsuarios = true;

                MostrarFormMenu(controladoraMultas);
            }
            else
            {
                // Si no es admin, se valida contra la base de datos
                using (var context = new SistemaBibliotecario())
                {
                    var usuario = context.Usuarios.FirstOrDefault(u => u.Dni == usuarioIngresado);

                    if (usuario != null)
                    {
                        if (claveIngresada == usuario.Clave)
                        {
                            // Cambiar estado dependiendo de si el usuario está activo o inactivo
                            estadoUsuario = usuario.Activo ? (IUsuarioState)new UsuarioActivoState() : new UsuarioInactivoState();

                            if (estadoUsuario.PuedeIniciarSesion(usuario))
                            {
                                // Si la contraseña es correcta y el estado lo permite, guardar el usuario en la sesión
                                var usuarioSesion = UsuarioSesion.ObtenerInstancia();
                                usuarioSesion.Usuario = usuario.Nombre;
                                usuarioSesion.Clave = usuario.Clave;
                                usuarioSesion.Dni = usuario.Dni;
                                usuarioSesion.Rol = usuario.Rol;
                                usuarioSesion.Apellido = usuario.Apellido;

                                // Asignamos los permisos del usuario
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
                                MostrarFormMenu(controladoraMultas);
                            }
                            else
                            {
                                MessageBox.Show("El usuario está inactivo, no puede iniciar sesión.");
                                textBoxUsuario.Clear();
                                textBoxContraseña.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña es incorrecta.");
                            textBoxContraseña.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre de usuario no existe.");
                        textBoxUsuario.Clear();
                        textBoxContraseña.Clear();
                    }
                }
            }
        }





        private void MostrarFormMenu(ControladoraMultas controladoraMultas)
        {
            FormMenu formMenu = new FormMenu(controladoraMultas);
            formMenu.FormClosed += (s, args) => this.Show(); // Muestra de nuevo el login al cerrar el menú
            formMenu.Show();
            this.Hide(); // Oculta el formulario de login mientras el menú está abierto
        }


        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación correctamente
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void buttonolvidecontraseña_Click(object sender, EventArgs e)
        {
            // Abre el formulario de cambio de contraseña
            FormCambiarContraseña formCambiarContraseña = new FormCambiarContraseña();
            formCambiarContraseña.FormClosed += (s, args) => this.Show(); // Muestra el login al cerrar el formulario de cambio de contraseña
            formCambiarContraseña.Show();
            // Oculta el formulario de login mientras el de cambio de contraseña está abierto
        }
    }
}
