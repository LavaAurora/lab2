namespace lab2
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSauvegarder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCharger = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEADMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomsÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxFactures = new System.Windows.Forms.GroupBox();
            this.btnManip = new System.Windows.Forms.Button();
            this.btnAjouterFacture = new System.Windows.Forms.Button();
            this.btnModifierFacture = new System.Windows.Forms.Button();
            this.btnRetirerFacture = new System.Windows.Forms.Button();
            this.dataGridViewFactures = new System.Windows.Forms.DataGridView();
            this.groupBoxArticles = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSourceFactures = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceArticles = new System.Windows.Forms.BindingSource(this.components);
            this.cNoFacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNbArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            this.groupBoxFactures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactures)).BeginInit();
            this.groupBoxArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFactures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier,
            this.aideToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(949, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // menuFichier
            // 
            this.menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSauvegarder,
            this.menuCharger,
            this.menuQuitter});
            this.menuFichier.Name = "menuFichier";
            this.menuFichier.Size = new System.Drawing.Size(54, 20);
            this.menuFichier.Text = "Fichier";
            // 
            // menuSauvegarder
            // 
            this.menuSauvegarder.Name = "menuSauvegarder";
            this.menuSauvegarder.Size = new System.Drawing.Size(139, 22);
            this.menuSauvegarder.Text = "Sauvegarder";
            this.menuSauvegarder.Click += new System.EventHandler(this.menuSauvegarder_Click);
            // 
            // menuCharger
            // 
            this.menuCharger.Name = "menuCharger";
            this.menuCharger.Size = new System.Drawing.Size(139, 22);
            this.menuCharger.Text = "Charger";
            // 
            // menuQuitter
            // 
            this.menuQuitter.Name = "menuQuitter";
            this.menuQuitter.Size = new System.Drawing.Size(139, 22);
            this.menuQuitter.Text = "Quitter";
            this.menuQuitter.Click += new System.EventHandler(this.menuQuitter_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEADMEToolStripMenuItem,
            this.nomsÉquipeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // rEADMEToolStripMenuItem
            // 
            this.rEADMEToolStripMenuItem.Name = "rEADMEToolStripMenuItem";
            this.rEADMEToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.rEADMEToolStripMenuItem.Text = "Documentation";
            this.rEADMEToolStripMenuItem.Click += new System.EventHandler(this.rEADMEToolStripMenuItem_Click);
            // 
            // nomsÉquipeToolStripMenuItem
            // 
            this.nomsÉquipeToolStripMenuItem.Name = "nomsÉquipeToolStripMenuItem";
            this.nomsÉquipeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.nomsÉquipeToolStripMenuItem.Text = "Noms équipe";
            this.nomsÉquipeToolStripMenuItem.Click += new System.EventHandler(this.nomsÉquipeToolStripMenuItem_Click);
            // 
            // groupBoxFactures
            // 
            this.groupBoxFactures.Controls.Add(this.btnManip);
            this.groupBoxFactures.Controls.Add(this.btnAjouterFacture);
            this.groupBoxFactures.Controls.Add(this.btnModifierFacture);
            this.groupBoxFactures.Controls.Add(this.btnRetirerFacture);
            this.groupBoxFactures.Controls.Add(this.dataGridViewFactures);
            this.groupBoxFactures.Location = new System.Drawing.Point(12, 27);
            this.groupBoxFactures.Name = "groupBoxFactures";
            this.groupBoxFactures.Size = new System.Drawing.Size(925, 209);
            this.groupBoxFactures.TabIndex = 1;
            this.groupBoxFactures.TabStop = false;
            this.groupBoxFactures.Text = "Factures";
            // 
            // btnManip
            // 
            this.btnManip.Location = new System.Drawing.Point(751, 179);
            this.btnManip.Name = "btnManip";
            this.btnManip.Size = new System.Drawing.Size(168, 23);
            this.btnManip.TabIndex = 4;
            this.btnManip.Text = "Manipulation de factures";
            this.btnManip.UseVisualStyleBackColor = true;
            this.btnManip.Click += new System.EventHandler(this.btnManip_Click);
            // 
            // btnAjouterFacture
            // 
            this.btnAjouterFacture.Location = new System.Drawing.Point(168, 179);
            this.btnAjouterFacture.Name = "btnAjouterFacture";
            this.btnAjouterFacture.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterFacture.TabIndex = 3;
            this.btnAjouterFacture.Text = "Ajouter";
            this.btnAjouterFacture.UseVisualStyleBackColor = true;
            // 
            // btnModifierFacture
            // 
            this.btnModifierFacture.Location = new System.Drawing.Point(87, 179);
            this.btnModifierFacture.Name = "btnModifierFacture";
            this.btnModifierFacture.Size = new System.Drawing.Size(75, 23);
            this.btnModifierFacture.TabIndex = 2;
            this.btnModifierFacture.Text = "Modifier";
            this.btnModifierFacture.UseVisualStyleBackColor = true;
            // 
            // btnRetirerFacture
            // 
            this.btnRetirerFacture.Location = new System.Drawing.Point(6, 179);
            this.btnRetirerFacture.Name = "btnRetirerFacture";
            this.btnRetirerFacture.Size = new System.Drawing.Size(75, 23);
            this.btnRetirerFacture.TabIndex = 1;
            this.btnRetirerFacture.Text = "Retirer";
            this.btnRetirerFacture.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFactures
            // 
            this.dataGridViewFactures.AutoGenerateColumns = false;
            this.dataGridViewFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNoFacture,
            this.cDescription,
            this.cNbArticle,
            this.cTotal});
            this.dataGridViewFactures.DataSource = this.bindingSourceFactures;
            this.dataGridViewFactures.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFactures.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewFactures.Name = "dataGridViewFactures";
            this.dataGridViewFactures.Size = new System.Drawing.Size(919, 157);
            this.dataGridViewFactures.TabIndex = 0;
            // 
            // groupBoxArticles
            // 
            this.groupBoxArticles.Controls.Add(this.label1);
            this.groupBoxArticles.Controls.Add(this.textBox1);
            this.groupBoxArticles.Controls.Add(this.button2);
            this.groupBoxArticles.Controls.Add(this.button3);
            this.groupBoxArticles.Controls.Add(this.button4);
            this.groupBoxArticles.Controls.Add(this.dataGridViewArticles);
            this.groupBoxArticles.Location = new System.Drawing.Point(12, 242);
            this.groupBoxArticles.Name = "groupBoxArticles";
            this.groupBoxArticles.Size = new System.Drawing.Size(925, 209);
            this.groupBoxArticles.TabIndex = 2;
            this.groupBoxArticles.TabStop = false;
            this.groupBoxArticles.Text = "Articles";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(168, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 179);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Retirer";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewArticles.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewArticles.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.Size = new System.Drawing.Size(919, 157);
            this.dataGridViewArticles.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Factures no.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(819, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total :";
            // 
            // cNoFacture
            // 
            this.cNoFacture.HeaderText = "No. facture";
            this.cNoFacture.Name = "cNoFacture";
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.Name = "cDescription";
            // 
            // cNbArticle
            // 
            this.cNbArticle.HeaderText = "Nb. d\'article";
            this.cNbArticle.Name = "cNbArticle";
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total";
            this.cTotal.Name = "cTotal";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 531);
            this.Controls.Add(this.groupBoxArticles);
            this.Controls.Add(this.groupBoxFactures);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FormPrincipal";
            this.Text = "Gestion de factures";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBoxFactures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactures)).EndInit();
            this.groupBoxArticles.ResumeLayout(false);
            this.groupBoxArticles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFactures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFichier;
        private System.Windows.Forms.ToolStripMenuItem menuSauvegarder;
        private System.Windows.Forms.ToolStripMenuItem menuCharger;
        private System.Windows.Forms.ToolStripMenuItem menuQuitter;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEADMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nomsÉquipeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxFactures;
        private System.Windows.Forms.Button btnManip;
        private System.Windows.Forms.Button btnAjouterFacture;
        private System.Windows.Forms.Button btnModifierFacture;
        private System.Windows.Forms.Button btnRetirerFacture;
        private System.Windows.Forms.DataGridView dataGridViewFactures;
        private System.Windows.Forms.GroupBox groupBoxArticles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bindingSourceFactures;
        private System.Windows.Forms.BindingSource bindingSourceArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoFacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNbArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
    }
}

