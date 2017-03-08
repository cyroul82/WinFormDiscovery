namespace Appli2
{
    partial class frmAppli2
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonRetablir = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.groupBoxParametre = new System.Windows.Forms.GroupBox();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.textBoxVitesse = new System.Windows.Forms.TextBox();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelVitesse = new System.Windows.Forms.Label();
            this.labelChoisirVitesse = new System.Windows.Forms.Label();
            this.labelChoisirTemperature = new System.Windows.Forms.Label();
            this.comboBoxVitesse = new System.Windows.Forms.ComboBox();
            this.comboBoxTemperature = new System.Windows.Forms.ComboBox();
            this.groupBoxParametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(250, 113);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonRetablir
            // 
            this.buttonRetablir.Location = new System.Drawing.Point(250, 142);
            this.buttonRetablir.Name = "buttonRetablir";
            this.buttonRetablir.Size = new System.Drawing.Size(75, 23);
            this.buttonRetablir.TabIndex = 3;
            this.buttonRetablir.Text = "Rétablir";
            this.buttonRetablir.UseVisualStyleBackColor = true;
            this.buttonRetablir.Click += new System.EventHandler(this.buttonRetablir_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(250, 171);
            this.buttonQuitter.Name = "buttonQuitter";
            this.buttonQuitter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitter.TabIndex = 4;
            this.buttonQuitter.Text = "Quitter";
            this.buttonQuitter.UseVisualStyleBackColor = true;
            this.buttonQuitter.Click += new System.EventHandler(this.buttonQuitter_Click);
            // 
            // groupBoxParametre
            // 
            this.groupBoxParametre.Controls.Add(this.textBoxTemperature);
            this.groupBoxParametre.Controls.Add(this.textBoxVitesse);
            this.groupBoxParametre.Controls.Add(this.labelTemperature);
            this.groupBoxParametre.Controls.Add(this.labelVitesse);
            this.groupBoxParametre.Location = new System.Drawing.Point(12, 110);
            this.groupBoxParametre.Name = "groupBoxParametre";
            this.groupBoxParametre.Size = new System.Drawing.Size(226, 82);
            this.groupBoxParametre.TabIndex = 5;
            this.groupBoxParametre.TabStop = false;
            this.groupBoxParametre.Text = "Paramètres retenus";
            this.groupBoxParametre.Visible = false;
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Enabled = false;
            this.textBoxTemperature.Location = new System.Drawing.Point(100, 51);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemperature.TabIndex = 3;
            // 
            // textBoxVitesse
            // 
            this.textBoxVitesse.Enabled = false;
            this.textBoxVitesse.Location = new System.Drawing.Point(100, 25);
            this.textBoxVitesse.Name = "textBoxVitesse";
            this.textBoxVitesse.Size = new System.Drawing.Size(100, 20);
            this.textBoxVitesse.TabIndex = 2;
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Location = new System.Drawing.Point(18, 55);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(76, 13);
            this.labelTemperature.TabIndex = 1;
            this.labelTemperature.Text = "Température : ";
            // 
            // labelVitesse
            // 
            this.labelVitesse.AutoSize = true;
            this.labelVitesse.Location = new System.Drawing.Point(44, 29);
            this.labelVitesse.Name = "labelVitesse";
            this.labelVitesse.Size = new System.Drawing.Size(50, 13);
            this.labelVitesse.TabIndex = 0;
            this.labelVitesse.Text = "Vitesse : ";
            // 
            // labelChoisirVitesse
            // 
            this.labelChoisirVitesse.AutoSize = true;
            this.labelChoisirVitesse.Location = new System.Drawing.Point(53, 27);
            this.labelChoisirVitesse.Name = "labelChoisirVitesse";
            this.labelChoisirVitesse.Size = new System.Drawing.Size(102, 13);
            this.labelChoisirVitesse.TabIndex = 6;
            this.labelChoisirVitesse.Text = "Chosir une vitesse : ";
            // 
            // labelChoisirTemperature
            // 
            this.labelChoisirTemperature.AutoSize = true;
            this.labelChoisirTemperature.Location = new System.Drawing.Point(30, 68);
            this.labelChoisirTemperature.Name = "labelChoisirTemperature";
            this.labelChoisirTemperature.Size = new System.Drawing.Size(125, 13);
            this.labelChoisirTemperature.TabIndex = 7;
            this.labelChoisirTemperature.Text = "Chosir une température : ";
            // 
            // comboBoxVitesse
            // 
            this.comboBoxVitesse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVitesse.FormattingEnabled = true;
            this.comboBoxVitesse.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "500"});
            this.comboBoxVitesse.Location = new System.Drawing.Point(171, 23);
            this.comboBoxVitesse.Name = "comboBoxVitesse";
            this.comboBoxVitesse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVitesse.TabIndex = 8;
            this.comboBoxVitesse.SelectedIndexChanged += new System.EventHandler(this.comboBoxVitesse_SelectedIndexChanged);
            // 
            // comboBoxTemperature
            // 
            this.comboBoxTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemperature.FormattingEnabled = true;
            this.comboBoxTemperature.Items.AddRange(new object[] {
            "50",
            "80",
            "100"});
            this.comboBoxTemperature.Location = new System.Drawing.Point(171, 64);
            this.comboBoxTemperature.Name = "comboBoxTemperature";
            this.comboBoxTemperature.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTemperature.TabIndex = 9;
            this.comboBoxTemperature.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemperature_SelectedIndexChanged);
            // 
            // frmAppli2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 209);
            this.Controls.Add(this.comboBoxTemperature);
            this.Controls.Add(this.comboBoxVitesse);
            this.Controls.Add(this.labelChoisirTemperature);
            this.Controls.Add(this.labelChoisirVitesse);
            this.Controls.Add(this.groupBoxParametre);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonRetablir);
            this.Controls.Add(this.buttonOk);
            this.Name = "frmAppli2";
            this.Text = "Appli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Appli1_FormClosing);
            this.groupBoxParametre.ResumeLayout(false);
            this.groupBoxParametre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonRetablir;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.GroupBox groupBoxParametre;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelVitesse;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.TextBox textBoxVitesse;
        private System.Windows.Forms.Label labelChoisirVitesse;
        private System.Windows.Forms.Label labelChoisirTemperature;
        private System.Windows.Forms.ComboBox comboBoxVitesse;
        private System.Windows.Forms.ComboBox comboBoxTemperature;
    }
}

