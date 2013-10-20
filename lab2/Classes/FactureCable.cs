using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    public class FactureCable : Facture
    {
        
        //Constructeur de sérialisation
        private FactureCable() { }

        //Nouvelle facture (ne provenant pas d'un fichier)
        public FactureCable(string description)
        {
            base.InitialisationFacture(description);
        }

        //Constructeur de copie
        public FactureCable(FactureCable factureAcopier)
        {
            base.InitialisationFacture(factureAcopier.Description);

            //Copie profonde des articles
            foreach(Article a in factureAcopier.Articles)
            {
                this.Articles.Add(new Article(a.Description, a.Quantite, a.PrixUnitaire, a.TypeTaxe));
            }

        }

    }
}
