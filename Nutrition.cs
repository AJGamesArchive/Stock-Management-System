using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to store all nutrition item details and handel nutrition item seeling
    public class Nutrition : Item
    {
        // Declaring all viable nutrition types as an enumeration
        public enum NutritionType
        {
            Carbs,
            Protein
        }

        // Class Attributes
        private double Quantity;
        private NutritionType Type;

        // Class Constructor
        public Nutrition(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, double quantity, NutritionType nutritionType) : base(name, price, stockLevel, orderStockLeevel, supplier)
        {
            Quantity = quantity;
            Type = nutritionType;
        }

        // Declaring a function that will handel the selling of all nutrition items
        public override bool sellItem(Customer customer)
        {
            if (!this.updateStockLevel()) { return false; }
            Purchase purchase = new Purchase();
            purchase.addNutrition(this);
            customer.Purchases.Add(purchase);
            return true;
        }
    }
}
