using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace lab2
{
    public class FactureEpicerie : Facture
    {
        //Constructeur de sérialisation
        private FactureEpicerie() { }

        //Nouvelle facture (ne provenant pas d'un fichier)
        public FactureEpicerie(string description)
        {
            base.InitialisationFacture(description);
        }


        //Nouvelle facture (provenant d'un fichier)
        public FactureEpicerie(int idFacture, string description)
        {
            base.InitialisationFacture(idFacture, description);
        }

        
    }
}
