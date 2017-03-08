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
        public frmChrono()
        {
            InitializeComponent();
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            frmPrinc.Affiche();
            textBoxChrono.Text = frmPrinc.Chrono.ToString();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmChrono_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((frmMdi)(frmPrinc.MdiParent)).fermeChrono();
        }
    }
}
