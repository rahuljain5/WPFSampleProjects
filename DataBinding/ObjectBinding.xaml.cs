using DataBinding.DAL;
using DataBinding.Entitites;
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
    /// Interaction logic for ObjectBinding.xaml
    /// </summary>
    public partial class ObjectBinding : Window
    {
        CollectionView view = null;
        PersonDBContext context = new PersonDBContext();
        ObservableCollection<Person> people = null;
        public ObjectBinding()
        {
            InitializeComponent();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            people = new ObservableCollection<Person>(context.People.ToList());

            this.DataContext = people;
            view = CollectionViewSource.GetDefaultView(people) as CollectionView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToFirst();
        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {
            if (view.CurrentPosition != 0)
                view.MoveCurrentToPrevious();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (view.CurrentPosition != view.Count - 1)
                view.MoveCurrentToNext();
        }

        private void btnLast_Click(object sender, RoutedEventArgs e)
        {
            view.MoveCurrentToLast();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {

            context.People.Remove(view.CurrentItem as Person);
            ObservableCollection<Person> people = this.DataContext as ObservableCollection<Person>;
            people.Remove(view.CurrentItem as Person);
            context.SaveChanges();
            //MessageBox.Show(people.Count.ToString());
            //view.MoveCurrentToNext();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Person> p1 = context.People.ToList();
            context.SaveChanges();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            AddPerson add = new AddPerson();
            add.people = people;
            add.ShowDialog();
        }

    }
}
