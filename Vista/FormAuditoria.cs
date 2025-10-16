using Controladora;
using Entidades;
using Modelo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormAuditoria : Form
    {
        private ControladoraAuditoria controladoraAuditoria;

        public FormAuditoria()
        {
            InitializeComponent();
            controladoraAuditoria = new ControladoraAuditoria();
            this.Load += FormAuditoria_Load;
        }

        private void FormAuditoria_Load(object sender, EventArgs e)
        {
            CargarEntidades();
            CargarRegistrosAuditoria();
        }

        private void CargarEntidades()
        {
            // Agrega las entidades disponibles a cmbEntidad
            cmbEntidad.Items.Clear();
            cmbEntidad.Items.Add("Todas");
            cmbEntidad.Items.Add("Sistema");
            cmbEntidad.Items.Add("CuotaMensual");
            cmbEntidad.SelectedIndex = 0;
        }

        private void CargarRegistrosAuditoria()
        {
            using (var context = new SistemaBibliotecario())
            {
                var registros = context.Auditorias
                    .OrderByDescending(a => a.FechaHora)
                    .ToList();

                dgvAuditoria.DataSource = registros;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaBibliotecario())
            {
                var query = context.Auditorias.AsQueryable();

                if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
                    query = query.Where(a => a.Usuario.Contains(txtUsuario.Text));

                if (cmbEntidad.SelectedItem.ToString() != "Todas")
                    query = query.Where(a => a.Entidad == cmbEntidad.SelectedItem.ToString());

                query = query.Where(a => a.FechaHora >= dtpDesde.Value && a.FechaHora <= dtpHasta.Value);

                dgvAuditoria.DataSource = query.OrderByDescending(a => a.FechaHora).ToList();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            cmbEntidad.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;
            CargarRegistrosAuditoria();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario y vuelve al menú
        }
    }
}
