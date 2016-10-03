using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvDevLabo4.Model
{
    public class Student
    {
        public String Name
        {
            get;
            set;
        }

       public int Age
        {
            get;
            set;
        }

        public Student(String n, int a)
        {
            Name = n;
            Age = a;
        }
    }
}
