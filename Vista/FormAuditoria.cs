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
            InicializarFiltros();
            CargarRegistrosAuditoria();
            dgvAuditoria.AutoGenerateColumns = false;
            dgvAuditoria.Columns.Clear();

            // Agregar columnas manualmente
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Usuario", DataPropertyName = "Usuario" });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Entidad", DataPropertyName = "Entidad" });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Acción", DataPropertyName = "Accion" });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Valor Anterior", DataPropertyName = "ValorAnterior" });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Valor Nuevo", DataPropertyName = "ValorNuevo" });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha y Hora", DataPropertyName = "FechaHora" });

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
        private void InicializarFiltros()
        {
            // Inicializar ComboBox de entidades
            cmbEntidad.Items.Clear();
            cmbEntidad.Items.Add("Todas");
            cmbEntidad.Items.Add("Sistema");
            cmbEntidad.Items.Add("CuotaMensual");
            cmbEntidad.SelectedIndex = 0;

            // Inicializar DateTimePickers
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;

            // Configurar DataGridView
            dgvAuditoria.AutoGenerateColumns = true;
            dgvAuditoria.ReadOnly = true;
            dgvAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditoria.MultiSelect = false;
        }

       

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaBibliotecario())
            {
                var query = context.Auditorias.AsQueryable();

                // Filtrar por usuario
                if (!string.IsNullOrWhiteSpace(txtUsuario.Text))
                    query = query.Where(a => a.Usuario.Contains(txtUsuario.Text));

                // Filtrar por entidad
                if (cmbEntidad.SelectedItem.ToString() != "Todas")
                    query = query.Where(a => a.Entidad == cmbEntidad.SelectedItem.ToString());

                // Filtrar por rango de fechas
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
