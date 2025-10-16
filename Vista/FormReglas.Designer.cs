namespace Vista
{
    partial class FormReglas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReglas));
            label5 = new Label();
            textBoxPorcentajerecargo = new TextBox();
            textBoxDiasvenceCuota = new TextBox();
            label4 = new Label();
            textBoxDiasMulta = new TextBox();
            label3 = new Label();
            buttonModificar = new Button();
            buttonSalir = new Button();
            label2 = new Label();
            textBoxMaximoPrestamo = new TextBox();
            label1 = new Label();
            textBoxDiasPrestamo = new TextBox();
            dgvReglas = new DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReglas).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(315, 170);
            label5.Name = "label5";
            label5.Size = new Size(188, 50);
            label5.TabIndex = 10;
            label5.Text = "Porcentaje de recargo \r\nde la cuota vencida";
            // 
            // textBoxPorcentajerecargo
            // 
            textBoxPorcentajerecargo.BorderStyle = BorderStyle.FixedSingle;
            textBoxPorcentajerecargo.Location = new Point(315, 228);
            textBoxPorcentajerecargo.Name = "textBoxPorcentajerecargo";
            textBoxPorcentajerecargo.Size = new Size(218, 23);
            textBoxPorcentajerecargo.TabIndex = 9;
            textBoxPorcentajerecargo.TextChanged += textBoxPorcentajerecargo_TextChanged;
            // 
            // textBoxDiasvenceCuota
            // 
            textBoxDiasvenceCuota.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiasvenceCuota.Location = new Point(315, 325);
            textBoxDiasvenceCuota.Name = "textBoxDiasvenceCuota";
            textBoxDiasvenceCuota.Size = new Size(218, 23);
            textBoxDiasvenceCuota.TabIndex = 8;
            textBoxDiasvenceCuota.TextChanged += textBoxDiasvenceCuota_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(315, 267);
            label4.Name = "label4";
            label4.Size = new Size(158, 50);
            label4.TabIndex = 7;
            label4.Text = "A los cuantos Dias\r\n vence la cuota";
            // 
            // textBoxDiasMulta
            // 
            textBoxDiasMulta.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiasMulta.Location = new Point(29, 325);
            textBoxDiasMulta.Name = "textBoxDiasMulta";
            textBoxDiasMulta.Size = new Size(218, 23);
            textBoxDiasMulta.TabIndex = 6;
            textBoxDiasMulta.TextChanged += textBoxDiasMulta_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 267);
            label3.Name = "label3";
            label3.Size = new Size(218, 50);
            label3.TabIndex = 5;
            label3.Text = "Dias de multa \r\nsin poder prestar un  libro";
            label3.Click += label3_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.FlatAppearance.BorderSize = 0;
            buttonModificar.FlatStyle = FlatStyle.Popup;
            buttonModificar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModificar.ForeColor = SystemColors.ButtonFace;
            buttonModificar.Image = (Image)resources.GetObject("buttonModificar.Image");
            buttonModificar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonModificar.Location = new Point(698, 86);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(182, 60);
            buttonModificar.TabIndex = 4;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleRight;
            buttonSalir.Location = new Point(566, 441);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 3;
            buttonSalir.Text = "Volver";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 379);
            label2.Name = "label2";
            label2.Size = new Size(160, 50);
            label2.TabIndex = 1;
            label2.Text = "Cantidad Maxima  \r\nde libros a Prestar";
            // 
            // textBoxMaximoPrestamo
            // 
            textBoxMaximoPrestamo.BorderStyle = BorderStyle.FixedSingle;
            textBoxMaximoPrestamo.Location = new Point(29, 441);
            textBoxMaximoPrestamo.Name = "textBoxMaximoPrestamo";
            textBoxMaximoPrestamo.Size = new Size(218, 23);
            textBoxMaximoPrestamo.TabIndex = 2;
            textBoxMaximoPrestamo.TextChanged += textBoxMaximoPrestamo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 179);
            label1.Name = "label1";
            label1.Size = new Size(226, 25);
            label1.TabIndex = 1;
            label1.Text = "Cantidad dias de prestamo";
            // 
            // textBoxDiasPrestamo
            // 
            textBoxDiasPrestamo.BorderStyle = BorderStyle.FixedSingle;
            textBoxDiasPrestamo.Location = new Point(32, 228);
            textBoxDiasPrestamo.Name = "textBoxDiasPrestamo";
            textBoxDiasPrestamo.Size = new Size(215, 23);
            textBoxDiasPrestamo.TabIndex = 0;
            textBoxDiasPrestamo.TextChanged += textBoxDiasPrestamo_TextChanged;
            // 
            // dgvReglas
            // 
            dgvReglas.AllowUserToAddRows = false;
            dgvReglas.AllowUserToDeleteRows = false;
            dgvReglas.BackgroundColor = Color.Black;
            dgvReglas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReglas.Location = new Point(21, 86);
            dgvReglas.Name = "dgvReglas";
            dgvReglas.ReadOnly = true;
            dgvReglas.RowTemplate.Height = 25;
            dgvReglas.Size = new Size(649, 60);
            dgvReglas.TabIndex = 1;
            dgvReglas.CellContentClick += dgvReglas_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumVioletRed;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 40);
            panel2.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(21, 58);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 11;
            label6.Text = "Reglas Actuales";
            // 
            // FormReglas
            // 
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(label6);
            Controls.Add(buttonSalir);
            Controls.Add(buttonModificar);
            Controls.Add(textBoxPorcentajerecargo);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(textBoxDiasvenceCuota);
            Controls.Add(dgvReglas);
            Controls.Add(label4);
            Controls.Add(textBoxDiasMulta);
            Controls.Add(textBoxDiasPrestamo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxMaximoPrestamo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReglas";
            Text = "FormReglas";
            Load += FormReglas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReglas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBoxMaximoPrestamo;
        private Label label1;
        private TextBox textBoxDiasPrestamo;
        private Button buttonSalir;
        private DataGridView dgvReglas;
        private Button buttonModificar;
        private TextBox textBoxDiasMulta;
        private Label label3;
        private TextBox textBoxDiasvenceCuota;
        private Label label4;
        private TextBox textBoxPorcentajerecargo;
        private Label label5;
        private Panel panel2;
        private Label label6;
    }
}