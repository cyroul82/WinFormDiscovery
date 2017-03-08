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
        public frmRandom()
        {
            InitializeComponent();
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
            frmPrinc.Affiche();
            textBoxAleatoire.Text = frmPrinc.Nombre.ToString();
        }


    }
}
