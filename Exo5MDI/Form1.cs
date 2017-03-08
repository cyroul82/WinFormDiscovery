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
    public partial class Form1 : Form
    {

        private frmExo5 frmPrinc;
        private frmChrono frmChr;
        private frmRandom frmR;
        public Form1()
        {
            InitializeComponent();
            frmPrinc = new frmExo5();
            frmPrinc.MdiParent = this;
            frmPrinc.Show();

            
        }

        private void frmChronoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                frmChr = new frmChrono();
                frmChr.MdiParent = this;
                frmChr.Show();
            
        }

        private void frmChronoToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            
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
