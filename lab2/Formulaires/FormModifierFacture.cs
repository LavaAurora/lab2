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
    public partial class FormModifierFacture : Form
    {
        private Facture facture;
        private Factures factures;
        private Dictionary<string, string> dcTypeFacture = new Dictionary<string, string>();

        public FormModifierFacture(Facture facture, Factures factures)
        {
            InitializeComponent();

            this.facture = facture;
            this.factures = factures;

            // Initialisation du dictionnaire de type de facture
            dcTypeFacture.Add("", "");
            dcTypeFacture.Add("FactureCable", "Câble");
            dcTypeFacture.Add("FactureEpicerie", "Épicerie");
            dcTypeFacture.Add("FactureUniversite", "Université");

            // Association de la source de données du Combo Box "Type de facture" avec
            // le dictionnaire de données
            comboBoxTypeDeFacture.DataSource = new BindingSource(dcTypeFacture, null);
            comboBoxTypeDeFacture.DisplayMember = "Value";
            comboBoxTypeDeFacture.ValueMember = "Key";

            // Peupler le Combo Box "Type de facture" avec le bon type de facture préalablement choisi
            foreach (string factureType in dcTypeFacture.Keys)
            {
                if (factureType == facture.GetType().Name)
                {
                    comboBoxTypeDeFacture.SelectedValue = factureType;
                }
            }
            textBoxDescription.Text = facture.Description;
        }

        private void FormModifierFacture_Load(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Lorsque le bouton "Modifier" est cliqué, les informations de la facture préalablement sélectionné
        // sont modifier avec les nouvelles informations inscrites dans les champs
        // Prennez note qu'une vérification supplémentaire est fait pour vérifier si le type de facture choisi est différent
        // de son ancien type. Si tel est le cas, l'ancienne facture est copiée (DEEP COPY) dans la nouvelle facture.
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeDeFacture.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Veuillez entrer un type de facture.");
            }
            else if (textBoxDescription.Text.ToString() == "")
            {
                MessageBox.Show("Veuillez entrer une description de facture.");
            }
            else
            {
                facture.Description = textBoxDescription.Text;
                if(facture.GetType().Name != comboBoxTypeDeFacture.SelectedValue.ToString())
                {
                    if (comboBoxTypeDeFacture.SelectedValue.ToString() == "FactureCable")
                    {
                        FactureCable nouvelleFacture = new FactureCable(facture.Description);
                        nouvelleFacture.IdFacture = facture.IdFacture + 1;
                        nouvelleFacture.Articles = facture.Articles;
                        factures.ListeFactures.Add(nouvelleFacture);
                        factures.RetirerFacture(facture.IdFacture);
                        nouvelleFacture.IdFacture--;

                    }
                    else if (comboBoxTypeDeFacture.SelectedValue.ToString() == "FactureEpicerie")
                    {
                        FactureEpicerie nouvelleFacture = new FactureEpicerie(facture.Description);
                        nouvelleFacture.IdFacture = facture.IdFacture + 1;
                        nouvelleFacture.Articles = facture.Articles;
                        factures.ListeFactures.Add(nouvelleFacture);
                        factures.RetirerFacture(facture.IdFacture);
                        nouvelleFacture.IdFacture--;
                    }
                    else
                    {
                        FactureUniversite nouvelleFacture = new FactureUniversite(facture.Description);
                        nouvelleFacture.IdFacture = facture.IdFacture + 1;
                        nouvelleFacture.Articles = facture.Articles;
                        factures.ListeFactures.Add(nouvelleFacture);
                        factures.RetirerFacture(facture.IdFacture);
                        nouvelleFacture.IdFacture--;
                    }
                }
                this.Close();
            }
            this.Close();
        }
    }
}
