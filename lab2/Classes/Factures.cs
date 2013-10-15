using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    /*
     * Classe qui représente un groupe de factures
     * 
     */
    public class Factures
    {
        private List<Facture> listeFactures = new List<Facture>();

        public List<Facture> ListeFactures
        {
            get { return this.listeFactures; }
            set { this.listeFactures = value; }
        }

        
        //typeDeFacture doit être le nom de la classe qu'on veux utiliser :
        //  * FactureCable
        //  * FactureEpicerie
        //  * FactureUniversite

        //TODO : utiliser le constructeur de copie
        public void AjouterFacture(string typeDeFacture, string description)
        {
            if(typeDeFacture == "FactureCable")
            {
                listeFactures.Add(new FactureCable(description));
            }
            else if(typeDeFacture == "FactureEpicerie")
            {
                listeFactures.Add(new FactureEpicerie(description));
            }
            else if(typeDeFacture == "FactureUniversite")
            {
                listeFactures.Add(new FactureUniversite(description));
            }
        }

        //TODO : utiliser le constructeur de copie
        public void AjouterFacture(string typeDeFacture, int factureId, string description)
        {
            if (typeDeFacture == "FactureCable")
            {
                listeFactures.Add(new FactureCable(factureId, description));
            }
            else if (typeDeFacture == "FactureEpicerie")
            {
                listeFactures.Add(new FactureEpicerie(factureId, description));
            }
            else if (typeDeFacture == "FactureUniversite")
            {
                listeFactures.Add(new FactureUniversite(factureId, description));
            }
        }

        //Retourne une facture en fonction de son identifiant
        //Si la facture n'est pas trouvée, la fonction retourne null
        public Facture ChercherFacture(int idFacture)
        {
            foreach(Facture facture in listeFactures)
            {
                if(facture.IdFacture == idFacture)
                {
                    return facture;
                }
            }

            return null;
        }

        //Supprime une facture en fonction de son identifiant
        public void RetirerFacture(int idFacture)
        {
            for (int i=0; i < listeFactures.Count ; i++)
            {
                if(listeFactures[i].IdFacture ==  idFacture)
                {
                    listeFactures.RemoveAt(i);
                    break;
                }
            }
        }

        public Article ChercherArticle(int idArticle)
        {
            Article tempArticle;
            foreach (Facture facture in listeFactures)
            {
                tempArticle = facture.ChercherArticle(idArticle);
                if (tempArticle != null)
                {
                    return tempArticle;
                }
            }
            return null;
        }
    }
}
