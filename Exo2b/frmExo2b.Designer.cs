namespace Exo2b
{
    partial class frmExo2b
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPhrase3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPhrase2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelPhrase1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxPhrase3 = new System.Windows.Forms.CheckBox();
            this.checkBoxPhrase2 = new System.Windows.Forms.CheckBox();
            this.checkBoxPhrase1 = new System.Windows.Forms.CheckBox();
            this.labelTextSearch = new System.Windows.Forms.Label();
            this.labelTextOccurence = new System.Windows.Forms.Label();
            this.textBoxLetter = new System.Windows.Forms.TextBox();
            this.textBoxOccurence = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.labelPhrase3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.labelPhrase2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelPhrase1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.groupBox1.Size = new System.Drawing.Size(662, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(62, 92);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(575, 20);
            this.textBox3.TabIndex = 5;
            // 
            // labelPhrase3
            // 
            this.labelPhrase3.AutoSize = true;
            this.labelPhrase3.Location = new System.Drawing.Point(7, 95);
            this.labelPhrase3.Name = "labelPhrase3";
            this.labelPhrase3.Size = new System.Drawing.Size(49, 13);
            this.labelPhrase3.TabIndex = 4;
            this.labelPhrase3.Text = "Phrase 3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(62, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(575, 20);
            this.textBox2.TabIndex = 3;
            // 
            // labelPhrase2
            // 
            this.labelPhrase2.AutoSize = true;
            this.labelPhrase2.Location = new System.Drawing.Point(7, 60);
            this.labelPhrase2.Name = "labelPhrase2";
            this.labelPhrase2.Size = new System.Drawing.Size(49, 13);
            this.labelPhrase2.TabIndex = 2;
            this.labelPhrase2.Text = "Phrase 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(574, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelPhrase1
            // 
            this.labelPhrase1.AutoSize = true;
            this.labelPhrase1.Location = new System.Drawing.Point(8, 23);
            this.labelPhrase1.Name = "labelPhrase1";
            this.labelPhrase1.Size = new System.Drawing.Size(49, 13);
            this.labelPhrase1.TabIndex = 0;
            this.labelPhrase1.Text = "Phrase 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxPhrase3);
            this.groupBox2.Controls.Add(this.checkBoxPhrase2);
            this.groupBox2.Controls.Add(this.checkBoxPhrase1);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rechercher dans : ";
            // 
            // checkBoxPhrase3
            // 
            this.checkBoxPhrase3.AutoSize = true;
            this.checkBoxPhrase3.Location = new System.Drawing.Point(10, 78);
            this.checkBoxPhrase3.Name = "checkBoxPhrase3";
            this.checkBoxPhrase3.Size = new System.Drawing.Size(68, 17);
            this.checkBoxPhrase3.TabIndex = 2;
            this.checkBoxPhrase3.Text = "Phrase &3";
            this.checkBoxPhrase3.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhrase2
            // 
            this.checkBoxPhrase2.AutoSize = true;
            this.checkBoxPhrase2.Location = new System.Drawing.Point(10, 54);
            this.checkBoxPhrase2.Name = "checkBoxPhrase2";
            this.checkBoxPhrase2.Size = new System.Drawing.Size(68, 17);
            this.checkBoxPhrase2.TabIndex = 1;
            this.checkBoxPhrase2.Text = "Phrase &2";
            this.checkBoxPhrase2.UseVisualStyleBackColor = true;
            // 
            // checkBoxPhrase1
            // 
            this.checkBoxPhrase1.AutoSize = true;
            this.checkBoxPhrase1.Location = new System.Drawing.Point(11, 30);
            this.checkBoxPhrase1.Name = "checkBoxPhrase1";
            this.checkBoxPhrase1.Size = new System.Drawing.Size(68, 17);
            this.checkBoxPhrase1.TabIndex = 0;
            this.checkBoxPhrase1.Text = "Phrase &1";
            this.checkBoxPhrase1.UseVisualStyleBackColor = true;
            // 
            // labelTextSearch
            // 
            this.labelTextSearch.AutoSize = true;
            this.labelTextSearch.Location = new System.Drawing.Point(189, 184);
            this.labelTextSearch.Name = "labelTextSearch";
            this.labelTextSearch.Size = new System.Drawing.Size(97, 13);
            this.labelTextSearch.TabIndex = 2;
            this.labelTextSearch.Text = "Lettre à rechercher";
            // 
            // labelTextOccurence
            // 
            this.labelTextOccurence.AutoSize = true;
            this.labelTextOccurence.Location = new System.Drawing.Point(175, 221);
            this.labelTextOccurence.Name = "labelTextOccurence";
            this.labelTextOccurence.Size = new System.Drawing.Size(111, 13);
            this.labelTextOccurence.TabIndex = 3;
            this.labelTextOccurence.Text = "Nombre d\'occurences";
            // 
            // textBoxLetter
            // 
            this.textBoxLetter.Location = new System.Drawing.Point(300, 181);
            this.textBoxLetter.Name = "textBoxLetter";
            this.textBoxLetter.Size = new System.Drawing.Size(100, 20);
            this.textBoxLetter.TabIndex = 4;
            // 
            // textBoxOccurence
            // 
            this.textBoxOccurence.Enabled = false;
            this.textBoxOccurence.Location = new System.Drawing.Point(300, 221);
            this.textBoxOccurence.Name = "textBoxOccurence";
            this.textBoxOccurence.Size = new System.Drawing.Size(100, 20);
            this.textBoxOccurence.TabIndex = 5;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(492, 201);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(157, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Lancer la recherche";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // frmExo2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 271);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxOccurence);
            this.Controls.Add(this.textBoxLetter);
            this.Controls.Add(this.labelTextOccurence);
            this.Controls.Add(this.labelTextSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExo2b";
            this.Text = "Exo2b";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPhrase3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelPhrase2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelPhrase1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxPhrase3;
        private System.Windows.Forms.CheckBox checkBoxPhrase2;
        private System.Windows.Forms.CheckBox checkBoxPhrase1;
        private System.Windows.Forms.Label labelTextSearch;
        private System.Windows.Forms.Label labelTextOccurence;
        private System.Windows.Forms.TextBox textBoxLetter;
        private System.Windows.Forms.TextBox textBoxOccurence;
        private System.Windows.Forms.Button buttonSearch;
    }
}

