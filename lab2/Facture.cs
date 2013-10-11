using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    public abstract class Facture : IArticle
    {
        private int idFacture;                                  //Identifiant de la facture
        private static int compteurId = 5000;                   //Compteur de id
        private List<Article> articles = new List<Article>();   //Articles liés à une facture
        private string description;                             //Description de la facture

        public int IdFacture
        {
            get { return this.idFacture; }
        }

        public List<Article> Articles
        {
            get { return this.articles; }
            set { this.articles = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        //Initialisation pour une nouvelle facture
        public void InitialisationFacture(string description)
        {

            //Nouvel id du compteur
            this.idFacture = compteurId++;
            this.description = description;
        }

        //Initialisation pour une nouvelle facture qui provient d'un fichier
        public void InitialisationFacture(int idFacture, string description)
        {
            this.idFacture = idFacture;
            this.description = description;

            //Ajuste le compteur d'id pour éviter les collisions
            AjusterCompteurFactureProvenantDeFichier(idFacture);
        }

        
        private void AjusterCompteurFactureProvenantDeFichier(int nouvelIdCree)
        {
            //Si l'id ajouté peut créer une collisions de compteur d'id de facture
            if(nouvelIdCree >= compteurId)
            {
                //Ajuste le compteur pour éviter les collisions
                compteurId = nouvelIdCree + 1;
            }
        }





        /**
         * Méthodes provenant de l'interface IArticle
         * 
         */
        //Ajoute un article à la facture
        public void CreerArticle(string description, int quantite, decimal prixUnitaire, string typeTaxe)
        {
            this.articles.Add(new Article(description, quantite, prixUnitaire, typeTaxe));
        }

        //Ajoute un article à la facture
        public void CreerArticle(int articleId, string description, int quantite, decimal prixUnitaire, string typeTaxe)
        {
            this.articles.Add(new Article(articleId, description, quantite, prixUnitaire, typeTaxe));
        }

        //Ajoute un article (object) à la facture
        public void AjouerArticle(Article article)
        {
            this.articles.Add(article);
        }

        //Enlève un article en fonction de son identifiant
        public void RetirerArticle(int idArticle)
        {
            for (int i = 0; i < articles.Count; i++)
            {
                if (articles[i].IdArticle == idArticle)
                {
                    articles.RemoveAt(i);
                    break;
                }
            }
        }

        //Retourne le nombre d'articles que contient la facture
        public int RetournerNbArticle()
        {
            return this.articles.Count;

        }
        public void Sauvegarder()
        {
            //TODO : créer cette méthode
        }
        public void Charger()
        {
            //TODO : créer cette méthode
        }


    }
}
