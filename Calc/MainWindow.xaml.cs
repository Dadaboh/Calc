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

namespace Calc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string op1;
            string op2;
            string result;
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            L1.Content += "1";
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            L1.Content += "2";
        }

        private void B3_Click_1(object sender, RoutedEventArgs e)
        {
            L1.Content += "3";
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            L1.Content += "4";
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            L1.Content += "5";
        }

        private void B6_Click(object sender, RoutedEventArgs e)
        {
            L1.Content += "6";
        }

        private void B7_Click(object sender, RoutedEventArgs e)
        {
            L1.Content += "7";
        }

        private void B8_Click(object sender, RoutedEventArgs e)
        {
            L1.Content += "8";
        }

        private void B9_Click(object sender, RoutedEventArgs e)
        {
            L1.Content += "9";
        }
    }
}
