using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Abstract Class that other item classes can derive common attributes from
    // Handel item selling for all items
    public abstract class Item
    {
        // Class Attributes
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int StockLevel { get; private set; }
        public int OrderStockLevel { get; private set; }
        public Supplier SupplierDetails { get; private set; }

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
        public abstract bool sellItem(Customer customer);

        // Function to subtracked 1 from the stock level if there is stock left
        public bool updateStockLevel()
        {
            if(StockLevel == 0) { return false; }
            StockLevel -= 1;
            return true;
        }
    }
}
