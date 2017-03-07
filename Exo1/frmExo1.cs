using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo1
{
    public partial class frmExo1 : Form
    {

        private String leTexte;
        public frmExo1()
        {
            InitializeComponent();

            textBoxOriginal.GotFocus += new EventHandler(textBoxOriginal_GotFocus);
            leTexte = "Entrer le texte initiale";
        }

        private void textBoxOriginal_GotFocus(object sender, EventArgs e)
        {
            textBoxOriginal.Text = "";
        }

        private void btnRecopier_Click(object sender, EventArgs e)
        {
            lblResultat.Text = textBoxOriginal.Text;
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            textBoxOriginal.Text = leTexte;
            lblResultat.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frlExo1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez vous vraiment quitter ?", "Terminer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rep == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmExo1_Load(object sender, EventArgs e)
        {
            textBoxOriginal.Text = leTexte; 
        }
    }
}
