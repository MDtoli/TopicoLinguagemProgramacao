using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoTopicoLinguagem01
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            formLogin formLogin = new formLogin();

            var login = formLogin;

            Application.Run(login);
            if (login.DialogResult == DialogResult.OK)
            {
                Application.Run(new formPrincipal());
            }

            
        }
    }
}
