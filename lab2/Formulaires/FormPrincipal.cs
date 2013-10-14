﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace lab2
{
    public partial class FormPrincipal : Form
    {
        private Factures factures;
        private List<int> listeFactureIdSelectionnees = new List<int>();

        public FormPrincipal(Factures factures)
        {
            InitializeComponent();

            //Référence à la classe de factures (permet de passer les factures entre les forms)
            this.factures = factures;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            InitialiserDataGridViewFactures();
            InitialiserDataGridViewArticles();
        }

        public void InitialiserDataGridViewFactures()
        {
            bindingSourceFactures.DataSource = factures.ListeFactures;
            dataGridViewFactures.Columns[0].DataPropertyName = "IdFacture";
            dataGridViewFactures.Columns[1].DataPropertyName = "Description";
            dataGridViewFactures.DataSource = bindingSourceFactures;
            bindingSourceFactures.ResetBindings(false);

            foreach (DataGridViewRow row in dataGridViewFactures.Rows)
            {
                row.Cells[2].Value = factures.ChercherFacture(int.Parse(row.Cells[0].Value.ToString())).RetournerNbArticle();
                row.Cells[3].Value = factures.ChercherFacture(int.Parse(row.Cells[0].Value.ToString())).RetournerTotalAvecTaxes();
            }
        }

        private void InitialiserDataGridViewArticles()
        {
            dataGridViewArticles.Columns[0].DataPropertyName = "IdArticle";
            dataGridViewArticles.Columns[1].DataPropertyName = "Description";
            dataGridViewArticles.Columns[2].DataPropertyName = "Quantite";
            dataGridViewArticles.Columns[3].DataPropertyName = "PrixUnitaire";
            dataGridViewArticles.Columns[4].DataPropertyName = "TypeTaxe";
            dataGridViewArticles.DataSource = bindingSourceArticles;
            bindingSourceArticles.ResetBindings(false);
        }

        private void rEADMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"..\..\Documentation.docx");

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Le fichier d'aide est introuvable!");
            }
        }

        private void menuQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nomsÉquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                Process.Start(@"..\..\NomsEquipe.txt");

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Le fichier de noms d'équipe est introuvable!");
            }
        }

        private void menuSauvegarder_Click(object sender, EventArgs e)
        {

        }

        private void btnManip_Click(object sender, EventArgs e)
        {
            Formulaires.FormManipulationFactures f = new Formulaires.FormManipulationFactures(this.factures);

            f.ShowDialog();
        }

        private void dataGridViewFactures_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewArticles.Rows.Clear();
            listeFactureIdSelectionnees.Clear();
            foreach (DataGridViewRow rowFacture in dataGridViewFactures.SelectedRows)
            {
                listeFactureIdSelectionnees.Add(int.Parse(rowFacture.Cells[0].Value.ToString()));
                foreach (Article article in factures.ChercherFacture(int.Parse(rowFacture.Cells[0].Value.ToString())).Articles)
                {
                    bindingSourceArticles.Add(article);
                    dataGridViewArticles.Refresh();

                    //Assigne la colonne "Total $" du dataGridViewArticles au total d'un article d'une facture
                    dataGridViewArticles.Rows[dataGridViewArticles.Rows.Count - 1].Cells[5].Value = //Colonne "Total $"
                        factures.ChercherFacture(int.Parse(rowFacture.Cells[0].Value.ToString())).  //Trouver la facture
                        ChercherArticle(int.Parse(dataGridViewArticles.Rows[dataGridViewArticles.Rows.Count - 1].Cells[0].Value.ToString())). //Trouver l'article
                        CalculerTotalAvecTaxes(); //Calculer le total $
                }
            }
        }

        private void FormPrincipal_Activated(object sender, EventArgs e)
        {
            this.InitialiserDataGridViewFactures();
            InitialiserDataGridViewFactures();
        }

        private void btnRetirerFacture_Click(object sender, EventArgs e)
        {
            bindingSourceFactures.SuspendBinding();
            List<int> listeIdFacture = new List<int>();
            foreach (DataGridViewRow row in dataGridViewFactures.SelectedRows)
            {
                listeIdFacture.Add(int.Parse(row.Cells[0].Value.ToString()));
            }
            foreach (int factureId in listeIdFacture)
            {
                factures.RetirerFacture(factureId);
            }
            bindingSourceFactures.ResumeBinding();
            InitialiserDataGridViewFactures();
            dataGridViewArticles.Rows.Clear();
        }

        private void buttonRetirerArticle_Click(object sender, EventArgs e)
        {
            bindingSourceArticles.SuspendBinding();
            List<int> listeIdArticle = new List<int>();
            foreach (DataGridViewRow row in dataGridViewArticles.SelectedRows)
            {
                listeIdArticle.Add(int.Parse(row.Cells[0].Value.ToString()));
                row.Visible = false;
            }
            foreach (int articleId in listeIdArticle)
            {
                factures.ChercherFacture(TrouverFactureIdDeArticle(articleId)).RetirerArticle(articleId);
            }
            bindingSourceArticles.ResumeBinding();
            dataGridViewArticles.Refresh();

            InitialiserDataGridViewFactures();
        }

        private int TrouverFactureIdDeArticle(int articleId)
        {
            Article tempArticle;
            foreach (int factureId in listeFactureIdSelectionnees)
            {
                Console.WriteLine("factureId : " + factureId);
                foreach (Facture facture in factures.ListeFactures)
                {
                    if (facture.IdFacture == factureId)
                    {
                        tempArticle = facture.ChercherArticle(articleId);
                        if (tempArticle != null)
                        {
                            return factureId;
                        }
                    }
                }
            }
            return 0;
        }

    }
}
