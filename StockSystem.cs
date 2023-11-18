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

        #endregion

        #region Data Processing



        #endregion
    }
}
