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
    public partial class FormManipulationFactures : Form
    {
        private Factures factures;
        private List<Facture> lFacturesTous = new List<Facture>();
        private List<Facture> lFactures1 = new List<Facture>();
        private List<Facture> lFactures2 = new List<Facture>();
        private Dictionary<string, string> dcTypeFacture = new Dictionary<string, string>();

        public FormManipulationFactures(Factures fac)
        { 
            InitializeComponent();

            this.factures = fac;

            dcTypeFacture.Add("", "");
            dcTypeFacture.Add("FactureCable", "Câble");
            dcTypeFacture.Add("FactureEpicerie", "Épicerie");
            dcTypeFacture.Add("FactureUniversite", "Université");
            cmbTypeFacture.DataSource = new BindingSource(dcTypeFacture, null);
            cmbTypeFacture.DisplayMember = "Value";
            cmbTypeFacture.ValueMember = "Key";

            ///////////////////////////////////////////////////
            //TEMPO
            ///////////////////////////////////////////////////
            //foreach(Facture f in this.factures.ListeFactures)
              //  lFactures1.Add(f);

            //liste1.Items.AddRange(lFactures1.ToArray());

            //srcList1.DataSource = lFactures1;

            ///////////////////////////////////////////////////
            //FIN TEMPO
            ///////////////////////////////////////////////////

            listeTous.DisplayMember = "description";
            liste1.DisplayMember = "description";
            liste2.DisplayMember = "description";

            setProprieteGrilleDetails(grilleDetails1);
            setProprieteGrilleDetails(grilleDetails2);

        }

        private void setProprieteGrilleDetails(DataGridView d)
        {
            d.Columns[0].DataPropertyName = "idArticle";
            d.Columns[1].DataPropertyName = "description";
            d.Columns[2].DataPropertyName = "quantite";
            d.Columns[3].DataPropertyName = "prixUnitaire";
            d.Columns[4].DataPropertyName = "typeTaxe";
        }

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

        private void btnAjoutFacture_Click(object sender, EventArgs e)
        {

        }

        
        //peupler liste1 selon type de facture
        private void cmbTypeFacture_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex > 0)
            {
                viderListes();

                //ajouter chaque facture du type choisi
                foreach (Facture f in this.factures.ListeFactures)
                    if (f.GetType().Name.ToString() == (sender as ComboBox).SelectedValue.ToString())
                        listeTous.Items.Add(f);

                //listeTous.Items.AddRange(lFacturesTous.ToArray());

            }
        }

        private void viderListes()
        {
            //vider les listes
            listeTous.Items.Clear();
            lFacturesTous.Clear();
            lFactures1.Clear();
            liste1.Items.Clear();
            lFactures2.Clear();
            liste2.Items.Clear();
        }

        //remplir la grille facture détails avec les articles de chaque facture
        private void ChargerGrilleDetails()
        {
            srcDetails1.Clear();
            srcDetails2.Clear();

            foreach (Facture f in liste1.Items)
            {
                foreach (Article a in f.Articles)
                    srcDetails1.Add(a);     
            }

            foreach (Facture f in liste2.Items)
            {
                foreach (Article a in f.Articles)
                    srcDetails2.Add(a);
            }
        }

    }
}
