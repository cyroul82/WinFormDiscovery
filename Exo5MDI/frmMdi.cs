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
        private Boolean flag = false;
        public frmMdi()
        {
            InitializeComponent();
            
            frmPrinc = new frmExo5();
            frmPrinc.MdiParent = this;
            //this.FormClosing += new FormClosingEventHandler(this.fermeApp);
            frmPrinc.FormClosing += new FormClosingEventHandler(this.fermeApp);
            frmPrinc.FormClosed += new FormClosedEventHandler(this.closeMainApp);
            frmPrinc.Show();
        }

        private void frmExo5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPrinc != null)
            {
                frmPrinc.Activate();
            }
            else
            {
                frmPrinc = new frmExo5();
                frmPrinc.MdiParent = this;
                //frmPrinc.FormClosing += new FormClosingEventHandler(this.fermeApp);
                frmPrinc.Show();
            }
        }

        public void fermeChrono(object sender, FormClosingEventArgs e)
        {
            frmChr = null;
        }

        public void fermeRandom(object sender, FormClosingEventArgs e)
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
                frmChr = new frmChrono();
                frmChr.MdiParent = this;
                frmChr.FormClosing += new FormClosingEventHandler(this.fermeChrono);
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
                frmR = new frmRandom();
                frmR.MdiParent = this;
                frmR.FormClosing += new FormClosingEventHandler(this.fermeRandom);
                frmR.Show();
            }
            frmR.textBoxAleatoire.Text = frmPrinc.textBoxNombreAleatoire.Text;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fermeApp(object sender, FormClosingEventArgs e)
        {
                DialogResult rep = MessageBox.Show("Voulez vous vraiment quitter?", "Terminer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rep == DialogResult.No)
                {
                    e.Cancel = true;
                }

        }
        private void closeMainApp(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aPropsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void frmMdi_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
