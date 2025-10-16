namespace Vista
{
    partial class FormRegistros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistros));
            buttonSalir = new Button();
            dgvDevoluciones = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dgvMultas = new DataGridView();
            label3 = new Label();
            panel1 = new Panel();
            dgvCuotasPagadas = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuotasPagadas).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleRight;
            buttonSalir.Location = new Point(565, 442);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Volver";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // dgvDevoluciones
            // 
            dgvDevoluciones.AllowUserToAddRows = false;
            dgvDevoluciones.AllowUserToDeleteRows = false;
            dgvDevoluciones.BackgroundColor = Color.Black;
            dgvDevoluciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevoluciones.Location = new Point(22, 71);
            dgvDevoluciones.Name = "dgvDevoluciones";
            dgvDevoluciones.ReadOnly = true;
            dgvDevoluciones.RowTemplate.Height = 25;
            dgvDevoluciones.Size = new Size(896, 94);
            dgvDevoluciones.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2676, 71);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Devoluciones";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 43);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 3;
            label2.Text = "Devoluciones";
            // 
            // dgvMultas
            // 
            dgvMultas.AllowUserToAddRows = false;
            dgvMultas.AllowUserToDeleteRows = false;
            dgvMultas.BackgroundColor = Color.Black;
            dgvMultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMultas.Location = new Point(22, 226);
            dgvMultas.Name = "dgvMultas";
            dgvMultas.ReadOnly = true;
            dgvMultas.RowTemplate.Height = 25;
            dgvMultas.Size = new Size(896, 87);
            dgvMultas.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 198);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 5;
            label3.Text = "Multas";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 40);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // dgvCuotasPagadas
            // 
            dgvCuotasPagadas.AllowUserToAddRows = false;
            dgvCuotasPagadas.AllowUserToDeleteRows = false;
            dgvCuotasPagadas.BackgroundColor = Color.Black;
            dgvCuotasPagadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotasPagadas.Location = new Point(12, 347);
            dgvCuotasPagadas.Name = "dgvCuotasPagadas";
            dgvCuotasPagadas.ReadOnly = true;
            dgvCuotasPagadas.RowTemplate.Height = 25;
            dgvCuotasPagadas.Size = new Size(861, 89);
            dgvCuotasPagadas.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(22, 316);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 8;
            label4.Text = "Cuotas Pagadas";
            // 
            // FormRegistros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(label4);
            Controls.Add(dgvCuotasPagadas);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(dgvMultas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDevoluciones);
            Controls.Add(buttonSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistros";
            Text = "FormRegistros";
            Load += FormRegistros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMultas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuotasPagadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private DataGridView dgvDevoluciones;
        private Label label1;
        private Label label2;
        private DataGridView dgvMultas;
        private Label label3;
        private Panel panel1;
        private DataGridView dgvCuotasPagadas;
        private Label label4;
    }
}