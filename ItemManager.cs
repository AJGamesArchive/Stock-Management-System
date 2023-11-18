using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stock_Management_System.Clothing;
using static Stock_Management_System.Shoe;

namespace Stock_Management_System
{
    // Class to handel all the data processing (adding, updating, retrieving) for all items in the system
    public class ItemManager
    {
        // Class Attributes
        private List<Item> Items;

        // Class Constructor
        public ItemManager()
        {
            Items = new List<Item>();
        }

        #region Retrieve Data

        // Function to retrieve an item by a given item ID
        public bool getItem(int id, out Item item)
        {
            foreach(Item i in Items)
            {
                if (!i.hasMatchingAttribute(id)) { continue; }
                item = i;
                return true;
            }
            item = new Accessary(-1, "No Item Found", 0, 0, 0, new Supplier(-1, "", "", ""), "", new Dictionary<string, string[]>());
            return false;
        }

        // Function to retrieve all the items supplied by a given supplier
        public Item[] getItemsBySupplier(Supplier supplier)
        {
            List<Item> filteredItems = new List<Item>();
            foreach(Item i in Items)
            {
                if(!i.hasMatchingAttribute(supplier)) { continue; }
                filteredItems.Add(i);
            }
            return filteredItems.ToArray();
        }

        #endregion
    }
}