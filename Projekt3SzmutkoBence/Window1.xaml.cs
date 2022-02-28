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
        Kerdes jelenlegiKerdes;
        Random rnd = new Random();
        List<int> lista = new List<int>();
        int osszes = 0;
        int eltalalt = 0;
        public Window1(List<Kerdes> Kerdesek, string tema)
        {
            InitializeComponent();
            
            
            
            this.Kerdesek = Kerdesek;
            BetoltUjKerdes(Kerdesek, rnd, lista);

        }
        private void visszaSzinez() 
        {
            valasz1.Background = Brushes.White;
            valasz2.Background = Brushes.White;
            valasz3.Background = Brushes.White;
            valasz4.Background = Brushes.White;
        }
        private void BetoltUjKerdes(List<Kerdes> Kerdesek, Random rnd, List<int> lista)
        {
            lista.Clear();
            while (lista.Count < 4)
            {
                int szam = rnd.Next(0, 4);
                if (lista.Contains(szam))
                {

                }
                else
                {
                    lista.Add(szam);
                }
            }
            visszaSzinez();
            jelenlegiKerdes = Kerdesek[rnd.Next(0, Kerdesek.Count)];
            KerdesLabel.Content = jelenlegiKerdes.kerdes;
            valasz1.Content = jelenlegiKerdes.valaszok[lista[0]];
            valasz2.Content = jelenlegiKerdes.valaszok[lista[1]];
            valasz3.Content = jelenlegiKerdes.valaszok[lista[2]];
            valasz4.Content = jelenlegiKerdes.valaszok[lista[3]];
            osszes++;
            
        }

        private void valasz1_Click(object sender, RoutedEventArgs e)
        {
            if (valasz1.Content == jelenlegiKerdes.helyesValasz)
            {
                valasz1.Background = Brushes.Green;
                eltalalt++;
            }
            else
            {
                valasz1.Background = Brushes.Red;
            }
            
        }

        private void valasz2_Click(object sender, RoutedEventArgs e)
        {
            if (valasz2.Content == jelenlegiKerdes.helyesValasz)
            {
                valasz2.Background = Brushes.Green;
                eltalalt++;
            }
            else
            {
                valasz2.Background = Brushes.Red;
            }
            
        }

        private void valasz3_Click(object sender, RoutedEventArgs e)
        {
            if (valasz3.Content == jelenlegiKerdes.helyesValasz)
            {
                valasz3.Background = Brushes.Green;
                eltalalt++;
            }
            else
            {
                valasz3.Background = Brushes.Red;
            }
            
        }

        private void valasz4_Click(object sender, RoutedEventArgs e)
        {
            if (valasz4.Content == jelenlegiKerdes.helyesValasz)
            {
                valasz4.Background = Brushes.Green;
                eltalalt++;
            }
            else
            {
                valasz4.Background = Brushes.Red;
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BetoltUjKerdes(Kerdesek, rnd, lista);
        }

        private void kiertekeles_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Eredmény: {osszes}/{eltalalt}", "Kiértékelés");
        }
    }
}
