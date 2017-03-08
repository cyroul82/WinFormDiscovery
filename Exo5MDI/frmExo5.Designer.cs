namespace Exo5MDI
{
    partial class frmExo5
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
            this.lblChrono = new System.Windows.Forms.Label();
            this.lblNombreAleatoire = new System.Windows.Forms.Label();
            this.textBoxChrono = new System.Windows.Forms.TextBox();
            this.textBoxNombreAleatoire = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblChrono
            // 
            this.lblChrono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChrono.AutoSize = true;
            this.lblChrono.Location = new System.Drawing.Point(55, 38);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(41, 13);
            this.lblChrono.TabIndex = 0;
            this.lblChrono.Text = "Chrono";
            // 
            // lblNombreAleatoire
            // 
            this.lblNombreAleatoire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreAleatoire.AutoSize = true;
            this.lblNombreAleatoire.Location = new System.Drawing.Point(8, 66);
            this.lblNombreAleatoire.Name = "lblNombreAleatoire";
            this.lblNombreAleatoire.Size = new System.Drawing.Size(88, 13);
            this.lblNombreAleatoire.TabIndex = 1;
            this.lblNombreAleatoire.Text = "Nombre Aléatoire";
            // 
            // textBoxChrono
            // 
            this.textBoxChrono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChrono.Enabled = false;
            this.textBoxChrono.Location = new System.Drawing.Point(119, 35);
            this.textBoxChrono.Name = "textBoxChrono";
            this.textBoxChrono.Size = new System.Drawing.Size(167, 20);
            this.textBoxChrono.TabIndex = 2;
            // 
            // textBoxNombreAleatoire
            // 
            this.textBoxNombreAleatoire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNombreAleatoire.Enabled = false;
            this.textBoxNombreAleatoire.Location = new System.Drawing.Point(119, 63);
            this.textBoxNombreAleatoire.Name = "textBoxNombreAleatoire";
            this.textBoxNombreAleatoire.Size = new System.Drawing.Size(167, 20);
            this.textBoxNombreAleatoire.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmExo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 117);
            this.Controls.Add(this.textBoxNombreAleatoire);
            this.Controls.Add(this.textBoxChrono);
            this.Controls.Add(this.lblNombreAleatoire);
            this.Controls.Add(this.lblChrono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmExo5";
            this.Text = "frmExo5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExo5_FormClosing);
            this.Load += new System.EventHandler(this.frmExo5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChrono;
        private System.Windows.Forms.Label lblNombreAleatoire;
        private System.Windows.Forms.TextBox textBoxChrono;
        private System.Windows.Forms.TextBox textBoxNombreAleatoire;
        private System.Windows.Forms.Timer timer;
    }
}