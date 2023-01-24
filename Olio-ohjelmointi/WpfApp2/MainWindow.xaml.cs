using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int r = 1;
        int t = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void click2(object sender, RoutedEventArgs e)
        {
            txt_2.Text = "Mopoautoja : " + r;
            r++;
        }

        private void click1(object sender, RoutedEventArgs e)
        {
            txt_1.Text = "Traktoreita : " + t;
            t++;
            Convert.ToString(r);
        }

        private void click3(object sender, RoutedEventArgs e)
        {
            Pituus.Text = Convert.ToString(float.Parse(Pituus.Text) * 1.609344);
        }

        private void click4(object sender, RoutedEventArgs e)
        {
            Pituus.Text = Convert.ToString(float.Parse(Pituus.Text) / 1.609344);
        }

        private void Pituus_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
