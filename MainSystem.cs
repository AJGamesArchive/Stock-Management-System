using System.ComponentModel;

namespace Stock_Management_System
{
    public partial class MainSystem : Form
    {
        // Class Attributeese
        private StockSystem stockSystem;
        // Class Constructor
        public MainSystem(StockSystem ss)
        {
            stockSystem = ss;
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
            string[] customerIdentifiers = stockSystem.retrieveCustomerIdentifiers();
            foreach(string identifier in customerIdentifiers)
            {
                CustomerEmailSelectCmb.Items.Add(identifier);
                VCPCustomerEmailCmb.Items.Add(identifier);
            }
            // Update supplier data combo box
            string[] supplierIdentifiers = stockSystem.retrieveSupplierIdentifiers();
            foreach(string identifier in supplierIdentifiers)
            {
                SelectSupplyerCmb.Items.Add(identifier);
            }
            return;
        }

        // Function to reset the state(s) and some attribute(s) of the GUI components on the shop tab
        private void shopTabReset()
        {
            // Selected Item Details Group Box
            DtlNameDisplayLbl.Text = "-----";
            DtlPriceDisplayLbl.Text = "-----";
            DtlStockLevelDisplayLbl.Text = "-----";
            DtlTypeDisplayLbl.Text = "-----";
            DtlSupplierDisplayLbl.Text = "-----";
            PurchaseConfirmationGrpBx.Enabled = false;
            // Select Item Group Box
            SelectItemCmb.Items.Clear();
            SelectItemCmb.Enabled = false;
            SelectItemTypeCmb.SelectedIndex = -1;
            SelectItemTypeCmb.Enabled = false;
            SelectItemGrpBx.Enabled = false;
            CharacteristicsDisplayTxt.Text = "";
            SelectionFilterMessageLbl.Text = "-----";
            SelectionFilterMessageLbl.ForeColor = Color.Black;
        }

        #endregion

        #region Shop Tab

        #region Select Customer Group Box

        // Open Add Customer form when the 'Add New' button is clicked
        // Passes current stock system instence into the 'Add Customer' form class
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(stockSystem);
            addCustomer.Show();
            return;
        }

        // Refresh the data combo boxes when 'Refresh' button is clicked
        private void RefreshCustomersBtn_Click(object sender, EventArgs e)
        {
            updateGUIData();
            shopTabReset();
            ItemNameRdBtn.Checked = false;
            ItemFilterRdBtn.Checked = false;
            ItemSelectionMethodGrpBx.Enabled = false;
            CustomerNameDisplayLbl.Text = "-----";
            DtlCustomerDisplayLbl.Text = "-----";
            CustomerEmailDisplayLbl.Text = "-----";
            CustomerGDPRDisplayLbl.Text = "-----";
            return;
        }

