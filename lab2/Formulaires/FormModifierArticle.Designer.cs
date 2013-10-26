namespace lab2.Formulaires
{
    partial class FormModifierArticle
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
            this.numericUpDownPrixUnitaire = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownQuantite = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTypeDeTaxe = new System.Windows.Forms.Label();
            this.comboBoxTypeDeTaxe = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrixUnitaire)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownPrixUnitaire
            // 
            this.numericUpDownPrixUnitaire.DecimalPlaces = 2;
            this.numericUpDownPrixUnitaire.Location = new System.Drawing.Point(10, 129);
            this.numericUpDownPrixUnitaire.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownPrixUnitaire.Name = "numericUpDownPrixUnitaire";
            this.numericUpDownPrixUnitaire.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownPrixUnitaire.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prix unitaire";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownPrixUnitaire);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownQuantite);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.labelTypeDeTaxe);
            this.groupBox1.Controls.Add(this.comboBoxTypeDeTaxe);
            this.groupBox1.Controls.Add(this.buttonAnnuler);
            this.groupBox1.Controls.Add(this.buttonAjouter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 238);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modifier un article";
            // 
            // numericUpDownQuantite
            // 
            this.numericUpDownQuantite.Location = new System.Drawing.Point(10, 85);
            this.numericUpDownQuantite.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownQuantite.Name = "numericUpDownQuantite";
            this.numericUpDownQuantite.Size = new System.Drawing.Size(56, 20);
            this.numericUpDownQuantite.TabIndex = 7;
            this.numericUpDownQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantité";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(9, 41);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(244, 20);
            this.textBoxDescription.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(6, 24);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // labelTypeDeTaxe
            // 
            this.labelTypeDeTaxe.AutoSize = true;
            this.labelTypeDeTaxe.Location = new System.Drawing.Point(3, 157);
            this.labelTypeDeTaxe.Name = "labelTypeDeTaxe";
            this.labelTypeDeTaxe.Size = new System.Drawing.Size(69, 13);
            this.labelTypeDeTaxe.TabIndex = 3;
            this.labelTypeDeTaxe.Text = "Type de taxe";
            // 
            // comboBoxTypeDeTaxe
            // 
            this.comboBoxTypeDeTaxe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeDeTaxe.FormattingEnabled = true;
            this.comboBoxTypeDeTaxe.Items.AddRange(new object[] {
            "",
            "F",
            "P",
            "FP"});
            this.comboBoxTypeDeTaxe.Location = new System.Drawing.Point(6, 173);
            this.comboBoxTypeDeTaxe.Name = "comboBoxTypeDeTaxe";
            this.comboBoxTypeDeTaxe.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeDeTaxe.TabIndex = 2;
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(98, 209);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuler.TabIndex = 1;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(179, 209);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouter.TabIndex = 0;
            this.buttonAjouter.Text = "Modifier";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // FormModifierArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormModifierArticle";
            this.Text = "Modifier un article";
            this.Load += new System.EventHandler(this.FormModifierArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrixUnitaire)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownPrixUnitaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTypeDeTaxe;
        private System.Windows.Forms.ComboBox comboBoxTypeDeTaxe;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
    }
}