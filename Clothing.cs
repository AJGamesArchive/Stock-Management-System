using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    public class Clothing : Item
    {
        // Class Attributes
        public enum ClothingType
        {
            Shorts,
            Capris,
            Legging,
            Vest,
            Top,
            Jacket
        }
        private int Size { get; set; }
        private string Colour { get; set; }
        private ClothingType Style { get; set; }

        // Class Constructor
        public Clothing(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, int size, string colour, ClothingType clothingType) : base (name, price, stockLevel, orderStockLeevel, supplier)
        {
            Size = size;
            Colour = colour;
            Style = clothingType;
        }
    }
}
