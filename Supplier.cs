using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    internal class Supplier
    {
        // Class Attributes
        private string Name { get; set; }
        private string Email { get; set; }
        private string PhoneNumber { get; set; }

        // Class Constructor
        public Supplier(string name, string email, string phoneNumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
