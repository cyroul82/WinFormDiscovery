using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo2b
{
    public partial class frmExo2b : Form
    {
        public frmExo2b()
        {
            InitializeComponent();
        }
        private Int32 rechercheCaractre(String zone, Char caractereRecherche)
        {
            Int32 cmptr = 0;
            for(int i = 0; i<=zone.Length - 1; i++)
            {
                if(zone[i] == caractereRecherche)
                {
                    cmptr++;
                }
            }
            return cmptr;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Int32 nbrOccurences = 0;

            if(textBoxLetter.Text.Length == 0)
            {
                MessageBox.Show("Vous n'avez pas renseigné le caractère à rechercher");
                textBoxLetter.Focus();
            }
            else
            {
                textBoxLetter.Text = textBoxLetter.Text.Substring(0, 1);

                if (checkBoxPhrase1.Checked)
                {
                    nbrOccurences += rechercheCaractre(textBox1.Text, Char.Parse(textBoxLetter.Text));
                }
                if (checkBoxPhrase2.Checked)
                {
                    nbrOccurences += rechercheCaractre(textBox2.Text, Char.Parse(textBoxLetter.Text));
                }
                if (checkBoxPhrase3.Checked)
                {
                    nbrOccurences += rechercheCaractre(textBox3.Text, Char.Parse(textBoxLetter.Text));
                }

                textBoxOccurence.Text = nbrOccurences.ToString();
            }
        }
    }
}
