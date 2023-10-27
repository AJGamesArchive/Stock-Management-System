namespace Stock_Management_System
{
    public partial class MainSystem : Form
    {
        // Declaring the Entity Manager object
        private EntityManager em;

        // Initialise the Main System form, retrieving the entity manager instence, populateing certain combo boxing with data
        public MainSystem(EntityManager em)
        {
            InitializeComponent();
            this.em = em;
            updateGUIData();
        }

        #region Common Functions

        // Update varying data displayed in the combo boxes on the GUI
        private void updateGUIData()
        {
            // Clear all the data combo bxes before re-adding data to them
            CustomerEmailSelectCmb.Items.Clear();
            VCPCustomerEmailCmb.Items.Clear();
            SelectSupplyerCmb.Items.Clear();

            // Update customer data combo boxes
            string[] customerEmails = em.getCustomerEmails();
            foreach(string email in customerEmails)
            {
                CustomerEmailSelectCmb.Items.Add(email);
                VCPCustomerEmailCmb.Items.Add(email);
            }

            // Update supplier data combo box
            string[] supplierNames = em.getSupplierNames();
            foreach(string name in supplierNames)
            {
                SelectSupplyerCmb.Items.Add(name);
            }

            return;
        }

        #endregion

        #region Shop Tab

        // Open Add Customer form when the 'Add New' button is clicked
        // Passes current entity manager instence into the 'Add Customer' form class
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(em);
            addCustomer.Show();
            return;
        }

        // Open the Admin pannel when the 'Manage Stock' button is clicked
        private void ManageStockBtn_Click(object sender, EventArgs e)
        {
            NavSystemMain.SelectedIndex = 1;
            // Add the clear form function here as well
            return;
        }

        // Refresh the data combo boxes when 'Refresh' button is clicked
        private void RefreshCustomersBtn_Click(object sender, EventArgs e)
        {
            updateGUIData();
            return;
        }

        #endregion

        #region Admin Tab

        // Open Add Customer form when the 'Add New' button is clicked
        // Passes current entity manager instence into the 'Add Supplier' form class
        private void AddSupplyerBtn_Click(object sender, EventArgs e)
        {
            AddSupplyer addSupplyer = new AddSupplyer(em);
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

        // Refresh the data combo boxes when 'Refresh' button is clicked
        private void RefreshSuppliersBtn_Click(object sender, EventArgs e)
        {
            updateGUIData();
            return;
        }

        #endregion
    }
}