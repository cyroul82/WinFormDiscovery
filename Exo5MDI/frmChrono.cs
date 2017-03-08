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
            affiche();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void affiche()
        {
            textBoxChrono.Text = Donnees.Chrono.ToString();
        }

        private void frmChrono_Activated(object sender, EventArgs e)
        {
            affiche();
        }
    }
}
