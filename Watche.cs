using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to store all watche item details and handel watche item seeling
    public class Watche : Item
    {
       // Declaring all viable watche types as an enumeration
        public enum WatcheType
        {
            Simple,
            HeartRate,
            GPS,
            GPSandHeartRate
        }

        // Class Attributes
        private WatcheType Type;

        // Class Constructor
        public Watche(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, WatcheType watcheType) : base(name, price, stockLevel, orderStockLeevel, supplier)
        {
            Type = watcheType;
        }

        // Declaring a function that will handel the selling of all watche items
        public override bool sellItem(Customer customer)
        {
            if (!this.updateStockLevel()) { return false; }
            Purchase purchase = new Purchase();
            purchase.addWatch(this);
            customer.Purchases.Add(purchase);
            return true;
        }
    }
}
