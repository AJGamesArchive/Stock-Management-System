using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Abstract Class that other item classes can derive common attributes from
    // Handle item selling for all items
    public abstract class Item
    {
        // Class Attributes
        private string Name;
        private decimal Price;
        private int StockLevel;
        private int OrderStockLevel;
        private Supplier SupplierDetails;

        // Class Constructor
        public Item(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier)
        {
            Name = name;
            Price = price;
            StockLevel = stockLevel;
            OrderStockLevel = orderStockLeevel;
            SupplierDetails = supplier;
        }

        // Declaring a function that will handel the selling of all items, will be overridden by other item classes
        // idk if this will need overloading or not
        public bool sellItem(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
