using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreCheckout
{
    public class MethodOverLoading
    {
        public void Checkout(int price)
        {
            Console.WriteLine("Price : " + price);
            Console.WriteLine("------------------");
        }
        public void Checkout(int price, int quantity)
        {
            int amount = price * quantity;
            Console.WriteLine("Price : " + price + " " + "Quantiy: " + quantity + " Amount : " + amount);
            Console.WriteLine("------------------");

        }
        public void Checkout(string couponCode)

        {
            Console.WriteLine("CouponCode : " + couponCode);
            Console.WriteLine("------------------");
        }
        public void Checkout(int price, int quantity, string couponCode)
        {
            int amount = price * quantity;
            Console.WriteLine("Price : " + price + " " + "Quantiy: " + quantity + " Amount : " + amount + " CouponCode : " + couponCode);
            Console.WriteLine("------------------");
        }

    }
}
