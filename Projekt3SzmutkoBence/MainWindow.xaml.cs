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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Projekt3SzmutkoBence
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Kerdes> Kerdesek = new List<Kerdes>();
        public string selectedTema;
        public MainWindow()
        {
            InitializeComponent();

            string[] sorok = File.ReadAllLines("torikerdes.txt");
            foreach (string sor in sorok)
            {
                string[] adatok = sor.Split(new char[] { ';' });
                string temakor = adatok[0];
                string kerdes = adatok[1];
                int helyesValasz = int.Parse(adatok[2]);
                List<string> valaszok = new List<string>();
                for (int i = 3; i < adatok.Length; i++)
                {
                    valaszok.Add(adatok[i]);
                }
                Kerdesek.Add(new Kerdes(temakor, kerdes, valaszok, helyesValasz));
            }
            
            temaValasztas.Items.Add("Történelem");
            temaValasztas.Items.Add("Matematika");
            temaValasztas.Items.Add("Irodalom");
            

        }

        private void megerosites_Click(object sender, RoutedEventArgs e)
        {
            if (temaValasztas.SelectedItem == null)
            {
                return;
            }
            Window1 win2 = new Window1(Kerdesek, selectedTema);
            win2.Show();
            this.Close();
        }

        private void temaValasztas_Selected(object sender, RoutedEventArgs e)
        {
            selectedTema = temaValasztas.SelectedItem.ToString();
        }
    }
}
