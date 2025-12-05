using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3Day1
{

        public static class EnumerableExtensions
        {
            public static int SumOfSquares(this IEnumerable<int> numbers)
            {
                int sum = 0;
                foreach (int num in numbers)
                {
                    sum += num * num;
                }
                return sum;
            }
        }
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 2,3,4};
            Console.WriteLine(nums.SumOfSquares());
            Console.ReadLine();

        }
    }
}
