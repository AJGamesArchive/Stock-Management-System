using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to construct a list to store all supplier details and create order re-stocking lists based off of a given supplier
    public class Supplier : IEntities
    {
        // Class Attributes
        private int Id;
        private string Name;
        private string Email;
        private string PhoneNumber;

        // Class Constructor
        public Supplier(int id, string name, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        #region Manage Supplier Data

        // Functions to check for matching attributes to identify the object instence
        public bool hasMatchingAttribute(int id)
        {
            if(Id == id) { return true; }
            return false;
        }

        // Overriden Function to create a string identifier for a supplier
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Class Responsibilities

        // Function to generate a list of all the items needing restocking from a given supplier
        public Dictionary<string, string>[] generateRestockList(Item[] items)
        {
            List<Dictionary<string, string>> restockList = new List<Dictionary<string, string>>();
            foreach(Item item in items)
            {
                if(!item.getRestockDetails(out Dictionary<string, string> restockDeails)) { continue; }
                restockList.Add(restockDeails);
            }
            return restockList.ToArray();
        }

        #endregion
    }
}
