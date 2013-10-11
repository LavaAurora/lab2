using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class FactureUniversite : Facture
    {
         //Nouvelle facture (ne provenant pas d'un fichier)
        public FactureUniversite(string description)
        {
            base.InitialisationFacture(description);
        }


        //Nouvelle facture (provenant d'un fichier)
        public FactureUniversite(int idFacture, string description)
        {
            base.InitialisationFacture(idFacture, description);
        }
    }
}
