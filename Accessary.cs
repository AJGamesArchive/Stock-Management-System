using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to store all the accessory item details
    public class Accessary : Item, ICharacteristics
    {
        // Class Attributes
        public string Type { get; private set; }
        public Dictionary<string, string[]> Characteristics { get; private set; }

        // Class Constructor
        public Accessary(int id, string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, string type, Dictionary<string, string[]> characteristics) : base(id, name, price, stockLevel, orderStockLeevel, supplier)
        {
            Type = type;
            Characteristics = characteristics;
        }
    }
}
