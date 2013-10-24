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



        //Ajoute une facture. 
        //NB : Pour les besoins du TP, une facture est créé en utilisant une copie d'une 
        //     facture déjà existante de laquelle on efface les données.
        //     Si une facture est créé d'un type qui n'est pas présent dans la liste des 
        //     factures du système, la nouvelle facture sera créé sans utilisé le constructeur 
        //     de copie.
        public void AjouterFacture(string typeDeFacture, string description)
        {
            Facture factureAajouter;

            if(typeDeFacture == "FactureCable")
            {
                factureAajouter = CopierFacture(typeof(FactureCable));

                //Nouvelle facture
                if (factureAajouter == null)
                {
                    listeFactures.Add(new FactureCable(description));
                }

                //Nouvelle facture provenant d'une copie
                else
                {
                    factureAajouter.Description = description;

                    //Efface les articles de la facture
                    factureAajouter.Articles.Clear();

                    listeFactures.Add(factureAajouter);
                }
                
            }
            else if(typeDeFacture == "FactureEpicerie")
            {
                factureAajouter = CopierFacture(typeof(FactureEpicerie));

                //Nouvelle facture
                if (factureAajouter == null)
                {
                    listeFactures.Add(new FactureEpicerie(description));
                }

                //Nouvelle facture provenant d'une copie
                else
                {
                    factureAajouter.Description = description;

                    //Efface les articles de la facture
                    factureAajouter.Articles.Clear();
                    listeFactures.Add(factureAajouter);
                }
            }
            else if(typeDeFacture == "FactureUniversite")
            {
                factureAajouter = CopierFacture(typeof(FactureUniversite));

                //Nouvelle facture
                if (factureAajouter == null)
                {
                    listeFactures.Add(new FactureUniversite(description));
                }

                //Nouvelle facture provenant d'une copie
                else
                {
                    factureAajouter.Description = description;

                    //Efface les articles de la facture
                    factureAajouter.Articles.Clear();

                    listeFactures.Add(factureAajouter);
                }
            }
        }

        //Copie une facture de la liste pour un type donné.
        //Les données de la copie (articles, etc.)
        //seront effacés. 
        //Retourne null si la facture ne peut^pas être copié
        public Facture CopierFacture(Type typeDeFacture)
        {
            Facture factureModele;
            Facture nouvelleFacture;
            
            factureModele = RetournerPremiereFactureDunType(typeDeFacture);

            //Si aucune facture n'existe pour le type voulue
            if (factureModele == null)
            {
                return null;
            }


            //Une facture existe avec le type voulue

            if(typeDeFacture == typeof(FactureCable))
            {
                nouvelleFacture = new FactureCable((FactureCable)factureModele);
            }
            else if(typeDeFacture == typeof(FactureEpicerie))
            {
                nouvelleFacture = new FactureEpicerie((FactureEpicerie)factureModele);
            }
            else{
                nouvelleFacture = new FactureUniversite((FactureUniversite)factureModele);
            }
           
            


            return nouvelleFacture;
        }


        //Ajuste le compteur de id
        public void AjusterCompteurId()
        {
            int plusGrandIdCree = 5000;

             foreach(Facture f in this.ListeFactures)
             {
                 if(f.IdFacture > plusGrandIdCree)
                 {
                     plusGrandIdCree = f.IdFacture;
                 }
             }

            //Ajuste le compteur de id des factures
            Facture.compteurId = plusGrandIdCree + 1;
        }
        private Facture RetournerPremiereFactureDunType(Type typeDeFacture)
        {
            //Boucle la liste des factures de l'application et cherche la première
            //qui correspond à une facture d'un certain type (passé en paramètre)

            foreach(Facture f in this.listeFactures)
            {
                Console.WriteLine(f.GetType());
                if(f.GetType() == typeDeFacture)
                {
                    return f;
                }
                    
            }

            return null;
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
