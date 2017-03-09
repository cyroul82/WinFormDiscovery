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
    /// Logique d'interaction pour wdChrono.xaml
    /// </summary>
    public partial class wdChrono : Window
    {
        public wdChrono()
        {
            InitializeComponent();
            textBoxChrono.Text = Donnees.Chrono.ToString();
        }

        private void buttonActualiser_Click(object sender, RoutedEventArgs e)
        {
            textBoxChrono.Text = Donnees.Chrono.ToString();
        }

        private void buttonFermer_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
