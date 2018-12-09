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
        //private const string Dot = ".";
        double result = 0, lastNumber = 0;
        string operation = "";
        bool hasValue = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //if (Button_Click()) { result.Text = ""};
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            string content = b.Content.ToString();
           
            if (resultDisplay.Text == "0" || hasValue)//Cleaning display from zero
            {
                resultDisplay.Text = "";
                hasValue = false;
            }

            if (content == ".")
            {
                if (resultDisplay.Text.Contains(".")) //If there is . already
                {
                    resultDisplay.Text = resultDisplay.Text;
                }
                else
                {
                    resultDisplay.Text += content;
                    
                }
            }
            else
            {
                resultDisplay.Text += content;
                
            }

        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            hasValue = true;
            Button b = (Button)sender;
            //result = Double.Parse(resultDisplay.Text);
            operation = b.Content.ToString();
            //ButtonEquals_Click(this, null);                                
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    resultDisplay.Text = (result + Double.Parse(resultDisplay.Text)).ToString();
                    break;
                case "-":
                    resultDisplay.Text = (result - Double.Parse(resultDisplay.Text)).ToString();
                    break;
                case "*":
                    resultDisplay.Text = (result * Double.Parse(resultDisplay.Text)).ToString();                    
                    break;
                case "/":
                    if (result == 0) resultDisplay.Text = result.ToString();
                    resultDisplay.Text = (result / Double.Parse(resultDisplay.Text)).ToString();
                    break;
                    /*case "%":
                        result += result;
                        resultDisplay.Text = result.ToString();
                        break;
                        */
            }
            result = Double.Parse(resultDisplay.Text);
            operation = "";
        }

            private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            resultDisplay.Text = "0";
            result = 0;
            hasValue = false;
        }

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            resultDisplay.Text = "0";
        }
    }
}
 