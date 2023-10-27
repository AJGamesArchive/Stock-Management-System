using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    public class EntityManager
    {
        // Declaring list to store all customer details
        private List<Customer> Customers;
        private List<Supplier> Suppliers;
        
        public EntityManager()
        {
            // Initalising the lists
            Customers = new List<Customer>();
            Suppliers = new List<Supplier>();

            // Populated some lists with test data
            createTestData();
        }

        #region Create Test Data Functions

        // Function that adds test data to some of the data store lists
        private void createTestData()
        {
            bool validTestData = true;

            // Declaring initial test data to store in the Customers list
            if(!addNewCustomer("Alex Ward", "AW949@canterbury.ac.uk", true)) { validTestData = false; }
            if(!addNewCustomer("Jonathan N", "jonathann@gmail.com", false)) { validTestData = false; }
            if(!addNewCustomer("Ethan", "ethanm@gmail.com", false)) { validTestData = false; }

            // Declaring initial test data to store in the Suppliers list
            if(!addNewSupplier("ClothingLtd", "clothing.supplys@gmail.com", "01304591665")) { validTestData = false; }
            if(!addNewSupplier("ShoeWareLtd", "shoeware.supplys@gmail.com", "01304187516")) { validTestData = false; }
            if(!addNewSupplier("AccessorysLtd", "accessory.supplys@gmail.com", "01304795168")) { validTestData = false; }

            // Ensure all provided test data is valid
            if (!validTestData)
            {
                MessageBox.Show("Some of the provided test data is invalid.");
            }

            return;
        }

        #endregion

        #region Add Entity Data Functions

        // Function that takes a customers; name, email, and GDPR state and adds the new customer to the system
        // Returns 'true' if customer was added succesfuly and 'false' if not
        public bool addNewCustomer(string name, string email, bool GDPR)
        {
            if(!isValidEmail(email)) { return false; } 
            Customers.Add(new Customer(name, email, GDPR));
            return true;
        }

        // Function that takes a suppliers; name, email, and phone number and adds the new supplier to the system
        // Returns 'true' if supplier was added succesfuly and 'false' if not
        public bool addNewSupplier(string name, string email, string phoneNumber)
        {
            if(!isValidEmail(email)) { return false; }
            Suppliers.Add(new Supplier(name, email, phoneNumber));
            return true;
        }

        #endregion

        #region Get Entity Data Functions

        // Function that retrieves all customer emails and returns them as a string array
        public string[] getCustomerEmails()
        {
            List<string> customerEmails = new List<string>();
            foreach(Customer customer in Customers)
            {
                customerEmails.Add(customer.Email);
            }
            return customerEmails.ToArray();
        }

        // Function that retrieves all supplier names and returns them as a string array
        public string[] getSupplierNames()
        {
            List<string> supplierNames = new List<string>();
            foreach(Supplier supplier in Suppliers)
            {
                supplierNames.Add(supplier.Name);
            }
            return supplierNames.ToArray();
        }

        #endregion

        #region Entity Data Validation Functions

        // Function that takes an email address as a string and checks that it's a valid email address
        private bool isValidEmail(string email)
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

        #endregion
    }
}
