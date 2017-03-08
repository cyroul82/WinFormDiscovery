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
        internal Double Nombre { get; private set; }
        internal Int32 Chrono { get; private set; } = 0;
        public frmExo5()
        {
            InitializeComponent();
            this.aleat = new System.Random();
            this.Affiche();
        }
       
        public void Affiche()
        {
            Donnees.LeNombre = aleat.NextDouble();
            textBoxNombreAleatoire.Text = Donnees.LeNombre.ToString();

            Donnees.LeNombre++;
            textBoxChrono.Text = Donnees.LeNombre.ToString();
        }

        private void frmExo5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Affiche();
        }
    }
}
