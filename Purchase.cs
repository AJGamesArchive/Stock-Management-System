using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to aggrigate into Customer and store all a customers orders
    public class Purchase
    {
        // Class Attributes
        private DateTime SaleDate;
        private List<Clothing> ClothingItems;
        private List<Shoe> ShoeItems;
        private List<Bag> BagItems;
        private List<Nutrition> NutritionItems;
        private List<Watche> WatcheItems;

        // Class Constructor
        public Purchase(DateTime saleDate)
        {
            SaleDate = saleDate;
            ClothingItems = new List<Clothing>();
            ShoeItems = new List<Shoe>();
            BagItems = new List<Bag>();
            NutritionItems = new List<Nutrition>();
            WatcheItems = new List<Watche>();
        }
    }
}