        // Display the selected customers details to the GUI and unlock the item method selection system, if a customer is found
        private void CustomerEmailSelectCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!Tools.getEntityId(CustomerEmailSelectCmb.Text, out int id)) { shopUnaccpectedError("A valid Id could not be found for the selected customer. Please try again."); return; }
            if(!stockSystem.retrieveCustomerDetails(id, out string[] details)) { shopUnaccpectedError("The selected customer could not be found. Please try again."); return; }
            CustomerNameDisplayLbl.Text = details[0];
            DtlCustomerDisplayLbl.Text = details[0];
            CustomerEmailDisplayLbl.Text = details[1];
            CustomerGDPRDisplayLbl.Text = details[2];
            ItemSelectionMethodGrpBx.Enabled = true;
            return;
        }

        #endregion

        #region Item Selection Method Group Box

        // Allow the user to select an item from the system by name if this selection method is chosen
        private void ItemNameRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(!ItemNameRdBtn.Checked) { return; }
            shopTabReset();
            string[] itemIdentifiers = stockSystem.retrieveItemIdentifiers();
            foreach(string identifier in itemIdentifiers)
            {
                SelectItemCmb.Items.Add(identifier);
            }
            SelectItemGrpBx.Enabled = true;
            SelectItemCmb.Enabled = true;
            SelectionFilterMessageLbl.Text = "ALL ITEMS";
            SelectionFilterMessageLbl.ForeColor = Color.ForestGreen;
            return;
        }

        // Allow the user to select an item type from the system if this selection method is chosen
        private void ItemFilterRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(!ItemFilterRdBtn.Checked) { return; }
            shopTabReset();
            SelectItemGrpBx.Enabled = true;
            SelectItemTypeCmb.Enabled = true;
            return;
        }

        #endregion

        #region Select Item Group Box

        // Output the selected items details to the GUI when an item is selected
        private void SelectItemCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            PurchaseConfirmationGrpBx.Enabled = true;
            if(!Tools.getEntityId(SelectItemCmb.Text, out int id)) { shopUnaccpectedError("A valid Id could not be found for the selected item. Please try again"); return; }
            if(!stockSystem.retrieveCoreItemDetails(id, out string[] coreDetails)) { shopUnaccpectedError("The selected items core details could not be found. Please try again."); return; }
            if(!stockSystem.retrieveItemCharacteristics(id, out string[] itemCharacteristics)) { shopUnaccpectedError(("The selected item's characteristics could not be found. Please try again.")); return; }
            DtlNameDisplayLbl.Text = coreDetails[0];
            DtlPriceDisplayLbl.Text = coreDetails[1];
            DtlStockLevelDisplayLbl.Text = coreDetails[2];
            string[] typeSplit = coreDetails[3].Split(".");
            DtlTypeDisplayLbl.Text = typeSplit[1];
            DtlSupplierDisplayLbl.Text = coreDetails[4];
            CharacteristicsDisplayTxt.Text = "";
            foreach (string detail in itemCharacteristics)
            {
                CharacteristicsDisplayTxt.Text += detail;
                CharacteristicsDisplayTxt.Text += Environment.NewLine;
            }
            return;
        }

        // Updated the 'Select Item' combo box with a filtered list of items when an item type filter is selected
        private void SelectItemTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Purchase Confirmation Group Box

        // Cancel the current sail when the 'Cancel Sail' button is clicked
        private void CancelSailBtn_Click(object sender, EventArgs e)
        {
            shopTabReset();
            ItemNameRdBtn.Checked = false;
            ItemFilterRdBtn.Checked = false;
            return;
        }

        #endregion

        #region System Controls Group Box

        // Open the Admin pannel when the 'Manage Stock' button is clicked
        private void ManageStockBtn_Click(object sender, EventArgs e)
        {
            NavSystemMain.SelectedIndex = 1;
            return;
        }

        // Reset the shop tab form when the 'Clear Form' button is clicked
        private void ClearFormBtn_Click(object sender, EventArgs e)
        {
            shopTabReset();
            ItemNameRdBtn.Checked = false;
            ItemFilterRdBtn.Checked = false;
            return;
        }

        #endregion

        #endregion

        #region Admin Tab

        #region View Restock Requirements By Supplier Group Box

        // Open Add Supplier form when the 'Add New' button is clicked
        // Passes current stock system instence into the 'Add Supplier' form class
        private void AddSupplyerBtn_Click(object sender, EventArgs e)
        {
            AddSupplyer addSupplyer = new AddSupplyer(stockSystem);
            addSupplyer.Show();
            return;
        }

        // Refresh the data combo boxes when 'Refresh' button is clicked
        private void RefreshSuppliersBtn_Click(object sender, EventArgs e)
        {
            updateGUIData();
            shopTabReset();
            ItemNameRdBtn.Checked = false;
            ItemFilterRdBtn.Checked = false;
            ItemSelectionMethodGrpBx.Enabled = false;
            CustomerNameDisplayLbl.Text = "-----";
            DtlCustomerDisplayLbl.Text = "-----";
            CustomerEmailDisplayLbl.Text = "-----";
            CustomerGDPRDisplayLbl.Text = "-----";
            return;
        }

        #endregion

        #region System Controls Group Box

        // Open the Shop pannel when the 'Sell Stock' button is clicked
        private void SellStockBtn_Click(object sender, EventArgs e)
        {
            NavSystemMain.SelectedIndex = 0;
            return;
        }

        #endregion

        #endregion

        #region Unaccpected Error Occured

        // Function to handel unaccpected errors
        private void shopUnaccpectedError(string message)
        {
            shopTabReset();
            ItemSelectionMethodGrpBx.Enabled = false;
            CustomerNameDisplayLbl.Text = "-----";
            DtlCustomerDisplayLbl.Text = "-----";
            CustomerEmailDisplayLbl.Text = "-----";
            CustomerGDPRDisplayLbl.Text = "-----";
            CustomerEmailSelectCmb.SelectedIndex = -1;
            MessageBox.Show(message, "Unaccpected Error");
            return;
        }

        #endregion
    }
}