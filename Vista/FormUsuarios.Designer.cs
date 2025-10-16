namespace Vista
{
    partial class FormUsuarios
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
            dataGridViewUsuarios = new DataGridView();
            button1 = new Button();
            buttonModificar = new Button();
            buttonBorrar = new Button();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDni = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            buttonVolver = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(12, 158);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowTemplate.Height = 25;
            dataGridViewUsuarios.Size = new Size(890, 270);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(323, 57);
            button1.Name = "button1";
            button1.Size = new Size(89, 45);
            button1.TabIndex = 1;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.BackColor = Color.Black;
            buttonModificar.FlatStyle = FlatStyle.Popup;
            buttonModificar.ForeColor = SystemColors.ControlLightLight;
            buttonModificar.Location = new Point(529, 107);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(133, 40);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "resetear clave";
            buttonModificar.UseVisualStyleBackColor = false;
            buttonModificar.Click += buttonModificar_Click_1;
            // 
            // buttonBorrar
            // 
            buttonBorrar.BackColor = Color.Black;
            buttonBorrar.FlatStyle = FlatStyle.Popup;
            buttonBorrar.ForeColor = SystemColors.ControlLightLight;
            buttonBorrar.Location = new Point(323, 114);
            buttonBorrar.Name = "buttonBorrar";
            buttonBorrar.Size = new Size(89, 38);
            buttonBorrar.TabIndex = 3;
            buttonBorrar.Text = "Borrar";
            buttonBorrar.UseVisualStyleBackColor = false;
            buttonBorrar.Click += buttonBorrar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(12, 79);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(137, 23);
            textBoxNombre.TabIndex = 4;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(12, 129);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(137, 23);
            textBoxApellido.TabIndex = 5;
            textBoxApellido.TextChanged += textBoxApellido_TextChanged;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(178, 79);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(121, 23);
            textBoxDni.TabIndex = 6;
            textBoxDni.TextChanged += textBoxDni_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(178, 59);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "D.N.I";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Bibliotecario" });
            comboBox1.Location = new Point(178, 129);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Black;
            buttonVolver.FlatStyle = FlatStyle.Popup;
            buttonVolver.ForeColor = SystemColors.ControlLightLight;
            buttonVolver.Location = new Point(699, 434);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(189, 60);
            buttonVolver.TabIndex = 11;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(178, 107);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 12;
            label4.Text = "Rol";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(529, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(529, 57);
            label5.Name = "label5";
            label5.Size = new Size(125, 15);
            label5.TabIndex = 14;
            label5.Text = "D.N.I RESETEAR CLAVE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumVioletRed;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 27);
            panel2.TabIndex = 17;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(panel2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(buttonVolver);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDni);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonBorrar);
            Controls.Add(buttonModificar);
            Controls.Add(button1);
            Controls.Add(dataGridViewUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormUsuarios";
            Text = "FormUsuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsuarios;
        private Button button1;
        private Button buttonModificar;
        private Button buttonBorrar;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDni;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button buttonVolver;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Panel panel2;
    }
}