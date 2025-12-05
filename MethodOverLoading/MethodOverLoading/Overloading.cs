using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    public class Overloading
    {
        public void CalculateInterest(decimal principle, decimal rate)
        {
            decimal result = principle * rate;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("The Calculated Interest is : " + result);
        }
        public void CalculateInterest(decimal principle, decimal rate, decimal time)
        {
          
            decimal price = (principle * rate * time) / 100;
            decimal result = 2 * price;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("The Calculated Simple Interest  for 2 years is : " + result);
        }
        public void CalculateInterest(decimal principle, decimal rate, decimal time,decimal amount)
        {
           
            decimal price = principle*(1 + (rate / 100)) * time;
            decimal compoundinterest = amount - price;
            decimal result = 3 * price;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("The Calculated Compound  Interest  for 3 years is : " + result);
        }
    }

}
