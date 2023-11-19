using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stock_Management_System.Clothing;
using static Stock_Management_System.Shoe;

namespace Stock_Management_System
{
    public class TestData
    {
        // Creating customer test data
        public void createTestCustomers(StockSystem stockSystem)
        {
            stockSystem.enterNewCustomer("Alex Ward", "AW949@canterbury.ac.uk", true);
            stockSystem.enterNewCustomer("Jonathan N", "jonathann@gmail.com", false);
            stockSystem.enterNewCustomer("Ethan", "ethanm@gmail.com", false);
            return;
        }

        // Creating supplier test data
        public void createTestSuppliers(StockSystem stockSystem)
        {
            stockSystem.enterNewSupplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665");
            stockSystem.enterNewSupplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516");
            stockSystem.enterNewSupplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168");
            return;
        }

        // Creating item test data
        public void createTestItems(StockSystem stockSystem)
        {
            #region Clothing

            // Clothing
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_1", 20, 50, 20, 1, "Shorts", new Dictionary<string, string[]> 
            { 
                { "Size", new string[] { "25", "27", "29" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_2", 22, 50, 20, 1, "Shorts", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "30", "32", "34" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_3", 25, 50, 20, 1, "Capris", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "25", "27", "29" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_4", 30, 50, 20, 1, "Capris", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "30", "32", "34" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_5", 24, 50, 20, 1, "Leggings", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "25", "27", "29" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_6", 28, 50, 20, 1, "Leggings", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "30", "32", "34" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_7", 15, 50, 20, 1, "Vest", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "25", "27", "29" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_8", 18, 50, 20, 1, "Vest", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "30", "32", "34" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_9", 25, 50, 20, 1, "Top", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "25", "27", "29" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_10", 30, 50, 20, 1, "Top", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "30", "32", "34" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_11", 35, 50, 20, 1, "Jacket", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "25", "27", "29" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Clothing, "Clothing_Item_12", 40, 50, 20, 1, "Jacket", new Dictionary<string, string[]> 
            {
                { "Size", new string[] { "30", "32", "34" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });

            #endregion

            #region Shoes

            // Shoes
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_1", 45, 60, 20, 2, "Racer", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "20", "22", "24", "26" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_2", 50, 60, 20, 2, "Racer", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "26", "28", "30", "32" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_3", 45, 60, 20, 2, "Stabiliyt", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "20", "22", "24", "26" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_4", 50, 60, 20, 2, "Stability", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "26", "28", "30", "32" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_5", 55, 60, 20, 2, "Neutral", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "20", "22", "24", "26" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_6", 60, 60, 20, 2, "Neutral", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "26", "28", "30", "32" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_7", 55, 60, 20, 2, "Trail", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "20", "22", "24", "26" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_8", 60, 60, 20, 2, "Trail", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "26", "28", "30", "32" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_9", 60, 60, 20, 2, "Track", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "20", "22", "24", "26" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Shoe, "Shoe_Item_10", 70, 60, 20, 2, "Track", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "26", "28", "30", "32" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });

            #endregion

            #region Accessorys

            // Accessorys

            #region Bags

            // Bags
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Bag_Item_1", 20, 40, 10, 3, "Bag", new Dictionary<string, string[]>
            {
                { "Capacity", new string[] { "15", "20", "25", "30", "35", "40" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Bag_Item_2", 25, 40, 10, 3, "Bag", new Dictionary<string, string[]>
            {
                { "Capacity", new string[] { "30", "35", "40", "45", "50", "55" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Bag_Item_3", 30, 40, 10, 3, "Bag", new Dictionary<string, string[]>
            {
                { "Capacity", new string[] { "15", "20", "25", "30", "35", "40" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Bag_Item_4", 35, 40, 10, 3, "Bag", new Dictionary<string, string[]>
            {
                { "Capacity", new string[] { "30", "35", "40", "45", "50", "55" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Bag_Item_5", 40, 40, 10, 3, "Bag", new Dictionary<string, string[]>
            {
                { "Capacity", new string[] { "15", "20", "25", "30", "35", "40" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Bag_Item_6", 45, 40, 10, 3, "Bag", new Dictionary<string, string[]>
            {
                { "Capacity", new string[] { "30", "35", "40", "45", "50", "55" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Bag_Item_7", 50, 40, 10, 3, "Bag", new Dictionary<string, string[]>
            {
                { "Capacity", new string[] { "15", "20", "25", "30", "35", "40" } },
                { "Colour", new string[] { "Blue, Black, Grey, Purple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Bag_Item_8", 55, 40, 10, 3, "Bag", new Dictionary<string, string[]>
            {
                { "Capacity", new string[] { "30", "35", "40", "45", "50", "55" } },
                { "Colour", new string[] { "Blue, White, Green, Red" } }
            });

            #endregion

            #region Nutritions

            // Nutritions
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Nutrition_Item_1", 30, 60, 20, 3, "Nutrition", new Dictionary<string, string[]>
            {
                { "Nutrition Type", new string[] { "Carbs" } },
                { "Quantity", new string[] { "10", "15", "20", "25", "30" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Nutrition_Item_2", 35, 60, 20, 3, "Nutrition", new Dictionary<string, string[]>
            {
                { "Nutrition Type", new string[] { "Carbs" } },
                { "Quantity", new string[] { "10", "15", "20", "25", "30", "35", "40" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Nutrition_Item_3", 40, 60, 20, 3, "Nutrition", new Dictionary<string, string[]>
            {
                { "Nutrition Type", new string[] { "Carbs" } },
                { "Quantity", new string[] { "30", "35", "40", "45", "50", "55", "60" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Nutrition_Item_4", 30, 60, 20, 3, "Nutrition", new Dictionary<string, string[]>
            {
                { "Nutrition Type", new string[] { "Protein" } },
                { "Quantity", new string[] { "10", "15", "20", "25", "30" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Nutrition_Item_5", 35, 60, 20, 3, "Nutrition", new Dictionary<string, string[]>
            {
                { "Nutrition Type", new string[] { "Protein" } },
                { "Quantity", new string[] { "10", "15", "20", "25", "30", "35", "40" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Nutrition_Item_6", 40, 60, 20, 3, "Nutrition", new Dictionary<string, string[]>
            {
                { "Nutrition Type", new string[] { "Protein" } },
                { "Quantity", new string[] { "30", "35", "40", "45", "50", "55", "60" } }
            });

            #endregion

            #region Watches

            // Watches
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Watch_Item_1", 40, 50, 20, 3, "Watche", new Dictionary<string, string[]>
            {
                { "Watche Type", new string[] { "Simple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Watch_Item_2", 50, 50, 20, 3, "Watche", new Dictionary<string, string[]>
            {
                { "Watche Type", new string[] { "Simple" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Watch_Item_3", 40, 50, 20, 3, "Watche", new Dictionary<string, string[]>
            {
                { "Watche Type", new string[] { "Hear Rate" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Watch_Item_4", 50, 50, 20, 3, "Watche", new Dictionary<string, string[]>
            {
                { "Watche Type", new string[] { "Heart Rate" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Watch_Item_5", 50, 50, 20, 3, "Watche", new Dictionary<string, string[]>
            {
                { "Watche Type", new string[] { "GPS" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Watch_Item_6", 60, 50, 20, 3, "Watche", new Dictionary<string, string[]>
            {
                { "Watche Type", new string[] { "GPS" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Watch_Item_7", 50, 50, 20, 3, "Watche", new Dictionary<string, string[]>
            {
                { "Watche Type", new string[] { "GPS and Heart Rate" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Watch_Item_8", 60, 50, 20, 3, "Watche", new Dictionary<string, string[]>
            {
                { "Watche Type", new string[] { "GPS and Heart Rate" } }
            });

            #endregion

            #region Other Accessorys

            // Other
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Hat_Item_1", 20, 40, 10, 3, "Hat", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "10", "15", "20", "25", "30" } },
                { "Colour", new string[] { "White", "Black", "Yellow", "Blue", "Green" } },
                { "Hat Type", new string[] { "Cap" } }
            });
            stockSystem.enterNewItem(StockSystem.ItemType.Accessory, "Hat_Item_2", 30, 40, 10, 3, "Hat", new Dictionary<string, string[]>
            {
                { "Size", new string[] { "10", "15", "20", "25", "30" } },
                { "Colour", new string[] { "Yellow", "Black & White", "Rainbow" } },
                { "Hat Type", new string[] { "Sombrero" } }
            });

            #endregion

            #endregion

            return;
        }
    }
}
