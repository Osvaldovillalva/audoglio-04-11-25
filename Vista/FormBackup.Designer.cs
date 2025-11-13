namespace Vista
{
    partial class FormBackup
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
            label1 = new Label();
            textBoxUbicacionbackUp = new TextBox();
            buttonExaminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 28);
            label1.Name = "label1";
            label1.Size = new Size(425, 15);
            label1.TabIndex = 0;
            label1.Text = "\"Seleccione la ubicación donde desea guardar el archivo de respaldo (backup):\"";
            // 
            // textBoxUbicacionbackUp
            // 
            textBoxUbicacionbackUp.Location = new Point(33, 61);
            textBoxUbicacionbackUp.Multiline = true;
            textBoxUbicacionbackUp.Name = "textBoxUbicacionbackUp";
            textBoxUbicacionbackUp.Size = new Size(543, 35);
            textBoxUbicacionbackUp.TabIndex = 1;
            // 
            // buttonExaminar
            // 
            buttonExaminar.Location = new Point(605, 51);
            buttonExaminar.Name = "buttonExaminar";
            buttonExaminar.Size = new Size(126, 62);
            buttonExaminar.TabIndex = 2;
            buttonExaminar.Text = "Examinar";
            buttonExaminar.UseVisualStyleBackColor = true;
            buttonExaminar.Click += buttonExaminar_Click;
            // 
            // FormBackup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 223);
            Controls.Add(buttonExaminar);
            Controls.Add(textBoxUbicacionbackUp);
            Controls.Add(label1);
            Name = "FormBackup";
            Text = "FormBackup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUbicacionbackUp;
        private Button buttonExaminar;
    }
}