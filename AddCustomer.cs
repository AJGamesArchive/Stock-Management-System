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
    public partial class AddCustomer : Form
    {
        // Declaring the Stock System object
        private StockSystem stockSystem;

        // Initialise the 'Add Customer' form, retrieve current instence of stock system object
        public AddCustomer(StockSystem ss)
        {
            InitializeComponent();
            stockSystem = ss;
        }

        // Close the 'Add Customer' form when the 'Close' button is clicked
        private void CancelNewCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        // Add a new customer to the system when the 'Add Customer' button is clicked
        private void AddNewCustomerBtn_Click(object sender, EventArgs e)
        {
            // Gard statements to ensure all required data has been entered
            if(CustomerNameTxt.Text == "") { invalidInput("Name"); return; }
            if(CustomerEmailTxt.Text == "") { invalidInput("Email"); return; }
            if(!Tools.validEmail(CustomerEmailTxt.Text)) { invalidInput("Email"); return; }
            if (CustomerGDPRConcentRdBtn.Checked == false && CustomerGDPRNoConcentRdBtn.Checked == false) { invalidInput("GDPR State"); return; }

            // Check the GDPR State
            bool GDPR = (CustomerGDPRConcentRdBtn.Checked) ? true : false;

            // Add new customer to the system
            stockSystem.enterNewCustomer(CustomerNameTxt.Text, CustomerEmailTxt.Text, GDPR);

            // Display confirmation message
            MessageBox.Show("New customer added successfully!", "Success");
            this.Close();
            return;
        }

        // Function that displays an error to the user if an input is invalid
        private void invalidInput(string invalidField)
        {
            MessageBox.Show($"An invalid Customer {invalidField} was entered. Please enter a valid {invalidField} and then try again.", "Error Adding Customer");
            return;
        }
    }
}
