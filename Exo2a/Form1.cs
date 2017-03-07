using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo2a
{
    public partial class Exo2a : Form
    {
        public Exo2a()
        {
            InitializeComponent();
            Height = 194;
        }

        private void checkBoxChangeColor_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxColor.Visible = checkBoxChangeColor.Checked;

            Height = checkBoxChangeColor.Checked ? 307 : 194;
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRed.Checked)
            {
                lblColor.BackColor = System.Drawing.Color.Red;
            }
        }

        private void radioButtonVert_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVert.Checked)
            {
                lblColor.BackColor = System.Drawing.Color.Green;
            }
        }

        private void Bleu_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlue.Checked)
            {
                lblColor.BackColor = System.Drawing.Color.Blue;
            }
        }
    }
}
