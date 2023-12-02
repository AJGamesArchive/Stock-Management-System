using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class AddItem : Form
    {
        // Class Attributes
        private StockSystem stockSystem;

        // Class Constructor
        public AddItem(StockSystem stockSystem)
        {
            InitializeComponent();
            this.stockSystem = stockSystem;
        }

        // Add all suppliers in the system to the select supplier combo box when form loads
        private void AddItem_Load(object sender, EventArgs e)
        {
            string[] supplierIdentifiers = stockSystem.retrieveSupplierIdentifiers();
            foreach(string identifier in supplierIdentifiers)
            {
                SelectSupplierCmb.Items.Add(identifier);
            }
            return;
        }

        // Close the form when the 'Cancel' button is clicked
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        // Validate the entered item details and add the item to the system when the 'Add Item' button is clicked
        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            // Guard statements to ensure all entered details are valid
            if(!Tools.getEntityId(SelectSupplierCmb.Text, out int id)) { unaccpectedError("An ID for the selected supplier could not be found. Please try again."); return; }
            if(!decimal.TryParse(EnterPriceTxt.Text, out decimal price)) { invalidDetails("The entered price is not valid. Please enter a decimal number and try again.", 1); return; }
            if(!int.TryParse(EnterStockAmountTxt.Text, out int stockLevel)) { invalidDetails("The entered stock level is invalid. Please enter a whole number and try again.", 2); return; }
            if(!int.TryParse(EnterRestockLevelTxt.Text, out int restockLevel)) { invalidDetails("The entered restock level is invalid. Please enter a whole number and try again.", 3); return; }
            if(!validCharacteristics(EnterFurtherDetailsTxt.Text, out string trimedCharacteristics)) { invalidDetails("The entered item characteristics are invalid. Please see the outlined formate and try again.", 4); return; }
            if(EnterNameTxt.Text == "") { invalidDetails("You have not entered a name for the new item. Please enter a name and try again.", 5); return; }
            if(EnterMakeTxt.Text == "") { invalidDetails("You have not entered a make for the new item. Please enter a make and then try gain.", 6); return; }
            // Confirming the type of the entered item
            ItemManager.ItemType type;
            switch(SelectTypeCmb.Text)
            {
                case "Clothing":
                    type = ItemManager.ItemType.Clothing;
                    break;
                case "Shoe":
                    type = ItemManager.ItemType.Shoe;
                    break;
                case "Accessory":
                    type = ItemManager.ItemType.Accessory;
                    break;
                default:
                    invalidDetails("You have not selected a type for the new item. Please select a type and try again.", 7);
                    return;
            }
            // Turning the entered characteristics into a dictionary
            Dictionary<string, string[]> characteristics = new Dictionary<string, string[]>();
            string[] characSplit = trimedCharacteristics.Split(".");
            foreach(string charac in characSplit)
            {
                string[] valueSplit = charac.Split(",");
                if (valueSplit[0] == "") { continue; }
                List<string> values = new List<string>();
                for(int i = 0; i < valueSplit.Length; i++)
                {
                    if(i == 0) { continue; }
                    values.Add(valueSplit[i]);
                }
                characteristics.Add(valueSplit[0], values.ToArray());
            }
            // Add new item to the system
            if(!stockSystem.enterNewItem(type, EnterNameTxt.Text, price, stockLevel, restockLevel, id, EnterMakeTxt.Text, characteristics)) { unaccpectedError("An unaaccpected error occured and the item could not be added to the system. Please try again."); return; }
            // Success Message
            MessageBox.Show("The item was added successfully.", "Success!");
            this.Close();
            return;
        }

        #region Reset Text Input Colours

        // Reset the enter price text to black when the box is typed in
        private void EnterPriceTxt_TextChanged(object sender, EventArgs e)
        {
            EnterPriceTxt.ForeColor = Color.Black;
            EnterPriceLbl.ForeColor = Color.Black;
            return;
        }

        // Reset the enter stock level text to black when the box is typed in
        private void EnterStockAmountTxt_TextChanged(object sender, EventArgs e)
        {
            EnterStockAmountTxt.ForeColor = Color.Black;
            EnterStockAmountLbl.ForeColor = Color.Black;
            return;
        }

        // Reset the enter restock level text to black when the box is typed in
        private void EnterRestockLevelTxt_TextChanged(object sender, EventArgs e)
        {
            EnterRestockLevelTxt.ForeColor = Color.Black;
            EnterRestockLevelLbl.ForeColor = Color.Black;
            return;
        }

        // Reset the enter further details text to black when the box is typed in
        private void EnterFurtherDetailsTxt_TextChanged(object sender, EventArgs e)
        {
            EnterFurtherDetailsTxt.ForeColor = Color.Black;
            ItemDetailInstructionsLbl.ForeColor = Color.Black;
            return;
        }

        // Reset the enter name text to black when the box is typed in
        private void EnterNameTxt_TextChanged(object sender, EventArgs e)
        {
            EnterNameTxt.ForeColor = Color.Black;
            EnterNameLbl.ForeColor = Color.Black;
            return;
        }

        // Reset the enter make text to black when the box is typed in
        private void EnterMakeTxt_TextChanged(object sender, EventArgs e)
        {
            EnterMakeTxt.ForeColor = Color.Black;
            EnterMakeLbl.ForeColor = Color.Black;
            return;
        }

        // Reset the select type combo box label text to black when the box has it's selection changed
        private void SelectTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTypeLbl.ForeColor = Color.Black;
            return;
        }

        #endregion

        #region Validation Functions

        // Function to check that valid item characteristics have been entered
        private bool validCharacteristics(string characteristics, out string trimedCharacteristics)
        {
            bool valid = true;
            trimedCharacteristics = Regex.Replace(characteristics, @"\s+", "");
            if (characteristics == "") { return false; }
            string[] characSplit = trimedCharacteristics.Split(".");
            foreach(string charac in characSplit)
            {
                string[] valueSplit = charac.Split(",");
                if(valueSplit.Length <= 1 && valueSplit[0] != "") { valid = false; break; }
            }
            return valid;
        }

        #endregion

        #region Errors

        // Display an invalid details error message
        private void invalidDetails(string message, int code)
        {
            MessageBox.Show(message, "Invalid Item Detail(s)");
            switch(code)
            {
                case 1:
                    EnterPriceTxt.ForeColor = Color.Red;
                    EnterPriceLbl.ForeColor = Color.Red;
                    break;
                case 2:
                    EnterStockAmountTxt.ForeColor = Color.Red;
                    EnterStockAmountLbl.ForeColor = Color.Red;
                    break;
                case 3:
                    EnterRestockLevelTxt.ForeColor = Color.Red;
                    EnterRestockLevelLbl.ForeColor = Color.Red;
                    break;
                case 4:
                    EnterFurtherDetailsTxt.ForeColor = Color.Red;
                    ItemDetailInstructionsLbl.ForeColor = Color.Red;
                    break;
                case 5:
                    EnterNameTxt.ForeColor = Color.Red;
                    EnterNameLbl.ForeColor = Color.Red;
                    break;
                case 6:
                    EnterMakeTxt.ForeColor = Color.Red;
                    EnterMakeLbl.ForeColor = Color.Red;
                    break;
                case 7:
                    SelectTypeLbl.ForeColor = Color.Red;
                    break;
            }
            return;
        }

        // Display an unaccpected error message
        private void unaccpectedError(string message)
        {
            MessageBox.Show(message, "Unaccpected Error");
            return;
        }

        #endregion
    }
}
