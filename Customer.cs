using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    public class Customer
    {
        // Class Attributes
        public string Name { get; private set; }
        public string Email { get; private set; }
        public bool GDPR { get; private set; }
        public List<Purchase> Purchases { get; set; }

        // Class Constructor
        public Customer(string name, string email, bool gdpr)
        {
            Name = name;
            Email = email;
            GDPR = gdpr;
            Purchases = new List<Purchase>();
        }
    }
}
