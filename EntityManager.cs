using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System
{
    // Class to handel all th data processing (adding, updating, retrieving) for all Customers and Suppliers in the system
    public class EntityManager
    {
        // Declaring list to store all customer & suplier details
        private List<Customer> Customers;
        private List<Supplier> Suppliers;

        // Class constructor to create new lists for each entity data store
        public EntityManager()
        {
            Customers = new List<Customer>();
            Suppliers = new List<Supplier>();
        }

        // Overloaded Constructor to create new lists for each entity data store and add test data to the lists
        public EntityManager(TestData testData)
        {
            Customers = new List<Customer>();
            if(!testData.createTestCustomers(this)) { throw new ArgumentException("Invalid Customer Test Data"); }
            Suppliers = new List<Supplier>();
            if(!testData.createTestSuppliers(this)) { throw new ArgumentException("Invalid Supplier Test Data"); }
        }

        #region Add Entity Data Functions

        // Overloaded Function that takes a customers; name, email, and GDPR state and adds the new customer to the system
        // Returns 'true' if customer was added succesfuly and 'false' if not
        public bool addEntity(string name, string email, bool GDPR)
        {
            if(!isValidEmail(email)) { return false; } 
            Customers.Add(new Customer(name, email, GDPR));
            return true;
        }

        // Overloaded Function that takes a suppliers; name, email, and phone number and adds the new supplier to the system
        // Returns 'true' if supplier was added succesfuly and 'false' if not
        public bool addEntity(string name, string email, string phoneNumber)
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

        // Function to retreive a customer based off of their email
        // Will return true if a customer is found, will return false if no customer is found
        public bool getCustomer(string email, out Customer customer)
        {
            foreach(Customer c in Customers)
            {
                if(c.Email != email) { continue; }
                customer = c;
                return true;
            }
            customer = new Customer("An Error Occured", "", false);
            return false;
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
