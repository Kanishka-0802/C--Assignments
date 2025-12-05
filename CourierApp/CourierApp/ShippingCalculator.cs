using System;

namespace CourierApp
{
    public abstract class ShippingCalculator
    {
        public abstract decimal Calculate(decimal weight, string zone);
        public virtual string Label() => "Generic Shipping Provider";
    }

    public class StandardShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal rateperkg = 0;

            switch (zone)
            {
                case "ZoneA":
                    if (weight <= 5)
                    {
                        rateperkg = 60;
                    }
                    else
                    {
                        rateperkg = 30;
                    }
                    break;

                case "ZoneB":
                    if (weight <= 15)
                    {
                        rateperkg = 20;
                    }
                    else
                    {
                        rateperkg = 50;
                    }
                    break;

                default:
                    rateperkg = 80;
                    break;
            }

            return weight * rateperkg;
        }

        public override string Label() => "Standard Shipping";
    }

    public class ExpressShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal baseFee = 100;
            decimal ratePerKg = 0;

            switch (zone)
            {
                case "ZoneA":
                    ratePerKg = 50;
                    break;
                case "ZoneB":
                    ratePerKg = 60;
                    break;
                default:
                    ratePerKg = 70;
                    break;
            }

            return baseFee + (weight * ratePerKg);
        }

        public override string Label() => "Express Shipping";
    }

    public class InternationalShipping : ShippingCalculator
    {
        public override decimal Calculate(decimal weight, string zone)
        {
            decimal baseRate = 150;
            decimal surcharge = 100;
            int zoneMultiplier = 0;

            switch (zone)
            {
                case "ZoneA":
                    zoneMultiplier = 1;
                    break;
                case "ZoneB":
                    zoneMultiplier = 2;
                    break;
                default:
                    zoneMultiplier = 3;
                    break;
            }

            return (baseRate + surcharge) * zoneMultiplier;
        }

        public override string Label() => "International Shipping";
    }
}
