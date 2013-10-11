using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    public interface IArticle
    {
        void CreerArticle(string description, int quantite, decimal prixUnitaire, string typeTaxe);
        void CreerArticle(int articleId, string description, int quantite, decimal prixUnitaire, string typeTaxe);
        void AjouerArticle(Article article);
        void RetirerArticle(int idArticle);
        int RetournerNbArticle();
        void Sauvegarder();
        void Charger();
    }
}
