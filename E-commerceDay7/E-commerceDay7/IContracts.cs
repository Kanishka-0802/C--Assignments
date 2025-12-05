using System;

namespace E_commerceDay7
{
    internal interface IContracts
    {
        public interface IOrder
        {
            void Order(int items)
            {
                Console.WriteLine($"Default Order placed for {items} item(s).");
            }
        }

        public interface ILineItem
        {
            void LineItem(int items)
            {
                Console.WriteLine($"Default LineItem created for {items} item(s).");
            }
        }

        public interface IPricingStrategy
        {
            void Price(int price)
            {
                Console.WriteLine($"Default pricing applied: ₹{price}");
            }
        }

        public interface IShipmentQuoter
        {
            void Shipping(int weightKg)
            {
                Console.WriteLine($"Default shipping cost for {weightKg} kg.");
            }
        }
    }
}
