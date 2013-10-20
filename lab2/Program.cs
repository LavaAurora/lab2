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

            /* 
             * DONNÉES TEMPORAIRES 
             */

            Facture f;

            factures.AjouterFacture("FactureUniversite", "Frais scolarité");
            {
                f = factures.ChercherFacture(5000);
                f.CreerArticle("Droits scolarité", 1, 1500m, "FP");
                f.CreerArticle("Droits afférents", 1, 50m, "FP");

            }
            
 
            factures.AjouterFacture("FactureEpicerie", "Boulangerie");
            {
                f = factures.ChercherFacture(5001);
                f.CreerArticle("Pain blanc", 2, 3.5m, "P");
                f.CreerArticle("Pain tranché", 3, 4.35m, "P");
                f.CreerArticle("Pain brun", 6, 1.98m, "P");

            }
           

            factures.AjouterFacture("FactureEpicerie", "Fruits et légumes");
            {
                f = factures.ChercherFacture(5002);
                f.CreerArticle("Oranges à Joe", 156, 1.2m, "");
                f.CreerArticle("Salade", 2, 0.98m, "");
                f.CreerArticle("Pommes", 12, 1.59m, "");
                f.CreerArticle("Tomates", 2, 0.89m, "");

            }
       

            factures.AjouterFacture("FactureCable", "Internet");
            {
                f = factures.ChercherFacture(5003);
                f.CreerArticle("Frais de base", 1, 98m, "FP");
                f.CreerArticle("Dépassement consomation (gig)", 53, 1.23m, "F");
            }

            factures.AjouterFacture("FactureEpicerie", "Facture1");
            {
                f = factures.ChercherFacture(5004);
                f.CreerArticle("Poire", 156, 1.2m, "");
                f.CreerArticle("Pommes", 2, 0.98m, "");
                f.CreerArticle("Fraises", 12, 1.59m, "");
                f.CreerArticle("Citrons", 2, 0.89m, "");

            }

            factures.AjouterFacture("FactureEpicerie", "Facture2");
            {
                f = factures.ChercherFacture(5005);
                f.CreerArticle("Poire", 156, 1.2m, "");
                f.CreerArticle("Pommes", 2, 0.98m, "");
                f.CreerArticle("Pommes", 2, 1m, "");
                f.CreerArticle("Fraises", 12, 1.59m, "");
                f.CreerArticle("Citrons", 2, 0.89m, "");

            }

            factures.AjouterFacture("FactureEpicerie", "Facture3");
            {
                f = factures.ChercherFacture(5006);
                f.CreerArticle("Poire", 156, 1.2m, "");
                f.CreerArticle("Pommes", 2, 0.98m, "");
                f.CreerArticle("Fraises", 12, 1.59m, "");
                f.CreerArticle("Citrons", 2, 0.89m, "");

            }


            factures.AjouterFacture("FactureEpicerie", "Facture4");
            {
                f = factures.ChercherFacture(5007);
                f.CreerArticle("Poire", 3, 1.2m, "");
            }

            factures.AjouterFacture("FactureEpicerie", "Facture5");
            {
                f = factures.ChercherFacture(5008);
                f.CreerArticle("Poire", 5, 1.2m, "");

            }
 
            
            /* 
             * FIN DES DONNÉES TEMPORAIRES
             */

            Application.Run(new FormPrincipal(factures));
        }
    }
}
