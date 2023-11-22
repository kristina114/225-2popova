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
using static System.Math;

namespace ЛАБ3
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(TextBox1.Text, out double A))
            {
                MessageBox.Show("Поле А только число!");
            }
            if (!double.TryParse(textbox2.Text, out double B))
            {
                MessageBox.Show("Поле B только число!");
            }
            if (!double.TryParse(textbox3.Text, out double C))
            {
                MessageBox.Show("Поле C только число!");
            }
            A = B;
            B = C;
            C = A;
            TextBox4.Text += $"{A}{B}{C}\n";

        }
    }
}
