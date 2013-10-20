using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab2
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

            Factures factures = new Factures();

            Classes.FacturesSerialisateur.Deserialiser();

            Application.Run(new FormPrincipal(factures));
        }
    }
}
