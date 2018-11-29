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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace XMLBinding
{
    /// <summary>
    /// Interaction logic for XMLBinding.xaml
    /// </summary>
    public partial class XMLBindingDemo : Window
    {
        public XMLBindingDemo()
        {
            InitializeComponent();
            //XElement xElement = XElement.Load("C:/Users/Rahul Jain/source/repos/WpfAppDemo/XMLBinding/Company.xml");
            //var empList = from e in xElement.Descendants("EmployeeInfo")
            //              select new { EmpNo = e.Element("EmpNo").Value, EmpName = e.Element("EmpName").Value, EmpImg = e.Element("EmpImage").Value };
            //this.DataContext = empList.ToList();
        }
    }
}
