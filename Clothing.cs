using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to store all clothing item details and handel clothing item seeling
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
        private int Size;
        private string Colour;
        private ClothingType Style;

        // Class Constructor
        public Clothing(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, int size, string colour, ClothingType clothingType) : base (name, price, stockLevel, orderStockLeevel, supplier)
        {
            Size = size;
            Colour = colour;
            Style = clothingType;
        }

        // Declaring a function that will handel the selling of all clothing items
        public override bool sellItem(Customer customer)
        {
            if(!this.updateStockLevel()) { return false; }
            Purchase purchase = new Purchase();
            purchase.addPurchasedItem(this);
            customer.Purchases.Add(purchase);
            return true;
        }
    }
}
