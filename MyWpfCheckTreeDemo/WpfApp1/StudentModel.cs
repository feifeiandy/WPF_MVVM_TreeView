using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1
{
    public class StudentModel:INotifyPropertyChanged
    {
        public Student newStudent;
        public RelayCommand btnCommand;
        private ObservableCollection<Student> students;
        public ObservableCollection<Student> Students
        {
            get { return students; }
            set { students = value;
                this.OnPropertyChanged("Students");
            }
        }
        public void run()
        {
            newStudent = new Student();
            newStudent.Name = "xmx";
        }
        
        public StudentModel()
        {
            Students = new ObservableCollection<Student>();
          
            Student s1= new Student() {ID=1,Name="1"};
           
            Student s2= new Student() {ID=2,Name="2"};
            s1.Stus.Add(s2);

            Student s3 = new Student() { ID = 2, Name = "3",IsChecked=true };
            s2.Stus.Add(s3);

            Student s4 = new Student() { ID = 2, Name = "4" };
            s2.Stus.Add(s4);

            Students.Add(s1);

            this.btnCommand = new RelayCommand(run);
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

 

    }

    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public RelayCommand(Action a)
        {
            a();
        }
    }
}
