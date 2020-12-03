using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExcelLinq
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
            frm_Principal ventana = new frm_Principal();
            if(ventana.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }           
        }
    }
}
