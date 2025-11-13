using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Seleccione la carpeta donde guardar el backup";
                dialog.ShowNewFolderButton = true;  // permite crear carpetas nuevas

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxUbicacionbackUp.Text = dialog.SelectedPath;
                }
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
