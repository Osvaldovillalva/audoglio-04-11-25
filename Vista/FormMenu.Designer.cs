namespace Vista
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            buttonSocios = new Button();
            buttonLibros = new Button();
            buttonGenerardevolucion = new Button();
            buttonPrestamos = new Button();
            buttonRegistros = new Button();
            buttonValorCuota = new Button();
            buttonCobroCuotas = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            buttonReglasBiblio = new Button();
            buttonGestionUsuarios = new Button();
            buttonmiperfil = new Button();
            button1 = new Button();
            buttonAuditoria = new Button();
            buttonbackup = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSocios
            // 
            buttonSocios.FlatAppearance.BorderColor = Color.White;
            buttonSocios.FlatAppearance.BorderSize = 0;
            buttonSocios.FlatStyle = FlatStyle.Popup;
            buttonSocios.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSocios.ForeColor = SystemColors.ButtonFace;
            buttonSocios.Image = (Image)resources.GetObject("buttonSocios.Image");
            buttonSocios.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSocios.Location = new Point(12, 67);
            buttonSocios.Name = "buttonSocios";
            buttonSocios.Size = new Size(170, 50);
            buttonSocios.TabIndex = 1;
            buttonSocios.Text = "Socios";
            buttonSocios.UseVisualStyleBackColor = true;
            buttonSocios.Click += buttonSocios_Click;
            // 
            // buttonLibros
            // 
            buttonLibros.FlatAppearance.BorderColor = Color.White;
            buttonLibros.FlatAppearance.BorderSize = 0;
            buttonLibros.FlatStyle = FlatStyle.Popup;
            buttonLibros.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLibros.ForeColor = SystemColors.ButtonFace;
            buttonLibros.Image = (Image)resources.GetObject("buttonLibros.Image");
            buttonLibros.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLibros.Location = new Point(12, 133);
            buttonLibros.Name = "buttonLibros";
            buttonLibros.Size = new Size(210, 61);
            buttonLibros.TabIndex = 0;
            buttonLibros.Text = "     Libros  Ingresos\r\n";
            buttonLibros.UseVisualStyleBackColor = true;
            buttonLibros.Click += buttonLibros_Click;
            // 
            // buttonGenerardevolucion
            // 
            buttonGenerardevolucion.FlatAppearance.BorderSize = 0;
            buttonGenerardevolucion.FlatStyle = FlatStyle.Popup;
            buttonGenerardevolucion.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerardevolucion.ForeColor = SystemColors.ButtonFace;
            buttonGenerardevolucion.Image = (Image)resources.GetObject("buttonGenerardevolucion.Image");
            buttonGenerardevolucion.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGenerardevolucion.Location = new Point(12, 303);
            buttonGenerardevolucion.Name = "buttonGenerardevolucion";
            buttonGenerardevolucion.Size = new Size(170, 59);
            buttonGenerardevolucion.TabIndex = 2;
            buttonGenerardevolucion.Text = "Generar\r\n Devolucion";
            buttonGenerardevolucion.UseVisualStyleBackColor = true;
            buttonGenerardevolucion.Click += button1_Click;
            // 
            // buttonPrestamos
            // 
            buttonPrestamos.FlatAppearance.BorderColor = Color.White;
            buttonPrestamos.FlatAppearance.BorderSize = 0;
            buttonPrestamos.FlatStyle = FlatStyle.Popup;
            buttonPrestamos.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrestamos.ForeColor = SystemColors.ButtonFace;
            buttonPrestamos.Image = (Image)resources.GetObject("buttonPrestamos.Image");
            buttonPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPrestamos.Location = new Point(12, 189);
            buttonPrestamos.Name = "buttonPrestamos";
            buttonPrestamos.Size = new Size(210, 91);
            buttonPrestamos.TabIndex = 2;
            buttonPrestamos.Text = "    Generar Prestamo\r\n Consultar Libros\r\n";
            buttonPrestamos.UseVisualStyleBackColor = true;
            buttonPrestamos.Click += buttonPrestamos_Click;
            // 
            // buttonRegistros
            // 
            buttonRegistros.FlatStyle = FlatStyle.Popup;
            buttonRegistros.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistros.ForeColor = SystemColors.ButtonFace;
            buttonRegistros.Image = (Image)resources.GetObject("buttonRegistros.Image");
            buttonRegistros.ImageAlign = ContentAlignment.MiddleLeft;
            buttonRegistros.Location = new Point(228, 207);
            buttonRegistros.Name = "buttonRegistros";
            buttonRegistros.Size = new Size(170, 50);
            buttonRegistros.TabIndex = 3;
            buttonRegistros.Text = "Registros";
            buttonRegistros.UseVisualStyleBackColor = true;
            buttonRegistros.Click += button2_Click;
            // 
            // buttonValorCuota
            // 
            buttonValorCuota.FlatStyle = FlatStyle.Popup;
            buttonValorCuota.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonValorCuota.ForeColor = SystemColors.ButtonFace;
            buttonValorCuota.Image = (Image)resources.GetObject("buttonValorCuota.Image");
            buttonValorCuota.ImageAlign = ContentAlignment.MiddleLeft;
            buttonValorCuota.Location = new Point(228, 67);
            buttonValorCuota.Name = "buttonValorCuota";
            buttonValorCuota.Size = new Size(170, 60);
            buttonValorCuota.TabIndex = 2;
            buttonValorCuota.Text = "     Asignar valor \r\n     de la Cuota";
            buttonValorCuota.UseVisualStyleBackColor = true;
            buttonValorCuota.Click += buttonCuota_Click;
            // 
            // buttonCobroCuotas
            // 
            buttonCobroCuotas.FlatStyle = FlatStyle.Popup;
            buttonCobroCuotas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCobroCuotas.ForeColor = SystemColors.ButtonFace;
            buttonCobroCuotas.Image = (Image)resources.GetObject("buttonCobroCuotas.Image");
            buttonCobroCuotas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCobroCuotas.Location = new Point(228, 133);
            buttonCobroCuotas.Name = "buttonCobroCuotas";
            buttonCobroCuotas.Size = new Size(170, 50);
            buttonCobroCuotas.TabIndex = 3;
            buttonCobroCuotas.Text = "   Cobrar Cuota";
            buttonCobroCuotas.UseVisualStyleBackColor = true;
            buttonCobroCuotas.Click += buttonCobroCuotas_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumVioletRed;
            panel3.Dock = DockStyle.Top;
            panel3.ForeColor = Color.MediumVioletRed;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(930, 40);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(582, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(323, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // buttonReglasBiblio
            // 
            buttonReglasBiblio.FlatAppearance.BorderSize = 0;
            buttonReglasBiblio.FlatStyle = FlatStyle.Popup;
            buttonReglasBiblio.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReglasBiblio.ForeColor = SystemColors.ButtonFace;
            buttonReglasBiblio.Image = (Image)resources.GetObject("buttonReglasBiblio.Image");
            buttonReglasBiblio.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReglasBiblio.Location = new Point(228, 276);
            buttonReglasBiblio.Name = "buttonReglasBiblio";
            buttonReglasBiblio.Size = new Size(188, 86);
            buttonReglasBiblio.TabIndex = 5;
            buttonReglasBiblio.Text = "Reglas \r\nde la \r\nBilioteca";
            buttonReglasBiblio.UseVisualStyleBackColor = true;
            buttonReglasBiblio.Click += buttonReglasBiblio_Click;
            // 
            // buttonGestionUsuarios
            // 
            buttonGestionUsuarios.FlatStyle = FlatStyle.Popup;
            buttonGestionUsuarios.ForeColor = SystemColors.ControlLightLight;
            buttonGestionUsuarios.Location = new Point(27, 384);
            buttonGestionUsuarios.Name = "buttonGestionUsuarios";
            buttonGestionUsuarios.Size = new Size(131, 72);
            buttonGestionUsuarios.TabIndex = 6;
            buttonGestionUsuarios.Text = "Gestion Usuarios";
            buttonGestionUsuarios.UseVisualStyleBackColor = true;
            buttonGestionUsuarios.Click += buttonGestion_Click;
            // 
            // buttonmiperfil
            // 
            buttonmiperfil.FlatStyle = FlatStyle.Popup;
            buttonmiperfil.ForeColor = SystemColors.ControlLightLight;
            buttonmiperfil.Location = new Point(425, 83);
            buttonmiperfil.Name = "buttonmiperfil";
            buttonmiperfil.Size = new Size(151, 56);
            buttonmiperfil.TabIndex = 7;
            buttonmiperfil.Text = "Mi Perfil";
            buttonmiperfil.UseVisualStyleBackColor = true;
            buttonmiperfil.Click += buttonrestearcontraseña_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(228, 382);
            button1.Name = "button1";
            button1.Size = new Size(124, 74);
            button1.TabIndex = 8;
            button1.Text = "Reportes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // buttonAuditoria
            // 
            buttonAuditoria.FlatStyle = FlatStyle.Popup;
            buttonAuditoria.ForeColor = SystemColors.ButtonFace;
            buttonAuditoria.Location = new Point(467, 205);
            buttonAuditoria.Name = "buttonAuditoria";
            buttonAuditoria.Size = new Size(94, 52);
            buttonAuditoria.TabIndex = 9;
            buttonAuditoria.Text = "Auditoria";
            buttonAuditoria.UseVisualStyleBackColor = true;
            buttonAuditoria.Click += buttonAuditoria_Click;
            // 
            // buttonbackup
            // 
            buttonbackup.FlatStyle = FlatStyle.Popup;
            buttonbackup.ForeColor = SystemColors.ButtonHighlight;
            buttonbackup.Location = new Point(441, 315);
            buttonbackup.Name = "buttonbackup";
            buttonbackup.Size = new Size(103, 54);
            buttonbackup.TabIndex = 10;
            buttonbackup.Text = "Generar Back Up";
            buttonbackup.UseVisualStyleBackColor = true;
            buttonbackup.Click += buttonbackup_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(buttonbackup);
            Controls.Add(buttonAuditoria);
            Controls.Add(button1);
            Controls.Add(buttonmiperfil);
            Controls.Add(buttonGestionUsuarios);
            Controls.Add(buttonReglasBiblio);
            Controls.Add(pictureBox1);
            Controls.Add(buttonLibros);
            Controls.Add(buttonPrestamos);
            Controls.Add(buttonSocios);
            Controls.Add(buttonGenerardevolucion);
            Controls.Add(buttonValorCuota);
            Controls.Add(buttonCobroCuotas);
            Controls.Add(buttonRegistros);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            Text = "Menu";
            Load += FormMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonLibros;
        private Button buttonSocios;
        private Button buttonPrestamos;
        private Button buttonGenerardevolucion;
        private Button buttonRegistros;
        private Button buttonValorCuota;
        private Button buttonCobroCuotas;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button buttonReglasBiblio;
        private Button buttonGestionUsuarios;
        private Button buttonmiperfil;
        private Button button1;
        private Button buttonAuditoria;
        private Button buttonbackup;
    }
}