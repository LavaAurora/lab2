namespace lab2.Formulaires
{
    partial class FormAjouterFacture
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTypeDeFacture = new System.Windows.Forms.Label();
            this.comboBoxTypeDeFacture = new System.Windows.Forms.ComboBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.labelDescription);
            this.groupBox1.Controls.Add(this.labelTypeDeFacture);
            this.groupBox1.Controls.Add(this.comboBoxTypeDeFacture);
            this.groupBox1.Controls.Add(this.buttonAnnuler);
            this.groupBox1.Controls.Add(this.buttonAjouter);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 238);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter une facture";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(10, 125);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(244, 20);
            this.textBoxDescription.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(7, 108);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Description";
            // 
            // labelTypeDeFacture
            // 
            this.labelTypeDeFacture.AutoSize = true;
            this.labelTypeDeFacture.Location = new System.Drawing.Point(3, 45);
            this.labelTypeDeFacture.Name = "labelTypeDeFacture";
            this.labelTypeDeFacture.Size = new System.Drawing.Size(82, 13);
            this.labelTypeDeFacture.TabIndex = 3;
            this.labelTypeDeFacture.Text = "Type de facture";
            // 
            // comboBoxTypeDeFacture
            // 
            this.comboBoxTypeDeFacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeDeFacture.FormattingEnabled = true;
            this.comboBoxTypeDeFacture.Location = new System.Drawing.Point(6, 61);
            this.comboBoxTypeDeFacture.Name = "comboBoxTypeDeFacture";
            this.comboBoxTypeDeFacture.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTypeDeFacture.TabIndex = 2;
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
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // FormAjouterFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAjouterFacture";
            this.Text = "Ajouter une facture";
            this.Load += new System.EventHandler(this.FormAjouterFacture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Label labelTypeDeFacture;
        private System.Windows.Forms.ComboBox comboBoxTypeDeFacture;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
    }
}