using System;


namespace CourierApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal weight = 10;
            string zone = "ZoneA";

            StandardShipping standard = new StandardShipping();
            ExpressShipping express = new ExpressShipping();
            InternationalShipping international = new InternationalShipping();

            decimal standardCost = standard.Calculate(weight, zone);
            decimal expressCost = express.Calculate(weight, zone);
            decimal internationalCost = international.Calculate(weight, zone);

            Console.WriteLine($"Standard Shipping to {zone} for {weight}kg: ₹{standardCost}");
            Console.WriteLine($"Express Shipping to {zone} for {weight}kg: ₹{expressCost}");
            Console.WriteLine($"International Shipping to {zone} for {weight}kg: ₹{internationalCost}");

            Console.ReadLine();
        }
    }
}
