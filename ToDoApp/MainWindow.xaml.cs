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

namespace ToDoApp
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

        //private void Item5CheckBox_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(Item5CheckBox.Content.ToString());
        //    if(icon.Kind == MaterialDesignThemes.Wpf.PackIconKind.CheckDecagram)
        //        icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckCircleOutline;
        //    else 
        //        icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckDecagram;
        //}
        private void IconSwitch(object sender, RoutedEventArgs e)
        {
            MaterialDesignThemes.Wpf.PackIcon icon = null;
            Button btn = e.Source as Button;
            if(btn != null){
                icon = btn.Content as MaterialDesignThemes.Wpf.PackIcon;
            if (icon.Kind == MaterialDesignThemes.Wpf.PackIconKind.CheckDecagram)
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckCircleOutline;
            else
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.CheckDecagram;
                btn.Content = icon;
            }
        }

        private void Sample5_DialogHost_OnDialogClosing(object src, RoutedEventArgs e) { }
    }
}
