namespace Appli1
{
    partial class frmAppli1
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
            this.groupBoxVitesse = new System.Windows.Forms.GroupBox();
            this.radioButtonVitesseCinqCent = new System.Windows.Forms.RadioButton();
            this.radioButtonVitesseTroisCent = new System.Windows.Forms.RadioButton();
            this.radioButtonVitesseDeuxCent = new System.Windows.Forms.RadioButton();
            this.radioButtonVitesseCent = new System.Windows.Forms.RadioButton();
            this.groupBoxTemperature = new System.Windows.Forms.GroupBox();
            this.radioButtonTemperatureCent = new System.Windows.Forms.RadioButton();
            this.radioButtonTemperaturQuatreVingt = new System.Windows.Forms.RadioButton();
            this.radioButtonTemperaturCinquante = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonRetablir = new System.Windows.Forms.Button();
            this.buttonQuitter = new System.Windows.Forms.Button();
            this.groupBoxParametre = new System.Windows.Forms.GroupBox();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.textBoxVitesse = new System.Windows.Forms.TextBox();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelVitesse = new System.Windows.Forms.Label();
            this.groupBoxVitesse.SuspendLayout();
            this.groupBoxTemperature.SuspendLayout();
            this.groupBoxParametre.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxVitesse
            // 
            this.groupBoxVitesse.Controls.Add(this.radioButtonVitesseCinqCent);
            this.groupBoxVitesse.Controls.Add(this.radioButtonVitesseTroisCent);
            this.groupBoxVitesse.Controls.Add(this.radioButtonVitesseDeuxCent);
            this.groupBoxVitesse.Controls.Add(this.radioButtonVitesseCent);
            this.groupBoxVitesse.Location = new System.Drawing.Point(12, 12);
            this.groupBoxVitesse.Name = "groupBoxVitesse";
            this.groupBoxVitesse.Size = new System.Drawing.Size(313, 67);
            this.groupBoxVitesse.TabIndex = 0;
            this.groupBoxVitesse.TabStop = false;
            this.groupBoxVitesse.Text = "Vitesse du mélangeur en tours par minute";
            // 
            // radioButtonVitesseCinqCent
            // 
            this.radioButtonVitesseCinqCent.AutoSize = true;
            this.radioButtonVitesseCinqCent.Location = new System.Drawing.Point(220, 31);
            this.radioButtonVitesseCinqCent.Name = "radioButtonVitesseCinqCent";
            this.radioButtonVitesseCinqCent.Size = new System.Drawing.Size(43, 17);
            this.radioButtonVitesseCinqCent.TabIndex = 3;
            this.radioButtonVitesseCinqCent.Text = "500";
            this.radioButtonVitesseCinqCent.UseVisualStyleBackColor = true;
            this.radioButtonVitesseCinqCent.CheckedChanged += new System.EventHandler(this.radioButtonVitesseCinqCent_CheckedChanged);
            // 
            // radioButtonVitesseTroisCent
            // 
            this.radioButtonVitesseTroisCent.AutoSize = true;
            this.radioButtonVitesseTroisCent.Location = new System.Drawing.Point(153, 31);
            this.radioButtonVitesseTroisCent.Name = "radioButtonVitesseTroisCent";
            this.radioButtonVitesseTroisCent.Size = new System.Drawing.Size(43, 17);
            this.radioButtonVitesseTroisCent.TabIndex = 2;
            this.radioButtonVitesseTroisCent.Text = "300";
            this.radioButtonVitesseTroisCent.UseVisualStyleBackColor = true;
            this.radioButtonVitesseTroisCent.CheckedChanged += new System.EventHandler(this.radioButtonVitesseTroisCent_CheckedChanged);
            // 
            // radioButtonVitesseDeuxCent
            // 
            this.radioButtonVitesseDeuxCent.AutoSize = true;
            this.radioButtonVitesseDeuxCent.Location = new System.Drawing.Point(84, 31);
            this.radioButtonVitesseDeuxCent.Name = "radioButtonVitesseDeuxCent";
            this.radioButtonVitesseDeuxCent.Size = new System.Drawing.Size(43, 17);
            this.radioButtonVitesseDeuxCent.TabIndex = 1;
            this.radioButtonVitesseDeuxCent.Text = "200";
            this.radioButtonVitesseDeuxCent.UseVisualStyleBackColor = true;
            this.radioButtonVitesseDeuxCent.CheckedChanged += new System.EventHandler(this.radioButtonVitesseDeuxCent_CheckedChanged);
            // 
            // radioButtonVitesseCent
            // 
            this.radioButtonVitesseCent.AutoSize = true;
            this.radioButtonVitesseCent.Location = new System.Drawing.Point(13, 31);
            this.radioButtonVitesseCent.Name = "radioButtonVitesseCent";
            this.radioButtonVitesseCent.Size = new System.Drawing.Size(43, 17);
            this.radioButtonVitesseCent.TabIndex = 0;
            this.radioButtonVitesseCent.Text = "100";
            this.radioButtonVitesseCent.UseVisualStyleBackColor = true;
            this.radioButtonVitesseCent.CheckedChanged += new System.EventHandler(this.radioButtonVitesseCent_CheckedChanged);
            // 
            // groupBoxTemperature
            // 
            this.groupBoxTemperature.Controls.Add(this.radioButtonTemperatureCent);
            this.groupBoxTemperature.Controls.Add(this.radioButtonTemperaturQuatreVingt);
            this.groupBoxTemperature.Controls.Add(this.radioButtonTemperaturCinquante);
            this.groupBoxTemperature.Location = new System.Drawing.Point(12, 85);
            this.groupBoxTemperature.Name = "groupBoxTemperature";
            this.groupBoxTemperature.Size = new System.Drawing.Size(226, 70);
            this.groupBoxTemperature.TabIndex = 1;
            this.groupBoxTemperature.TabStop = false;
            this.groupBoxTemperature.Text = "Température du mélangeur";
            // 
            // radioButtonTemperatureCent
            // 
            this.radioButtonTemperatureCent.AutoSize = true;
            this.radioButtonTemperatureCent.Location = new System.Drawing.Point(153, 33);
            this.radioButtonTemperatureCent.Name = "radioButtonTemperatureCent";
            this.radioButtonTemperatureCent.Size = new System.Drawing.Size(43, 17);
            this.radioButtonTemperatureCent.TabIndex = 5;
            this.radioButtonTemperatureCent.Text = "100";
            this.radioButtonTemperatureCent.UseVisualStyleBackColor = true;
            this.radioButtonTemperatureCent.CheckedChanged += new System.EventHandler(this.radioButtonTemperatureCent_CheckedChanged);
            // 
            // radioButtonTemperaturQuatreVingt
            // 
            this.radioButtonTemperaturQuatreVingt.AutoSize = true;
            this.radioButtonTemperaturQuatreVingt.Location = new System.Drawing.Point(84, 33);
            this.radioButtonTemperaturQuatreVingt.Name = "radioButtonTemperaturQuatreVingt";
            this.radioButtonTemperaturQuatreVingt.Size = new System.Drawing.Size(37, 17);
            this.radioButtonTemperaturQuatreVingt.TabIndex = 4;
            this.radioButtonTemperaturQuatreVingt.Text = "80";
            this.radioButtonTemperaturQuatreVingt.UseVisualStyleBackColor = true;
            this.radioButtonTemperaturQuatreVingt.CheckedChanged += new System.EventHandler(this.radioButtonTemperaturQuatreVingt_CheckedChanged);
            // 
            // radioButtonTemperaturCinquante
            // 
            this.radioButtonTemperaturCinquante.AutoSize = true;
            this.radioButtonTemperaturCinquante.Location = new System.Drawing.Point(13, 33);
            this.radioButtonTemperaturCinquante.Name = "radioButtonTemperaturCinquante";
            this.radioButtonTemperaturCinquante.Size = new System.Drawing.Size(37, 17);
            this.radioButtonTemperaturCinquante.TabIndex = 3;
            this.radioButtonTemperaturCinquante.Text = "50";
            this.radioButtonTemperaturCinquante.UseVisualStyleBackColor = true;
            this.radioButtonTemperaturCinquante.CheckedChanged += new System.EventHandler(this.radioButtonTemperaturCinquante_CheckedChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(250, 164);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonRetablir
            // 
            this.buttonRetablir.Location = new System.Drawing.Point(250, 193);
            this.buttonRetablir.Name = "buttonRetablir";
            this.buttonRetablir.Size = new System.Drawing.Size(75, 23);
            this.buttonRetablir.TabIndex = 3;
            this.buttonRetablir.Text = "Rétablir";
            this.buttonRetablir.UseVisualStyleBackColor = true;
            this.buttonRetablir.Click += new System.EventHandler(this.buttonRetablir_Click);
            // 
            // buttonQuitter
            // 
            this.buttonQuitter.Location = new System.Drawing.Point(250, 222);
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
            this.groupBoxParametre.Location = new System.Drawing.Point(12, 161);
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
            // Appli1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 255);
            this.Controls.Add(this.groupBoxParametre);
            this.Controls.Add(this.buttonQuitter);
            this.Controls.Add(this.buttonRetablir);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxTemperature);
            this.Controls.Add(this.groupBoxVitesse);
            this.Name = "Appli1";
            this.Text = "Appli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Appli1_FormClosing);
            this.groupBoxVitesse.ResumeLayout(false);
            this.groupBoxVitesse.PerformLayout();
            this.groupBoxTemperature.ResumeLayout(false);
            this.groupBoxTemperature.PerformLayout();
            this.groupBoxParametre.ResumeLayout(false);
            this.groupBoxParametre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxVitesse;
        private System.Windows.Forms.RadioButton radioButtonVitesseCinqCent;
        private System.Windows.Forms.RadioButton radioButtonVitesseTroisCent;
        private System.Windows.Forms.RadioButton radioButtonVitesseDeuxCent;
        private System.Windows.Forms.RadioButton radioButtonVitesseCent;
        private System.Windows.Forms.GroupBox groupBoxTemperature;
        private System.Windows.Forms.RadioButton radioButtonTemperatureCent;
        private System.Windows.Forms.RadioButton radioButtonTemperaturQuatreVingt;
        private System.Windows.Forms.RadioButton radioButtonTemperaturCinquante;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonRetablir;
        private System.Windows.Forms.Button buttonQuitter;
        private System.Windows.Forms.GroupBox groupBoxParametre;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelVitesse;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.TextBox textBoxVitesse;
    }
}

