using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        StudentModel studentModel = new StudentModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = studentModel;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class Student : INotifyPropertyChanged
    {
        public int ID { get; set; }
        private bool? isChecked;
        public bool? IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                this.OnPropertyChanged("IsChecked");
            }

        }
        private string name;
        private bool isSelect;
        public bool IsSelect
        {
            get { return isSelect; }
            set
            {
                isSelect = value;
                this.OnPropertyChanged("IsSelect");
                if (this.IsSelect)
                {
                    this.SelectStudentItem = this;
                    //Student student = new Student();
                    //student.name = "xx";
                    //this.Stus.Add(student);
                }
                else
                {
                    this.SelectStudentItem = null;
                }
                MessageBox.Show(this.SelectStudentItem.Name);
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                this.OnPropertyChanged("Name");
            }
        }
        private Student selectStudentItem;
        public Student SelectStudentItem
        {
            get { return selectStudentItem; }
            set
            {
                selectStudentItem = value;
                this.OnPropertyChanged("SelectStudentItem");
            }
        }
        private ObservableCollection<Student> stus;
        public ObservableCollection<Student> Stus
        {
            get { return stus; }
            set
            {
                stus = value;
                this.OnPropertyChanged("Stus");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Student()
        {
            this.Stus = new ObservableCollection<Student>();
        }
    }

    public class StstusConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return ToggleState.Indeterminate;
            }
            bool flag = (bool)value;
            if (flag == true)
            {
                return ToggleState.On;
            }
            return ToggleState.Off;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return null;
            }
            ToggleState flag = (ToggleState)value;
            if (flag == ToggleState.On)
            {
                return true;
            }
            if (flag == ToggleState.Off)
            {
                return false;

            }
            return null;
        }
    }
}
