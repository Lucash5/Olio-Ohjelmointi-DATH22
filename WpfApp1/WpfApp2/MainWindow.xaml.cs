using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (input_Syöte.Text.Contains("+"))
            {
                string[] lasku = input_Syöte.Text.Split('+');
                List<double> numerot = new List<double>();

                foreach (var num in lasku)
                {
                    string numeroTekstinä = Regex.Replace(num, " ", "");
                    double numero = Convert.ToDouble(numeroTekstinä);
                    numerot.Add(numero);
                }

                double summa = 0;

                foreach (var num in numerot)
                {
                    summa += num;
                }

                MessageBox.Show(summa.ToString());
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

    }
}
