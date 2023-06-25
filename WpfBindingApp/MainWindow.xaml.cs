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

namespace WpfBindingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeeModel employee = null!;
        Employee employee1 = null!;
        public MainWindow()
        {
            InitializeComponent();

            //Binding binding = new Binding();
            //binding.ElementName = "txtBox";
            //binding.Path = new PropertyPath("Text");
            //txtBlock.SetBinding(TextBlock.TextProperty, binding);

            //employee = new EmployeeModel() { Name = "Bobby", Age = 23 };
            //txtBox.DataContext = employee;

            employee1 = new Employee() { Name = "Mike", Age = 24 };
            stack.DataContext = employee1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //BindingOperations.ClearBinding(txtBlock, TextBlock.TextProperty);
            //BindingOperations.ClearAllBindings(txtBlock);
            BindingExpression expr = BindingOperations.GetBindingExpression(txtBox, TextBox.TextProperty);
            expr.UpdateSource();
        }

        private void btnNewName_Click(object sender, RoutedEventArgs e)
        {
            employee.Name = "Tommy";
        }

        private void btnShowName_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(employee.Name);
        }
    }
}
