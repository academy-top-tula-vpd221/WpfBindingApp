using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfBindingApp
{
    class Employee : DependencyObject
    {
        public static readonly DependencyProperty NameProperty;
        public static readonly DependencyProperty AgeProperty;

        static Employee()
        {
            NameProperty = DependencyProperty.Register(
                "Name",
                typeof(string),
                typeof(Employee)
                );
            AgeProperty = DependencyProperty.Register(
                "Age",
                typeof(int),
                typeof(Employee)
                );
        }
        public string Name
        {
            get => (string)GetValue(NameProperty);
            set => SetValue(NameProperty, value);
        }
        public int Age
        {
            get => (int)GetValue(AgeProperty);
            set => SetValue(AgeProperty, value);
        }
    }




    class EmployeeModel : INotifyPropertyChanged
    {
        Employee employee = new Employee();

        public string Name
        {
            get => employee.Name;
            set
            {
                employee.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Age
        {
            get => employee.Age;
            set
            {
                employee.Age = value;
                OnPropertyChanged(nameof(Age));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
