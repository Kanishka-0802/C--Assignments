


using System;

namespace RideAppDay3
{
    static class Pricing
    {
        public static decimal CalculateGST(decimal amount)
        {
            return amount * 0.18m;
        }

        public static bool TryGetWeekendSurcharge(DateTime rideDate, out decimal percent)
        {
            if (rideDate.DayOfWeek == DayOfWeek.Saturday || rideDate.DayOfWeek == DayOfWeek.Sunday)
            {
                percent = 10;
                return true;
            }
            percent = 0;
            return false;
        }

        public static decimal AddOnsCost(params string[] addOns)
        {
            decimal cost = 0;
            foreach (string add in addOns)
            {
                switch (add.ToLower())
                {
                    case "child-seat": 
                        cost += 35;
                        break;
                    case "fast-tag": 
                        cost += 25;
                        break;
                    case "priority-pickup": 
                        cost += 42; 
                        break;
                    case "extra-luggage": 
                        cost += 60;
                        break;
                }
            }
            return cost;
        }

        public static bool TryApplyCoupon_ByValue(decimal total, decimal couponAmount)
        {
            return total >= couponAmount;
        }

        public static void ApplyCoupon_ByRef(ref decimal total, decimal couponAmount)
        {
            total -= couponAmount;
        }

        public static void RedeemLoyalty(ref int points, ref decimal total)
        {
            decimal redeemValue = points;
            if (total >= redeemValue)
            {
                total -= redeemValue;
                points = 0;
            }
            else
            {
                points -= (int)total;
                total = 0;
            }
        }
    }
}