namespace Vista
{
    partial class FormPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamos));
            buttonGenerarPrestamo = new Button();
            label2 = new Label();
            textBoxDatosLibro = new TextBox();
            buttonSalir = new Button();
            label1 = new Label();
            textBoxDatosSocio = new TextBox();
            dgvSocios = new DataGridView();
            dgvLibros = new DataGridView();
            buttonLimpiartodo = new Button();
            listBoxCarrito = new ListBox();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            buttonGuardarcompra = new Button();
            listBoxLibros = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // buttonGenerarPrestamo
            // 
            buttonGenerarPrestamo.FlatAppearance.BorderSize = 0;
            buttonGenerarPrestamo.FlatStyle = FlatStyle.Popup;
            buttonGenerarPrestamo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerarPrestamo.ForeColor = SystemColors.ButtonFace;
            buttonGenerarPrestamo.Image = (Image)resources.GetObject("buttonGenerarPrestamo.Image");
            buttonGenerarPrestamo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGenerarPrestamo.Location = new Point(614, 297);
            buttonGenerarPrestamo.Name = "buttonGenerarPrestamo";
            buttonGenerarPrestamo.Size = new Size(251, 50);
            buttonGenerarPrestamo.TabIndex = 2;
            buttonGenerarPrestamo.Text = "Generar Prestamo";
            buttonGenerarPrestamo.UseVisualStyleBackColor = true;
            buttonGenerarPrestamo.Click += buttonGenerarPrestamo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(14, 168);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Datos Libro";
            // 
            // textBoxDatosLibro
            // 
            textBoxDatosLibro.BorderStyle = BorderStyle.FixedSingle;
            textBoxDatosLibro.Location = new Point(14, 244);
            textBoxDatosLibro.Name = "textBoxDatosLibro";
            textBoxDatosLibro.Size = new Size(437, 23);
            textBoxDatosLibro.TabIndex = 8;
            textBoxDatosLibro.TextChanged += textBoxDatosLibro_TextChanged;
            // 
            // buttonSalir
            // 
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleRight;
            buttonSalir.Location = new Point(572, 438);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 0;
            buttonSalir.Text = "Volver";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 53);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 3;
            label1.Text = "Socios";
            // 
            // textBoxDatosSocio
            // 
            textBoxDatosSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxDatosSocio.Location = new Point(14, 81);
            textBoxDatosSocio.Name = "textBoxDatosSocio";
            textBoxDatosSocio.Size = new Size(550, 23);
            textBoxDatosSocio.TabIndex = 4;
            textBoxDatosSocio.TextChanged += textBoxDatosSocio_TextChanged;
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.BackgroundColor = Color.Black;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(11, 110);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowTemplate.Height = 25;
            dgvSocios.Size = new Size(553, 97);
            dgvSocios.TabIndex = 10;
            dgvSocios.CellContentClick += dgvSocios_CellContentClick;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.BackgroundColor = Color.Black;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(14, 273);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.RowTemplate.Height = 25;
            dgvLibros.Size = new Size(437, 215);
            dgvLibros.TabIndex = 11;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            // 
            // buttonLimpiartodo
            // 
            buttonLimpiartodo.FlatAppearance.BorderSize = 0;
            buttonLimpiartodo.FlatStyle = FlatStyle.Popup;
            buttonLimpiartodo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiartodo.ForeColor = SystemColors.ButtonFace;
            buttonLimpiartodo.Image = (Image)resources.GetObject("buttonLimpiartodo.Image");
            buttonLimpiartodo.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLimpiartodo.Location = new Point(614, 367);
            buttonLimpiartodo.Name = "buttonLimpiartodo";
            buttonLimpiartodo.Size = new Size(251, 50);
            buttonLimpiartodo.TabIndex = 12;
            buttonLimpiartodo.Text = "Limpiar todo";
            buttonLimpiartodo.UseVisualStyleBackColor = true;
            buttonLimpiartodo.Click += buttonLimpiartodo_Click;
            // 
            // listBoxCarrito
            // 
            listBoxCarrito.FormattingEnabled = true;
            listBoxCarrito.ItemHeight = 15;
            listBoxCarrito.Location = new Point(575, 81);
            listBoxCarrito.Name = "listBoxCarrito";
            listBoxCarrito.Size = new Size(343, 199);
            listBoxCarrito.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(575, 43);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 14;
            label3.Text = "Carrito";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 40);
            panel1.TabIndex = 15;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(14, 210);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 16;
            label4.Text = "Libros";
            // 
            // buttonGuardarcompra
            // 
            buttonGuardarcompra.FlatStyle = FlatStyle.Popup;
            buttonGuardarcompra.ForeColor = SystemColors.ControlLightLight;
            buttonGuardarcompra.Location = new Point(462, 244);
            buttonGuardarcompra.Name = "buttonGuardarcompra";
            buttonGuardarcompra.Size = new Size(107, 173);
            buttonGuardarcompra.TabIndex = 17;
            buttonGuardarcompra.Text = "Agregar a\r\nla Lista de\r\nCompras";
            buttonGuardarcompra.UseVisualStyleBackColor = true;
            buttonGuardarcompra.Click += buttonGuardarcompra_Click_1;
            // 
            // listBoxLibros
            // 
            listBoxLibros.FormattingEnabled = true;
            listBoxLibros.ItemHeight = 15;
            listBoxLibros.Location = new Point(14, 273);
            listBoxLibros.Name = "listBoxLibros";
            listBoxLibros.Size = new Size(437, 214);
            listBoxLibros.TabIndex = 18;
          
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(listBoxLibros);
            Controls.Add(buttonGuardarcompra);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(listBoxCarrito);
            Controls.Add(buttonLimpiartodo);
            Controls.Add(dgvLibros);
            Controls.Add(dgvSocios);
            Controls.Add(buttonSalir);
            Controls.Add(label1);
            Controls.Add(textBoxDatosSocio);
            Controls.Add(label2);
            Controls.Add(textBoxDatosLibro);
            Controls.Add(buttonGenerarPrestamo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrestamos";
            Text = "FormPrestamos";
            Load += FormPrestamos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonGenerarPrestamo;
        private Label label2;
        private TextBox textBoxDatosLibro;
        private Button buttonSalir;
        private Label label1;
        private TextBox textBoxDatosSocio;
        private DataGridView dgvSocios;
        private DataGridView dgvLibros;
        private Button buttonLimpiartodo;
        private ListBox listBoxCarrito;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Button buttonGuardarcompra;
        private ListBox listBoxLibros;
    }
}