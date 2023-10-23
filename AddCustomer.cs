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

        // Initialise the 'Add Customer' form
        public AddCustomer()
        {
            InitializeComponent();
        }

        // Close the 'Add Customer' form when the 'Close' button is clicked
        private void CancelNewCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
