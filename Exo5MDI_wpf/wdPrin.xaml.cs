using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Exo5MDI_wpf
{
    /// <summary>
    /// Logique d'interaction pour wdPrin.xaml
    /// </summary>
    public partial class wdPrin : Window
    {
        public wdPrin()
        {
            InitializeComponent();
            Affiche();
        }

        private void buttonActualiser_Click(object sender, RoutedEventArgs e)
        {
            Affiche();
        }

        private void buttonFermer_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Affiche()
        {
            textBoxRandom.Text = Donnees.random.ToString();
        }
    }
}
