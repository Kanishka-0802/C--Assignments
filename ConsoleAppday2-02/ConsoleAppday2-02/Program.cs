using System;

namespace ConsoleAppday2_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Console.WriteLine("======== Grocery Shop Billing System ========");
            Console.Write("Enter number of items: ");
            int itemCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"\nItem {i + 1}:");
                Console.Write("Enter item name: ");
                string name = Console.ReadLine();

                Console.Write("Enter quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price per unit: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());

                customer.AddItem(name: name, quantity: quantity, price: price);
            }

            customer.PrintBill();
            Console.WriteLine("Billing completed successfully.");
            Console.ReadLine();
        }
    }
}
