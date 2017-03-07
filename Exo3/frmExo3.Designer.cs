namespace Exo3
{
    partial class frmExo3
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
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.labelSource = new System.Windows.Forms.Label();
            this.buttonAddOne = new System.Windows.Forms.Button();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonDeleteOne = new System.Windows.Forms.Button();
            this.buttonDeleteAll = new System.Windows.Forms.Button();
            this.labelCible = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.listBoxCible = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(16, 31);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSource.TabIndex = 0;
            this.comboBoxSource.DropDown += new System.EventHandler(this.comboBoxSource_DropDown);
            this.comboBoxSource.SelectedIndexChanged += new System.EventHandler(this.comboBoxSource_SelectedIndexChanged);
            this.comboBoxSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSource_KeyDown);
            // 
            // labelSource
            // 
            this.labelSource.AutoSize = true;
            this.labelSource.Location = new System.Drawing.Point(59, 9);
            this.labelSource.Name = "labelSource";
            this.labelSource.Size = new System.Drawing.Size(41, 13);
            this.labelSource.TabIndex = 1;
            this.labelSource.Text = "Source";
            // 
            // buttonAddOne
            // 
            this.buttonAddOne.Enabled = false;
            this.buttonAddOne.Location = new System.Drawing.Point(143, 29);
            this.buttonAddOne.Name = "buttonAddOne";
            this.buttonAddOne.Size = new System.Drawing.Size(75, 23);
            this.buttonAddOne.TabIndex = 2;
            this.buttonAddOne.Text = ">";
            this.buttonAddOne.UseVisualStyleBackColor = true;
            this.buttonAddOne.Click += new System.EventHandler(this.buttonAddOne_Click);
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Location = new System.Drawing.Point(143, 58);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAll.TabIndex = 3;
            this.buttonAddAll.Text = ">>";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // buttonDeleteOne
            // 
            this.buttonDeleteOne.Enabled = false;
            this.buttonDeleteOne.Location = new System.Drawing.Point(143, 164);
            this.buttonDeleteOne.Name = "buttonDeleteOne";
            this.buttonDeleteOne.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteOne.TabIndex = 4;
            this.buttonDeleteOne.Text = "<";
            this.buttonDeleteOne.UseVisualStyleBackColor = true;
            this.buttonDeleteOne.Click += new System.EventHandler(this.buttonDeleteOne_Click);
            // 
            // buttonDeleteAll
            // 
            this.buttonDeleteAll.Enabled = false;
            this.buttonDeleteAll.Location = new System.Drawing.Point(143, 193);
            this.buttonDeleteAll.Name = "buttonDeleteAll";
            this.buttonDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAll.TabIndex = 5;
            this.buttonDeleteAll.Text = "<<";
            this.buttonDeleteAll.UseVisualStyleBackColor = true;
            this.buttonDeleteAll.Click += new System.EventHandler(this.buttonDeleteAll_Click);
            // 
            // labelCible
            // 
            this.labelCible.AutoSize = true;
            this.labelCible.Location = new System.Drawing.Point(279, 9);
            this.labelCible.Name = "labelCible";
            this.labelCible.Size = new System.Drawing.Size(30, 13);
            this.labelCible.TabIndex = 6;
            this.labelCible.Text = "Cible";
            // 
            // buttonUp
            // 
            this.buttonUp.Enabled = false;
            this.buttonUp.Location = new System.Drawing.Point(233, 222);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(37, 23);
            this.buttonUp.TabIndex = 8;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Enabled = false;
            this.buttonDown.Location = new System.Drawing.Point(317, 222);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(37, 23);
            this.buttonDown.TabIndex = 9;
            this.buttonDown.Text = "Dn";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // listBoxCible
            // 
            this.listBoxCible.FormattingEnabled = true;
            this.listBoxCible.Location = new System.Drawing.Point(233, 31);
            this.listBoxCible.Name = "listBoxCible";
            this.listBoxCible.Size = new System.Drawing.Size(120, 186);
            this.listBoxCible.TabIndex = 10;
            this.listBoxCible.SelectedIndexChanged += new System.EventHandler(this.listBoxCible_SelectedIndexChanged);
            // 
            // frmExo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.listBoxCible);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.labelCible);
            this.Controls.Add(this.buttonDeleteAll);
            this.Controls.Add(this.buttonDeleteOne);
            this.Controls.Add(this.buttonAddAll);
            this.Controls.Add(this.buttonAddOne);
            this.Controls.Add(this.labelSource);
            this.Controls.Add(this.comboBoxSource);
            this.MaximizeBox = false;
            this.Name = "frmExo3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExo3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.Label labelSource;
        private System.Windows.Forms.Button buttonAddOne;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonDeleteOne;
        private System.Windows.Forms.Button buttonDeleteAll;
        private System.Windows.Forms.Label labelCible;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.ListBox listBoxCible;
    }
}

