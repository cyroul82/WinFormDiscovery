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
        private Double Nombre { get; set; }
        private Int32 Chrono { get; set; } = 0;
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

            Donnees.Chrono++;
            textBoxChrono.Text = Donnees.Chrono.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Affiche();
        }

       
    }
}
