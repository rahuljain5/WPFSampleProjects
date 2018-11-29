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

namespace SimpleCalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double number1 = 0;
        private double number2 = 0;
        private string optr = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(0);
        }

        private void UpdateNumber(double d)
        {
            if (optr == string.Empty)
            {
                number1 = number1 * 10 + d;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = number2 * 10 + d;
                Result.Text = number2.ToString();
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (optr)
            {
                case "+":
                    Result.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    Result.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    Result.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    Result.Text = (number1 / number2).ToString();
                    break;
                case "%":
                    Result.Text = (number1 % number2).ToString();
                    break;
                case "^":
                    Result.Text = Math.Pow(number1, number2).ToString();
                    break;
                default:
                    break;
            }
            number1 = double.Parse(Result.Text);
            number2 = 0;
            optr = string.Empty;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(3);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            optr = "+";
            Result.Text = number2.ToString();
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(6);
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            optr = "-";
            Result.Text = number2.ToString();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(7);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            UpdateNumber(9);
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            optr = "*";
            Result.Text = number2.ToString();
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            optr = "/";
            Result.Text = number2.ToString();
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (optr == string.Empty)
            {
                number1 = 0;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = 0;
                Result.Text = number1.ToString();
            }
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            optr = string.Empty;
            Result.Text = string.Empty;
        }

        private void BackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (optr == string.Empty)
            {
                number1 = (int)number1 / 10;
                Result.Text = number1.ToString();
            }
            else
            {
                number2 = (int)number2 / 10;
                //number2= Math.Floor(number2);
                Result.Text = number2.ToString();
            }
        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            optr = "%";
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (number1 > 0)
                number1 = Math.Sqrt(number1);
            Result.Text = number1.ToString();
        }

        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
            optr = "^";
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            if (btn != null)
            {
                
            }
        }
    }
}
