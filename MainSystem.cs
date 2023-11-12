using System.ComponentModel;

namespace Stock_Management_System
{
    public partial class MainSystem : Form
    {
        // Class Attributeese
        private EntityManager em;
        private ItemManager im;

        // Class Constructor
        public MainSystem(EntityManager entityManager, ItemManager itemManager)
        {
            em = entityManager;
            im = itemManager;
            InitializeComponent();
        }

        // Initial GUI setup on form load
        private void MainSystem_Load(object sender, EventArgs e)
        {
            updateGUIData();
            return;
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
            return;
        }

        // Refresh the data combo boxes when 'Refresh' button is clicked
        private void RefreshCustomersBtn_Click(object sender, EventArgs e)
        {
            updateGUIData();
            shopTabRese();
            ItemSelectionMethodGrpBx.Enabled = false;
            CustomerNameDisplayLbl.Text = "-----";
            CustomerGDPRDisplayLbl.Text = "-----";
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
            return;
        }

        // Refresh the data combo boxes when 'Refresh' button is clicked
        private void RefreshSuppliersBtn_Click(object sender, EventArgs e)
        {
            updateGUIData();
            shopTabRese();
            ItemSelectionMethodGrpBx.Enabled = false;
            CustomerNameDisplayLbl.Text = "-----";
            CustomerGDPRDisplayLbl.Text = "-----";
            return;
        }

        #endregion

        #region Reset Functions

        // Reset the shop tab form when the 'Clear Form' button is clicked
        private void ClearFormBtn_Click(object sender, EventArgs e)
        {
            shopTabRese();
            return;
        }

        private void shopTabRese()
        {
            // Selected Item Details Group Box
            DtlNameDisplayLbl.Text = "-----";
            DtlPriceDisplayLbl.Text = "-----";
            DtlStockLevelDisplayLbl.Text = "-----";
            DtlSizeDisplayLbl.Text = "-----";
            DtlColourDisplayLbl.Text = "-----";
            DtlClothingStyleDisplayLbl.Text = "-----";
            DtlShoeTypeDisplayLbl.Text = "-----";
            DtlAccessoryDisplayLbl.Text = "-----";
            DtlBagCapacityDisplayLbl.Text = "-----";
            DtlNutritionTypeDisplayLbl.Text = "-----";
            DtlNutritionQuantityDisplayLbl.Text = "-----";
            DtlWatcheTypeDisplayLbl.Text = "-----";
            SelectedItemDetailsGrpBx.Enabled = false;
            // Accessory Filter Group Box
            BagsRdBtn.Checked = false;
            NutritionRdBtn.Checked = false;
            WatchesRdBtn.Checked = false;
            SelectBagCapacityCmb.Controls.Clear();
            SelectNutritionTypeCmb.Controls.Clear();
            SelectNutritionQuantityCmb.Controls.Clear();
            SelectWatcheTypeCmb.Controls.Clear();
            SelectItemDCmb.Controls.Clear();
            AccessoryFilterGrpBx.Enabled = false;
            // Shoe Item Filter Group Box
            RacerRdBtn.Checked = false;
            StabilityRdBtn.Checked = false;
            NeutralRdBtn.Checked = false;
            TrailRdBtn.Checked = false;
            TrackRdBtn.Checked = false;
            SelectShoeSizeCmb.Controls.Clear();
            SelectItemCCmb.Controls.Clear();
            ShoeItemFilterGrpBx.Enabled = false;
            // Clothing Item Filter Group Box
            ShortsRdBtn.Checked = false;
            VestsRdBtn.Checked = false;
            CaprisRdBtn.Checked = false;
            TopsRdBtn.Checked = false;
            LeggingsRdBtn.Checked = false;
            JacketsRdBtn.Checked = false;
            SelectClothingSizeColorLbl.Controls.Clear();
            SelectClothingColourCmb.Controls.Clear();
            SelectItemBCmb.Controls.Clear();
            ClothingItemFilterGrpBx.Enabled = false;
            // Select Item Group Box
            SelectItemACmb.Controls.Clear();
            SelectItemTypeCmb.Controls.Clear();
            SelectItemGrpBx.Enabled = false;
            // Item Selection Method Group Box
            ItemNameRdBtn.Checked = false;
            ItemFilterRdBtn.Checked = false;
        }

        #endregion
    }
}