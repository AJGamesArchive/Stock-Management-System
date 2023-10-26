using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    internal class Purchase
    {
        // Class Attributes
        private DateTime SaleDate { get; set; }
        private StockSystem ItemsSold { get; set; }

        // Class Constructor
        public Purchase(DateTime saleDate, StockSystem itemsSold)
        {
            SaleDate = saleDate;
            ItemsSold = itemsSold;
        }
    }
}
