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

namespace wpfapp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string käyttäjänNimi;
        // Unity start metodi
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_button1_Click(object sender, RoutedEventArgs e)
        {
            ekateksti.Text = "get trolled";
            image.Visibility = Visibility.Visible;
            käyttäjänNimi = Input_Nimi.Text;
            hello.Text = "fack yuo " + Input_Nimi.Text;
        }
        private void btn_button2_Click
    }
}
