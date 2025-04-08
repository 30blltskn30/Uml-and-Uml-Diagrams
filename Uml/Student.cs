using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml
{
    public class Student
    {
        private string name;
        private string studentId;

        public Student(string name, string studentId)
        {
            this.name = name;
            this.studentId = studentId;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Student: {name}, ID: {studentId}");
        }
    }

}
