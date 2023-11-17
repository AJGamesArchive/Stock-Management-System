using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    public static class Tools
    {
        // Function that takes an email address as a string and checks that it's a valid email address
        public static bool validEmail(string email)
        {
            // Gard statment to ensure the string is not empty or null
            if (string.IsNullOrWhiteSpace(email)) { return false; }

            // Split the email address at the '@' symbol
            string[] parts = email.Split('@');

            // Gard statment to ensure there's only one '@' symbol in the email
            if (parts.Length != 2) { return false; }

            // Extract the domain part of the email
            string domain = parts[1];

            // Split the domain at the '.' symbol
            string[] domainParts = domain.Split('.');

            // Gard statment to ensure there's at least one '.' symbol in the domain section of the email
            if (!(domainParts.Length >= 2)) { return false; }

            // Returns true as the email is valid
            return true;
        }
    }
}
