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
    public partial class frmExo5 : Form
    {
        private System.Random aleat;
        private Double nombre;
        private Int32 chrono = 0;
        public frmExo5()
        {
            InitializeComponent();
            this.aleat = new System.Random();
            this.Affiche();
        }
       
        private void Affiche()
        {
            nombre = aleat.NextDouble();
            textBoxNombreAleatoire.Text = nombre.ToString();

            chrono++;
            textBoxChrono.Text = chrono.ToString();

        }

        private void frmExo5_Load(object sender, EventArgs e)
        {

        }

        private void frmExo5_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez vous vraiment quitter ?", "Terminer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Affiche();
        }
    }
}
