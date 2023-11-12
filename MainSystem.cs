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

        // Function to reset the state(s) and some attribute(s) of the GUI components on the shop tab
        private void shopTabReset()
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
            SelectBagCapacityCmb.Items.Clear();
            SelectBagCapacityCmb.Enabled = false;
            SelectNutritionTypeCmb.Items.Clear();
            SelectNutritionTypeCmb.Enabled = false;
            SelectNutritionQuantityCmb.Items.Clear();
            SelectNutritionQuantityCmb.Enabled = false;
            SelectWatcheTypeCmb.Items.Clear();
            SelectWatcheTypeCmb.Enabled = false;
            SelectItemDCmb.Items.Clear();
            SelectItemDCmb.Enabled = false;
            AccessoryFilterGrpBx.Enabled = false;
            // Shoe Item Filter Group Box
            RacerRdBtn.Checked = false;
            StabilityRdBtn.Checked = false;
            NeutralRdBtn.Checked = false;
            TrailRdBtn.Checked = false;
            TrackRdBtn.Checked = false;
            SelectShoeSizeCmb.Items.Clear();
            SelectShoeSizeCmb.Enabled = false;
            SelectItemCCmb.Items.Clear();
            SelectItemCCmb.Enabled = false;
            ShoeItemFilterGrpBx.Enabled = false;
            // Clothing Item Filter Group Box
            ShortsRdBtn.Checked = false;
            VestsRdBtn.Checked = false;
            CaprisRdBtn.Checked = false;
            TopsRdBtn.Checked = false;
            LeggingsRdBtn.Checked = false;
            JacketsRdBtn.Checked = false;
            SelectClothingSizeCmb.Items.Clear();
            SelectClothingSizeCmb.Enabled = false;
            SelectClothingColourCmb.Items.Clear();
            SelectClothingColourCmb.Enabled = false;
            SelectItemBCmb.Items.Clear();
            SelectItemBCmb.Enabled = false;
            ClothingItemFilterGrpBx.Enabled = false;
            // Select Item Group Box
            SelectItemACmb.Items.Clear();
            SelectItemACmb.Enabled = false;
            SelectItemTypeCmb.SelectedIndex = -1;
            SelectItemTypeCmb.Enabled = false;
            SelectItemGrpBx.Enabled = false;
        }

        // Overloaded Function to output clothing item details to the GUI
        private void shopOutputItem(Clothing item)
        {
            DtlNameDisplayLbl.Text = item.Name;
            DtlPriceDisplayLbl.Text = item.Price.ToString();
            DtlStockLevelDisplayLbl.Text = item.StockLevel.ToString();
            DtlSizeDisplayLbl.Text = item.Size.ToString();
            DtlColourDisplayLbl.Text = item.Colour;
            DtlClothingStyleDisplayLbl.Text = item.Style.ToString();
            DtlShoeTypeDisplayLbl.Text = "-----";
            DtlAccessoryDisplayLbl.Text = "-----";
            DtlBagCapacityDisplayLbl.Text = "-----";
            DtlNutritionTypeDisplayLbl.Text = "-----";
            DtlNutritionQuantityDisplayLbl.Text = "-----";
            DtlWatcheTypeDisplayLbl.Text = "-----";
            return;
        }

        // Overloaded Function to output shoe item details to the GUI
        private void shopOutputItem(Shoe item)
        {
            DtlNameDisplayLbl.Text = item.Name;
            DtlPriceDisplayLbl.Text = item.Price.ToString();
            DtlStockLevelDisplayLbl.Text = item.StockLevel.ToString();
            DtlSizeDisplayLbl.Text = item.Size.ToString();
            DtlColourDisplayLbl.Text = "-----";
            DtlClothingStyleDisplayLbl.Text = "-----";
            DtlShoeTypeDisplayLbl.Text = item.Type.ToString();
            DtlAccessoryDisplayLbl.Text = "-----";
            DtlBagCapacityDisplayLbl.Text = "-----";
            DtlNutritionTypeDisplayLbl.Text = "-----";
            DtlNutritionQuantityDisplayLbl.Text = "-----";
            DtlWatcheTypeDisplayLbl.Text = "-----";
            return;
        }

        // Overloaded Function to output bag item details to the GUI
        private void shopOutputItem(Bag item)
        {
            DtlNameDisplayLbl.Text = item.Name;
            DtlPriceDisplayLbl.Text = item.Price.ToString();
            DtlStockLevelDisplayLbl.Text = item.StockLevel.ToString();
            DtlSizeDisplayLbl.Text = "-----";
            DtlColourDisplayLbl.Text = "-----";
            DtlClothingStyleDisplayLbl.Text = "-----";
            DtlShoeTypeDisplayLbl.Text = "-----";
            DtlAccessoryDisplayLbl.Text = "Bag";
            DtlBagCapacityDisplayLbl.Text = item.Capacity.ToString();
            DtlNutritionTypeDisplayLbl.Text = "-----";
            DtlNutritionQuantityDisplayLbl.Text = "-----";
            DtlWatcheTypeDisplayLbl.Text = "-----";
            return;
        }

        // Overloaded Function to output nutrition item details to the GUI
        private void shopOutputItem(Nutrition item)
        {
            DtlNameDisplayLbl.Text = item.Name;
            DtlPriceDisplayLbl.Text = item.Price.ToString();
            DtlStockLevelDisplayLbl.Text = item.StockLevel.ToString();
            DtlSizeDisplayLbl.Text = "-----";
            DtlColourDisplayLbl.Text = "-----";
            DtlClothingStyleDisplayLbl.Text = "-----";
            DtlShoeTypeDisplayLbl.Text = "-----";
            DtlAccessoryDisplayLbl.Text = "Nutrition";
            DtlBagCapacityDisplayLbl.Text = "-----";
            DtlNutritionTypeDisplayLbl.Text = item.Type.ToString();
            DtlNutritionQuantityDisplayLbl.Text = item.Quantity.ToString();
            DtlWatcheTypeDisplayLbl.Text = "-----";
            return;
        }

        // Overloaded Function to output watche item details to the GUI
        private void shopOutputItem(Watche item)
        {
            DtlNameDisplayLbl.Text = item.Name;
            DtlPriceDisplayLbl.Text = item.Price.ToString();
            DtlStockLevelDisplayLbl.Text = item.StockLevel.ToString();
            DtlSizeDisplayLbl.Text = "-----";
            DtlColourDisplayLbl.Text = "-----";
            DtlClothingStyleDisplayLbl.Text = "-----";
            DtlShoeTypeDisplayLbl.Text = "-----";
            DtlAccessoryDisplayLbl.Text = "Watche";
            DtlBagCapacityDisplayLbl.Text = "-----";
            DtlNutritionTypeDisplayLbl.Text = "-----";
            DtlNutritionQuantityDisplayLbl.Text = "-----";
            DtlWatcheTypeDisplayLbl.Text = item.Type.ToString();
            return;
        }

        #endregion

        #region Shop Tab

        #region Select Customer Group Box

        // Open Add Customer form when the 'Add New' button is clicked
        // Passes current entity manager instence into the 'Add Customer' form class
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer(em);
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
            CustomerGDPRDisplayLbl.Text = "-----";
            return;
        }

        // Display the selected customers details to the GUI and unlock the item method selection system, if a customer is found
        private void CustomerEmailSelectCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!em.getCustomer(CustomerEmailSelectCmb.Text, out Customer customer))
            {
                shopUnaccpectedError();
                CustomerNameDisplayLbl.Text = customer.Name;
                return;
            }
            CustomerNameDisplayLbl.Text = customer.Name;
            CustomerGDPRDisplayLbl.Text = customer.GDPR.ToString();
            ItemSelectionMethodGrpBx.Enabled = true;
        }

        #endregion

        #region Item Selection Method Group Box

        // Allow the user to select an item from the system by name if this selection method is chosen
        private void ItemNameRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if(!ItemNameRdBtn.Checked) { return; }
            shopTabReset();
            string[] itemNames = im.getAllItemNames();
            foreach(string name in itemNames)
            {
                SelectItemACmb.Items.Add(name);
            }
            SelectItemGrpBx.Enabled = true;
            SelectItemACmb.Enabled = true;
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
        private void SelectItemACmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItemDetailsGrpBx.Enabled = true;
            if(im.getClothingItem(SelectItemACmb.Text, out Clothing clothing)) { shopOutputItem(clothing); return; }
            if(im.getShoeItem(SelectItemACmb.Text, out Shoe shoe)) { shopOutputItem(shoe); return; }
            if(im.getBagItem(SelectItemACmb.Text, out Bag bag)) { shopOutputItem(bag); return; }
            if(im.getNutritionItem(SelectItemACmb.Text, out Nutrition nutrition)) { shopOutputItem(nutrition); return; }
            if(im.getWatcheItem(SelectItemACmb.Text, out Watche watche)) { shopOutputItem(watche); return; }
            shopUnaccpectedError();
            return;
        }

        #endregion

        #region Selected Item Details Group Box

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

        // Open Add Customer form when the 'Add New' button is clicked
        // Passes current entity manager instence into the 'Add Supplier' form class
        private void AddSupplyerBtn_Click(object sender, EventArgs e)
        {
            AddSupplyer addSupplyer = new AddSupplyer(em);
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
        private void shopUnaccpectedError()
        {
            shopTabReset();
            ItemSelectionMethodGrpBx.Enabled = false;
            CustomerNameDisplayLbl.Text = "-----";
            CustomerGDPRDisplayLbl.Text = "-----";
            CustomerEmailSelectCmb.SelectedIndex = -1;
            MessageBox.Show("An unaccpected error has occured. Please try again or reset the form.", "Unaccpected Error");
            return;
        }

        #endregion
    }
}