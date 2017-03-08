namespace Exo5MDI
{
    partial class frmRandom
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
            this.textBoxAleatoire = new System.Windows.Forms.TextBox();
            this.lblNombreAleatoire = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAleatoire
            // 
            this.textBoxAleatoire.Enabled = false;
            this.textBoxAleatoire.Location = new System.Drawing.Point(136, 12);
            this.textBoxAleatoire.Name = "textBoxAleatoire";
            this.textBoxAleatoire.Size = new System.Drawing.Size(100, 20);
            this.textBoxAleatoire.TabIndex = 7;
            // 
            // lblNombreAleatoire
            // 
            this.lblNombreAleatoire.AutoSize = true;
            this.lblNombreAleatoire.Location = new System.Drawing.Point(37, 16);
            this.lblNombreAleatoire.Name = "lblNombreAleatoire";
            this.lblNombreAleatoire.Size = new System.Drawing.Size(88, 13);
            this.lblNombreAleatoire.TabIndex = 6;
            this.lblNombreAleatoire.Text = "Nombre Aléatoire";
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFermer.Location = new System.Drawing.Point(144, 55);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(92, 23);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualiser.Location = new System.Drawing.Point(40, 55);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(92, 23);
            this.btnActualiser.TabIndex = 4;
            this.btnActualiser.Tag = " ";
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // frmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 90);
            this.Controls.Add(this.textBoxAleatoire);
            this.Controls.Add(this.lblNombreAleatoire);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnActualiser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRandom";
            this.Text = "frmRandom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRandom_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreAleatoire;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnActualiser;
        internal System.Windows.Forms.TextBox textBoxAleatoire;
    }
}