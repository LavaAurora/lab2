namespace lab2.Formulaires
{
    partial class FormManipulationFactures
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.liste1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.liste2 = new System.Windows.Forms.ListBox();
            this.btnList2ToList1 = new System.Windows.Forms.Button();
            this.btnList1ToList2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAjoutL2 = new System.Windows.Forms.Button();
            this.btnAjoutL1 = new System.Windows.Forms.Button();
            this.listeTous = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTypeFacture = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAsoustraireFacture = new System.Windows.Forms.Button();
            this.btnAjoutFacture = new System.Windows.Forms.Button();
            this.grilleDetails1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.srcDetails1 = new System.Windows.Forms.BindingSource(this.components);
            this.grilleDetails2 = new System.Windows.Forms.DataGridView();
            this.idArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyListe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srcDetails2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnRetirer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilleDetails1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcDetails1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleDetails2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcDetails2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.liste1);
            this.groupBox1.Location = new System.Drawing.Point(558, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste1";
            // 
            // liste1
            // 
            this.liste1.FormattingEnabled = true;
            this.liste1.Location = new System.Drawing.Point(6, 19);
            this.liste1.Name = "liste1";
            this.liste1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.liste1.Size = new System.Drawing.Size(172, 186);
            this.liste1.Sorted = true;
            this.liste1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.liste2);
            this.groupBox2.Location = new System.Drawing.Point(877, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste2";
            // 
            // liste2
            // 
            this.liste2.FormattingEnabled = true;
            this.liste2.Location = new System.Drawing.Point(6, 19);
            this.liste2.Name = "liste2";
            this.liste2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.liste2.Size = new System.Drawing.Size(172, 186);
            this.liste2.Sorted = true;
            this.liste2.TabIndex = 0;
            // 
            // btnList2ToList1
            // 
            this.btnList2ToList1.Location = new System.Drawing.Point(771, 92);
            this.btnList2ToList1.Name = "btnList2ToList1";
            this.btnList2ToList1.Size = new System.Drawing.Size(75, 23);
            this.btnList2ToList1.TabIndex = 2;
            this.btnList2ToList1.Text = "<<";
            this.btnList2ToList1.UseVisualStyleBackColor = true;
            this.btnList2ToList1.Click += new System.EventHandler(this.btnList2ToList1_Click);
            // 
            // btnList1ToList2
            // 
            this.btnList1ToList2.Location = new System.Drawing.Point(771, 63);
            this.btnList1ToList2.Name = "btnList1ToList2";
            this.btnList1ToList2.Size = new System.Drawing.Size(75, 23);
            this.btnList1ToList2.TabIndex = 3;
            this.btnList1ToList2.Text = ">>";
            this.btnList1ToList2.UseVisualStyleBackColor = true;
            this.btnList1ToList2.Click += new System.EventHandler(this.btnList1ToList2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(986, 862);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAjoutL2);
            this.groupBox3.Controls.Add(this.btnAjoutL1);
            this.groupBox3.Controls.Add(this.listeTous);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbTypeFacture);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 209);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choix du type de facture";
            // 
            // btnAjoutL2
            // 
            this.btnAjoutL2.Location = new System.Drawing.Point(427, 80);
            this.btnAjoutL2.Name = "btnAjoutL2";
            this.btnAjoutL2.Size = new System.Drawing.Size(99, 23);
            this.btnAjoutL2.TabIndex = 4;
            this.btnAjoutL2.Text = "Ajouter Liste2";
            this.btnAjoutL2.UseVisualStyleBackColor = true;
            this.btnAjoutL2.Click += new System.EventHandler(this.btnAjoutL2_Click);
            // 
            // btnAjoutL1
            // 
            this.btnAjoutL1.Location = new System.Drawing.Point(427, 51);
            this.btnAjoutL1.Name = "btnAjoutL1";
            this.btnAjoutL1.Size = new System.Drawing.Size(99, 23);
            this.btnAjoutL1.TabIndex = 3;
            this.btnAjoutL1.Text = "Ajouter Liste1";
            this.btnAjoutL1.UseVisualStyleBackColor = true;
            this.btnAjoutL1.Click += new System.EventHandler(this.btnAjoutL1_Click);
            // 
            // listeTous
            // 
            this.listeTous.FormattingEnabled = true;
            this.listeTous.Location = new System.Drawing.Point(9, 51);
            this.listeTous.Name = "listeTous";
            this.listeTous.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listeTous.Size = new System.Drawing.Size(408, 147);
            this.listeTous.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type de facture";
            // 
            // cmbTypeFacture
            // 
            this.cmbTypeFacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeFacture.FormattingEnabled = true;
            this.cmbTypeFacture.Items.AddRange(new object[] {
            "",
            "Cable",
            "Épicerie",
            "Université"});
            this.cmbTypeFacture.Location = new System.Drawing.Point(94, 19);
            this.cmbTypeFacture.Name = "cmbTypeFacture";
            this.cmbTypeFacture.Size = new System.Drawing.Size(323, 21);
            this.cmbTypeFacture.TabIndex = 0;
            this.cmbTypeFacture.SelectedIndexChanged += new System.EventHandler(this.cmbTypeFacture_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grilleDetails2);
            this.groupBox4.Controls.Add(this.btnAsoustraireFacture);
            this.groupBox4.Controls.Add(this.btnAjoutFacture);
            this.groupBox4.Controls.Add(this.grilleDetails1);
            this.groupBox4.Location = new System.Drawing.Point(12, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1049, 346);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Détails des factures";
            // 
            // btnAsoustraireFacture
            // 
            this.btnAsoustraireFacture.Location = new System.Drawing.Point(887, 317);
            this.btnAsoustraireFacture.Name = "btnAsoustraireFacture";
            this.btnAsoustraireFacture.Size = new System.Drawing.Size(75, 23);
            this.btnAsoustraireFacture.TabIndex = 6;
            this.btnAsoustraireFacture.Text = "Soustraire";
            this.btnAsoustraireFacture.UseVisualStyleBackColor = true;
            this.btnAsoustraireFacture.Click += new System.EventHandler(this.btnAsoustraireFacture_Click);
            // 
            // btnAjoutFacture
            // 
            this.btnAjoutFacture.Location = new System.Drawing.Point(968, 317);
            this.btnAjoutFacture.Name = "btnAjoutFacture";
            this.btnAjoutFacture.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutFacture.TabIndex = 5;
            this.btnAjoutFacture.Text = "Ajouter";
            this.btnAjoutFacture.UseVisualStyleBackColor = true;
            this.btnAjoutFacture.Click += new System.EventHandler(this.btnAjoutFacture_Click_1);
            // 
            // grilleDetails1
            // 
            this.grilleDetails1.AutoGenerateColumns = false;
            this.grilleDetails1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleDetails1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleDetails1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticle,
            this.description,
            this.qtyListe1,
            this.prix,
            this.taxe});
            this.grilleDetails1.DataSource = this.srcDetails1;
            this.grilleDetails1.Location = new System.Drawing.Point(3, 16);
            this.grilleDetails1.Name = "grilleDetails1";
            this.grilleDetails1.Size = new System.Drawing.Size(537, 295);
            this.grilleDetails1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(21, 579);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1049, 264);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nouvelles factures";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1043, 245);
            this.dataGridView2.TabIndex = 0;
            // 
            // grilleDetails2
            // 
            this.grilleDetails2.AutoGenerateColumns = false;
            this.grilleDetails2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleDetails2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleDetails2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.grilleDetails2.DataSource = this.srcDetails2;
            this.grilleDetails2.Location = new System.Drawing.Point(552, 16);
            this.grilleDetails2.Name = "grilleDetails2";
            this.grilleDetails2.Size = new System.Drawing.Size(491, 295);
            this.grilleDetails2.TabIndex = 7;
            // 
            // idArticle
            // 
            this.idArticle.HeaderText = "# article";
            this.idArticle.Name = "idArticle";
            // 
            // description
            // 
            this.description.HeaderText = "Article";
            this.description.Name = "description";
            // 
            // qtyListe1
            // 
            this.qtyListe1.HeaderText = "Qté Liste1";
            this.qtyListe1.Name = "qtyListe1";
            // 
            // prix
            // 
            this.prix.HeaderText = "Prix Unitaire";
            this.prix.Name = "prix";
            // 
            // taxe
            // 
            this.taxe.HeaderText = "Taxe";
            this.taxe.Name = "taxe";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "# article";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Article";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Qté Liste2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Prix Unitaire";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Taxe";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // btnRetirer
            // 
            this.btnRetirer.Location = new System.Drawing.Point(771, 161);
            this.btnRetirer.Name = "btnRetirer";
            this.btnRetirer.Size = new System.Drawing.Size(75, 23);
            this.btnRetirer.TabIndex = 10;
            this.btnRetirer.Text = "Retirer";
            this.btnRetirer.UseVisualStyleBackColor = true;
            this.btnRetirer.Click += new System.EventHandler(this.btnRetirer_Click);
            // 
            // FormManipulationFactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 897);
            this.Controls.Add(this.btnRetirer);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnList1ToList2);
            this.Controls.Add(this.btnList2ToList1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormManipulationFactures";
            this.Text = "Manipulation de factures";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grilleDetails1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcDetails1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleDetails2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcDetails2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox liste1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox liste2;
        private System.Windows.Forms.Button btnList2ToList1;
        private System.Windows.Forms.Button btnList1ToList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAjoutL2;
        private System.Windows.Forms.Button btnAjoutL1;
        private System.Windows.Forms.ListBox listeTous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTypeFacture;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grilleDetails1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAsoustraireFacture;
        private System.Windows.Forms.Button btnAjoutFacture;
        private System.Windows.Forms.BindingSource srcDetails1;
        private System.Windows.Forms.DataGridView grilleDetails2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyListe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxe;
        private System.Windows.Forms.BindingSource srcDetails2;
        private System.Windows.Forms.Button btnRetirer;
    }
}