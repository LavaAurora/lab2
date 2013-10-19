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
    public partial class FormAjouterFacture : Form
    {
        private Factures factures;

        private Dictionary<string, string> dcTypeFacture = new Dictionary<string, string>();

        public FormAjouterFacture(Factures factures)
        {
            InitializeComponent();

            this.factures = factures;

            // Initialisation du dictionnaire de type de facture
            dcTypeFacture.Add("", "");
            dcTypeFacture.Add("FactureCable", "Câble");
            dcTypeFacture.Add("FactureEpicerie", "Épicerie");
            dcTypeFacture.Add("FactureUniversite", "Université");

            // Associer la source des données du Combo Box "Type de facture"
            // au dictionnaire de données
            comboBoxTypeDeFacture.DataSource = new BindingSource(dcTypeFacture, null);
            comboBoxTypeDeFacture.DisplayMember = "Value";
            comboBoxTypeDeFacture.ValueMember = "Key";
        }

        private void FormAjouterFacture_Load(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lorsque le bouton "Ajouter" est cliqué, une nouvelle facture est créé et
        // ajouté dans la liste des factures
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (comboBoxTypeDeFacture.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Veuillez entrer un type de facture.");
            }
            else if(textBoxDescription.Text.ToString() == "")
            {
                MessageBox.Show("Veuillez entrer une description de facture.");
            }
            else
            {
                factures.AjouterFacture(comboBoxTypeDeFacture.SelectedValue.ToString(), textBoxDescription.Text.ToString());
                this.Close();
            }
        }
    }
}
