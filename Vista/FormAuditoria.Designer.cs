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
            dgvAuditoria = new DataGridView();
            dtpHasta = new DateTimePicker();
            BtnVolver = new Button();
            cmbUsuario = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.FlatStyle = FlatStyle.Popup;
            btnFiltrar.ForeColor = SystemColors.ButtonHighlight;
            btnFiltrar.Location = new Point(449, 123);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(166, 75);
            btnFiltrar.TabIndex = 0;
            btnFiltrar.Text = "Aplicar Filtro";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.FlatStyle = FlatStyle.Popup;
            btnActualizar.ForeColor = SystemColors.ButtonFace;
            btnActualizar.Location = new Point(1186, 298);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(242, 107);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Limpiar campos";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // lblFiltros
            // 
            lblFiltros.AutoSize = true;
            lblFiltros.ForeColor = SystemColors.ButtonFace;
            lblFiltros.Location = new Point(42, 76);
            lblFiltros.Name = "lblFiltros";
            lblFiltros.Size = new Size(39, 15);
            lblFiltros.TabIndex = 2;
            lblFiltros.Text = "Desde";
            // 
            // cmbEntidad
            // 
            cmbEntidad.FormattingEnabled = true;
            cmbEntidad.Location = new Point(232, 168);
            cmbEntidad.Name = "cmbEntidad";
            cmbEntidad.Size = new Size(121, 23);
            cmbEntidad.TabIndex = 3;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(42, 94);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(346, 23);
            dtpDesde.TabIndex = 4;
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(32, 204);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.RowTemplate.Height = 25;
            dgvAuditoria.Size = new Size(1091, 398);
            dgvAuditoria.TabIndex = 6;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(449, 94);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(309, 23);
            dtpHasta.TabIndex = 7;
            // 
            // BtnVolver
            // 
            BtnVolver.FlatStyle = FlatStyle.Popup;
            BtnVolver.ForeColor = SystemColors.ButtonFace;
            BtnVolver.Location = new Point(1186, 509);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new Size(242, 93);
            BtnVolver.TabIndex = 8;
            BtnVolver.Text = "Volver";
            BtnVolver.UseVisualStyleBackColor = true;
            BtnVolver.Click += BtnVolver_Click;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(42, 168);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(121, 23);
            cmbUsuario.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(449, 76);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 10;
            label1.Text = "Hasta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(42, 146);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 11;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(232, 146);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Acciones";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.MediumVioletRed;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1448, 40);
            panel3.TabIndex = 14;
            // 
            // FormAuditoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1448, 634);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbUsuario);
            Controls.Add(BtnVolver);
            Controls.Add(dtpHasta);
            Controls.Add(dgvAuditoria);
            Controls.Add(dtpDesde);
            Controls.Add(cmbEntidad);
            Controls.Add(lblFiltros);
            Controls.Add(btnActualizar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.None;
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
        private DataGridView dgvAuditoria;
        private DateTimePicker dtpHasta;
        private Button BtnVolver;
        private ComboBox cmbUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel3;
    }
}