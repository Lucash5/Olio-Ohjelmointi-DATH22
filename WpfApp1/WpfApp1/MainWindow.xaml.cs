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

namespace WpfApp1
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

        private void click1(object sender, RoutedEventArgs e)
        {
            if (btn1.IsEnabled)
            {
                if (txt1.Text == "pois päältä")
                {
                    txt1.Text = "päällä";
                }
                else
                {
                    txt1.Text = "pois päältä";
                }
            }

        }

        private void click2(object sender, RoutedEventArgs e)
        {
            if (btn2.IsEnabled)
            {
                if (txt2.Text == "pois päältä")
                {
                    txt2.Text = "päällä";
                }
                else
                {
                    txt2.Text = "pois päältä";
                }
            }

        }


        private void click3(object sender, RoutedEventArgs e)
        {
            if (btn3.IsEnabled)
            {
                if (txt3.Text == "lukossa")
                {
                    txt3.Text = "auki";
                }
                else
                {
                    txt3.Text = "lukossa";
                }
            }

        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txt_Lämpötila.Text = "Lämpötila: " + slider1.Value;
        }
    }
    
    
}
