namespace Vista
{
    partial class FormLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibros));
            buttonSalir = new Button();
            buttonLimpiar = new Button();
            textBoxCantidad = new TextBox();
            label3 = new Label();
            textBoxAutor = new TextBox();
            label2 = new Label();
            textBoxTitulo = new TextBox();
            label1 = new Label();
            buttonAgregar = new Button();
            buttonModificar = new Button();
            buttonBorrar = new Button();
            dgvLibros = new DataGridView();
            textBoxBuscar = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
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
            buttonSalir.Location = new Point(563, 442);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Volver";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click_1;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.FlatAppearance.BorderSize = 0;
            buttonLimpiar.FlatStyle = FlatStyle.Popup;
            buttonLimpiar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.ForeColor = SystemColors.ButtonFace;
            buttonLimpiar.Image = (Image)resources.GetObject("buttonLimpiar.Image");
            buttonLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLimpiar.Location = new Point(12, 243);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(216, 50);
            buttonLimpiar.TabIndex = 9;
            buttonLimpiar.Text = "Limpiar Todo";
            buttonLimpiar.UseVisualStyleBackColor = true;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.BorderStyle = BorderStyle.FixedSingle;
            textBoxCantidad.Location = new Point(12, 202);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(216, 23);
            textBoxCantidad.TabIndex = 8;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 7;
            label3.Text = "Cantidad";
            // 
            // textBoxAutor
            // 
            textBoxAutor.BorderStyle = BorderStyle.FixedSingle;
            textBoxAutor.Location = new Point(12, 126);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(216, 23);
            textBoxAutor.TabIndex = 6;
            textBoxAutor.TextChanged += textBoxAutor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 5;
            label2.Text = "Apellido del Autor";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitulo.Location = new Point(12, 71);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(216, 23);
            textBoxTitulo.TabIndex = 4;
            textBoxTitulo.TextChanged += textBoxTitulo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 3;
            label1.Text = "Titulo";
            // 
            // buttonAgregar
            // 
            buttonAgregar.FlatAppearance.BorderSize = 0;
            buttonAgregar.FlatStyle = FlatStyle.Popup;
            buttonAgregar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.ForeColor = SystemColors.ButtonFace;
            buttonAgregar.Image = (Image)resources.GetObject("buttonAgregar.Image");
            buttonAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAgregar.Location = new Point(12, 313);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(216, 50);
            buttonAgregar.TabIndex = 2;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.FlatAppearance.BorderSize = 0;
            buttonModificar.FlatStyle = FlatStyle.Popup;
            buttonModificar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModificar.ForeColor = SystemColors.ButtonFace;
            buttonModificar.Image = (Image)resources.GetObject("buttonModificar.Image");
            buttonModificar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonModificar.Location = new Point(12, 369);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(216, 50);
            buttonModificar.TabIndex = 1;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonBorrar
            // 
            buttonBorrar.FlatAppearance.BorderSize = 0;
            buttonBorrar.FlatStyle = FlatStyle.Popup;
            buttonBorrar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBorrar.ForeColor = SystemColors.ButtonFace;
            buttonBorrar.Image = (Image)resources.GetObject("buttonBorrar.Image");
            buttonBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBorrar.Location = new Point(12, 438);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(216, 50);
            buttonBorrar.TabIndex = 0;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = true;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.BackgroundColor = Color.Black;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(255, 98);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowTemplate.Height = 25;
            dgvLibros.Size = new Size(663, 334);
            dgvLibros.TabIndex = 2;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscar.Location = new Point(324, 57);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(594, 23);
            textBoxBuscar.TabIndex = 3;
            textBoxBuscar.TextChanged += textBoxBuscar_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(255, 55);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 4;
            label4.Text = "Buscar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumVioletRed;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 40);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(label1);
            Controls.Add(textBoxTitulo);
            Controls.Add(textBoxAutor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxCantidad);
            Controls.Add(buttonLimpiar);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(textBoxBuscar);
            Controls.Add(dgvLibros);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(buttonSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLibros";
            Text = "FormLibros";
            Load += FormLibros_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private DataGridView dgvLibros;
        private Button buttonBorrar;
        private Label label3;
        private TextBox textBoxAutor;
        private Label label2;
        private TextBox textBoxTitulo;
        private Label label1;
        private Button buttonAgregar;
        private Button buttonModificar;
        private TextBox textBoxCantidad;
        private TextBox textBoxBuscar;
        private Label label4;
        private Button buttonLimpiar;
        private Panel panel2;
    }
}