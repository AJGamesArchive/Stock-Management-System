using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class AddSupplyer : Form
    {
        // Declaring the Entity Manager object
        private EntityManager em;

        // Initialise the 'Add Supplyer' form, retriving current instence of entity manager class
        public AddSupplyer(EntityManager em)
        {
            InitializeComponent();
            this.em = em;
        }

        // Close the 'Add Supplyer' form when the 'Close' button is clicked
        private void CancelNewSupplyerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        // Add a new supplier to the system when the 'Add Supplier' button is clicked
        private void AddNewSupplyerBtn_Click(object sender, EventArgs e)
        {
            // Gard statements to ensure all required data has been entered
            if (SupplyerNameTxt.Text == "") { invalidInput("Name"); return; }
            if (SupplyerEmailTxt.Text == "") { invalidInput("Email"); return; }
            if (SupplyerPhoneNumTxt.Text == "") { invalidInput("Phone Number"); return; }

            // Attempt to add the new supplier to the system
            if(!em.addNewSupplier(SupplyerNameTxt.Text, SupplyerEmailTxt.Text, SupplyerPhoneNumTxt.Text)) { invalidInput("Email"); return; }

            // Display confirmation message
            MessageBox.Show("New supplier added successfully!", "Success");
            this.Close();
            return;
        }

        // Function that displays an error to the user if an input is invalid
        private void invalidInput(string invalidInput)
        {
            MessageBox.Show($"An invalid supplier {invalidInput} was entered. Please enter a valid {invalidInput} and try again.", "Error Adding Supplier");
            return;
        }
    }
}
