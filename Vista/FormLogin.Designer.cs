using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    partial class FormLogin : Form
    {
        private Label label1;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Button buttonIngresar;
        private Button buttonCancelar;

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

       

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            label1 = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            buttonIngresar = new Button();
            buttonCancelar = new Button();
            buttonSalir = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonolvidecontraseña = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 81);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 0;
            label1.Text = "D.N.I";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 126);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Location = new Point(123, 83);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(248, 23);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BorderStyle = BorderStyle.FixedSingle;
            textBoxContraseña.Location = new Point(123, 126);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(248, 23);
            textBoxContraseña.TabIndex = 3;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.Black;
            buttonIngresar.FlatAppearance.BorderColor = Color.White;
            buttonIngresar.FlatAppearance.BorderSize = 0;
            buttonIngresar.FlatStyle = FlatStyle.Popup;
            buttonIngresar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIngresar.ForeColor = Color.White;
            buttonIngresar.Image = (Image)resources.GetObject("buttonIngresar.Image");
            buttonIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonIngresar.Location = new Point(201, 272);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(170, 50);
            buttonIngresar.TabIndex = 4;
            buttonIngresar.Text = "   Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.Black;
            buttonCancelar.FlatAppearance.BorderColor = Color.White;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = SystemColors.ButtonFace;
            buttonCancelar.Image = (Image)resources.GetObject("buttonCancelar.Image");
            buttonCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancelar.Location = new Point(12, 272);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(170, 50);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.BackColor = Color.Black;
            buttonSalir.FlatAppearance.BorderColor = Color.White;
            buttonSalir.FlatAppearance.BorderSize = 0;
            buttonSalir.FlatStyle = FlatStyle.Popup;
            buttonSalir.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSalir.ForeColor = SystemColors.ButtonFace;
            buttonSalir.Image = (Image)resources.GetObject("buttonSalir.Image");
            buttonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSalir.Location = new Point(566, 441);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(350, 50);
            buttonSalir.TabIndex = 6;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = false;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(930, 40);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(452, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(444, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // buttonolvidecontraseña
            // 
            buttonolvidecontraseña.FlatStyle = FlatStyle.Popup;
            buttonolvidecontraseña.ForeColor = SystemColors.ControlLightLight;
            buttonolvidecontraseña.Location = new Point(123, 177);
            buttonolvidecontraseña.Name = "buttonolvidecontraseña";
            buttonolvidecontraseña.Size = new Size(248, 40);
            buttonolvidecontraseña.TabIndex = 9;
            buttonolvidecontraseña.Text = "Olvide Mi Contraseña";
            buttonolvidecontraseña.UseVisualStyleBackColor = true;
            buttonolvidecontraseña.Click += buttonolvidecontraseña_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(930, 500);
            Controls.Add(buttonolvidecontraseña);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSalir;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button buttonolvidecontraseña;
    }
}
