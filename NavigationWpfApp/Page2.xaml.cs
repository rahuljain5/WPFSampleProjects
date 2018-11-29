﻿using System;
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

namespace NavigationWpfApp
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public string Name { get; set; }
        public Page2()
        {
            InitializeComponent();
        }
        public Page2(string pname)
        {
            InitializeComponent();
            Name = pname;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            msg.Text = "Hello " + Name;
        }
    }
}
