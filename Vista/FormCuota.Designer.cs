namespace Vista
{
    partial class FormCuota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCuota));
            buttonSalir = new Button();
            label3 = new Label();
            comboBoxMes = new ComboBox();
            label1 = new Label();
            textBoxAño = new TextBox();
            buttonAgregar = new Button();
            buttonEliminar = new Button();
            buttonModificar = new Button();
            textBoxValorCuota = new TextBox();
            label2 = new Label();
            dgvValorCuota = new DataGridView();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvValorCuota).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleRight;
            buttonSalir.Location = new Point(543, 438);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Volver";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(45, 25);
            label3.TabIndex = 11;
            label3.Text = "Mes";
            // 
            // comboBoxMes
            // 
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            comboBoxMes.Location = new Point(12, 134);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(165, 23);
            comboBoxMes.TabIndex = 10;
            comboBoxMes.SelectedIndexChanged += comboBoxMes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 9;
            label1.Text = "Año";
            // 
            // textBoxAño
            // 
            textBoxAño.BorderStyle = BorderStyle.FixedSingle;
            textBoxAño.Location = new Point(12, 71);
            textBoxAño.Name = "textBoxAño";
            textBoxAño.Size = new Size(165, 23);
            textBoxAño.TabIndex = 8;
            textBoxAño.TextChanged += textBoxAño_TextChanged;
            // 
            // buttonAgregar
            // 
            buttonAgregar.FlatAppearance.BorderSize = 0;
            buttonAgregar.FlatStyle = FlatStyle.Popup;
            buttonAgregar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.ForeColor = SystemColors.ButtonFace;
            buttonAgregar.Image = (Image)resources.GetObject("buttonAgregar.Image");
            buttonAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAgregar.Location = new Point(12, 248);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(170, 50);
            buttonAgregar.TabIndex = 7;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.FlatStyle = FlatStyle.Popup;
            buttonEliminar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.ForeColor = SystemColors.ButtonFace;
            buttonEliminar.Image = (Image)resources.GetObject("buttonEliminar.Image");
            buttonEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEliminar.Location = new Point(12, 396);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(170, 50);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Borrar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.FlatStyle = FlatStyle.Popup;
            buttonModificar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModificar.ForeColor = SystemColors.ButtonFace;
            buttonModificar.Image = (Image)resources.GetObject("buttonModificar.Image");
            buttonModificar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonModificar.Location = new Point(12, 320);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(170, 50);
            buttonModificar.TabIndex = 5;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBoxValorCuota
            // 
            textBoxValorCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxValorCuota.Location = new Point(12, 203);
            textBoxValorCuota.Name = "textBoxValorCuota";
            textBoxValorCuota.Size = new Size(165, 23);
            textBoxValorCuota.TabIndex = 4;
            textBoxValorCuota.TextChanged += textBoxValorCuota_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 2;
            label2.Text = "Valor de la Cuota ";
            // 
            // dgvValorCuota
            // 
            dgvValorCuota.AllowUserToAddRows = false;
            dgvValorCuota.AllowUserToDeleteRows = false;
            dgvValorCuota.BackgroundColor = Color.Black;
            dgvValorCuota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValorCuota.Location = new Point(203, 46);
            dgvValorCuota.Name = "dgvValorCuota";
            dgvValorCuota.ReadOnly = true;
            dgvValorCuota.RowTemplate.Height = 25;
            dgvValorCuota.Size = new Size(715, 380);
            dgvValorCuota.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumVioletRed;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 40);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // FormCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(buttonSalir);
            Controls.Add(buttonModificar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonAgregar);
            Controls.Add(comboBoxMes);
            Controls.Add(label3);
            Controls.Add(textBoxValorCuota);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(textBoxAño);
            Controls.Add(label1);
            Controls.Add(dgvValorCuota);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCuota";
            Text = "FormCuota";
            Load += FormCuota_Load;
            ((System.ComponentModel.ISupportInitialize)dgvValorCuota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private DataGridView dgvValorCuota;
        private Button buttonModificar;
        private TextBox textBoxValorCuota;
        private Label label2;
        private Button buttonEliminar;
        private Label label1;
        private TextBox textBoxAño;
        private Button buttonAgregar;
        private Label label3;
        private ComboBox comboBoxMes;
        private Panel panel2;
    }
}