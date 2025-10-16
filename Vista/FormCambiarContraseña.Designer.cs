namespace Vista
{
    partial class FormCambiarContraseña
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
            textBoxPalabrasegura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxdni = new TextBox();
            label3 = new Label();
            textBoxContraseñanueva = new TextBox();
            label4 = new Label();
            textBoxconfrimacioncontraseña = new TextBox();
            label5 = new Label();
            textBoxnuevapalabra = new TextBox();
            label6 = new Label();
            textBoxconfirmapalabra = new TextBox();
            buttonguardarcontraseñas = new Button();
            buttonSalir = new Button();
            buttonverificar = new Button();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // textBoxPalabrasegura
            // 
            textBoxPalabrasegura.Location = new Point(26, 190);
            textBoxPalabrasegura.Name = "textBoxPalabrasegura";
            textBoxPalabrasegura.Size = new Size(249, 23);
            textBoxPalabrasegura.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(26, 149);
            label1.Name = "label1";
            label1.Size = new Size(177, 15);
            label1.TabIndex = 1;
            label1.Text = "Cual es tu palabra de seguridad?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(27, 79);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "D.N.I";
            // 
            // textBoxdni
            // 
            textBoxdni.Location = new Point(27, 111);
            textBoxdni.Name = "textBoxdni";
            textBoxdni.Size = new Size(254, 23);
            textBoxdni.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(21, 216);
            label3.Name = "label3";
            label3.Size = new Size(220, 15);
            label3.TabIndex = 4;
            label3.Text = "Ingresa  una nueva contraseña numerica";
            // 
            // textBoxContraseñanueva
            // 
            textBoxContraseñanueva.Location = new Point(21, 248);
            textBoxContraseñanueva.Name = "textBoxContraseñanueva";
            textBoxContraseñanueva.Size = new Size(254, 23);
            textBoxContraseñanueva.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(21, 274);
            label4.Name = "label4";
            label4.Size = new Size(183, 15);
            label4.TabIndex = 6;
            label4.Text = "Confirma la contraseña numerica";
            // 
            // textBoxconfrimacioncontraseña
            // 
            textBoxconfrimacioncontraseña.Location = new Point(27, 309);
            textBoxconfrimacioncontraseña.Name = "textBoxconfrimacioncontraseña";
            textBoxconfrimacioncontraseña.Size = new Size(254, 23);
            textBoxconfrimacioncontraseña.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(27, 346);
            label5.Name = "label5";
            label5.Size = new Size(155, 15);
            label5.TabIndex = 8;
            label5.Text = "Nueva Palabra de Seguridad";
            // 
            // textBoxnuevapalabra
            // 
            textBoxnuevapalabra.Location = new Point(27, 364);
            textBoxnuevapalabra.Name = "textBoxnuevapalabra";
            textBoxnuevapalabra.Size = new Size(254, 23);
            textBoxnuevapalabra.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(27, 390);
            label6.Name = "label6";
            label6.Size = new Size(254, 15);
            label6.TabIndex = 10;
            label6.Text = "confirmacion de la nueva palabra de seguridad";
            // 
            // textBoxconfirmapalabra
            // 
            textBoxconfirmapalabra.Location = new Point(27, 417);
            textBoxconfirmapalabra.Name = "textBoxconfirmapalabra";
            textBoxconfirmapalabra.Size = new Size(254, 23);
            textBoxconfirmapalabra.TabIndex = 11;
            // 
            // buttonguardarcontraseñas
            // 
            buttonguardarcontraseñas.BackColor = Color.Black;
            buttonguardarcontraseñas.FlatStyle = FlatStyle.Popup;
            buttonguardarcontraseñas.ForeColor = SystemColors.ControlLightLight;
            buttonguardarcontraseñas.Location = new Point(305, 313);
            buttonguardarcontraseñas.Name = "buttonguardarcontraseñas";
            buttonguardarcontraseñas.Size = new Size(123, 80);
            buttonguardarcontraseñas.TabIndex = 12;
            buttonguardarcontraseñas.Text = "Guardar";
            buttonguardarcontraseñas.UseVisualStyleBackColor = false;
            buttonguardarcontraseñas.Click += buttonguardarcontraseñas_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Black;
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.ForeColor = SystemColors.ControlLightLight;
            buttonSalir.Location = new Point(774, 379);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(128, 70);
            buttonSalir.TabIndex = 13;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += button2_Click;
            // 
            // buttonverificar
            // 
            buttonverificar.BackColor = Color.Black;
            buttonverificar.FlatStyle = FlatStyle.Popup;
            buttonverificar.ForeColor = SystemColors.ControlLightLight;
            buttonverificar.Location = new Point(309, 146);
            buttonverificar.Name = "buttonverificar";
            buttonverificar.Size = new Size(119, 67);
            buttonverificar.TabIndex = 14;
            buttonverificar.Text = "Verificar";
            buttonverificar.UseVisualStyleBackColor = false;
            buttonverificar.Click += buttonverificar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumVioletRed;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(930, 40);
            panel2.TabIndex = 16;
            // 
            // FormCambiarContraseña
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(panel2);
            Controls.Add(buttonverificar);
            Controls.Add(buttonSalir);
            Controls.Add(buttonguardarcontraseñas);
            Controls.Add(textBoxconfirmapalabra);
            Controls.Add(label6);
            Controls.Add(textBoxnuevapalabra);
            Controls.Add(label5);
            Controls.Add(textBoxconfrimacioncontraseña);
            Controls.Add(label4);
            Controls.Add(textBoxContraseñanueva);
            Controls.Add(label3);
            Controls.Add(textBoxdni);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPalabrasegura);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCambiarContraseña";
            Text = "FormCambiarContraseña";
            Load += FormCambiarContraseña_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPalabrasegura;
        private Label label1;
        private Label label2;
        private TextBox textBoxdni;
        private Label label3;
        private TextBox textBoxContraseñanueva;
        private Label label4;
        private TextBox textBoxconfrimacioncontraseña;
        private Label label5;
        private TextBox textBoxnuevapalabra;
        private Label label6;
        private TextBox textBoxconfirmapalabra;
        private Button buttonguardarcontraseñas;
        private Button buttonSalir;
        private Button buttonverificar;
        private Panel panel2;
    }
}