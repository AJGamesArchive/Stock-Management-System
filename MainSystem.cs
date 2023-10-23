namespace Stock_Management_System
{
    public partial class MainSystem : Form
    {
        // Initialise the Main System form
        public MainSystem()
        {
            InitializeComponent();
        }

        // Open Add Customer form when the 'Add New' button is clicked
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }
    }
}