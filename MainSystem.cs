namespace Stock_Management_System
{
    public partial class MainSystem : Form
    {
        // Initialise the Main System form
        public MainSystem()
        {
            InitializeComponent();
        }

        #region Shop Tab

        // Open Add Customer form when the 'Add New' button is clicked
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            return;
        }

        // Open the Admin pannel when the 'Manage Stock' button is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            NavSystemMain.SelectedIndex = 1;
            // Add the clear form function here as well
            return;
        }

        #endregion

        #region Admin Tab

        // Open Add Customer form when the 'Add New' button is clicked
        private void AddSupplyerBtn_Click(object sender, EventArgs e)
        {
            AddSupplyer addSupplyer = new AddSupplyer();
            addSupplyer.Show();
            return;
        }

        // Open the Shop pannel when the 'Sell Stock' button is clicked
        private void SellStockBtn_Click(object sender, EventArgs e)
        {
            NavSystemMain.SelectedIndex = 0;
            // Add the clear form function here as well
            return;
        }

        #endregion
    }
}