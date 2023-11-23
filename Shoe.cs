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
        private string Make;
        private Dictionary<string, string[]> Characteristics;

        // Class Constructor
        public Shoe(int id, string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, string make, Dictionary<string, string[]> characteristics) : base(id, name, price, stockLevel, orderStockLeevel, supplier)
        {
            Make = make;
            Characteristics = characteristics;
        }

        #region Manage Shoe Data

        // Function to return the shoe items make
        public string getMake()
        {
            return Make;
        }

        // Function to return the shoe items characteristics
        public string[] getCharacteristics()
        {
            List<string> characteristicsStrings = new List<string>();
            foreach (var characteristic in Characteristics)
            {
                characteristicsStrings.Add($"{characteristic.Key} = {Tools.arrayToString(characteristic.Value)}");
            }
            return characteristicsStrings.ToArray();
        }

        #endregion
    }
}
