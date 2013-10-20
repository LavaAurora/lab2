﻿using System;
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

        //Constructeur de copie
        public FactureEpicerie(FactureEpicerie factureAcopier)
        {
            base.InitialisationFacture(factureAcopier.Description);

            //Copie profonde des articles
            foreach (Article a in factureAcopier.Articles)
            {
                this.Articles.Add(new Article(a.Description, a.Quantite, a.PrixUnitaire, a.TypeTaxe));
            }

        }

    }
}
