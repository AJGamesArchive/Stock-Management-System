using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to construct a list to store all supplier details and create order re-stocking lists based off of a given supplier
    public class Supplier
    {
        // Class Attributes
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string PhoneNumber { get; private set; }

        // Class Constructor
        public Supplier(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        // Function to generate a list of all the items needing restocking from a given supplier
        public string[] needingRestock(Clothing[] clothing, Shoe[] shoes, Bag[] bags, Nutrition[] nutritions, Watche[] watches)
        {
            List<string> itemIdentifiers = new List<string>();
            foreach(Clothing c in clothing)
            {
                if(c.Name != Name) { continue; }
                if(c.OrderStockLevel < c.StockLevel) { continue; }
                string identifier = $"{c.Name} (Clothing)";
                itemIdentifiers.Add(identifier);
            }
            foreach(Shoe s in shoes)
            {
                if (s.Name != Name) { continue; }
                if (s.OrderStockLevel < s.StockLevel) { continue; }
                string identifier = $"{s.Name} (Shoe)";
                itemIdentifiers.Add(identifier);
            }
            foreach(Bag b in bags)
            {
                if (b.Name != Name) { continue; }
                if (b.OrderStockLevel < b.StockLevel) { continue; }
                string identifier = $"{b.Name} (Bag)";
                itemIdentifiers.Add(identifier);
            }
            foreach(Nutrition n in nutritions)
            {
                if (n.Name != Name) { continue; }
                if (n.OrderStockLevel < n.StockLevel) { continue; }
                string identifier = $"{n.Name} (Nutrition)";
                itemIdentifiers.Add(identifier);
            }
            foreach(Watche w in watches)
            {
                if (w.Name != Name) { continue; }
                if (w.OrderStockLevel < w.StockLevel) { continue; }
                string identifier = $"{w.Name} (Watche)";
                itemIdentifiers.Add(identifier);
            }
            return itemIdentifiers.ToArray();
        }
    }
}
