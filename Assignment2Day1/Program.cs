using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Day1
{
    public static class Program
    {
        public static bool IsUpper(this string word)
        {
         string s = word.ToUpper(); 
            if (s.Equals(word))
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine(IsUpper("wELCOME"));
            Console.ReadLine();
            
        }

    }
}


