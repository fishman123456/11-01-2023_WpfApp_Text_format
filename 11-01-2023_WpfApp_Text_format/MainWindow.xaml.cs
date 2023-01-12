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

namespace _11_01_2023_WpfApp_Text_format
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

        private void font_size_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            for (int i = 2; i < 250; i++)
            {
                if (i%2==0)
                {
                    data.Add(i.ToString());
                }
                
            }

            var combo = sender as ComboBox;
            combo.ItemsSource = data;
        }

        private void font_size_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var znach = font_size.SelectedValue.ToString();
            TextBox1.FontSize = int.Parse(znach);
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox1.FontWeight = FontWeights.Regular;
            TextBox1.FontStyle = FontStyles.Normal;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBox1.FontWeight = FontWeights.Bold;
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TextBox1.FontStyle = FontStyles.Italic;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
