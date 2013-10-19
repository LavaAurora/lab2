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
    public partial class FormAjouterArticle : Form
    {
        private Facture facture;

        public FormAjouterArticle(Facture facture)
        {
            InitializeComponent();

            this.facture = facture;

            comboBoxTypeDeTaxe.SelectedIndex = 0;
        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lorsque l'utilisateur appuie sur le bouton "Ajouter", cela ajoutera un article
        // à la liste d'article de la facture dans laquel elle ce trouve.
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
                facture.CreerArticle(textBoxDescription.Text, 
                    int.Parse(numericUpDownQuantite.Value.ToString()), 
                    numericUpDownPrixUnitaire.Value, 
                    comboBoxTypeDeTaxe.SelectedItem.ToString());

                this.Close();
            }
        }

        private void FormAjouterArticle_Load(object sender, EventArgs e)
        {

        }
    }
}
