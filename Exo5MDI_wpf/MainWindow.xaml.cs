using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Exo5MDI_wpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private System.Random aleat;
        private wdChrono wdC;
        private wdPrin wdR;
        public MainWindow()
        {
            InitializeComponent();
            aleat = new System.Random();
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            Display();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Donnees.Chrono++;
            Donnees.random = aleat.NextDouble();
            Display();
        }

        private void Display()
        {
            textBoxChrono.Text = Donnees.Chrono.ToString();
            textBoxRandom.Text = Donnees.random.ToString();
        }

        private void MenuItem_Click_Nombre(object sender, RoutedEventArgs e)
        {
            if (wdR == null)
            {
                wdR = new wdPrin();
                wdR.Closing += new System.ComponentModel.CancelEventHandler(this.CloseRandom);
                wdR.Show();
            }
            else
            {
                wdR.Activate();
            }
        }

        private void CloseChrono(object sender, System.ComponentModel.CancelEventArgs e)
        {
            wdC = null;
        }

        private void CloseRandom(object sender, System.ComponentModel.CancelEventArgs e)
        {
            wdR = null;
        }

        private void MenuItem_Click_Chrono(object sender, RoutedEventArgs e)
        {
            if (wdC == null)
            {
                wdC = new wdChrono();
                wdC.Closing += new System.ComponentModel.CancelEventHandler(this.CloseChrono);
                wdC.Show();
            }
            else
            {
                wdC.Activate();
            }
        }

        private void WindowClosing_Event(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult rep = MessageBox.Show("Do u wanna close ?", "Closing ?", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(rep != MessageBoxResult.No)
            {
                if(wdC!=null)wdC.Close();
                if(wdR!=null)wdR.Close();
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
