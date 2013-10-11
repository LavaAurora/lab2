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
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFichier,
            this.aideToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(766, 24);
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
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 256);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
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
    }
}

