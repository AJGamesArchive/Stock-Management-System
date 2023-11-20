using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to store all clothing item details
    public class Clothing : Item, ICharacteristics
    {
        // Class Attributes
        private string Make;
        private Dictionary<string, string[]> Characteristics;

        // Class Constructor
        public Clothing(int id, string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, string make, Dictionary<string, string[]> characteristics) : base (id, name, price, stockLevel, orderStockLeevel, supplier)
        {
            Make = make;
            Characteristics = characteristics;
        }

        #region Manage Clothing Data

        // Function to return the clothing items make
        public string getMake()
        {
            return Make;
        }

        // Function to return the clothing items characteristics
        public Dictionary<string, string[]> getCharacteristics()
        {
            return Characteristics;
        }

        #endregion
    }
}
