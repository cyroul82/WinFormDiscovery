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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez vous vraiment quitter ?", "Terminer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void fermeChrono()
        {
            frmChr = null;
        }

        public void fermeRandom()
        {
            frmR = null;
        }

        private void chronoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmChr != null)
            {
                frmChr.Activate();
            }
            else
            {
                frmChr = new frmChrono(this.frmPrinc);
                frmChr.MdiParent = this;

                frmChr.Show();
            }
            frmChr.textBoxChrono.Text = frmPrinc.textBoxChrono.Text;
        }

        private void nombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmR != null)
            {
                frmR.Activate();
                
            }

            else
            {
                frmR = new frmRandom(frmPrinc);
                frmR.MdiParent = this;
                frmR.Show();
            }
            frmR.textBoxAleatoire.Text = frmPrinc.textBoxNombreAleatoire.Text;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
