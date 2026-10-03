using System;
using System.Windows.Forms;

namespace mylogin
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación WinForms.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
