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
    public partial class frmChrono : Form
    {
        private frmExo5 frmPrinc;
        public frmChrono(frmExo5 f)
        {
            InitializeComponent();
            frmPrinc = f;
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            frmPrinc.Affiche();
            textBoxChrono.Text = frmPrinc.textBoxChrono.Text;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void frmChrono_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez vous vraiment quitter ?", "Terminer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                ((frmMdi)(frmPrinc.MdiParent)).fermeChrono();
            }
        }
    }
}
