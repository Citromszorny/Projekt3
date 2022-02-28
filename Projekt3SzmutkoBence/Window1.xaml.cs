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
            Kerdesek.FindAll(k => k.temakor == tema);
            KerdesLabel.Content = Kerdesek[0].kerdes;
          
        }

        private void valasz2_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
