namespace Vista
{
    partial class FormAuditoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFiltrar = new Button();
            btnActualizar = new Button();
            lblFiltros = new Label();
            cmbEntidad = new ComboBox();
            dtpDesde = new DateTimePicker();
            txtUsuario = new TextBox();
            dgvAuditoria = new DataGridView();
            dtpHasta = new DateTimePicker();
            BtnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(103, 100);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(236, 99);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Aplicar Filtro";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(180, 276);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(231, 102);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.Location = new Point(635, 159);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(39, 15);
            lblFiltros.TabIndex = 2;
            lblFiltros.Text = "Filtros";
            // 
            // cmbEntidad
            // 
            cmbEntidad.FormattingEnabled = true;
            cmbEntidad.Location = new Point(932, 336);
            cmbEntidad.Name = "cmbEntidad";
            cmbEntidad.Size = new Size(121, 23);
            cmbEntidad.TabIndex = 3;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(878, 128);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(346, 23);
            dtpDesde.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(646, 253);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 5;
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(290, 407);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.RowTemplate.Height = 25;
            dgvAuditoria.Size = new Size(240, 150);
            dgvAuditoria.TabIndex = 6;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(1133, 218);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(200, 23);
            dtpHasta.TabIndex = 7;
            // 
            // BtnVolver
            // 
            BtnVolver.Location = new Point(1091, 505);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(242, 93);
            BtnVolver.TabIndex = 8;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // FormAuditoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1448, 634);
            Controls.Add(BtnVolver);
            Controls.Add(dtpHasta);
            Controls.Add(dgvAuditoria);
            Controls.Add(txtUsuario);
            Controls.Add(dtpDesde);
            Controls.Add(cmbEntidad);
            Controls.Add(lblFiltros);
            Controls.Add(btnActualizar);
            Controls.Add(btnFiltrar);
            Name = "FormAuditoria";
            Text = "FormAuditoria";
            Load += FormAuditoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private Button btnActualizar;
        private Label lblFiltros;
        private ComboBox cmbEntidad;
        private DateTimePicker dtpDesde;
        private TextBox txtUsuario;
        private DataGridView dgvAuditoria;
        private DateTimePicker dtpHasta;
        private Button BtnVolver;
    }
}