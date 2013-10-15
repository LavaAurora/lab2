using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab2.Formulaires
{
    public partial class FormManipulationFactures : Form
    {
        private Factures factures;
        private Dictionary<string, string> dcTypeFacture = new Dictionary<string, string>();

        public FormManipulationFactures(Factures fac)
        { 
            InitializeComponent();

            // liste des factures globales
            this.factures = fac;

            // initialisation du dictionnaire de type de facture
            dcTypeFacture.Add("", "");
            dcTypeFacture.Add("FactureCable", "Câble");
            dcTypeFacture.Add("FactureEpicerie", "Épicerie");
            dcTypeFacture.Add("FactureUniversite", "Université");
            cmbTypeFacture.DataSource = new BindingSource(dcTypeFacture, null);
            cmbTypeFacture.DisplayMember = "Value";
            cmbTypeFacture.ValueMember = "Key";

            listeTous.DisplayMember = "description";
            liste1.DisplayMember = "description";
            liste2.DisplayMember = "description";

            grilleNouvFacture.Columns[0].DataPropertyName = "IdFacture";
            grilleNouvFacture.Columns[1].DataPropertyName = "Description";

            setProprieteGrilleDetails(grilleDetails1);
            setProprieteGrilleDetails(grilleDetails2);

        }

        // associe les colonnes de la grille avec les propriétés des factures
        private void setProprieteGrilleDetails(DataGridView d)
        {
            d.Columns[0].DataPropertyName = "idArticle";
            d.Columns[1].DataPropertyName = "description";
            d.Columns[2].DataPropertyName = "quantite";
            d.Columns[3].DataPropertyName = "prixUnitaire";
            d.Columns[4].DataPropertyName = "typeTaxe";
        }

        // fermer le formulaire
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //transfert de la liste1 vers la liste2
        private void btnList1ToList2_Click(object sender, EventArgs e)
        {
            TransfertListe(liste1, liste2);
            ChargerGrilleDetails();
        }

        //transfert de la liste2 vers la liste1
        private void btnList2ToList1_Click(object sender, EventArgs e)
        {
            TransfertListe(liste2, liste1);
            ChargerGrilleDetails();
        }

        //transfert de la listeTous à liste1
        private void btnAjoutL1_Click(object sender, EventArgs e)
        {
            TransfertListe(listeTous, liste1);
            ChargerGrilleDetails();
        }

        //transfert de la listeTous à liste2
        private void btnAjoutL2_Click(object sender, EventArgs e)
        {
            TransfertListe(listeTous, liste2);
            ChargerGrilleDetails();
        }

        //transfert de la listeX vers la listeY
        private void TransfertListe(object from, object to) 
        {

            Object[] sItems = new Object[(from as ListBox).SelectedIndices.Count];

            (from as ListBox).SelectedItems.CopyTo(sItems, 0);

            foreach (Object item in sItems)
                (from as ListBox).Items.Remove(item);

            (to as ListBox).Items.AddRange(sItems);

        }
        
        //peupler liste1 selon type de facture
        private void cmbTypeFacture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex > 0)
            {
                ViderListes();
                RafraichirFacturesListeTous();
            }
        }

        //ajouter chaque facture du type choisi
        private void RafraichirFacturesListeTous()
        {
            // ajout des factures si elles ne sont pas déjà dans les listes
            foreach (Facture f in this.factures.ListeFactures)
                if (f.GetType().Name.ToString() == cmbTypeFacture.SelectedValue.ToString()
                    && listeTous.Items.Contains(f) == false
                    && liste1.Items.Contains(f) == false
                    && liste2.Items.Contains(f) == false)
                    listeTous.Items.Add(f);

        }

        //vide les listes
        private void ViderListes()
        {
            listeTous.Items.Clear();
            liste1.Items.Clear();
            liste2.Items.Clear();
        }

        //remplir la grille facture détails avec les articles de chaque facture
        private void ChargerGrilleDetails()
        {
            srcDetails1.Clear();
            srcDetails2.Clear();

            // parcours de la liste1
            foreach (Facture f in liste1.Items)
            {
                foreach (Article a in f.Articles)
                    srcDetails1.Add(a);     
            }

            // parcours de la liste2
            foreach (Facture f in liste2.Items)
            {
                foreach (Article a in f.Articles)
                    srcDetails2.Add(a);
            }
        }

        // appel de méthode pour soustraire les factures
        private void btnSoustraireFacture_Click(object sender, EventArgs e)
        {
            // s'il y a au moins une facture dans la liste2
            if (liste2.Items.Count > 0)
                ManipulerFacture(false);
            // sinon erreur
            else
                MessageBox.Show("Veuillez spécifier au moins une facture à soustraire dans la liste2.");
        }

        // appel de méthode pour additionner les factures
        private void btnAjoutFacture_Click_1(object sender, EventArgs e)
        {
            // s'il y a au moins une facture dans la liste1
            if (liste1.Items.Count > 0)
                ManipulerFacture(true);
            // sinon erreur
            else
                MessageBox.Show("Veuillez spécifier au moins une facture à additioner dans la liste1.");
        }


        // addition ou soustraction de facture
        private void ManipulerFacture(bool additioner)
        {
            // s'assurer que la nouvelle facture à une description
            if (txtFactureNom.Text.Length > 0)
            {
                Facture temp1 = CreerFactureTemporaire("");
                Facture temp2 = CreerFactureTemporaire("");
                Facture temp3 = CreerFactureTemporaire("");

                // addition des factures de la liste1
                foreach (Facture f in liste1.Items)
                    temp1 = temp1 + f;

                // addition des factures de la liste2
                foreach (Facture f in liste2.Items)
                    temp2 = temp2 + f;

                // selon le choix
                // additioner les factures
                if (additioner)
                    temp3 = temp1 + temp2;
                // soustraire les factures
                else
                    temp3 = temp1 - temp2;

                this.factures.AjouterFacture(temp3.GetType().Name.ToString(), txtFactureNom.Text);
                this.factures.ListeFactures[this.factures.ListeFactures.Count - 1].Articles = temp3.Articles;

                srcNouvelleFacture.Add(this.factures.ListeFactures[this.factures.ListeFactures.Count - 1]);

                foreach (DataGridViewRow row in grilleNouvFacture.Rows)
                {
                    row.Cells[2].Value = this.factures.ChercherFacture(int.Parse(row.Cells[0].Value.ToString())).RetournerNbArticle();
                    row.Cells[3].Value = this.factures.ChercherFacture(int.Parse(row.Cells[0].Value.ToString())).RetournerTotalAvecTaxes();
                }

                RafraichirFacturesListeTous();
                txtFactureNom.Text = "";
            }
            else
                MessageBox.Show("Veuillez décrire la nouvelle facture.");
        }

        // instancie une facture selon le type choisi
        private Facture CreerFactureTemporaire(string desc)
        {
            Facture f = null;

            if (cmbTypeFacture.SelectedIndex == 1)
                f = new FactureCable(desc);
            else if (cmbTypeFacture.SelectedIndex == 2)
                f = new FactureEpicerie(desc);
            else if (cmbTypeFacture.SelectedIndex == 3)
                f = new FactureUniversite(desc);

            return f;
        }

        // retire une facture de la liste1 ou liste2 et la transfert dans la listeTous
        private void btnRetirer_Click(object sender, EventArgs e)
        {
            if (liste1.SelectedIndices.Count > 0)
                TransfertListe(liste1, listeTous);

            if (liste2.SelectedIndices.Count > 0)
                TransfertListe(liste2, listeTous);

            ChargerGrilleDetails();
        }

        private void FormManipulationFactures_Load(object sender, EventArgs e)
        {

        }

    }
}
