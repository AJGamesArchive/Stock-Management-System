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
        // Initialise the 'Add Supplyer' form
        public AddSupplyer()
        {
            InitializeComponent();
        }

        // Close the 'Add Supplyer' form when the 'Close' button is clicked
        private void CancelNewSupplyerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
