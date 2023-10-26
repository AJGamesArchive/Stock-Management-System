using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    internal class Shoe : Item
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
        private decimal Size { get; set; }
        private ShoeType Type { get; set; }

        // Class Constructor
        public Shoe(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, decimal size, ShoeType shoeType) : base(name, price, stockLevel, orderStockLeevel, supplier)
        {
            Size = size;
            Type = shoeType;
        }
    }
}
