using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab2.Formulaires
{
    public partial class FormModifierArticle : Form
    {
        private Article article;

        public FormModifierArticle(Article article)
        {
            InitializeComponent();

            this.article = article;

            // Peupler les champs avec les informations correspondant de l'article à modifier
            textBoxDescription.Text = article.Description;
            numericUpDownQuantite.Value = article.Quantite;
            numericUpDownPrixUnitaire.Value = article.PrixUnitaire;
            comboBoxTypeDeTaxe.SelectedItem = article.TypeTaxe;
        }

        private void FormModifierArticle_Load(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lorsque le bouton "Modifier" est cliqué, les informations de l'article préalablement choisi sont
        // modifié avec les nouvelles informations inscrites dans les champs
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (int.Parse(numericUpDownQuantite.Value.ToString()) <= 0)
            {
                MessageBox.Show("La quantité doit être plus grande que 0.");
            }
            else if (numericUpDownPrixUnitaire.Value < 0)
            {
                MessageBox.Show("Le prix unitaire ne doit pas être négatif.");
            }
            else
            {
                article.Description = textBoxDescription.Text;
                article.Quantite = int.Parse(numericUpDownQuantite.Value.ToString());
                article.PrixUnitaire = numericUpDownPrixUnitaire.Value;
                article.TypeTaxe = comboBoxTypeDeTaxe.SelectedItem.ToString();
            }
            this.Close();
        }
    }
}
