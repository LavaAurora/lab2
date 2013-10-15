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


        //Nouvelle facture (provenant d'un fichier)
        public FactureCable(int idFacture, string description)
        {
            base.InitialisationFacture(idFacture, description);
        }
    }
}
