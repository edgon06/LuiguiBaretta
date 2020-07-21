using System;
using System.Windows.Forms;

namespace LuiguiBaretta
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            login.ShowDialog();
            if(login.Encendido)
                Application.Run(new Ventana_Prinsipal());
        }
    }
}
