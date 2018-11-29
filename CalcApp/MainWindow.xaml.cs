using CalcApp.ViewModels;
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

namespace CalcApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new CalcViewModel();
        }

        //    private void btnSum_Click(object sender, RoutedEventArgs e)
        //    {
        //        int n1 = int.Parse(num1.Text);
        //        int n2 = int.Parse(num2.Text);
        //        result.Text = (n1 + n2).ToString();
        //    }

        //    private void num1_TextChanged(object sender, TextChangedEventArgs e)
        //    {
        //        bool n1 = int.TryParse(num1.Text, out int fno);
        //        bool n2 = int.TryParse(num2.Text, out int sno);
        //        if (n1 == true && n2 == true)
        //        {
        //            btnSum.IsEnabled = true;
        //            menuSum.IsEnabled = true;
        //        }
        //        else
        //        {
        //            btnSum.IsEnabled = false;
        //            menuSum.IsEnabled = true;
        //        }
        //    }
    }
}
