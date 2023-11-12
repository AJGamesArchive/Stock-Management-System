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
    public class TestData
    {
        // Adding initial test data to the Customers list
        public bool createTestCustomers(EntityManager em)
        {
            bool validTestData = true;
            if (!em.addEntity("Alex Ward", "AW949@canterbury.ac.uk", true)) { validTestData = false; }
            if (!em.addEntity("Jonathan N", "jonathann@gmail.com", false)) { validTestData = false; }
            if (!em.addEntity("Ethan", "ethanm@gmail.com", false)) { validTestData = false; }
            return validTestData;
        }

        // Adding initial test data to the Suppliers list
        public bool createTestSuppliers(EntityManager em)
        {
            bool validTestData = true;
            if (!em.addEntity("ClothingLtd", "clothing.supplys@gmail.com", "01304591665")) { validTestData = false; }
            if (!em.addEntity("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516")) { validTestData = false; }
            if (!em.addEntity("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168")) { validTestData = false; }
            return validTestData;
        }

        // Adding initial test data to the ClothingItems list
        public bool createTestClothing(ItemManager im)
        {
            bool validTestData = true;
            if(!im.addItem("Clothing_Item_1", 20, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 25, "Blue", ClothingType.Shorts)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_2", 22, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 30, "Green", ClothingType.Shorts)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_3", 25, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 25, "Red", ClothingType.Capris)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_4", 30, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 30, "Orange", ClothingType.Capris)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_5", 24, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 25, "Yellow", ClothingType.Legging)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_6", 28, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 30, "Blue", ClothingType.Legging)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_7", 15, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 25, "Green", ClothingType.Vest)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_8", 18, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 30, "Red", ClothingType.Vest)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_9", 25, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 25, "Orange", ClothingType.Top)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_10", 30, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 30, "Yellow", ClothingType.Top)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_11", 35, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 25, "Purple", ClothingType.Jacket)) { validTestData = false; }
            if (!im.addItem("Clothing_Item_12", 40, 50, 20, new Supplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665"), 30, "Pink", ClothingType.Jacket)) { validTestData = false; }
            return validTestData;
        }

        // Adding initial test data to the ShoeItems list
        public bool createTestShoes(ItemManager im)
        {
            bool validTestData = true;
            if (!im.addItem("Shoe_Item_1", 45, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 22, ShoeType.Racer)) { validTestData = false; }
            if (!im.addItem("Shoe_Item_2", 50, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 26, ShoeType.Racer)) { validTestData = false; }
            if (!im.addItem("Shoe_Item_3", 45, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 22, ShoeType.Stability)) { validTestData = false; }
            if (!im.addItem("Shoe_Item_4", 50, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 26, ShoeType.Stability)) { validTestData = false; }
            if (!im.addItem("Shoe_Item_5", 55, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 22, ShoeType.Nutral)) { validTestData = false; }
            if (!im.addItem("Shoe_Item_6", 60, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 26, ShoeType.Nutral)) { validTestData = false; }
            if (!im.addItem("Shoe_Item_7", 55, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 22, ShoeType.Trail)) { validTestData = false; }
            if (!im.addItem("Shoe_Item_8", 60, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 26, ShoeType.Trail)) { validTestData = false; }
            if (!im.addItem("Shoe_Item_9", 60, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 22, ShoeType.Track)) { validTestData = false; }
            if (!im.addItem("Shoe_Item_10", 70, 60, 20, new Supplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516"), 26, ShoeType.Track)) { validTestData = false; }
            return validTestData;
        }

        // Adding initial test data to the BagItems list
        public bool createTestBags(ItemManager im)
        {
            bool validTestData = true;
            if (!im.addItem("Bag_Item_1", 20, 40, 10, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 20)) { validTestData = false; }
            if (!im.addItem("Bag_Item_2", 25, 40, 10, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 22)) { validTestData = false; }
            if (!im.addItem("Bag_Item_3", 30, 40, 10, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 24)) { validTestData = false; }
            if (!im.addItem("Bag_Item_4", 35, 40, 10, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 26)) { validTestData = false; }
            if (!im.addItem("Bag_Item_5", 40, 40, 10, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 28)) { validTestData = false; }
            if (!im.addItem("Bag_Item_6", 45, 40, 10, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 30)) { validTestData = false; }
            if (!im.addItem("Bag_Item_7", 50, 40, 10, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 32)) { validTestData = false; }
            if (!im.addItem("Bag_Item_8", 55, 40, 10, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 34)) { validTestData = false; }
            return validTestData;
        }

        // Adding initial test data to the NutritionItems list
        public bool createTestNutritions(ItemManager im)
        {
            bool validTestData = true;
            if (!im.addItem("Nutrition_Item_1", 30, 60, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 20, NutritionType.Carbs)) { validTestData = false; }
            if (!im.addItem("Nutrition_Item_2", 35, 60, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 30, NutritionType.Carbs)) { validTestData = false; }
            if (!im.addItem("Nutrition_Item_3", 40, 60, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 40, NutritionType.Carbs)) { validTestData = false; }
            if (!im.addItem("Nutrition_Item_4", 30, 60, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 20, NutritionType.Protein)) { validTestData = false; }
            if (!im.addItem("Nutrition_Item_5", 35, 60, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 30, NutritionType.Protein)) { validTestData = false; }
            if (!im.addItem("Nutrition_Item_6", 40, 60, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), 40, NutritionType.Protein)) { validTestData = false; }
            return validTestData;
        }

        // Adding initial test data to the WatchItems list
        public bool createTestWatches(ItemManager im)
        {
            bool validTestData = true;
            if (!im.addItem("Watch_Item_1", 40, 50, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), WatcheType.Simple)) { validTestData = false; }
            if (!im.addItem("Watch_Item_2", 50, 50, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), WatcheType.Simple)) { validTestData = false; }
            if (!im.addItem("Watch_Item_3", 40, 50, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), WatcheType.HeartRate)) { validTestData = false; }
            if (!im.addItem("Watch_Item_4", 50, 50, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), WatcheType.HeartRate)) { validTestData = false; }
            if (!im.addItem("Watch_Item_5", 50, 50, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), WatcheType.GPS)) { validTestData = false; }
            if (!im.addItem("Watch_Item_6", 60, 50, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), WatcheType.GPS)) { validTestData = false; }
            if (!im.addItem("Watch_Item_7", 50, 50, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), WatcheType.GPSandHeartRate)) { validTestData = false; }
            if (!im.addItem("Watch_Item_8", 60, 50, 20, new Supplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168"), WatcheType.GPSandHeartRate)) { validTestData = false; }
            return validTestData;
        }
    }
}
