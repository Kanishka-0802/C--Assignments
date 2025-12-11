using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methodoverloading  methodoverloading = new Methodoverloading();
            methodoverloading.logmessage("Success is not final, failure is not fatal: It is the courage to continue that counts.");
            methodoverloading.logmessage("Do not wait for leaders; do it alone, person to person.", 4);
            methodoverloading.logmessage("In the middle of difficulty lies opportunity.",DateTime.Now);
            methodoverloading.logmessage("Do not wait for leaders; do it alone, person to person.", DateTime.Now);
            Console.ReadLine();
        }

    }
}
