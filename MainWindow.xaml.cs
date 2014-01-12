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

namespace RedGreenRefactor
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

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
        }

        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Green);
        }

        private void btnRefactor_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
        }
    }
}
