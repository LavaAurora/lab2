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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cNoFacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNbArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceFactures = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxArticles = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalArticles = new System.Windows.Forms.TextBox();
            this.buttonAjouterArticle = new System.Windows.Forms.Button();
            this.buttonModifierArticle = new System.Windows.Forms.Button();
            this.buttonRetirerArticle = new System.Windows.Forms.Button();
            this.dataGridViewArticles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrixUnitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTypeTaxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceArticles = new System.Windows.Forms.BindingSource(this.components);
            this.menu.SuspendLayout();
            this.groupBoxFactures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFactures)).BeginInit();
            this.groupBoxArticles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).BeginInit();
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
            this.menuSauvegarder.Size = new System.Drawing.Size(152, 22);
            this.menuSauvegarder.Text = "Sauvegarder";
            this.menuSauvegarder.Click += new System.EventHandler(this.menuSauvegarder_Click);
            // 
            // menuCharger
            // 
            this.menuCharger.Name = "menuCharger";
            this.menuCharger.Size = new System.Drawing.Size(152, 22);
            this.menuCharger.Text = "Charger";
            this.menuCharger.Click += new System.EventHandler(this.menuCharger_Click);
            // 
            // menuQuitter
            // 
            this.menuQuitter.Name = "menuQuitter";
            this.menuQuitter.Size = new System.Drawing.Size(152, 22);
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
            this.btnAjouterFacture.Click += new System.EventHandler(this.btnAjouterFacture_Click);
            // 
            // btnModifierFacture
            // 
            this.btnModifierFacture.Location = new System.Drawing.Point(87, 179);
            this.btnModifierFacture.Name = "btnModifierFacture";
            this.btnModifierFacture.Size = new System.Drawing.Size(75, 23);
            this.btnModifierFacture.TabIndex = 2;
            this.btnModifierFacture.Text = "Modifier";
            this.btnModifierFacture.UseVisualStyleBackColor = true;
            this.btnModifierFacture.Click += new System.EventHandler(this.btnModifierFacture_Click);
            // 
            // btnRetirerFacture
            // 
            this.btnRetirerFacture.Location = new System.Drawing.Point(6, 179);
            this.btnRetirerFacture.Name = "btnRetirerFacture";
            this.btnRetirerFacture.Size = new System.Drawing.Size(75, 23);
            this.btnRetirerFacture.TabIndex = 1;
            this.btnRetirerFacture.Text = "Retirer";
            this.btnRetirerFacture.UseVisualStyleBackColor = true;
            this.btnRetirerFacture.Click += new System.EventHandler(this.btnRetirerFacture_Click);
            // 
            // dataGridViewFactures
            // 
            this.dataGridViewFactures.AllowUserToAddRows = false;
            this.dataGridViewFactures.AllowUserToDeleteRows = false;
            this.dataGridViewFactures.AutoGenerateColumns = false;
            this.dataGridViewFactures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFactures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNoFacture,
            this.cDescription,
            this.cNbArticle,
            this.cTotal});
            this.dataGridViewFactures.DataSource = this.bindingSourceFactures;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFactures.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFactures.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewFactures.Name = "dataGridViewFactures";
            this.dataGridViewFactures.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFactures.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFactures.Size = new System.Drawing.Size(919, 157);
            this.dataGridViewFactures.TabIndex = 0;
            this.dataGridViewFactures.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFactures_RowHeaderMouseClick);
            // 
            // cNoFacture
            // 
            this.cNoFacture.HeaderText = "No. facture";
            this.cNoFacture.Name = "cNoFacture";
            this.cNoFacture.ReadOnly = true;
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.Name = "cDescription";
            this.cDescription.ReadOnly = true;
            // 
            // cNbArticle
            // 
            this.cNbArticle.HeaderText = "Nb. d\'article";
            this.cNbArticle.Name = "cNbArticle";
            this.cNbArticle.ReadOnly = true;
            // 
            // cTotal
            // 
            this.cTotal.HeaderText = "Total $";
            this.cTotal.Name = "cTotal";
            this.cTotal.ReadOnly = true;
            // 
            // groupBoxArticles
            // 
            this.groupBoxArticles.Controls.Add(this.label1);
            this.groupBoxArticles.Controls.Add(this.textBoxTotalArticles);
            this.groupBoxArticles.Controls.Add(this.buttonAjouterArticle);
            this.groupBoxArticles.Controls.Add(this.buttonModifierArticle);
            this.groupBoxArticles.Controls.Add(this.buttonRetirerArticle);
            this.groupBoxArticles.Controls.Add(this.dataGridViewArticles);
            this.groupBoxArticles.Location = new System.Drawing.Point(12, 242);
            this.groupBoxArticles.Name = "groupBoxArticles";
            this.groupBoxArticles.Size = new System.Drawing.Size(925, 209);
            this.groupBoxArticles.TabIndex = 2;
            this.groupBoxArticles.TabStop = false;
            this.groupBoxArticles.Text = "Articles";
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
            // textBoxTotalArticles
            // 
            this.textBoxTotalArticles.Location = new System.Drawing.Point(819, 179);
            this.textBoxTotalArticles.Name = "textBoxTotalArticles";
            this.textBoxTotalArticles.ReadOnly = true;
            this.textBoxTotalArticles.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalArticles.TabIndex = 4;
            // 
            // buttonAjouterArticle
            // 
            this.buttonAjouterArticle.Location = new System.Drawing.Point(168, 179);
            this.buttonAjouterArticle.Name = "buttonAjouterArticle";
            this.buttonAjouterArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouterArticle.TabIndex = 3;
            this.buttonAjouterArticle.Text = "Ajouter";
            this.buttonAjouterArticle.UseVisualStyleBackColor = true;
            this.buttonAjouterArticle.Click += new System.EventHandler(this.buttonAjouterArticle_Click_1);
            // 
            // buttonModifierArticle
            // 
            this.buttonModifierArticle.Location = new System.Drawing.Point(87, 179);
            this.buttonModifierArticle.Name = "buttonModifierArticle";
            this.buttonModifierArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonModifierArticle.TabIndex = 2;
            this.buttonModifierArticle.Text = "Modifier";
            this.buttonModifierArticle.UseVisualStyleBackColor = true;
            this.buttonModifierArticle.Click += new System.EventHandler(this.buttonModiferArticle_Click_1);
            // 
            // buttonRetirerArticle
            // 
            this.buttonRetirerArticle.Location = new System.Drawing.Point(6, 179);
            this.buttonRetirerArticle.Name = "buttonRetirerArticle";
            this.buttonRetirerArticle.Size = new System.Drawing.Size(75, 23);
            this.buttonRetirerArticle.TabIndex = 1;
            this.buttonRetirerArticle.Text = "Retirer";
            this.buttonRetirerArticle.UseVisualStyleBackColor = true;
            this.buttonRetirerArticle.Click += new System.EventHandler(this.buttonRetirerArticle_Click);
            // 
            // dataGridViewArticles
            // 
            this.dataGridViewArticles.AllowUserToAddRows = false;
            this.dataGridViewArticles.AllowUserToDeleteRows = false;
            this.dataGridViewArticles.AutoGenerateColumns = false;
            this.dataGridViewArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.cQuantite,
            this.cPrixUnitaire,
            this.cTypeTaxe,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewArticles.DataSource = this.bindingSourceArticles;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewArticles.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewArticles.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewArticles.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewArticles.Name = "dataGridViewArticles";
            this.dataGridViewArticles.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewArticles.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewArticles.Size = new System.Drawing.Size(919, 157);
            this.dataGridViewArticles.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cNoArticle";
            this.dataGridViewTextBoxColumn1.HeaderText = "No. article";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cDescription";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // cQuantite
            // 
            this.cQuantite.HeaderText = "Quantité";
            this.cQuantite.Name = "cQuantite";
            this.cQuantite.ReadOnly = true;
            // 
            // cPrixUnitaire
            // 
            this.cPrixUnitaire.HeaderText = "Prix unitaire";
            this.cPrixUnitaire.Name = "cPrixUnitaire";
            this.cPrixUnitaire.ReadOnly = true;
            // 
            // cTypeTaxe
            // 
            this.cTypeTaxe.HeaderText = "Type de taxe";
            this.cTypeTaxe.Name = "cTypeTaxe";
            this.cTypeTaxe.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Total $";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFactures)).EndInit();
            this.groupBoxArticles.ResumeLayout(false);
            this.groupBoxArticles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticles)).EndInit();
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
        private System.Windows.Forms.TextBox textBoxTotalArticles;
        private System.Windows.Forms.Button buttonAjouterArticle;
        private System.Windows.Forms.Button buttonModifierArticle;
        private System.Windows.Forms.Button buttonRetirerArticle;
        private System.Windows.Forms.DataGridView dataGridViewArticles;
        private System.Windows.Forms.BindingSource bindingSourceFactures;
        private System.Windows.Forms.BindingSource bindingSourceArticles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNoFacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNbArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrixUnitaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTypeTaxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

