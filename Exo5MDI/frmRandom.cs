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
            DialogResult rep = MessageBox.Show("Voulez vous vraiment quitter ?", "Terminer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
