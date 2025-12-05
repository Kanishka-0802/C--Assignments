using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Overloading overloading = new Overloading();
            overloading.CalculateInterest(8500,4m);
            overloading.CalculateInterest(8000,30,5.6m);
            overloading.CalculateInterest(8000,46,5m,10000);
            Console.ReadLine();

        }
    }
}
