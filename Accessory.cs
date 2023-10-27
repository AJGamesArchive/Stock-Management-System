using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class Attributes
    public class Accessory : Item
    {
        // Remove later if no functions are needed here
        // If removed, change inheritents of Bag, Nutrition, and Watche classes to inherit from Item

        public Accessory(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier) : base(name, price, stockLevel, orderStockLeevel, supplier)
        {

        }
    }
}
