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
    public sealed class ItemManager
    {
        // Enumeration to state the type of an item being added to or searched for in the system
        public enum ItemType
        {
            Clothing,
            Shoe,
            Accessory
        }

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

        // Function to retrieve the number of items in the system
        public int getNumItems()
        {
            return Items.Count;
        }

        // Overloaded Function to retrieve an identifier string for every item in the system
        public string[] generateItemIdentifiers()
        {
            List<string> identifiers = new List<string>();
            foreach(Item i in Items)
            {
                identifiers.Add(i.ToString());
            }
            return identifiers.ToArray();
        }

        // Overloaded Function to retrieve an identifier string for all of one type of item in the system
        public string[] generateItemIdentifiers(ItemType type)
        {
            List<string> identifiers = new List<string>();
            switch (type)
            {
                case ItemType.Clothing:
                    foreach(Item i in Items)
                    {
                        if(i is not Clothing clothing) { continue; }
                        identifiers.Add(i.ToString());
                    }
                    break;
                case ItemType.Shoe:
                    foreach (Item i in Items)
                    {
                        if (i is not Shoe shoe) { continue; }
                        identifiers.Add(i.ToString());
                    }
                    break;
                case ItemType.Accessory:
                    foreach (Item i in Items)
                    {
                        if (i is not Accessary accessary) { continue; }
                        identifiers.Add(i.ToString());
                    }
                    break;
            };
            return identifiers.ToArray();
        }

        // Function to generate an array of core item details based on a given Id
        public bool generateCoreItemDetails(int id, out string[] coreDetails)
        {
            foreach(Item i in Items)
            {
                if(!i.hasMatchingAttribute(id)) { continue; }
                coreDetails = i.getCoreDetails();
                return true;
            }
            coreDetails = new string[0];
            return false;
        }

        // Function to retrieve a string array of all the characteristics of a given item
        public bool getItemCharacteristics(int id, out string[] characteristics)
        {
            characteristics = new string[0];
            foreach(Item i in Items)
            {
                if(!i.hasMatchingAttribute(id)) { continue; }
                switch(i)
                {
                    case Clothing clothing:
                        characteristics = clothing.getCharacteristics();
                        break;
                    case Shoe shoe:
                        characteristics = shoe.getCharacteristics();
                        break;
                    case Accessary accessory:
                        characteristics = accessory.getCharacteristics();
                        break;
                };
                if(characteristics.Length == 0) { return false; }
                return true;
            }
            return false;
        }

        #endregion

        #region Add Data

        // Function to add a new item to the system
        public void addItem(Item item)
        {
            Items.Add(item);
            return;
        }

        #endregion
    }
}