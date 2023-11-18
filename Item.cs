using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Abstract Class that other item classes can derive common attributes from
    // Handle item selling for all items
    public abstract class Item : IEntities
    {
        // Class Attributes
        private int Id;
        private string Name;
        private decimal Price;
        private int StockLevel;
        private int OrderStockLevel;
        private Supplier SupplierDetails;

        // Class Constructor
        public Item(int id, string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier)
        {
            Id = id;
            Name = name;
            Price = price;
            StockLevel = stockLevel;
            OrderStockLevel = orderStockLeevel;
            SupplierDetails = supplier;
        }

        #region Manage Item Data

        // Functions to check for matching attributes to identify the object instence
        public bool hasMatchingAttribute(int id)
        {
            if (Id == id) { return true; }
            return false;
        }
        public bool hasMatchingAttribute(Supplier supplier)
        {
            if(SupplierDetails == supplier) { return true; }
            return false;
        }

        // Function that will return a Dictionary of an items; id, name, stock level, and order stock level if the item needs re-stocking
        public bool getRestockDetails(out Dictionary<string, string> restockDetails)
        {
            if (StockLevel >= OrderStockLevel) { restockDetails = new Dictionary<string, string>(); return false; }
            restockDetails = new Dictionary<string, string>
            {
                {"Id", Id.ToString()},
                {"Name", Name},
                {"Current Stock Level", StockLevel.ToString()},
                {"Restock Level", OrderStockLevel.ToString()},
            };
            return true;
        }

        // Overriden Function to create a string identifier for an item
        public override string ToString()
        {
            return $"({Id}) {this.GetType()} - {Name}";
        }

        #endregion

        #region Class Responsibilities

        // Function that will handel the selling of all items
        public bool sellItem(Customer customer)
        {
            if(StockLevel == 0) { return false; }
            StockLevel -= 1;
            Purchase purchase = new Purchase(Name, Price);
            customer.addPurchase(purchase);
            return true;
        }

        #endregion
    }
}
