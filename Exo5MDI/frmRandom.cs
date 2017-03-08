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
    public partial class frmRandom : Form
    {
        frmExo5 frmPrinc;
        public frmRandom(frmExo5 f)
        {
            InitializeComponent();
            frmPrinc = f;
        }

        private void frmRandom_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((frmMdi)frmPrinc.MdiParent).fermeRandom();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            textBoxAleatoire.Text = frmPrinc.Nombre.ToString();
        }


    }
}
