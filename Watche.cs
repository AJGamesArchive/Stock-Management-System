using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    public class Watche : Accessory
    {
       // Declaring all viable watche types as an enumeration
        public enum WatcheType
        {
            Simple,
            HeartRate,
            GPS,
            GPSandHeartRate
        }

        // Class Attributes
        private WatcheType Type { get; set; }

        // Class Constructor
        public Watche(string name, decimal price, int stockLevel, int orderStockLeevel, Supplier supplier, WatcheType watcheType) : base(name, price, stockLevel, orderStockLeevel, supplier)
        {
            Type = watcheType;
        }
    }
}
