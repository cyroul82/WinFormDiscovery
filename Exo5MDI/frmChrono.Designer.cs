namespace Exo5MDI
{
    partial class frmChrono
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
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.lblChrono = new System.Windows.Forms.Label();
            this.textBoxChrono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnActualiser
            // 
            this.btnActualiser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnActualiser.Location = new System.Drawing.Point(59, 60);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(92, 23);
            this.btnActualiser.TabIndex = 0;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFermer.Location = new System.Drawing.Point(163, 60);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(92, 23);
            this.btnFermer.TabIndex = 1;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // lblChrono
            // 
            this.lblChrono.AutoSize = true;
            this.lblChrono.Location = new System.Drawing.Point(96, 16);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(41, 13);
            this.lblChrono.TabIndex = 2;
            this.lblChrono.Text = "Chrono";
            // 
            // textBoxChrono
            // 
            this.textBoxChrono.Enabled = false;
            this.textBoxChrono.Location = new System.Drawing.Point(155, 12);
            this.textBoxChrono.Name = "textBoxChrono";
            this.textBoxChrono.Size = new System.Drawing.Size(100, 20);
            this.textBoxChrono.TabIndex = 3;
            // 
            // frmChrono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 95);
            this.Controls.Add(this.textBoxChrono);
            this.Controls.Add(this.lblChrono);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnActualiser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChrono";
            this.Text = "frmChrono";
            this.Activated += new System.EventHandler(this.frmChrono_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualiser;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label lblChrono;
        internal System.Windows.Forms.TextBox textBoxChrono;
    }
}