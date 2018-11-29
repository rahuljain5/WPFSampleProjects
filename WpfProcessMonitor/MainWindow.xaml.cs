using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace WpfProcessMonitor
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            list.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(sortField.Text, System.ComponentModel.ListSortDirection.Ascending));
        }

        private void SortBtn_Click(object sender, RoutedEventArgs e)
        {
            string sort = "";
            if (sortField.Text == "Name")
                sort = "ProcessName";
            if (sortField.Text == "Memory")
                sort = "WorkingSet64";
            if (sortField.Text == "ID")
                sort = "Id";
            if (sortField.Text == "State")
                sort = "PriorityClass";
            if (sortAsc.IsChecked == true)
                list.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(sort, System.ComponentModel.ListSortDirection.Ascending));
            else
                list.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription(sort, System.ComponentModel.ListSortDirection.Descending));
        }

        private void FilterBtn_Click(object sender, RoutedEventArgs e)
        {
            list.Items.Filter = new Predicate<object>( p  => {
                Process pr = p as Process;
                if (pr.Id.ToString().Contains(filter.Text) || pr.ProcessName.ToString().Contains(filter.Text) || pr.WorkingSet64.ToString().Contains(filter.Text))
                    return true;
                else return false;
            });
        }

        private void priorityGroup_Click(object sender, RoutedEventArgs e)
        {
            list.Items.GroupDescriptions.Add(new PropertyGroupDescription("PriorityClass"));
        }
    }
}
