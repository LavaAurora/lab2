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
        public FormPrincipal(Factures factures)
        {
            InitializeComponent();

            //Référence à la classe de factures (permet de passer les factures entre les forms)
            this.factures = factures;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

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
    }
}
