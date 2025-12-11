using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderDay10
{
    public class Order
    {
    public int OrderId { get; set; }
    public string Customer_Name { get; set; }

    public decimal Total_Amount { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            ArrayList orderList = new ArrayList();
            orderList.Add(new Order { OrderId = 101, Customer_Name = "Tina", Total_Amount = 7000 });
            orderList.Add(new Order { OrderId = 102, Customer_Name = "Rina", Total_Amount = 8000 });
            orderList.Add(new Order { OrderId = 103, Customer_Name = "Siya", Total_Amount = 9000 });
            while (true)
            {
                Console.WriteLine("\n ==========Foodify==========");
                Console.WriteLine("----Restaurant Order Management----");
                Console.WriteLine("1. Add New Order");
                Console.WriteLine("2.Display all Orders");
                Console.WriteLine("3.Search Order by OrderId");
                Console.WriteLine("4.Remove Order");
                Console.WriteLine("5.Showing Total Number of Orders");
                Console.WriteLine("6.Sort Order by Amount");
                Console.WriteLine("7.Reverse Order List");
                Console.WriteLine("8.Exit");
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the OrderId,CustomerName and TotalAmount");
                        order.OrderId = Convert.ToInt32(Console.ReadLine());
                        order.Customer_Name = Console.ReadLine();
                        order.Total_Amount = Convert.ToDecimal(Console.ReadLine());
                        orderList.Add(order);
                        break;
                    case 2:
                        Console.WriteLine("-------Order Details------");
                        Console.WriteLine("Displaying the Current Orders :");
                        foreach (Order od in orderList)
                        {
                            Console.WriteLine($" OrderId : {od.OrderId} CustomerName : {od.Customer_Name} TotalAmount : {od.Total_Amount}");

                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the OrderID to Search : ");
                        int searchId = Convert.ToInt32(Console.ReadLine());
                        Order foundId = null;
                        foreach (Order od in orderList)
                        {
                            if (od.OrderId == searchId)
                            {
                                foundId = od;
                                break;
                            }
                        }
                        if (foundId != null)
                        {
                            Console.WriteLine($"Found Order: OrderId : {foundId.OrderId}, Name : {foundId.Customer_Name}, TotalAmount :{foundId.Total_Amount}");

                        }
                        else
                        {
                            Console.WriteLine("Order not found ");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Enter Order Id to remove");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        Order orderToRemove = null;
                        foreach (Order od in orderList)
                        {
                            if (od.OrderId == removeId)
                            {
                                orderToRemove = od;
                                break;
                            }
                        }
                        if (orderToRemove != null)
                        {
                            orderList.Remove(orderToRemove);
                            Console.WriteLine("Order removed Successfully!");
                        }
                        break;
                    case 5:
                        int count = orderList.Count;
                        Console.WriteLine(" Showing   Total Number of Orders : " + count);
                        foreach (Order od in orderList)
                        {
                            Console.WriteLine($" OrderId : {od.OrderId} CustomerName : {od.Customer_Name} TotalAmount : {od.Total_Amount}");

                        }
                        break;
                    case 6:
                        orderList.Sort(new AmountComparer());
                        Console.WriteLine("Orders sorted by Amount:");

                        foreach (Order od in orderList)
                        {
                            Console.WriteLine($" OrderId : {od.OrderId} CustomerName : {od.Customer_Name} TotalAmount : {od.Total_Amount}");

                        }
                        break;
                    case 7:
                        orderList.Reverse();
                        Console.WriteLine("Reversing the List:");

                        foreach (Order od in orderList)
                        {
                            Console.WriteLine($" OrderId : {od.OrderId} CustomerName : {od.Customer_Name} TotalAmount : {od.Total_Amount}");

                        }
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;
                }
                Console.ReadLine();



                }
            }
        public class AmountComparer : IComparer
        {
            public int Compare(object  x, object y)
            {
                return ((Order)x).Total_Amount.CompareTo( ((Order)y).Total_Amount);

            }
        }
        }
    
}
