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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSauvegarder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCharger = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEADMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nomsÉquipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cIdFacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRetirerFacture = new System.Windows.Forms.Button();
            this.btnModifierFacture = new System.Windows.Forms.Button();
            this.btnAjouterFacture = new System.Windows.Forms.Button();
            this.btnManip = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnManip);
            this.groupBox1.Controls.Add(this.btnAjouterFacture);
            this.groupBox1.Controls.Add(this.btnModifierFacture);
            this.groupBox1.Controls.Add(this.btnRetirerFacture);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factures";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdFacture,
            this.cDescription});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // cIdFacture
            // 
            this.cIdFacture.HeaderText = "Factures no.";
            this.cIdFacture.Name = "cIdFacture";
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.Name = "cDescription";
            // 
            // btnRetirerFacture
            // 
            this.btnRetirerFacture.Location = new System.Drawing.Point(17, 197);
            this.btnRetirerFacture.Name = "btnRetirerFacture";
            this.btnRetirerFacture.Size = new System.Drawing.Size(75, 23);
            this.btnRetirerFacture.TabIndex = 1;
            this.btnRetirerFacture.Text = "Retirer";
            this.btnRetirerFacture.UseVisualStyleBackColor = true;
            // 
            // btnModifierFacture
            // 
            this.btnModifierFacture.Location = new System.Drawing.Point(98, 197);
            this.btnModifierFacture.Name = "btnModifierFacture";
            this.btnModifierFacture.Size = new System.Drawing.Size(75, 23);
            this.btnModifierFacture.TabIndex = 2;
            this.btnModifierFacture.Text = "Modifier";
            this.btnModifierFacture.UseVisualStyleBackColor = true;
            // 
            // btnAjouterFacture
            // 
            this.btnAjouterFacture.Location = new System.Drawing.Point(179, 197);
            this.btnAjouterFacture.Name = "btnAjouterFacture";
            this.btnAjouterFacture.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterFacture.TabIndex = 3;
            this.btnAjouterFacture.Text = "Ajouter";
            this.btnAjouterFacture.UseVisualStyleBackColor = true;
            // 
            // btnManip
            // 
            this.btnManip.Location = new System.Drawing.Point(751, 197);
            this.btnManip.Name = "btnManip";
            this.btnManip.Size = new System.Drawing.Size(168, 23);
            this.btnManip.TabIndex = 4;
            this.btnManip.Text = "Manipulation de factures";
            this.btnManip.UseVisualStyleBackColor = true;
            this.btnManip.Click += new System.EventHandler(this.btnManip_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FormPrincipal";
            this.Text = "Gestion de factures";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManip;
        private System.Windows.Forms.Button btnAjouterFacture;
        private System.Windows.Forms.Button btnModifierFacture;
        private System.Windows.Forms.Button btnRetirerFacture;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdFacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
    }
}

