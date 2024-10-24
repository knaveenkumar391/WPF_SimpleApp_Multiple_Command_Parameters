using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SimpleApp_Multiple_Command_Parameters.MVVM.Model
{
    public class Teacher
    {
        public string TeacherName { get; set; }
        public string TeacherDescription { get; set; }
        public string TeachingSection {  get; set; }
        public Teacher(string TName,string TDisp,string Tsection) {
            TeacherName = TName;
            TeacherDescription = TDisp;
            TeachingSection = Tsection;
        }
    }
}
