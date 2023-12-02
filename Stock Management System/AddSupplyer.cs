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
        // Declaring the Stock System object
        private StockSystem stockSystem;

        // Initialise the 'Add Supplyer' form, retriving current instence of stock system object
        public AddSupplyer(StockSystem ss)
        {
            InitializeComponent();
            stockSystem = ss;
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
            // Gard statements to ensure all required data has been entered and is valid
            if (SupplyerNameTxt.Text == "") { invalidInput("Name"); return; }
            if (SupplyerEmailTxt.Text == "") { invalidInput("Email"); return; }
            if (!Tools.validEmail(SupplyerEmailTxt.Text)) { invalidInput("Email"); return; }
            if (SupplyerPhoneNumTxt.Text == "") { invalidInput("Phone Number"); return; }

            // Add a new supplier to the system
            stockSystem.enterNewSupplier(SupplyerNameTxt.Text, SupplyerEmailTxt.Text, SupplyerPhoneNumTxt.Text);

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
