using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to store all shoe item details
    public class Shoe : Item, ICharacteristics
    {
        // Class Attributes
        public string Type { get; private set; }
        public Dictionary<string, string[]> Characteristics { get; private set; }

        // Class Constructor
        public Shoe(int id, string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, string type, Dictionary<string, string[]> characteristics) : base(id, name, price, stockLevel, orderStockLeevel, supplier)
        {
            Type = type;
            Characteristics = characteristics;
        }
    }
}
