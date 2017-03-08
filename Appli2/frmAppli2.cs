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
    public partial class frmAppli2 : Form
    {
        private String speed;
        private String temp;
        public frmAppli2()
        {
            InitializeComponent();
            SetDefaultValueComboBox();
            
        }

        private void SetDefaultValueComboBox()
        {
            comboBoxVitesse.SelectedIndex = 0;
            comboBoxTemperature.SelectedIndex = 0;
        }

        private void SetEnableGroupBoxTempAndSpeed(Boolean b)
        {
            comboBoxVitesse.Enabled = b;
            comboBoxTemperature.Enabled = b;
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
                SetDefaultValueComboBox();
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


        private void Appli1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rep = MessageBox.Show("Voulez-vous fermer cette magnifique et utile app !?", "R U SURE ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rep == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void comboBoxVitesse_SelectedIndexChanged(object sender, EventArgs e)
        {
            speed = comboBoxVitesse.SelectedItem.ToString();
        }

        private void comboBoxTemperature_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp = comboBoxTemperature.SelectedItem.ToString();
        }
    }
}
