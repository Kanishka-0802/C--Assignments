using System;

namespace ConsoleAppday2_02
{
    internal class Customer
    {
        public string[] Items = new string[10];
        public int[] Quantities = new int[10];
        public decimal[] Prices = new decimal[10];
        public decimal[] Totals = new decimal[10];
        public int itemCount = 0;

        public void AddItem(string name, int quantity, decimal price)
        {
            if (itemCount < 10)
            {
                Items[itemCount] = name;
                Quantities[itemCount] = quantity;
                Prices[itemCount] = price;
                Totals[itemCount] = quantity * price;
                itemCount++;
            }
            else
            {
                Console.WriteLine("Maximum item limit reached.");
            }
        }

        public void CalculateBill(out decimal grandTotal, out decimal discount, out decimal finalBill)
        {
            grandTotal = 0;
            for (int i = 0; i < itemCount; i++)
            {
                grandTotal += Totals[i];
            }

            if (grandTotal > 5000)
                discount = grandTotal * 0.20m;
            else if (grandTotal >= 2000)
                discount = grandTotal * 0.10m;
            else if (grandTotal >= 1000)
                discount = grandTotal * 0.05m;
            else
                discount = 0;

            finalBill = grandTotal - discount;
        }

        public void PrintBill()
        {
            Console.WriteLine("\n========== Final Bill ==========");
            Console.WriteLine("Item\tQty\tPrice\tTotal");
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"{Items[i]}\t{Quantities[i]}\t{Prices[i]:0.00}\t{Totals[i]:0.00}");
            }

            CalculateBill(out decimal grandTotal, out decimal discount, out decimal finalBill);
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Grand Total:\t{grandTotal:0.00}");
            Console.WriteLine($"Discount:\t{discount:0.00}");
            Console.WriteLine($"Final Bill:\t{finalBill:0.00}");
            Console.WriteLine("===============================\n");
        }
    }
}
