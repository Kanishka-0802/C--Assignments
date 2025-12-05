using System;
using static E_commerceDay7.IContracts;

namespace E_commerceDay7
{
    // Abstract base class for payment providers
    public abstract class PaymentProviderBase
    {
        public abstract void ProcessPayment(decimal amount);
    }

    public class RazorpayProvider : PaymentProviderBase
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ₹{amount} via Razorpay.");
        }
    }

    public class StripeProvider : PaymentProviderBase
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ₹{amount} via Stripe.");
        }
    }

    // Pricing Strategies
    public class MRPStrategy : IPricingStrategy
    {
        public void Price(int price)
        {
            Console.WriteLine($"Final Price (MRP): ₹{price}");
        }
    }

    public class TieredDiscountStrategy : IPricingStrategy
    {
        public void Price(int price)
        {
            decimal discount = 0;
            if (price >= 15000)
                discount = 0.12m;
            else if (price >= 5000)
                discount = 0.05m;

            decimal finalPrice = price - (price * discount);
            Console.WriteLine($"Final Price after discount: ₹{finalPrice}");
        }
    }

    // Shipping Quoters
    public class BluedartQuoter : IShipmentQuoter
    {
        public void Shipping(int weightKg)
        {
            decimal baseRate = 60;
            decimal ratePerKg = 25;
            decimal metroDiscount = 0.10m;

            decimal cost = baseRate + (ratePerKg * weightKg);
            cost -= cost * metroDiscount;

            Console.WriteLine($"Bluedart Shipping Cost: ₹{cost}");
        }
    }

    public class DelhiveryQuoter : IShipmentQuoter
    {
        public void Shipping(int weightKg)
        {
            decimal baseRate = 50;
            decimal ratePerKg = 28;
            decimal remoteSurcharge = 0.08m;

            decimal cost = baseRate + (ratePerKg * weightKg);
            cost += cost * remoteSurcharge;

            Console.WriteLine($"Delhivery Shipping Cost: ₹{cost}");
        }
    }

    // Payments class implementing IOrder
    public class Payments : IOrder
    {
        IPricingStrategy pricingStrategy;
        IShipmentQuoter shipmentQuoter;
        PaymentProviderBase paymentProvider;

        public Payments(IPricingStrategy pricingStrategy, IShipmentQuoter shipmentQuoter, PaymentProviderBase paymentProvider)
        {
            this.pricingStrategy = pricingStrategy;
            this.shipmentQuoter = shipmentQuoter;
            this.paymentProvider = paymentProvider;
        }

        public void Order(int items)
        {
            Console.WriteLine($"Order placed for {items} item(s).");
        }

        public void MakeOrder(int itemNo, string itemName, decimal amount, int weightKg, string location, string address)
        {
            Console.WriteLine("Order is under processing...");
            Console.WriteLine($"Item #{itemNo}: {itemName}");
            Console.WriteLine($"Shipping to: {address}, {location}");

            pricingStrategy.Price((int)amount);
            shipmentQuoter.Shipping(weightKg);
            paymentProvider.ProcessPayment(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Choose strategy, shipper, and payment provider
            IPricingStrategy pricingStrategy = new TieredDiscountStrategy(); // or new MRPStrategy()
            IShipmentQuoter shipmentQuoter = new BluedartQuoter(); // or new DelhiveryQuoter()
            PaymentProviderBase paymentProvider = new RazorpayProvider(); // or new StripeProvider()

            // Inject dependencies into Payments
            Payments payment = new Payments(pricingStrategy, shipmentQuoter, paymentProvider);

            // Place order
            payment.Order(3);
            payment.MakeOrder(101, "Smartphone", 6000, 2, "Hyderabad", "Plot 42, Tech Park");

            Console.ReadLine();
        }
    }
}
