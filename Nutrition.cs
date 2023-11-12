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
        public double Quantity { get; private set; }
        public NutritionType Type { get; private set; }

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
            purchase.addPurchasedItem(this);
            customer.Purchases.Add(purchase);
            return true;
        }
    }
}
