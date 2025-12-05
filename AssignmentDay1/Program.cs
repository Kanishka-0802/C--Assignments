using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay1
{
    partial class Student
    {
       
        public string Name { get; set; }
        public int Age { get; set; }
       

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Kanishka";
            student.Age = 20;
            student.DisplayDetails();
            Console.ReadLine();
        }
    }
}
