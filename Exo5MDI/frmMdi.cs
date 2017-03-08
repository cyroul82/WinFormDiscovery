using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo5MDI
{
    public partial class frmMdi : Form
    {

        private frmExo5 frmPrinc;
        private frmChrono frmChr;
        private frmRandom frmR;
        public frmMdi()
        {
            InitializeComponent();
            frmPrinc = new frmExo5();
            frmPrinc.MdiParent = this;
            frmPrinc.Show();
    
        }

        private void frmChronoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmChr != null)
            {
                frmChr.Activate();
            }
            else
            {
                frmChr = new frmChrono();
                frmChr.MdiParent = this;
                frmChr.textBoxChrono.Text = frmPrinc.textBoxChrono.Text;
                frmChr.Show();
            }

        }

        private void frmChronoToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void frmExo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmPrinc != null)
            {
                frmPrinc.Activate();
            }
            else
            {
                frmPrinc = new frmExo5();
                frmPrinc.MdiParent = this;
                frmPrinc.Show();
            }
        }

        private void frmRandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmR != null)
            {
                frmR.Activate();
            }
            else
            {
                frmR = new frmRandom();
                frmR.MdiParent = this;
                frmR.textBoxAleatoire.Text = frmPrinc.textBoxNombreAleatoire.Text;
                frmR.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez vous vraiment quitter ?", "Terminer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        
    }
}
