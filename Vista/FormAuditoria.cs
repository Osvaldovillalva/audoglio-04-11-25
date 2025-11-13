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
            ConfigurarDataGridView();
            InicializarFiltros();
            CargarUsuariosEnComboBox();
            CargarRegistrosAuditoria();
            
            ConfigurarEventosMouseBotones(this);
        }
        // ✅ Cambia el color de los botones al pasar el mouse
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

                // Si hay contenedores con más controles (como panels o groupboxes)
                if (control.HasChildren)
                {
                    ConfigurarEventosMouseBotones(control);
                }
            }
        }

        // ✅ Cambia el color del botón
        private void CambiarColorBoton(Button button, Color color)
        {
            button.BackColor = color;
        }

        private void ConfigurarDataGridView()
        {
            dgvAuditoria.AutoGenerateColumns = false;
            dgvAuditoria.Columns.Clear();

            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Usuario", DataPropertyName = "Usuario" });
            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Acción", DataPropertyName = "Accion" });

            // 🔹 Columna Detalle (expandida y con ajuste de texto)
            var colDetalle = new DataGridViewTextBoxColumn
            {
                HeaderText = "Detalle",
                DataPropertyName = "Detalle",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, // Se expande
                DefaultCellStyle = { WrapMode = DataGridViewTriState.True } // Permite múltiples líneas
            };
            dgvAuditoria.Columns.Add(colDetalle);

            dgvAuditoria.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Fecha y Hora", DataPropertyName = "FechaHora" });

            // 🔹 Opciones generales
            dgvAuditoria.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvAuditoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAuditoria.ReadOnly = true;
            dgvAuditoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAuditoria.MultiSelect = false;
        }
       

        private void InicializarFiltros()
        {
            // 🔹 Fechas: siempre el día actual
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

            // 🔹 Combo de acciones (entidades)
            cmbEntidad.Items.Clear();
            cmbEntidad.Items.Add("Todas");
            cmbEntidad.Items.Add("Login");
            cmbEntidad.Items.Add("Logout");
            cmbEntidad.Items.Add("Cobro de Cuota");
            cmbEntidad.SelectedIndex = 0;
        }

        private void CargarUsuariosEnComboBox()
        {
            using (var context = new SistemaBibliotecario())
            {
                var usuarios = context.Auditorias
                    .Select(a => a.Usuario)
                    .Distinct()
                    .OrderBy(u => u)
                    .ToList();

                cmbUsuario.Items.Clear();
                cmbUsuario.Items.Add("Todos");

                foreach (var usuario in usuarios)
                {
                    cmbUsuario.Items.Add(usuario);
                }

                cmbUsuario.SelectedIndex = 0;
            }
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

        // ✅ FILTRAR: ahora sí funciona correctamente
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            using (var context = new SistemaBibliotecario())
            {
                var query = context.Auditorias.AsQueryable();

                // 🔹 Filtrar por usuario
                if (cmbUsuario.SelectedItem != null && cmbUsuario.SelectedItem.ToString() != "Todos")
                {
                    string usuarioSeleccionado = cmbUsuario.SelectedItem.ToString();
                    query = query.Where(a => a.Usuario == usuarioSeleccionado);
                }

                // 🔹 Filtrar por acción (Login, Logout, Cobro)
                if (cmbEntidad.SelectedItem != null && cmbEntidad.SelectedItem.ToString() != "Todas")
                {
                    string accionSeleccionada = cmbEntidad.SelectedItem.ToString();
                    query = query.Where(a => a.Accion == accionSeleccionada);
                }

                // 🔹 Filtrar por rango de fechas
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);
                query = query.Where(a => a.FechaHora >= desde && a.FechaHora <= hasta);

                // 🔹 Obtener resultados
                var resultados = query.OrderByDescending(a => a.FechaHora).ToList();

                // ⚡️ Forzar actualización
                dgvAuditoria.DataSource = null;
                dgvAuditoria.DataSource = resultados;
                dgvAuditoria.Refresh();

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros con los filtros seleccionados.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        // ✅ ACTUALIZAR: limpia todo y vuelve a cargar los registros
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            using (var context = new SistemaBibliotecario())
            {
                var query = context.Auditorias.AsQueryable();

                // 🔹 Filtrar por usuario
                if (cmbUsuario.SelectedItem != null && cmbUsuario.SelectedItem.ToString() != "Todos")
                {
                    string usuarioSeleccionado = cmbUsuario.SelectedItem.ToString();
                    query = query.Where(a => a.Usuario == usuarioSeleccionado);
                }

                // 🔹 Filtrar por acción (Login, Logout, Cobro)
                if (cmbEntidad.SelectedItem != null && cmbEntidad.SelectedItem.ToString() != "Todas")
                {
                    string accionSeleccionada = cmbEntidad.SelectedItem.ToString();

                    // ✅ Ajuste: "Cobro de Cuota" corresponde a "CuotaMensual" en la BD
                    if (accionSeleccionada == "Cobro de Cuota")
                        accionSeleccionada = "CuotaMensual";

                    query = query.Where(a => a.Accion == accionSeleccionada);
                }

                // 🔹 Filtrar por rango de fechas
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);
                query = query.Where(a => a.FechaHora >= desde && a.FechaHora <= hasta);

                // 🔹 Obtener resultados
                var resultados = query.OrderByDescending(a => a.FechaHora).ToList();

                // ⚡️ Forzar actualización
                dgvAuditoria.DataSource = null;
                dgvAuditoria.DataSource = resultados;
                dgvAuditoria.Refresh();

                if (resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros con los filtros seleccionados.",
                        "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            // 🔹 Resetear filtros
            cmbUsuario.SelectedIndex = 0;
            cmbEntidad.SelectedIndex = 0;
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

            // 🔹 Recargar registros
            using (var context = new SistemaBibliotecario())
            {
                var registros = context.Auditorias
                    .OrderByDescending(a => a.FechaHora)
                    .ToList();

                dgvAuditoria.DataSource = null;
                dgvAuditoria.DataSource = registros;
                dgvAuditoria.Refresh();
            }
        }
    }
}
