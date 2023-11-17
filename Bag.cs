using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    /*
    // Class to store all bag item details and handel bag item seeling
    public class Bag : Item
    {
        // Class Attributes
        public int Capacity { get; private set; }

        // Class Constructor
        public Bag(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, int capacity) : base(name, price, stockLevel, orderStockLeevel, supplier)
        {
            Capacity = capacity;
        }

        // Declaring a function that will handel the selling of all bag items
        public override bool sellItem(Customer customer)
        {
            if (!this.updateStockLevel()) { return false; }
            Purchase purchase = new Purchase();
            purchase.addPurchasedItem(this);
            customer.Purchases.Add(purchase);
            return true;
        }
    }
    */
}
