using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace SistemaOrdenes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Mutex instanceLock = new Mutex(false, "OrdenesDeCompra");
            if (instanceLock.WaitOne(0, false))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Login());
                    //Application.Run(new Menumain());
                }
                finally
                { instanceLock.ReleaseMutex(); }
            }
            else
            {
                MessageBox.Show("No se puede ejecutar 2 veces");
                Application.Exit();
            }
        }

        

        
    }
    

}
