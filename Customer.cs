using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    internal class Customer
    {
        // Class Attributes
        private string Name { get; set; }
        private string Email { get; set; }
        private bool GDPR { get; set; }
        private List<Purchase> Purchases { get; set; }

        // Class Constructor
        public Customer(string name, string email, bool gdpr)
        {
            Name = name;
            Email = email;
            GDPR = gdpr;
            List<Purchase> purchases = new List<Purchase>();
        }

        // Function that will add purchases to the classes purchases list
        public void addPurchase(Purchase purchase)
        {
            Purchases.Add(purchase);
            return;
        }
    }
}
