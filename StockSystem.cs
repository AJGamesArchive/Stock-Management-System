using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    public class StockSystem
    {
        // Class Attributes
        private List<Clothing> ClothingItems { get; set; }
        private List<Shoe> ShoeItems { get; set; }
        private List<Bag> BagItems { get; set; }
        private List<Nutrition> NutritionItems { get; set; }
        private List<Watche> WatcheItems { get; set; }

        // Class Constructor
        public StockSystem()
        {
            ClothingItems = new List<Clothing>();
            ShoeItems = new List<Shoe>();
            BagItems = new List<Bag>();
            NutritionItems = new List<Nutrition>();
            WatcheItems = new List<Watche>();
        }

        // Functions that add respective items to the respective lists in the class
        public void addClothing(Clothing item)
        {
            ClothingItems.Add(item);
            return;
        }

        public void addShoe(Shoe item)
        {
            ShoeItems.Add(item);
            return;
        }

        public void addBag(Bag item)
        {
            BagItems.Add(item); 
            return;
        }

        public void addNutrition(Nutrition item)
        {
            NutritionItems.Add(item);
            return;
        }

        public void addWatche(Watche item)
        {
            WatcheItems.Add(item);
            return;
        }

        // Function to generate a list of all the items needing restocking by a given supplier
        public List<StockSystem> NeedingRestock(Supplier selectedSupplier)
        {
            List<StockSystem> needRestocking = new List<StockSystem>();

            // Writee algrithym here

            return needRestocking;
        }
    }
}
