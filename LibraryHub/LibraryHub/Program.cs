using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryHub
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
            // Application.Run(new Forms_admin.Form_dashboard());

            // Application.Run(new Forms_clients.FormC_dashboard());
            Application.Run(new Forms.Form_entry());
        }
    }
}
