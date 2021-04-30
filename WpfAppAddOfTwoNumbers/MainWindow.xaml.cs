using LibraryAddNumbers;
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

namespace WpfAppAddOfTwoNumbers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a, b, result;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxNumber1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((TextBoxNumber1.Text != "") &&
    (!double.TryParse(TextBoxNumber1.Text, out a)))
            {
                MessageBox.Show("Правильный формат ввода число-запятая-число",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                TextBoxNumber1.Text = "";
            }
            TextBoxResult.Text = "";

        }

        private void TextBoxNumber2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBoxNumber2.Text != "")
                if (!double.TryParse(TextBoxNumber2.Text, out b))
                {
                    MessageBox.Show("Правильный формат ввода число-запятая-число",
                    "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                    TextBoxNumber2.Text = "";
                }
            TextBoxResult.Text = "";

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            result = (double)SumNumber.Add(a, b);
            TextBoxResult.Text = result.ToString();
        }
    }
}
