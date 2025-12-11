using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading_02
{
    public  class Methodoverloading
    {
      public void logmessage(string message) { 
        Console.WriteLine("Message : "+message);
            Console.WriteLine("------------------");
        }
        public void logmessage(string message,int level)
        {
            Console.WriteLine( "Message : "+message +" "+"Level: "+level);
            Console.WriteLine("------------------");
           
        }
        public void logmessage(string message,DateTime time)

        {
            Console.WriteLine("Message : " + message + " " + "Time: " + time);
            Console.WriteLine("------------------");
        }
        public void logmessage(string message,int level,DateTime time)
        {
            Console.WriteLine("Message : " + message + " " + "Level: " + level+" Time: "+time);
            Console.WriteLine("------------------");
        }

    }
}
