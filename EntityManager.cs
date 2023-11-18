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
        // Class Attributes
        private List<Customer> Customers;
        private List<Supplier> Suppliers;

        // Class Constructor
        public EntityManager()
        {
            Customers = new List<Customer>();
            Suppliers = new List<Supplier>();
        }

        #region Retrieve Data

        // Function to retrieve a customer by a given ID
        public bool getCustomer(int id, out Customer customer)
        {
            foreach(Customer c in Customers)
            {
                if(!c.hasMatchingAttribute(id)) { continue; }
                customer = c;
                return true;
            }
            customer = new Customer(-1, "No Customer Found", "", false);
            return false;
        }

        // Function to retrieve a supplier by a given ID
        public bool getSupplier(int id, out Supplier supplier)
        {
            foreach(Supplier s in Suppliers)
            {
                if(s.hasMatchingAttribute(id)) { continue; }
                supplier = s;
                return true;
            }
            supplier = new Supplier(-1, "", "", "");
            return false;
        }

        // Function to retrieve the number of customers in the system
        public int getNumCustomers()
        {
            return Customers.Count;
        }

        // Function to retrieve the number of suppliers in the system
        public int getNumSuppliers()
        {
            return Suppliers.Count;
        }

        #endregion

        #region Add Data

        // Overloaded Function to add a customer to the system
        public void addEntity(Customer customer)
        {
            Customers.Add(customer);
            return;
        }

        // Overloaded Function to add a supplier to the system
        public void addEntity(Supplier supplier)
        {
            Suppliers.Add(supplier);
            return;
        }

        #endregion
    }
}