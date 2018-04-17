using System;
using System.Collections.Generic;
using System.Data;
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

namespace SimpleCalculator
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
        private void append(String app)
        {
            numberBox.AppendText(app);
        }
        private void buttonSeven_Click(object sender, RoutedEventArgs e)
        {
            append("7");
        }

        private void buttonEight_Click(object sender, RoutedEventArgs e)
        {
            append("8");
        }

        private void buttonNine_Click(object sender, RoutedEventArgs e)
        {
            append("9");

        }

        private void buttonFour_Click(object sender, RoutedEventArgs e)
        {

            append("4");
        }

        private void buttonFive_Click(object sender, RoutedEventArgs e)
        {
            append("5");
        }

        private void buttonSix_Click(object sender, RoutedEventArgs e)
        {
            append("6");
        }

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            append("1");
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e)
        {
            append("2");
        }

        private void buttonThree_Click(object sender, RoutedEventArgs e)
        {
            append("3");
        }

        private void buttonZero_Click(object sender, RoutedEventArgs e)
        {
            append("0");
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            append("+");
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            append("-");
        }

        private void buttonMult_Click(object sender, RoutedEventArgs e)
        {
            append("*");
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            append("/");
        }

        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            try
            {
                numberBox.Text = dt.Compute(numberBox.Text.ToString(), "").ToString();
            }
            catch(EvaluateException exc)
            {
                numberBox.Text = "Bad Eval";
                Console.WriteLine(exc.StackTrace);
            }
            
        }
    }
}
