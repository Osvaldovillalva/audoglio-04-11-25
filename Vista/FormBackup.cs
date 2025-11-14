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

        private void buttonConfirmarBackup_Click(object sender, EventArgs e)
        {
            // 1️⃣ Verificar que haya ruta elegida
            if (string.IsNullOrWhiteSpace(textBoxUbicacionbackUp.Text))
            {
                MessageBox.Show("Debe seleccionar una ubicación para guardar el backup.",
                                "Ruta no seleccionada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2️⃣ Ruta de tu base de datos actual (la original)
                string rutaBD = @"C:\Users\javie\DataBase120524.mdf";
                string rutaLog = @"C:\Users\javie\DataBase120524_log.ldf"; // si existe

                // 3️⃣ Crear nombre del archivo final con fecha/hora
                string nombreBackup = $"BackupBiblioteca_{DateTime.Now:yyyyMMdd_HHmmss}.mdf";
                string nombreBackupLog = $"BackupBiblioteca_{DateTime.Now:yyyyMMdd_HHmmss}_log.ldf";

                // 4️⃣ Crear rutas finales
                string destinoBD = Path.Combine(textBoxUbicacionbackUp.Text, nombreBackup);
                string destinoLog = Path.Combine(textBoxUbicacionbackUp.Text, nombreBackupLog);

                // 5️⃣ Copiar archivo MDF
                File.Copy(rutaBD, destinoBD, true);

                // 6️⃣ Copiar archivo LDF (si existe)
                if (File.Exists(rutaLog))
                    File.Copy(rutaLog, destinoLog, true);

                // 7️⃣ Mensaje final
                MessageBox.Show("⚡ Backup realizado con éxito.\n\nUbicación:\n" + textBoxUbicacionbackUp.Text,
                                "Backup Finalizado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                this.Close(); // opcional
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el backup:\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
