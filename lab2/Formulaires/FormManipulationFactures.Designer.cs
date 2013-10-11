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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnList2ToList1 = new System.Windows.Forms.Button();
            this.btnList1ToList2 = new System.Windows.Forms.Button();
            this.srcList1 = new System.Windows.Forms.BindingSource(this.components);
            this.srcList2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAjoutFacture = new System.Windows.Forms.Button();
            this.btnAsoustraireFacture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcList2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste1";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.srcList1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(172, 277);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Location = new System.Drawing.Point(319, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste2";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.srcList2;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(172, 277);
            this.listBox2.TabIndex = 0;
            // 
            // btnList2ToList1
            // 
            this.btnList2ToList1.Location = new System.Drawing.Point(218, 171);
            this.btnList2ToList1.Name = "btnList2ToList1";
            this.btnList2ToList1.Size = new System.Drawing.Size(75, 23);
            this.btnList2ToList1.TabIndex = 2;
            this.btnList2ToList1.Text = "<<";
            this.btnList2ToList1.UseVisualStyleBackColor = true;
            // 
            // btnList1ToList2
            // 
            this.btnList1ToList2.Location = new System.Drawing.Point(218, 122);
            this.btnList1ToList2.Name = "btnList1ToList2";
            this.btnList1ToList2.Size = new System.Drawing.Size(75, 23);
            this.btnList1ToList2.TabIndex = 3;
            this.btnList1ToList2.Text = ">>";
            this.btnList1ToList2.UseVisualStyleBackColor = true;
            // 
            // btnAjoutFacture
            // 
            this.btnAjoutFacture.Location = new System.Drawing.Point(319, 322);
            this.btnAjoutFacture.Name = "btnAjoutFacture";
            this.btnAjoutFacture.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutFacture.TabIndex = 4;
            this.btnAjoutFacture.Text = "Ajouter";
            this.btnAjoutFacture.UseVisualStyleBackColor = true;
            // 
            // btnAsoustraireFacture
            // 
            this.btnAsoustraireFacture.Location = new System.Drawing.Point(428, 322);
            this.btnAsoustraireFacture.Name = "btnAsoustraireFacture";
            this.btnAsoustraireFacture.Size = new System.Drawing.Size(75, 23);
            this.btnAsoustraireFacture.TabIndex = 5;
            this.btnAsoustraireFacture.Text = "Soustraire";
            this.btnAsoustraireFacture.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "&Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormManipulationFactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAsoustraireFacture);
            this.Controls.Add(this.btnAjoutFacture);
            this.Controls.Add(this.btnList1ToList2);
            this.Controls.Add(this.btnList2ToList1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormManipulationFactures";
            this.Text = "Manipulation de factures";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srcList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcList2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource srcList1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnList2ToList1;
        private System.Windows.Forms.Button btnList1ToList2;
        private System.Windows.Forms.BindingSource srcList2;
        private System.Windows.Forms.Button btnAjoutFacture;
        private System.Windows.Forms.Button btnAsoustraireFacture;
        private System.Windows.Forms.Button button1;
    }
}