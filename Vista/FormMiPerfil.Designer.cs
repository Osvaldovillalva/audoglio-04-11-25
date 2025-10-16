namespace Vista
{
    partial class FormMiPerfil
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
            buttonrestearcontraseña = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblRol = new Label();
            buttonVolver = new Button();
            buttonCerrarSesion = new Button();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // buttonrestearcontraseña
            // 
            buttonrestearcontraseña.BackColor = Color.Black;
            buttonrestearcontraseña.FlatStyle = FlatStyle.Popup;
            buttonrestearcontraseña.ForeColor = SystemColors.ControlLightLight;
            buttonrestearcontraseña.Location = new Point(42, 371);
            buttonrestearcontraseña.Name = "buttonrestearcontraseña";
            buttonrestearcontraseña.Size = new Size(234, 78);
            buttonrestearcontraseña.TabIndex = 8;
            buttonrestearcontraseña.Text = "cambiar  contraseña";
            buttonrestearcontraseña.UseVisualStyleBackColor = false;
            buttonrestearcontraseña.Click += buttonrestearcontraseña_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(42, 120);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.ForeColor = SystemColors.ControlLightLight;
            lblApellido.Location = new Point(42, 184);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 10;
            lblApellido.Text = "Apellido:";
            lblApellido.Click += label2_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.ForeColor = SystemColors.ControlLightLight;
            lblDni.Location = new Point(42, 234);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(36, 15);
            lblDni.TabIndex = 11;
            lblDni.Text = "D.N.I:";
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.ForeColor = SystemColors.ControlLightLight;
            lblRol.Location = new Point(42, 278);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 12;
            lblRol.Text = "Rol:";
            // 
            // buttonVolver
            // 
            buttonVolver.BackColor = Color.Black;
            buttonVolver.FlatStyle = FlatStyle.Popup;
            buttonVolver.ForeColor = SystemColors.ControlLightLight;
            buttonVolver.Location = new Point(669, 422);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(233, 66);
            buttonVolver.TabIndex = 13;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = false;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.BackColor = Color.Black;
            buttonCerrarSesion.FlatStyle = FlatStyle.Popup;
            buttonCerrarSesion.ForeColor = SystemColors.ControlLightLight;
            buttonCerrarSesion.Location = new Point(696, 134);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(206, 115);
            buttonCerrarSesion.TabIndex = 14;
            buttonCerrarSesion.Text = "Cerrar Sesion";
            buttonCerrarSesion.UseVisualStyleBackColor = false;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
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
            // FormMiPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(panel2);
            Controls.Add(buttonCerrarSesion);
            Controls.Add(buttonVolver);
            Controls.Add(lblRol);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(buttonrestearcontraseña);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMiPerfil";
            Text = "FormMiPerfil";
            Load += FormMiPerfil_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonrestearcontraseña;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblRol;
        private Button buttonVolver;
        private Button buttonCerrarSesion;
        private Panel panel2;
    }
}