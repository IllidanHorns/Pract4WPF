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

namespace Pract4WPF
{
    /// <summary>
    /// Логика взаимодействия для ChangeTestPage.xaml
    /// </summary>
    public partial class ChangeTestPage : Page
    {
        public List<TestClass> Tests = new List<TestClass>();
        public ChangeTestPage()
        {
            InitializeComponent();
            change_test_datagrid.ItemsSource = Tests;
        }
    }
}
