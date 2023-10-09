using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    internal class Accounts : Customer
    {
        public enum Type
        {
            Customer,
            Admin
        }
        public string Password { get; set; }
        public Type Rank { get; set; }
        public string CreationDate { get; set; }
    }
}
