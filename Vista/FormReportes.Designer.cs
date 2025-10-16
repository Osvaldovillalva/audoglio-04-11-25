namespace Vista
{
    partial class FormReportes
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
            button1 = new Button();
            dataGridViewLibrosparacomprar = new DataGridView();
            btnborrar = new Button();
            label1 = new Label();
            buttonvergraficas = new Button();
            panelGrafico = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrosparacomprar).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(702, 435);
            button1.Name = "button1";
            button1.Size = new Size(200, 63);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewLibrosparacomprar
            // 
            dataGridViewLibrosparacomprar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLibrosparacomprar.Location = new Point(24, 62);
            dataGridViewLibrosparacomprar.Name = "dataGridViewLibrosparacomprar";
            dataGridViewLibrosparacomprar.RowTemplate.Height = 25;
            dataGridViewLibrosparacomprar.Size = new Size(487, 134);
            dataGridViewLibrosparacomprar.TabIndex = 1;
            dataGridViewLibrosparacomprar.CellContentClick += dataGridViewLibrosparacomprar_CellContentClick;
            // 
            // btnborrar
            // 
            btnborrar.BackColor = Color.Black;
            btnborrar.FlatStyle = FlatStyle.Popup;
            btnborrar.ForeColor = SystemColors.ControlLightLight;
            btnborrar.Location = new Point(548, 44);
            btnborrar.Name = "btnborrar";
            btnborrar.Size = new Size(138, 74);
            btnborrar.TabIndex = 2;
            btnborrar.Text = "Borrar";
            btnborrar.UseVisualStyleBackColor = false;
            btnborrar.Click += btnborrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 3;
            label1.Text = "Libros para comprar";
            // 
            // buttonvergraficas
            // 
            buttonvergraficas.BackColor = Color.Black;
            buttonvergraficas.FlatStyle = FlatStyle.Popup;
            buttonvergraficas.ForeColor = SystemColors.ControlLightLight;
            buttonvergraficas.Location = new Point(548, 132);
            buttonvergraficas.Name = "buttonvergraficas";
            buttonvergraficas.Size = new Size(138, 73);
            buttonvergraficas.TabIndex = 4;
            buttonvergraficas.Text = "Ver graficos";
            buttonvergraficas.UseVisualStyleBackColor = false;
            buttonvergraficas.Click += buttonvergraficas_Click;
            // 
            // panelGrafico
            // 
            panelGrafico.Location = new Point(24, 211);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(878, 218);
            panelGrafico.TabIndex = 7;
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
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 500);
            Controls.Add(panel2);
            Controls.Add(panelGrafico);
            Controls.Add(buttonvergraficas);
            Controls.Add(label1);
            Controls.Add(btnborrar);
            Controls.Add(dataGridViewLibrosparacomprar);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReportes";
            Text = "FormReportes";
            Load += FormReportes_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLibrosparacomprar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridViewLibrosparacomprar;
        private Button btnborrar;
        private Label label1;
        private Button buttonvergraficas;
        private Panel panelGrafico;
        private Panel panel2;
    }
}