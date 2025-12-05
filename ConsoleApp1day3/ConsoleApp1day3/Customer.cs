using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideAppDay3
{
    internal class Customer
    {
        public string name;
        public string contact;
        public int loyaltyPoints;

        public Customer(string name, string contact, int loyaltyPoints)
        {
            this.name = name;
            this.contact = contact;
            this.loyaltyPoints = loyaltyPoints;
        }
    }
}
