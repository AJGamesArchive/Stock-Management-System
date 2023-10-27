using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    public class Item
    {
        // Class Attributes
        private string Name { get; set; }
        private decimal Price { get; set; }
        private int StockLevel { get; set; }
        private int OrderStockLevel { get; set; }
        private Supplier SupplierDetails { get; set; }

        // Class Constructor
        public Item(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier)
        {
            Name = name;
            Price = price;
            StockLevel = stockLevel;
            OrderStockLevel = orderStockLeevel;
            SupplierDetails = supplier;
        }
    }
}
