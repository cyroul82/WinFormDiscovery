using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo3
{
    public partial class frmExo3 : Form
    {
        public frmExo3()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            comboBoxSource.Items.Clear();
            this.comboBoxSource.Items.AddRange(new object[] {
            "France",
            "Belgique",
            "Allemagne",
            "Japon",
            "Portugal",
            "Grèce"});
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            foreach(Object o in comboBoxSource.Items)
            {
                listBoxCible.Items.Add(o);
            }
            comboBoxSource.Items.Clear();
            buttonAddAll.Enabled = false;
            buttonAddOne.Enabled = false;
            buttonDeleteOne.Enabled = true;
            buttonDeleteAll.Enabled = true;
        }

        private void buttonAddOne_Click(object sender, EventArgs e)
        {
            if (comboBoxSource.SelectedItem != null)
            {
                listBoxCible.Items.Add(comboBoxSource.SelectedItem);
                comboBoxSource.Items.Remove(comboBoxSource.SelectedItem);
                comboBoxSource.Text = null;

                if (comboBoxSource.Items.Count == 0)
                {
                    buttonAddAll.Enabled = false;
                }
                buttonDeleteOne.Enabled = true;
                buttonDeleteAll.Enabled = true;
            }
        }

        private void comboBoxSource_DropDown(object sender, EventArgs e)
        {
            if (comboBoxSource.Text != "")
            {
                if (!(comboBoxSource.Items.Contains(comboBoxSource.Text)))
                {
                    if (!(listBoxCible.Items.Contains(comboBoxSource.Text)))
                    {
                        DialogResult res = MessageBox.Show("Le Pays " + comboBoxSource.Text + " n'est pas présent dans la liste,\n Voulez-vous le rajouter ?", "Pays Manquant ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            comboBoxSource.Items.Add(comboBoxSource.Text);
                            
                            buttonAddAll.Enabled = true;
                        }
                        comboBoxSource.Text = "";

                    }
                }
            }
        }

        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSource.SelectedItem != null)
            {
                buttonAddOne.Enabled = true;
            }
            else
            {
                buttonAddOne.Enabled = false;
            }
            
        }

        private void buttonDeleteOne_Click(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedItem != null)
            {
                comboBoxSource.Items.Add(listBoxCible.SelectedItem);
                listBoxCible.Items.Remove(listBoxCible.SelectedItem);
                listBoxCible.SelectedItem = null;

                if (listBoxCible.Items.Count == 0)
                {
                    buttonDeleteOne.Enabled = false;
                    buttonDeleteAll.Enabled = false;
                }
                buttonAddAll.Enabled = true;
            }
        }

        private void buttonDeleteAll_Click(object sender, EventArgs e)
        {
            foreach (Object o in listBoxCible.Items)
            {
                comboBoxSource.Items.Add(o);
            }
            listBoxCible.Items.Clear();
            buttonDeleteAll.Enabled = false;
            buttonDeleteOne.Enabled = false;
            buttonAddAll.Enabled = true;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedItems.Count <= 2) { 
                Object temp;
                if (listBoxCible.SelectedIndex != 0 && listBoxCible.SelectedItem != null)
                {
                    temp = listBoxCible.SelectedItem;
                    listBoxCible.Items[listBoxCible.SelectedIndex] = listBoxCible.Items[listBoxCible.SelectedIndex - 1];
                    listBoxCible.Items[listBoxCible.SelectedIndex - 1] = temp;
                    listBoxCible.SelectedIndex--;
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedItems.Count <= 2)
            {
                Object temp;
                if (listBoxCible.SelectedIndex != listBoxCible.Items.Count - 1 && listBoxCible.SelectedItem != null)
                {
                    temp = listBoxCible.SelectedItem;
                    listBoxCible.Items[listBoxCible.SelectedIndex] = listBoxCible.Items[listBoxCible.SelectedIndex + 1];
                    listBoxCible.Items[listBoxCible.SelectedIndex + 1] = temp;
                    listBoxCible.SelectedIndex++;
                }
            }
        }

        private void listBoxCible_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCible.SelectedItem != null && listBoxCible.Items.Count >= 2)
            {
                buttonUp.Enabled = true;
                buttonDown.Enabled = true;
            }
            else
            {
                buttonUp.Enabled = false;
                buttonDown.Enabled = false;
            }
        }



        private void comboBoxSource_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                comboBoxSource_DropDown(sender, e);
            }
        }
    }
}
