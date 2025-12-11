using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreCheckout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MethodOverLoading methodoverloading = new MethodOverLoading();
            methodoverloading.Checkout(3000);
            methodoverloading.Checkout(200,6);
            methodoverloading.Checkout("QXRET567895");
            methodoverloading.Checkout(765,2,"MKJHN987654");
            Console.ReadLine();

        }
    }
}
