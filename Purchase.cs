using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to aggrigate into Customer and store all a customers orders and handel adding items to each order
    // Future proofed to allow multiple items to be added to one order
    public class Purchase
    {
        // Class Attributes
        private DateTime SaleDate;
        private List<Clothing> ClothingItems;
        private List<Shoe> ShoeItems;
        private List<Bag> BagItems;
        private List<Nutrition> NutritionItems;
        private List<Watche> WatchItem;

        // Class Constructor
        public Purchase()
        {
            SaleDate = DateTime.Now;
            ClothingItems = new List<Clothing>();
            ShoeItems = new List<Shoe>();
            BagItems = new List<Bag>();
            NutritionItems = new List<Nutrition>();
            WatchItem = new List<Watche>();
        }

        // Overloaded constructor that allows you to spesify an order time
        public Purchase(DateTime orderTimestamp)
        {
            SaleDate = orderTimestamp;
            ClothingItems = new List<Clothing>();
            ShoeItems = new List<Shoe>();
            BagItems = new List<Bag>();
            NutritionItems = new List<Nutrition>();
            WatchItem = new List<Watche>();
        }

        #region Add Item Functions

        // Overloaded Function to add a clothing item to the purchase
        public void addPurchasedItem(Clothing clothing)
        {
            ClothingItems.Add(clothing);
            return;
        }

        // Overloaded Function to add a shoe item to the purchase
        public void addPurchasedItem(Shoe shoe)
        {
            ShoeItems.Add(shoe);
            return;
        }

        // Overloaded Function to add a bag item to the purchase
        public void addPurchasedItem(Bag bag)
        {
            BagItems.Add(bag);
            return;
        }

        // Overloaded Function to add a nutrition item to the purchase
        public void addPurchasedItem(Nutrition nutrition)
        {
            NutritionItems.Add(nutrition);
            return;
        }

        // Overloaded Function to add a watch to the order
        public void addPurchasedItem(Watche watche)
        {
            WatchItem.Add(watche);
            return;
        }

        #endregion
    }
}
