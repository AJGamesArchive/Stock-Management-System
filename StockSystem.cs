using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    public class StockSystem
    {
        // Enumeration to state the type of an item being added to the system
        public enum ItemType
        {
            Clothing,
            Shoe,
            Accessory
        }

        // Class Attributes
        private EntityManager entityManager;
        private ItemManager itemManager;

        // Class Constructor
        public StockSystem()
        {
            entityManager = new EntityManager();
            itemManager = new ItemManager();
        }

        #region Core Functions

        // Function to complete a purchase
        public bool completePurchase(int customerId, int itemid)
        {
            if(!entityManager.getCustomer(customerId, out Customer customer)) { return false; }
            if(!itemManager.getItem(itemid, out Item item)) { return false; }
            if(!item.sellItem(customer)) { return false; }
            return true;
        }

        // Function to return a generated list of all items needing restocking by a given supplier
        public bool getRestockList(int supplierId, out Dictionary<string, string>[] restockList)
        {
            if(!entityManager.getSupplier(supplierId, out Supplier supplier)) { restockList = new Dictionary<string, string>[0]; return false; }
            Item[] items = itemManager.getItemsBySupplier(supplier);
            restockList = supplier.generateRestockList(items);
            return true;
        }

        // Function to return a generated list of all purchases for a given customoer
        public bool getCustomerPurchases(int customerId, out Dictionary<string, string>[] purchaseList)
        {
            if (!entityManager.getCustomer(customerId, out Customer customer)) { purchaseList = new Dictionary<string, string>[0]; return false; }
            purchaseList = customer.getPurchases();
            return true;
        }

        // Function to enter a new customers details into the system
        public void enterNewCustomer(string name, string email, bool GDPR)
        {
            int id = entityManager.getNumCustomers() + 1;
            Customer customer = new Customer(id, name, email, GDPR);
            entityManager.addEntity(customer);
            return;
        }

        // Function to enter a new suppliers details into the system
        public void enterNewSupplier(string name, string email, string phoneNumber)
        {
            int id = entityManager.getNumSuppliers() + 1;
            Supplier supplier = new Supplier(id, name, email, phoneNumber);
            entityManager.addEntity(supplier);
            return;
        }

        // Function to enter a new items details into the systetm
        public bool enterNewItem(ItemType type, string name, decimal price, int stockLevel, int orderStockLevel, int supplierId, string make, Dictionary<string, string[]> characteristics)
        {
            if (!entityManager.getSupplier(supplierId, out Supplier supplier)) { return false; }
            int id = itemManager.getNumItems() + 1;
            switch(type)
            {
                case ItemType.Clothing:
                    Clothing clothing = new Clothing(id, name, price, stockLevel, orderStockLevel, supplier, make, characteristics);
                    itemManager.addItem(clothing);
                    break;
                case ItemType.Shoe:
                    Shoe shoe = new Shoe(id, name, price, stockLevel, orderStockLevel, supplier, make, characteristics);
                    itemManager.addItem(shoe);
                    break;
                case ItemType.Accessory:
                    Accessary accessary = new Accessary(id, name, price, stockLevel, orderStockLevel, supplier, make, characteristics);
                    itemManager.addItem(accessary);
                    break;
            }
            return true;
        }

        #endregion

        #region Data Processing

        // Function to retrieve the generated customer identifier strings
        public string[] retrieveCustomerIdentifiers()
        {
            return entityManager.generateCustomerIdentifierAll();
        }

        // Function to retrieve the generated supplier identifier strings
        public string[] retrieveSupplierIdentifiers()
        {
            return entityManager.generateSupplierIdentifierAll();
        }

        // Function to return a customers details if the customer exists
        public bool retrieveCustomerDetails(int id, out string[] details)
        {
            if(!entityManager.getCustomerDetails(id, out details)) { return false; }
            return true;
        }

        // Overloaded Function to retrieve the generated item identifier strings
        public string[] retrieveItemIdentifiers()
        {
            return itemManager.generateItemIdentifiers();
        }

        // Overloaded Function to retrieve the generated item identifiers for all the items of one type
        public string[] retrieveItemIdentifiers(string type)
        {
            return itemManager.generateItemIdentifiers(type);
        }

        // Function to retrieve the enerated core item details for an item based on given id
        public bool retrieveCoreItemDetails(int id, out string[] coreDetails)
        {
            if(!itemManager.generateCoreItemDetails(id, out coreDetails)) { return false; }
            return true;
        }

        // Function to return a string[] of the item charactoristics for a given item
        public bool retrieveItemCharacteristics(int id, out string[] characteristics)
        {
            if(!itemManager.getItemCharacteristics(id, out characteristics)) { return false; }
            return true;
        }



        #endregion
    }
}
