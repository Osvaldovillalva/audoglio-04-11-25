using System;
using System.Threading;
using System.Windows.Forms;

namespace Vista
{
    internal static class Program
    {
        private static Mutex mutex;

        [STAThread]
        static void Main()
        {
            bool nuevaInstancia;
            mutex = new Mutex(true, "MiAplicacionUnica", out nuevaInstancia);

            if (!nuevaInstancia)
            {
                MessageBox.Show("La aplicación ya está en ejecución.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new FormLogin());
            }
            finally
            {
                // Liberamos el mutex solo si la instancia es la única
                if (nuevaInstancia)
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
