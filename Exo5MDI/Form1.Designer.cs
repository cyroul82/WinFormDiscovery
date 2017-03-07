namespace Exo5MDI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chronoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.frmExo5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmChronoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmRandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aPropsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.fenêtreToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(367, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // fenêtreToolStripMenuItem
            // 
            this.fenêtreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chronoToolStripMenuItem,
            this.nombreToolStripMenuItem,
            this.toolStripSeparator1,
            this.frmExo5ToolStripMenuItem,
            this.frmChronoToolStripMenuItem,
            this.frmRandomToolStripMenuItem});
            this.fenêtreToolStripMenuItem.Name = "fenêtreToolStripMenuItem";
            this.fenêtreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fenêtreToolStripMenuItem.Text = "F&enêtre";
            // 
            // chronoToolStripMenuItem
            // 
            this.chronoToolStripMenuItem.Name = "chronoToolStripMenuItem";
            this.chronoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chronoToolStripMenuItem.Text = "Chrono";
            // 
            // nombreToolStripMenuItem
            // 
            this.nombreToolStripMenuItem.Name = "nombreToolStripMenuItem";
            this.nombreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nombreToolStripMenuItem.Text = "&Nombre";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // frmExo5ToolStripMenuItem
            // 
            this.frmExo5ToolStripMenuItem.Checked = true;
            this.frmExo5ToolStripMenuItem.CheckOnClick = true;
            this.frmExo5ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.frmExo5ToolStripMenuItem.Name = "frmExo5ToolStripMenuItem";
            this.frmExo5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.frmExo5ToolStripMenuItem.Text = "&1 frmExo5";
            // 
            // frmChronoToolStripMenuItem
            // 
            this.frmChronoToolStripMenuItem.CheckOnClick = true;
            this.frmChronoToolStripMenuItem.Name = "frmChronoToolStripMenuItem";
            this.frmChronoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.frmChronoToolStripMenuItem.Text = "&2 frmChrono";
            this.frmChronoToolStripMenuItem.CheckedChanged += new System.EventHandler(this.frmChronoToolStripMenuItem_CheckedChanged);
            this.frmChronoToolStripMenuItem.Click += new System.EventHandler(this.frmChronoToolStripMenuItem_Click);
            // 
            // frmRandomToolStripMenuItem
            // 
            this.frmRandomToolStripMenuItem.CheckOnClick = true;
            this.frmRandomToolStripMenuItem.Name = "frmRandomToolStripMenuItem";
            this.frmRandomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.frmRandomToolStripMenuItem.Text = "&3 frmRandom";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPropsToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "&?";
            // 
            // aPropsToolStripMenuItem
            // 
            this.aPropsToolStripMenuItem.Name = "aPropsToolStripMenuItem";
            this.aPropsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aPropsToolStripMenuItem.Text = "&A Propos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 308);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chronoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem frmExo5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmChronoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmRandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aPropsToolStripMenuItem;
    }
}

