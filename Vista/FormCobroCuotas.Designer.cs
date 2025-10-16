namespace Vista
{
    partial class FormCobroCuotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCobroCuotas));
            buttonSalir = new Button();
            label1 = new Label();
            textBoxDatosSocio = new TextBox();
            dgvSocios = new DataGridView();
            dgvCuotasMensuales = new DataGridView();
            listBoxCarritoCuotas = new ListBox();
            buttonGenerarPago = new Button();
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuotasMensuales).BeginInit();
            SuspendLayout();
            // 
            // buttonSalir
            // 
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleRight;
            buttonSalir.Location = new Point(568, 436);
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
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 1;
            label1.Text = "Datos del Socio";
            // 
            // textBoxDatosSocio
            // 
            textBoxDatosSocio.BorderStyle = BorderStyle.FixedSingle;
            textBoxDatosSocio.Location = new Point(12, 71);
            textBoxDatosSocio.Name = "textBoxDatosSocio";
            textBoxDatosSocio.Size = new Size(527, 23);
            textBoxDatosSocio.TabIndex = 2;
            textBoxDatosSocio.TextChanged += textBoxDatosSocio_TextChanged;
            // 
            // dgvSocios
            // 
            dgvSocios.AllowUserToAddRows = false;
            dgvSocios.AllowUserToDeleteRows = false;
            dgvSocios.BackgroundColor = Color.Black;
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(12, 100);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.ReadOnly = true;
            dgvSocios.RowTemplate.Height = 25;
            dgvSocios.Size = new Size(906, 109);
            dgvSocios.TabIndex = 3;
            // 
            // dgvCuotasMensuales
            // 
            dgvCuotasMensuales.AllowUserToAddRows = false;
            dgvCuotasMensuales.AllowUserToDeleteRows = false;
            dgvCuotasMensuales.BackgroundColor = Color.Black;
            dgvCuotasMensuales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuotasMensuales.Location = new Point(12, 240);
            dgvCuotasMensuales.Name = "dgvCuotasMensuales";
            dgvCuotasMensuales.ReadOnly = true;
            dgvCuotasMensuales.RowTemplate.Height = 25;
            dgvCuotasMensuales.Size = new Size(579, 180);
            dgvCuotasMensuales.TabIndex = 4;
            dgvCuotasMensuales.CellContentClick += dgvCuotasMensuales_CellContentClick;
            // 
            // listBoxCarritoCuotas
            // 
            listBoxCarritoCuotas.FormattingEnabled = true;
            listBoxCarritoCuotas.ItemHeight = 15;
            listBoxCarritoCuotas.Location = new Point(612, 237);
            listBoxCarritoCuotas.Name = "listBoxCarritoCuotas";
            listBoxCarritoCuotas.Size = new Size(296, 169);
            listBoxCarritoCuotas.TabIndex = 5;
            // 
            // buttonGenerarPago
            // 
            buttonGenerarPago.FlatAppearance.BorderSize = 0;
            buttonGenerarPago.FlatStyle = FlatStyle.Popup;
            buttonGenerarPago.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerarPago.ForeColor = SystemColors.ButtonFace;
            buttonGenerarPago.Image = (Image)resources.GetObject("buttonGenerarPago.Image");
            buttonGenerarPago.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGenerarPago.Location = new Point(285, 426);
            buttonGenerarPago.Name = "buttonGenerarPago";
            buttonGenerarPago.Size = new Size(254, 62);
            buttonGenerarPago.TabIndex = 6;
            buttonGenerarPago.Text = "Generar Pago";
            buttonGenerarPago.UseVisualStyleBackColor = true;
            buttonGenerarPago.Click += buttonGenerarPago_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 40);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 8;
            label2.Text = "Cuotas que Adeuda";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(22, 426);
            button1.Name = "button1";
            button1.Size = new Size(204, 62);
            button1.TabIndex = 9;
            button1.Text = "Limpiar todo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormCobroCuotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(buttonGenerarPago);
            Controls.Add(listBoxCarritoCuotas);
            Controls.Add(dgvCuotasMensuales);
            Controls.Add(dgvSocios);
            Controls.Add(textBoxDatosSocio);
            Controls.Add(label1);
            Controls.Add(buttonSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCobroCuotas";
            Text = "FormCobroCuotas";
            Load += FormCobroCuotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuotasMensuales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private Label label1;
        private TextBox textBoxDatosSocio;
        private DataGridView dgvSocios;
        private DataGridView dgvCuotasMensuales;
        private ListBox listBoxCarritoCuotas;
        private Button buttonGenerarPago;
        private Panel panel1;
        private Label label2;
        private Button button1;
    }
}