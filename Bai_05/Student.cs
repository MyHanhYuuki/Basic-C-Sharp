using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_05
{
    public class Student
    {
        string id, name, department;
        double gpa;
        public string ID
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Department
        {
            get => department;
            set => department = value;
        }
        public double GPA
        {
            get => gpa;
            set => gpa = value;
        }
        public Student(string i = "", string n = "", string d = "", double g = 0)
        {
            id = i; name = n; department = d; gpa = g;
        }
    }
}
