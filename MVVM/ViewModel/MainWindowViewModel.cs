using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_SimpleApp_Multiple_Command_Parameters.MVVM.Commands;
using WPF_SimpleApp_Multiple_Command_Parameters.MVVM.Model;

namespace WPF_SimpleApp_Multiple_Command_Parameters.MVVM.ViewModel
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        private List<Teacher> myVar;

       

        public List<Teacher> TeacherDetails
        {
            get { return myVar; }
            set 
            { 
                myVar = value;
                OnPropertyChnaged("TeacherDetails");
            }
        }

        private ICommand myVar2;

        public ICommand SubmitCommand
        {
            get { return myVar2; }
            set { myVar2 = value;
            }
        }


        public MainWindowViewModel()
        {
            TeacherDetails=new List<Teacher>();
            TeacherDetails.Add(new Teacher("TeacherName-1", "He takes Maths Class", "8th A Division"));
            SubmitCommand = new GenericCommand(CanExecute, OnSubmit);

        }



        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void OnSubmit(object parameter)
        {
            var values = (object[])parameter;
            var temp = new List<Teacher>();
           
            foreach (var v in TeacherDetails) { 
                temp.Add(v);
            }
            temp.Add(new Teacher((string)values[0], (string)values[1], (string)values[2]));
            TeacherDetails = temp;

        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChnaged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
