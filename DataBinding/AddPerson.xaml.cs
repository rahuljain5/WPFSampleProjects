using DataBinding.DAL;
using DataBinding.Entitites;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for AddPerson.xaml
    /// </summary>
    public partial class AddPerson : Window
    {
        Person p = null;
        PersonDBContext context = new PersonDBContext();
        public ObservableCollection<Person> people = null;
        public AddPerson()
        {
            InitializeComponent();
            p = new Person();
            DataContext = p;
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            context.People.Add(p);
            context.SaveChanges();
            people.Add(p);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true) {
                p.Photo = dialog.FileName;
            };
        }


    }
}
