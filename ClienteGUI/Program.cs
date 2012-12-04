using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClienteGUI
{
    public static class Program2
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ClioGUI());
        }

        
    }
}
