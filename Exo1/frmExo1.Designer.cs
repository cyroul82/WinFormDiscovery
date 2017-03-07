namespace Exo1
{
    partial class frmExo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExo1));
            this.lblOriginal = new System.Windows.Forms.Label();
            this.lblCopie = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.btnRecopier = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(13, 27);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(51, 13);
            this.lblOriginal.TabIndex = 0;
            this.lblOriginal.Text = "Original : ";
            // 
            // lblCopie
            // 
            this.lblCopie.AutoSize = true;
            this.lblCopie.Location = new System.Drawing.Point(21, 59);
            this.lblCopie.Name = "lblCopie";
            this.lblCopie.Size = new System.Drawing.Size(43, 13);
            this.lblCopie.TabIndex = 1;
            this.lblCopie.Text = "Copie : ";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(70, 24);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(162, 20);
            this.textBoxOriginal.TabIndex = 2;
            // 
            // btnRecopier
            // 
            this.btnRecopier.Location = new System.Drawing.Point(291, 12);
            this.btnRecopier.Name = "btnRecopier";
            this.btnRecopier.Size = new System.Drawing.Size(75, 23);
            this.btnRecopier.TabIndex = 3;
            this.btnRecopier.Text = "Recopier";
            this.btnRecopier.UseVisualStyleBackColor = true;
            this.btnRecopier.Click += new System.EventHandler(this.btnRecopier_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(291, 41);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer.TabIndex = 4;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(291, 70);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.ForeColor = System.Drawing.Color.Red;
            this.lblResultat.Location = new System.Drawing.Point(70, 59);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(162, 20);
            this.lblResultat.TabIndex = 6;
            // 
            // frmExo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 107);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnRecopier);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.lblCopie);
            this.Controls.Add(this.lblOriginal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExo1";
            this.Text = "FrmExo1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frlExo1_FormClosing);
            this.Load += new System.EventHandler(this.frmExo1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOriginal;
        private System.Windows.Forms.Label lblCopie;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.Button btnRecopier;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label lblResultat;
    }
}

