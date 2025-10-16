namespace Vista
{
    partial class FormDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevoluciones));
            buttonSalir = new Button();
            dgvPrestamos = new DataGridView();
            textBoxBuscar = new TextBox();
            label1 = new Label();
            buttonGenerarDevolucion = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleRight;
            buttonSalir.Location = new Point(566, 438);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Volver";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AllowUserToAddRows = false;
            dgvPrestamos.AllowUserToDeleteRows = false;
            dgvPrestamos.BackgroundColor = Color.Black;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(23, 95);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.ReadOnly = true;
            dgvPrestamos.RowTemplate.Height = 25;
            dgvPrestamos.Size = new Size(895, 324);
            dgvPrestamos.TabIndex = 1;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Location = new Point(284, 58);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(632, 23);
            textBoxBuscar.TabIndex = 2;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 58);
            label1.Name = "label1";
            label1.Size = new Size(253, 25);
            label1.TabIndex = 3;
            label1.Text = "Ingrese D.N.I o Titulo del Libro";
            // 
            // buttonGenerarDevolucion
            // 
            buttonGenerarDevolucion.FlatAppearance.BorderSize = 0;
            buttonGenerarDevolucion.FlatStyle = FlatStyle.Popup;
            buttonGenerarDevolucion.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerarDevolucion.ForeColor = SystemColors.ButtonFace;
            buttonGenerarDevolucion.Image = (Image)resources.GetObject("buttonGenerarDevolucion.Image");
            buttonGenerarDevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGenerarDevolucion.Location = new Point(36, 438);
            buttonGenerarDevolucion.Name = "buttonGenerarDevolucion";
            buttonGenerarDevolucion.Size = new Size(245, 50);
            buttonGenerarDevolucion.TabIndex = 4;
            buttonGenerarDevolucion.Text = "     Generar Devolucion";
            buttonGenerarDevolucion.UseVisualStyleBackColor = true;
            buttonGenerarDevolucion.Click += buttonGenerarDevolucion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 40);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // FormDevoluciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(panel1);
            Controls.Add(buttonGenerarDevolucion);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(dgvPrestamos);
            Controls.Add(buttonSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDevoluciones";
            Text = "FormDevoluciones";
            Load += FormDevoluciones_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private DataGridView dgvPrestamos;
        private TextBox textBoxBuscar;
        private Label label1;
        private Button buttonGenerarDevolucion;
        private Panel panel1;
    }
}