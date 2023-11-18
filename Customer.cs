using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to construct a list to store all customer details
    public class Customer : IEntities
    {
        // Class Attributes
        private int Id;
        private string Name;
        private string Email;
        private bool GDPR;
        private List<Purchase> Purchases;

        // Class Constructor
        public Customer(int id, string name, string email, bool gdpr)
        {
            Id = id;
            Name = name;
            Email = email;
            GDPR = gdpr;
            Purchases = new List<Purchase>();
        }

        #region Manage Customer Data

        // Functions to add a new purchase to the given customer
        public void addPurchase(Purchase purchase)
        {
            Purchases.Add(purchase);
            return;
        }

        // Functions to check for matching attributes to identify the object instence
        public bool hasMatchingAttribute(int id)
        {
            if (Id == id) { return true; }
            return false;
        }

        // Functioon to retrieve all purchases by the given customer
        public Dictionary<string, string>[] getPurchases()
        {
            List<Dictionary<string, string>> purchases = new List<Dictionary<string, string>>();
            foreach(Purchase p in Purchases)
            {
                purchases.Add(p.getPurchaseDetails());
            }
            return purchases.ToArray();
        }

        // Overriden Function to create a string identifier for a customer
        public override string ToString()
        {
            return $"({Id}) {Name} - {Email}";
        }

        #endregion
    }
}
