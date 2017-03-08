namespace Exo2a
{
    partial class Exo2a
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.checkBoxChangeColor = new System.Windows.Forms.CheckBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonVert = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(171, 26);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Démonstration des cases à cocher\r\net des boutons d\'options";
            // 
            // checkBoxChangeColor
            // 
            this.checkBoxChangeColor.AutoSize = true;
            this.checkBoxChangeColor.Location = new System.Drawing.Point(15, 50);
            this.checkBoxChangeColor.Name = "checkBoxChangeColor";
            this.checkBoxChangeColor.Size = new System.Drawing.Size(112, 17);
            this.checkBoxChangeColor.TabIndex = 1;
            this.checkBoxChangeColor.Text = "Modifier la couleur";
            this.checkBoxChangeColor.UseVisualStyleBackColor = true;
            this.checkBoxChangeColor.CheckedChanged += new System.EventHandler(this.checkBoxChangeColor_CheckedChanged);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Red;
            this.lblColor.Location = new System.Drawing.Point(130, 51);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(142, 87);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "La couleur choisie";
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonVert);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Location = new System.Drawing.Point(133, 149);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(139, 100);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Couleur";
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(7, 20);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(57, 17);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Rouge";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonVert
            // 
            this.radioButtonVert.AutoSize = true;
            this.radioButtonVert.Location = new System.Drawing.Point(7, 44);
            this.radioButtonVert.Name = "radioButtonVert";
            this.radioButtonVert.Size = new System.Drawing.Size(44, 17);
            this.radioButtonVert.TabIndex = 1;
            this.radioButtonVert.TabStop = true;
            this.radioButtonVert.Text = "Vert";
            this.radioButtonVert.UseVisualStyleBackColor = true;
            this.radioButtonVert.CheckedChanged += new System.EventHandler(this.radioButtonVert_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(7, 68);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBlue.TabIndex = 2;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Bleu";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.Bleu_CheckedChanged);
            // 
            // Exo2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.checkBoxChangeColor);
            this.Controls.Add(this.lblInfo);
            this.Name = "Exo2a";
            this.Text = "Exo2a";
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox checkBoxChangeColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonVert;
        private System.Windows.Forms.RadioButton radioButtonRed;
    }
}

