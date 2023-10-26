using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    internal class Nutrition : Accessory
    {
        // Declaring all viable nutrition types as an enumeration
        public enum NutritionType
        {
            Carbs,
            Protein
        }

        // Class Attributes
        private double Quantity { get; set; }
        private NutritionType Type { get; set; }

        // Class Constructor
        public Nutrition(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, double quantity, NutritionType nutritionType) : base(name, price, stockLevel, orderStockLeevel, supplier)
        {
            Quantity = quantity;
            Type = nutritionType;
        }
    }
}
