using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AssignmentDay2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public int TotalMarks { get; set; }
        public char Gender { get; set; }


        public override string ToString()
            => $" Name : {Name}, Class : {Class}, TotalMarks : {TotalMarks}";


    }
    class Program
    {

//        Dictionary<string, Student> student = new Dictionary<string, Student>()
//        {
//            ["student:1"] = new Student { Name = "Indhu", Class = "CT", TotalMarks = 443, Gender = 'F' },
//            ["student:2"] = new Student { Name = "Pravin", Class = "CSE", TotalMarks = 450, Gender = 'M' },
//            ["student:3"] = new Student { Name = "sasti", Class = "AI&DS", TotalMarks = 483, Gender = 'F' },
//            ["student:4"] = new Student { Name = "mahitha", Class = "AI&DS", TotalMarks = 469, Gender = 'F' },
//            ["student:5"] = new Student { Name = "yuva", Class = "IT", TotalMarks = 493, Gender = 'F' },

//        };
//        public void ShowAllStudents()
//        {
//            WriteLine("-------------Students Detail-----------");
//            WriteLine("\n");
//            foreach (var item in student)
//            {
//                WriteLine($"{item.Key}  {item.Value}");
//            }
//        }
//        static void Main(string[] args)
//        {
//            Program p = new Program();
//            p.ShowAllStudents();
//            ReadLine();

//        }

//    }
//}






        
        static Dictionary<int, Student> students = new Dictionary<int, Student>()
        {
            [1] = new Student { Id = 1, Name = "Indhu", Class = "CT", TotalMarks = 443, Gender = 'F' },
            [2] = new Student { Id = 2, Name = "Pravin", Class = "CSE", TotalMarks = 450, Gender = 'M' },
            [3] = new Student { Id = 3, Name = "Sasti", Class = "AI&DS", TotalMarks = 483, Gender = 'F' },
            [4] = new Student { Id = 4, Name = "Mahitha", Class = "AI&DS", TotalMarks = 469, Gender = 'F' },
            [5] = new Student { Id = 5, Name = "Yuva", Class = "IT", TotalMarks = 493, Gender = 'F' },
            [6] = new Student { Id = 6, Name = "sita", Class = "IT", TotalMarks = 400, Gender = 'M' } // for testing exception
        };


        public async Task<Student> GetStudentAsync(int id = 0)
        {
            try
            {
                return await Task.Run(() =>
                {
                  
                    if (id == 0)
                    {
                        return new Student { Name = "riya", Class = "AGRI", TotalMarks = 350, Gender = 'F' };
                    }

                    
                    if (students.TryGetValue(id, out Student student))
                    {
                 
                        if (student.TotalMarks < 300)
                        {
                            throw new Exception("Marks are less than 500");
                        }
                        return student;
                    }
                    else
                    {
                        return new Student { Name = "Not Found", Class = "N/A", TotalMarks = 0, Gender = 'U' };
                    }
                });
            }
            catch (Exception ex) when (ex.Message.Contains("less than 500"))
            {
                
             
                WriteLine($"Error: {ex.Message}");
                return new Student { Name = "Error Student", Class = "N/A", TotalMarks = 0, Gender = 'U' };
            }
        }


        public async Task ShowAllStudentsAsync()
        {
            try
            {
                WriteLine("------------- Student Details -----------");
                foreach (var item in students)
                {
                    WriteLine($"{item.Key}  {item.Value}");
                }
            }
            catch (Exception ex)
            {
                await Task.Delay(100); 
                WriteLine($"Error in ShowAllStudentsAsync: {ex.Message}");
            }
        }

        static async Task Main(string[] args)
        {
            Program p = new Program();

       
            await p.ShowAllStudentsAsync();

            WriteLine("\n--- Testing GetStudentAsync ---");

           
            var s1 = await p.GetStudentAsync(1);
            WriteLine($"Fetched: {s1}");


            var s2 = await p.GetStudentAsync();
            WriteLine($"Fetched: {s2}");


            var s3 = await p.GetStudentAsync(6);
            WriteLine($"Fetched: {s3}");

            ReadLine();
        }
    }
}
