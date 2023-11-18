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
        private string Name;
        private decimal Price;

        // Class Constructor
        public Purchase(string name, decimal price)
        {
            SaleDate = DateTime.Now;
            Name = name;
            Price = price;
        }

        // Overloaded constructor to allow a sale date to be manually passed in
        public Purchase(DateTime saleDate, string name, decimal price)
        {
            SaleDate = saleDate;
            Name = name;
            Price = price;
        }

        #region Manage Purchase Data

        public Dictionary<string, string> getPurchaseDetails()
        {
            Dictionary<string, string> purchaseDetails = new Dictionary<string, string>
            {
                {"Purchase Date", SaleDate.ToString()},
                {"Item Purchased", Name},
                {"Item Pricec", Price.ToString()}
            };
            return purchaseDetails;
        }

        #endregion
    }
}
