using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appli2
{
    public partial class frmAppli1 : Form
    {
        private String speed;
        private String temp;
        public frmAppli1()
        {
            InitializeComponent();
            radioButtonTemperaturCinquante.Checked = true;
            radioButtonVitesseCent.Checked = true;
        }

        private void SetEnableGroupBoxTempAndSpeed(Boolean b)
        {
            groupBoxTemperature.Enabled = b;
            groupBoxVitesse.Enabled = b;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRetablir_Click(object sender, EventArgs e)
        {
            if (groupBoxParametre.Visible == Visible)
            {   
                groupBoxParametre.Visible = false;
                radioButtonTemperaturCinquante.Checked = true;
                radioButtonVitesseCent.Checked = true;
                SetEnableGroupBoxTempAndSpeed(true);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {

            if (groupBoxParametre.Visible != Visible)
            {
                textBoxVitesse.Text = speed;
                textBoxTemperature.Text = temp;
                groupBoxParametre.Visible = true;
                SetEnableGroupBoxTempAndSpeed(false);
            }
        }

        private void radioButtonVitesseCent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVitesseCent.Checked)
            {
                speed = radioButtonVitesseCent.Text;
            }
        }

        private void radioButtonVitesseDeuxCent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVitesseDeuxCent.Checked)
            {
                speed = radioButtonVitesseDeuxCent.Text;
            }
        }

        private void radioButtonVitesseTroisCent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVitesseTroisCent.Checked)
            {
                speed = radioButtonVitesseTroisCent.Text;
            }
        }

        private void radioButtonVitesseCinqCent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVitesseCinqCent.Checked)
            {
                speed = radioButtonVitesseCinqCent.Text;
            }
        }



        private void radioButtonTemperaturQuatreVingt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTemperaturQuatreVingt.Checked)
            {
                temp = radioButtonTemperaturQuatreVingt.Text;
            }
        }

        private void radioButtonTemperatureCent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTemperatureCent.Checked)
            {
                temp = radioButtonTemperatureCent.Text;
            }
        }

        private void radioButtonTemperaturCinquante_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTemperaturCinquante.Checked)
            {
                temp = radioButtonTemperaturCinquante.Text;
            }
        }

        private void Appli1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez-vous fermer cette magnifique et utile app !?", "R U SURE ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rep == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

    }
}
