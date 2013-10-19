using System;
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

        // Permet de garder en mémoire la liste des factures sélectionnées dans le DataGridViewFacture
        private List<int> listeFactureIdSelectionnees = new List<int>();

        public FormPrincipal(Factures factures)
        {
            InitializeComponent();

            // Référence à la classe de factures (permet de passer les factures entre les forms)
            this.factures = factures;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            InitialiserDataGridViewFactures();
            InitialiserDataGridViewArticles();
        }

        // Initialise et rafraîchit le tableau de données des factures
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

        // Initialise et rafraîchit le tableau de données des artciles
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

        // Lorsque l'utilisateur clique sur le bouton "Aide" du MenuStrip, le fichier d'aide s'ouvre
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

        // Lorsque l'utilisateur clique sur le bouton "Quitter" du MenuStrip, le programme se termine
        private void menuQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Lorsque l'utilisateur clique sur le bouton "Équipe" du MenuStrip, les membres de l'équipe sont affichés
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

        // Lorsque l'utilisateur clique sur le bouton "Manipulation de factures" au bas du tableau des factures,
        // la fenêtre "Manipulation des factures" s'ouvre.
        private void btnManip_Click(object sender, EventArgs e)
        {
            Formulaires.FormManipulationFactures f = new Formulaires.FormManipulationFactures(this.factures);
            f.ShowDialog();
            InitialiserDataGridViewFactures();
        }

        // Lorsque l'utilisateur clique sur la marge (de gauche) d'une rangé dans le tableau des facture, une rangé est sélectionné.
        // Se qui a pour effet de sélectionner une facture et d'afficher les articles qui y sont associés
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
            CalculerTotalArticles();
        }

        // Lorsque l'utilisateur clique sur le bouton "Retirer", en dessous des factures,
        // cette facture est retiré de la liste des factures
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
            CalculerTotalArticles();
        }

        // Lorsque l'utilisateur clique sur le bouton "Retirer", en dessous des articles,
        // cette article est retiré de la liste d'articles associée à la facture préalablement sélectionnée
        private void buttonRetirerArticle_Click(object sender, EventArgs e)
        {
            bindingSourceArticles.SuspendBinding();
            List<int> listeIdArticle = new List<int>();
            foreach (DataGridViewRow row in dataGridViewArticles.SelectedRows)
            {
                listeIdArticle.Add(int.Parse(row.Cells[0].Value.ToString()));
                row.Cells[5].Value = 0;
                row.Visible = false;
            }
            foreach (int articleId in listeIdArticle)
            {
                factures.ChercherFacture(TrouverFactureIdDeArticle(articleId)).RetirerArticle(articleId);
            }
            bindingSourceArticles.ResumeBinding();
            dataGridViewArticles.Refresh();
            CalculerTotalArticles();
        }

        // Méthode servant à trouver la facture dans laquel se retrouve un article
        // (à partir du Id d'un article)
        private int TrouverFactureIdDeArticle(int articleId)
        {
            Article tempArticle;
            foreach (int factureId in listeFactureIdSelectionnees)
            {
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

        // Calcul le total (en argent $) pour tous les articles d'une ou de plusieurs
        // factures. Ce total apparait en bas à droite de la fenêtre.
        private void CalculerTotalArticles()
        {
            decimal tempTotalArticle = 0;
            foreach(DataGridViewRow row in dataGridViewArticles.Rows)
            {
                tempTotalArticle += decimal.Parse(row.Cells[5].Value.ToString());
            }
            textBoxTotalArticles.Text = tempTotalArticle.ToString();
        }

        // Lorsque l'utilisateur clique sur le bouton "Ajouter", en bas des factures,
        // la fenêtre FormAjouterFacture sera ouverte, permettant ainsi d'ajouter une facture
        private void btnAjouterFacture_Click(object sender, EventArgs e)
        {
            Formulaires.FormAjouterFacture formAjouterFacture = new Formulaires.FormAjouterFacture(factures);
            formAjouterFacture.ShowDialog();
            InitialiserDataGridViewFactures();
        }

        // Lorsque l'utilisateur clique sur le bouton "Modifier", en bas de factures,
        // la fenêtre FormModifierFacture sera ouverte, permettant ainsi de modifier une facture
        private void btnModifierFacture_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactures.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vous devez sélectionner seulement une facture pour en faire la modification.");
            }
            else
            {
                Formulaires.FormModifierFacture formModifierFacture = new Formulaires.FormModifierFacture(  // Créer la fenêtre de modification d'une facture
                    factures.ChercherFacture(int.Parse(dataGridViewFactures.SelectedRows[0].Cells[0].Value.ToString())), //La facture à modifier
                    factures); //Liste de toutes les factures
                formModifierFacture.ShowDialog();
            }
            InitialiserDataGridViewFactures();
        }

        // Lorsque l'utilisateur clique sur le bouton "Modifier", en bas des articles,
        // la fenêtre FormModifierArticle sera ouverte, permettant ainsi de modifier un article
        private void buttonModiferArticle_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewArticles.SelectedRows.Count != 1)
            {
                MessageBox.Show("Veuillez sélectionner seulement un article.");
            }
            else
            {
                Formulaires.FormModifierArticle formModifierArticle = new Formulaires.FormModifierArticle( // Créer la fenêtre de modification d'un article
                    factures.ChercherFacture(TrouverFactureIdDeArticle( // Chercher la facture à travers la liste des factures
                    int.Parse(dataGridViewArticles.SelectedRows[0].Cells[0].Value.ToString()))). // Lui passer le Id de l'article sélectionné
                    ChercherArticle(int.Parse(dataGridViewArticles.SelectedRows[0].Cells[0].Value.ToString()))); // Chercher l'article dans la facture trouvée
                formModifierArticle.ShowDialog();
                dataGridViewFactures_RowHeaderMouseClick(null, null);
            }
        }

        // Lorsque l'utilisateur clique sur le bouton "Sauvegarder" du MenuStrip, les factures et articles sont sauvegardé
        // dans un fichier externe. Il sera alors possible de les charger.
        private void menuSauvegarder_Click(object sender, EventArgs e)
        {
            if (Classes.FacturesSerialisateur.Serialiser(this.factures))
            {
                MessageBox.Show("Sauvegarde effectuée!");
            }
            else
            {
                MessageBox.Show("Une erreur s'est produite durant la sauvegarde!");
            }
        }

        // Lorsque l'utilisateur clique sur le bouton "Charger" du MenuStrip, les factures et articles sont chargés
        // dans le programme en cours. Les anciennes données sont écrasées
        private void menuCharger_Click(object sender, EventArgs e)
        {
            Factures nouvellesFactures;

            DialogResult resultat = MessageBox.Show("Le chargement écrasera les données non sauvegardées. Voulez-vous quand même charger les données",
                "Charger des données", MessageBoxButtons.YesNo);

            if (resultat == DialogResult.Yes)
            {
                nouvellesFactures = Classes.FacturesSerialisateur.Deserialiser();

                //Si erreur lors de la désérialisation
                if (nouvellesFactures == null)
                {
                    MessageBox.Show("Impossible de charger les données!");
                }
                else
                {

                    //Écrase l'ancienne liste de factures
                    this.factures = nouvellesFactures;

                    //Réaffiche les données
                    InitialiserDataGridViewFactures();
                    InitialiserDataGridViewArticles();
                }
            }
        }

        // Lorsque l'utilisateur clique sur le bouton "Ajouter", en bas des articles,
        // la fenêtre FormAjouterArticle sera ouverte, permettant ainsi d'ajouter un article
        private void buttonAjouterArticle_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewFactures.SelectedRows.Count != 1)
            {
                MessageBox.Show("Veuillez sélectionner seulement une facture.");
            }
            else
            {
                Formulaires.FormAjouterArticle formAjouterArticle = new Formulaires.FormAjouterArticle( // Crée la fenêtre d'ajout d'un article
                    factures.ChercherFacture(int.Parse(dataGridViewFactures.SelectedRows[0].Cells[0].Value.ToString()))); // Passe la facture sélectionnée en paramètre
                formAjouterArticle.ShowDialog();
                dataGridViewFactures_RowHeaderMouseClick(null, null);
            }
        }
    }
}
