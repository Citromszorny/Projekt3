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
using System.IO;

namespace Projekt3SzmutkoBence
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Kerdes> Kerdesek;
        public Window1(List<Kerdes> Kerdesek, string tema)
        {
            InitializeComponent();
            this.Kerdesek = Kerdesek;
            
            KerdesLabel.Content = Kerdesek[0].kerdes;
            valasz1.Content = Kerdesek[0].valaszok[0];
            valasz2.Content = Kerdesek[0].valaszok[1];
            valasz3.Content = Kerdesek[0].valaszok[2];
            valasz4.Content = Kerdesek[0].valaszok[3];

        }



        private void valasz1_Click(object sender, RoutedEventArgs e)
        {
            if (valasz1.Content == Kerdesek[0].helyesValasz)
            {
                valasz1.Background = Brushes.Green;
            }
            else
            {
                valasz1.Background = Brushes.Red;
            }
        }

        private void valasz2_Click(object sender, RoutedEventArgs e)
        {
            if (valasz2.Content == Kerdesek[0].helyesValasz)
            {
                valasz2.Background = Brushes.Green;
            }
            else
            {
                valasz2.Background = Brushes.Red;
            }
        }

        private void valasz3_Click(object sender, RoutedEventArgs e)
        {
            if (valasz3.Content == Kerdesek[0].helyesValasz)
            {
                valasz3.Background = Brushes.Green;
            }
            else
            {
                valasz3.Background = Brushes.Red;
            }
        }

        private void valasz4_Click(object sender, RoutedEventArgs e)
        {
            if (valasz4.Content == Kerdesek[0].helyesValasz)
            {
                valasz4.Background = Brushes.Green;
            }
            else
            {
                valasz4.Background = Brushes.Red;
            }
        }
    }
}
