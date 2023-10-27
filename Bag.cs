using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    public class Bag : Accessory
    {
        // Class Attributes
        private int Capacity { get; set; }

        // Class Constructor
        public Bag(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, int capacity) : base(name, price, stockLevel, orderStockLeevel, supplier)
        {
            Capacity = capacity;
        }
    }
}
