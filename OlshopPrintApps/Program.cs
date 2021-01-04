using System;
using System.Windows.Forms;

namespace OlshopPrintApps
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                core c = new core();
                Application.Run(new frmLogin(c));         
        }
    }
}
