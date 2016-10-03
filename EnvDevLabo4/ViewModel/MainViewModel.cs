using EnvDevLabo4.Model;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvDevLabo4.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<Student> _students;

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                RaisePropertyChanged("Students");
            }
        }

        public MainViewModel()
        {
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }
    }
}
