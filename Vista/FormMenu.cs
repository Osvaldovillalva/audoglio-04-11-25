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
    public partial class FormMenu : Form
    {
        private ControladoraMultas controladoraMultas;
        private ControladoraCuotas controladoraCuotas;

        public FormMenu(ControladoraMultas controladora)
        {
            InitializeComponent();
            controladoraMultas = controladora;
            controladoraCuotas = new ControladoraCuotas();
            this.Load += new EventHandler(FormMenu_Load);
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
        private void buttonLibros_Click(object sender, EventArgs e)
        {
            using (FormLibros formLibros = new FormLibros())
            {
                formLibros.ShowDialog();
            }
        }



        private void FormMenu_Load(object sender, EventArgs e)
        {
            controladoraMultas.VerificarYActualizarEstadoSocios();
            controladoraMultas.VerificarYActualizarEstadoSociosMultados();
            controladoraCuotas.VerificarYDeshabilitarSociosConCuotasPendientes();

            var usuarioSesion = UsuarioSesion.ObtenerInstancia();

            // Mostrar los datos del usuario en un Label (puedes tener un labelUsuario en el formulario)
            buttonGestionUsuarios.Enabled = usuarioSesion.PuedeGestionarUsuarios;
            buttonRegistros.Enabled = usuarioSesion.PuedeVerRegistros;
            buttonReglasBiblio.Enabled = usuarioSesion.PuedeCambiarReglas;
            buttonValorCuota.Enabled = usuarioSesion.PuedeModificarValorCuota;
            buttonCobroCuotas.Enabled = usuarioSesion.PuedeCobrarCuotas;
        }

        private void buttonSocios_Click(object sender, EventArgs e)
        {
            using (FormSocios formSocios = new FormSocios())
            {
                formSocios.ShowDialog();
            }
        }

        private void buttonPrestamos_Click(object sender, EventArgs e)
        {
            using (FormPrestamos formPrestamos = new FormPrestamos())
            {
                formPrestamos.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormDevoluciones formDevoluciones = new FormDevoluciones())
            {
                formDevoluciones.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FormRegistros formRegistros = new FormRegistros())
            {
                formRegistros.ShowDialog();
            }
        }

        private void buttonCuota_Click(object sender, EventArgs e)
        {
            using (FormCuota formCuota = new FormCuota())
            {
                formCuota.ShowDialog();
            }
        }

        private void buttonCobroCuotas_Click(object sender, EventArgs e)
        {
            using (FormCobroCuotas formCobroCuotas = new FormCobroCuotas())
            {
                formCobroCuotas.ShowDialog();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonReglasBiblio_Click(object sender, EventArgs e)
        {
            using (FormReglas formReglas = new FormReglas())
            {
                formReglas.ShowDialog();
            }
        }

        private void buttonGestion_Click(object sender, EventArgs e)
        {
            using (FormUsuarios formUsuarios = new FormUsuarios())
            {
                formUsuarios.ShowDialog();
            }
        }

        private void buttonrestearcontraseña_Click(object sender, EventArgs e)
        {
            FormMiPerfil miPerfil = new FormMiPerfil(); // Usa el nombre correcto del formulario
            miPerfil.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormReportes formReportes = new FormReportes();

            // Mostrar el formulario de reportes
            formReportes.Show();
        }
        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            var usuarioSesion = UsuarioSesion.ObtenerInstancia();
            if (!string.IsNullOrEmpty(usuarioSesion.Usuario))
            {
                var controladoraAuditoria = new ControladoraAuditoria();
                controladoraAuditoria.Registrar(usuarioSesion.Usuario, "Sistema", "Logout");
            }

            // Limpiar sesión
            usuarioSesion.CerrarSesion();
        }

        private void buttonAuditoria_Click(object sender, EventArgs e)
        {
            using (FormAuditoria formAuditoria = new FormAuditoria())
            {
                formAuditoria.ShowDialog();
            }
        }

        private void buttonbackup_Click(object sender, EventArgs e)
        {
            using (FormBackup fb = new FormBackup())
            {
                fb.ShowDialog();
            }
        }
    }
}
