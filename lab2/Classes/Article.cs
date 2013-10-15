using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace lab2
{
    public class Article
    {
        private const double TPS = 0.05;
        private const double TVQ = 0.09975;
        
        private int idArticle;                      //Identifiant de l'article
        private static int compteurId = 7000;       //Compteur d'identifiant d'article
        private string description;                 //Description de l'article
        private int quantite;
        private decimal prixUnitaire;
        private string typeTaxe;                    //Taxe fédérale ou provinciale {F, P, FP}


        public int IdArticle
        {
            get { return this.idArticle; }
            set { this.idArticle = value; }    //Pour sérialisation uniquement

        }

       
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public int Quantite
        {
            get { return this.quantite; }
            set { this.quantite = value; }
        }

        public decimal PrixUnitaire
        {
            get { return this.prixUnitaire; }
            set { this.prixUnitaire = value; }
        }

        public string TypeTaxe
        {
            get { return this.typeTaxe; }
            set { this.typeTaxe = value; }
        }

        //Constructeur de sérialisation
        private Article() {}

        //Crée un article (ne provenant pas d'un fichier)
        public Article(string description, int quantite, decimal prixUnitaire, string typeTaxe)
        {
            this.idArticle = compteurId++;
            this.description = description;
            this.quantite = quantite;
            this.prixUnitaire = prixUnitaire;
            this.typeTaxe = typeTaxe.ToUpper();
        }

        //Crée un article (provenant d'un fichier)
        public Article(int idArticle, string description, int quantite, decimal prixUnitaire, string typeTaxe)
        {
            this.idArticle = idArticle;
            this.description = description;
            this.quantite = quantite;
            this.prixUnitaire = prixUnitaire;
            this.typeTaxe = typeTaxe.ToUpper();

            //Ajuste le compteur d'id pour éviter les collisions
            AjusterCompteurArticleProvenantDeFichier(idArticle);
        }

        
        private void AjusterCompteurArticleProvenantDeFichier(int nouvelIdCree)
        {
            //Si l'id ajouté peut créer une collisions de compteur d'id de facture
            if (nouvelIdCree >= compteurId)
            {
                //Ajuste le compteur pour éviter les collisions
                compteurId = nouvelIdCree + 1;
            }
        }

        //Montant avant taxe (qté * prix unitaire)
        public decimal CalculerSousTotal()
        {
            return quantite * prixUnitaire;
        }

        
        //Retourne le montant total incluant la TPS et TVQ (si applicable)
        //À noter la TVQ se calcule maintenant sur le montant EXCLUANT la TPS
        //voir http://www.revenuquebec.ca/fr/entreprise/taxes/tvq_tps/
        public decimal CalculerTotalAvecTaxes()
        { 
            decimal montant = CalculerSousTotal();  //Sous total
            decimal totalTPS = 0;
            decimal totalTVQ = 0;

            //Si TPS applicable
            if (typeTaxe.Contains('F'))
            {
                totalTPS = this.CalculerTPS(montant);
            }
            //Si TVQ applicable
            if(typeTaxe.Contains('P'))
            {
                totalTVQ += this.CalculerTVQ(montant);
            }


            return montant + totalTPS + totalTVQ;
        }

        //Retourne le montant de la TPS (taxe uniquement)
        private decimal CalculerTPS(decimal montant)
        {

            return montant * (decimal)TPS;
        }

        //Retourne le montant de la TVQ (taxe uniquement)
        private decimal CalculerTVQ(decimal montant)
        {

            return montant * (decimal)TVQ;
        }
    }

    
}
