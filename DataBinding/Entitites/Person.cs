using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.Entitites
{
    public class Person : INotifyPropertyChanged
    {
        //public string Name { get; set; }

        private string name;
        private int age;
        private string mobile;
        private string email;
        private string photo;

        public int PersonID { get; set; }
        public string Name { get => name; set { name = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name")); } }

        public int Age { get => age; set { age = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Age")); } }

        public string Mobile { get => mobile; set { mobile = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mobile")); } }

        public string Email { get => email; set { email = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email")); } }

        public string Photo { get => photo; set { photo = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Photo")); } }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
