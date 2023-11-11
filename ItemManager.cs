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

        // Constructor to create new lists for each data store and add test data to the lists
        public ItemManager()
        {
            TestData testData = new TestData();
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

        // Function that addsa new clothing item to the system
        // Just returns true as there's no data validation needed currently
        public bool addNewClothingItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, int size, string colour, ClothingType style)
        {
            ClothingItems.Add(new Clothing(name, price, stockLevel, orderStockLevel, supplierDetails, size, colour, style));
            return true;
        }

        // Function that adds new shoe items to the system
        // Just returns true as there's no data validation needed currently
        public bool addNewShoeItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, decimal size, ShoeType shoeType)
        {
            ShoeItems.Add(new Shoe(name, price, stockLevel, orderStockLevel, supplierDetails, size, shoeType));
            return true;
        }

        // Function that adds new bag items to the system
        // Just returns true as there's no data validation needed currently
        public bool addNewBagItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, int capacity)
        {
            BagItems.Add(new Bag(name, price, stockLevel, orderStockLevel, supplierDetails, capacity));
            return true;
        }

        // Function that adds new nutrition items to the system
        // Just returns true as there's no data validation needed currently
        public bool addNewNutritionItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, double quantity, NutritionType nutritionType)
        {
            NutritionItems.Add(new Nutrition(name, price, stockLevel, orderStockLevel, supplierDetails, quantity, nutritionType));
            return true;
        }

        // Function that adds new watch items to the system
        // Just returns true as there's no data validation needed currently
        public bool addNewWatchItem(string name, decimal price, int stockLevel, int orderStockLevel, Supplier supplierDetails, WatcheType watchType)
        {
            WatcheItems.Add(new Watche(name, price, stockLevel, orderStockLevel, supplierDetails, watchType));
            return true;
        }

        #endregion
    }
}
