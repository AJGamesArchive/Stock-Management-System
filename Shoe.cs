using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to store all shoe item details and handel shoe item seeling
    public class Shoe : Item
    {
        // Class Attributes
        public enum ShoeType
        {
            Racer,
            Stability,
            Nutral,
            Trail,
            Track
        }
        private decimal Size;
        private ShoeType Type;

        // Class Constructor
        public Shoe(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, decimal size, ShoeType shoeType) : base(name, price, stockLevel, orderStockLeevel, supplier)
        {
            Size = size;
            Type = shoeType;
        }

        // Declaring a function that will handel the selling of all shoe items
        public override bool sellItem(Customer customer)
        {
            if (!this.updateStockLevel()) { return false; }
            Purchase purchase = new Purchase();
            purchase.addPurchasedItem(this);
            customer.Purchases.Add(purchase);
            return true;
        }
    }
}
