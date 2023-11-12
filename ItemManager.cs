using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stock_Management_System.Clothing;
using static Stock_Management_System.Nutrition;
using static Stock_Management_System.Shoe;
using static Stock_Management_System.Watche;

namespace Stock_Management_System
{
    // Class to handel all the data processing (adding, updating, retrieving) for all items in the system
    public class ItemManager
    {
        // Declearing lists to store all item related details, a seperate list for each type of item
        private List<Clothing> ClothingItems;
        private List<Shoe> ShoeItems;
        private List<Bag> BagItems;
        private List<Nutrition> NutritionItems;
        private List<Watche> WatcheItems;

        // Class constructor to create new lists for each item data store
        public ItemManager()
        {
            ClothingItems = new List<Clothing>();
            ShoeItems = new List<Shoe>();
            BagItems = new List<Bag>();
            NutritionItems = new List<Nutrition>();
            WatcheItems = new List<Watche>();
        }

        // Overloaded Constructor to create new lists for each item data store and add test data to the lists
        public ItemManager(TestData testData)
        {
            ClothingItems = new List<Clothing>();
            if (!testData.createTestClothing(this)) { throw new ArgumentException("Invalid Clothing Item Test Data"); }
            ShoeItems = new List<Shoe>();
            if (!testData.createTestShoes(this)) { throw new ArgumentException("Invalid Shoe Item Test Data"); }
            BagItems = new List<Bag>();
            if (!testData.createTestBags(this)) { throw new ArgumentException("Invalid Bag Item Test Data"); }
            NutritionItems = new List<Nutrition>();
            if (!testData.createTestNutritions(this)) { throw new ArgumentException("Invalid Nutrition Item Test Data"); }
            WatcheItems = new List<Watche>();
            if (!testData.createTestWatches(this)) { throw new ArgumentException("Invalid Watch Item Test Data"); }
        }

        #region Add Item Data Functions

        // Overloaded Function that addsa new clothing item to the system
        // Just returns true as there's no data validation needed currently
        public bool addItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, int size, string colour, ClothingType style)
        {
            ClothingItems.Add(new Clothing(name, price, stockLevel, orderStockLevel, supplierDetails, size, colour, style));
            return true;
        }

        // Overloaded Function that adds new shoe items to the system
        // Just returns true as there's no data validation needed currently
        public bool addItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, decimal size, ShoeType shoeType)
        {
            ShoeItems.Add(new Shoe(name, price, stockLevel, orderStockLevel, supplierDetails, size, shoeType));
            return true;
        }

        // Overloaded Function that adds new bag items to the system
        // Just returns true as there's no data validation needed currently
        public bool addItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, int capacity)
        {
            BagItems.Add(new Bag(name, price, stockLevel, orderStockLevel, supplierDetails, capacity));
            return true;
        }

        // Overloaded Function that adds new nutrition items to the system
        // Just returns true as there's no data validation needed currently
        public bool addItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, double quantity, NutritionType nutritionType)
        {
            NutritionItems.Add(new Nutrition(name, price, stockLevel, orderStockLevel, supplierDetails, quantity, nutritionType));
            return true;
        }

        // Overloaded Function that adds new watch items to the system
        // Just returns true as there's no data validation needed currently
        public bool addItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, WatcheType watchType)
        {
            WatcheItems.Add(new Watche(name, price, stockLevel, orderStockLevel, supplierDetails, watchType));
            return true;
        }

        #endregion

        #region Retrieve Data Functions

        #region Retrieve All Items Of A Given Type

        // Function to retreive all clothing items
        public Clothing[] getClothing()
        {
            return ClothingItems.ToArray();
        }

        // Function to retreive all shoe items
        public Shoe[] getShoes()
        {
            return ShoeItems.ToArray();
        }

        // Function to retreive all bag items
        public Bag[] getBags()
        {
            return BagItems.ToArray();
        }

        // Function to retreive all nutrition items
        public Nutrition[] getNutrition()
        {
            return NutritionItems.ToArray();
        }

        // Function to retreive all watche items
        public Watche[] getWatches()
        {
            return WatcheItems.ToArray();
        }

        #endregion

        #region Retrieve A Single Item Of A Given Type

        // Function to retrieve a single clothing item, if the item exists
        public bool getClothingItem(string name, out Clothing item)
        {
            throw new NotImplementedException();
        }

        // Function to retrieve a single shoe item, if the item exists
        public bool getShoeItem(string name, out Shoe item)
        {
            throw new NotImplementedException();
        }

        // Function to retrieve a single bag item, if the item exists
        public bool getBagItem(string name, out Bag item)
        {
            throw new NotImplementedException();
        }

        // Function to retrieve a single nutrition item, if the item exists
        public bool getNutritionItem(string name, out Nutrition item)
        {
            throw new NotImplementedException();
        }

        // Function to retrieve a single watche item, if the item exists
        public bool getWatcheItem(string name, out Watche item)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Retrieve Combinations Of Data

        // Function to retrieve all item names for all item types in the system
        public string[] getAllItemNames()
        {
            List<string> itemNames = new List<string>();
            foreach(Clothing clothing in ClothingItems)
            {
                itemNames.Add(clothing.Name);
            }
            foreach(Shoe shoe in ShoeItems)
            {
                itemNames.Add(shoe.Name);
            }
            foreach(Bag bag in BagItems)
            {
                itemNames.Add(bag.Name);
            }
            foreach(Nutrition nutrition in NutritionItems)
            {
                itemNames.Add(nutrition.Name);
            }
            foreach(Watche watche in WatcheItems)
            {
                itemNames.Add(watche.Name);
            }
            return itemNames.ToArray();
        }

        #endregion

        #endregion
    }
}
