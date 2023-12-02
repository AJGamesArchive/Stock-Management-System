namespace Stock_Management_System
{
    partial class AddItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItem));
            this.EnterItemDetailsGrp = new System.Windows.Forms.GroupBox();
            this.EnterMakeTxt = new System.Windows.Forms.TextBox();
            this.EnterMakeLbl = new System.Windows.Forms.Label();
            this.SelectSupplierCmb = new System.Windows.Forms.ComboBox();
            this.SelectTypeCmb = new System.Windows.Forms.ComboBox();
            this.SelectSupplierLbl = new System.Windows.Forms.Label();
            this.SelectTypeLbl = new System.Windows.Forms.Label();
            this.EnterRestockLevelTxt = new System.Windows.Forms.TextBox();
            this.EnterRestockLevelLbl = new System.Windows.Forms.Label();
            this.EnterStockAmountTxt = new System.Windows.Forms.TextBox();
            this.EnterStockAmountLbl = new System.Windows.Forms.Label();
            this.EnterPriceTxt = new System.Windows.Forms.TextBox();
            this.EnterPriceLbl = new System.Windows.Forms.Label();
            this.EnterNameTxt = new System.Windows.Forms.TextBox();
            this.EnterNameLbl = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ItemDetailInstructionsLbl = new System.Windows.Forms.Label();
            this.EnterFurtherItemDetailsGrp = new System.Windows.Forms.GroupBox();
            this.EnterFurtherDetailsTxt = new System.Windows.Forms.TextBox();
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.AddNewItemGrp = new System.Windows.Forms.GroupBox();
            this.EnterItemDetailsGrp.SuspendLayout();
            this.EnterFurtherItemDetailsGrp.SuspendLayout();
            this.AddNewItemGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterItemDetailsGrp
            // 
            this.EnterItemDetailsGrp.Controls.Add(this.EnterMakeTxt);
            this.EnterItemDetailsGrp.Controls.Add(this.EnterMakeLbl);
            this.EnterItemDetailsGrp.Controls.Add(this.SelectSupplierCmb);
            this.EnterItemDetailsGrp.Controls.Add(this.SelectTypeCmb);
            this.EnterItemDetailsGrp.Controls.Add(this.SelectSupplierLbl);
            this.EnterItemDetailsGrp.Controls.Add(this.SelectTypeLbl);
            this.EnterItemDetailsGrp.Controls.Add(this.EnterRestockLevelTxt);
            this.EnterItemDetailsGrp.Controls.Add(this.EnterRestockLevelLbl);
            this.EnterItemDetailsGrp.Controls.Add(this.EnterStockAmountTxt);
            this.EnterItemDetailsGrp.Controls.Add(this.EnterStockAmountLbl);
            this.EnterItemDetailsGrp.Controls.Add(this.EnterPriceTxt);
            this.EnterItemDetailsGrp.Controls.Add(this.EnterPriceLbl);
            this.EnterItemDetailsGrp.Controls.Add(this.EnterNameTxt);
            this.EnterItemDetailsGrp.Controls.Add(this.EnterNameLbl);
            this.EnterItemDetailsGrp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterItemDetailsGrp.Location = new System.Drawing.Point(7, 0);
            this.EnterItemDetailsGrp.Margin = new System.Windows.Forms.Padding(2);
            this.EnterItemDetailsGrp.Name = "EnterItemDetailsGrp";
            this.EnterItemDetailsGrp.Padding = new System.Windows.Forms.Padding(2);
            this.EnterItemDetailsGrp.Size = new System.Drawing.Size(667, 168);
            this.EnterItemDetailsGrp.TabIndex = 0;
            this.EnterItemDetailsGrp.TabStop = false;
            this.EnterItemDetailsGrp.Text = "Enter New Item Details";
            // 
            // EnterMakeTxt
            // 
            this.EnterMakeTxt.Location = new System.Drawing.Point(107, 130);
            this.EnterMakeTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EnterMakeTxt.Name = "EnterMakeTxt";
            this.EnterMakeTxt.PlaceholderText = "Top Hat";
            this.EnterMakeTxt.Size = new System.Drawing.Size(204, 29);
            this.EnterMakeTxt.TabIndex = 13;
            this.EnterMakeTxt.TextChanged += new System.EventHandler(this.EnterMakeTxt_TextChanged);
            // 
            // EnterMakeLbl
            // 
            this.EnterMakeLbl.AutoSize = true;
            this.EnterMakeLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterMakeLbl.Location = new System.Drawing.Point(12, 133);
            this.EnterMakeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterMakeLbl.Name = "EnterMakeLbl";
            this.EnterMakeLbl.Size = new System.Drawing.Size(91, 21);
            this.EnterMakeLbl.TabIndex = 12;
            this.EnterMakeLbl.Text = "Enter Make:";
            // 
            // SelectSupplierCmb
            // 
            this.SelectSupplierCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectSupplierCmb.FormattingEnabled = true;
            this.SelectSupplierCmb.Location = new System.Drawing.Point(447, 31);
            this.SelectSupplierCmb.Margin = new System.Windows.Forms.Padding(2);
            this.SelectSupplierCmb.Name = "SelectSupplierCmb";
            this.SelectSupplierCmb.Size = new System.Drawing.Size(200, 29);
            this.SelectSupplierCmb.TabIndex = 11;
            // 
            // SelectTypeCmb
            // 
            this.SelectTypeCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTypeCmb.FormattingEnabled = true;
            this.SelectTypeCmb.Items.AddRange(new object[] {
            "Clothing",
            "Shoe",
            "Accessory"});
            this.SelectTypeCmb.Location = new System.Drawing.Point(111, 31);
            this.SelectTypeCmb.Margin = new System.Windows.Forms.Padding(2);
            this.SelectTypeCmb.Name = "SelectTypeCmb";
            this.SelectTypeCmb.Size = new System.Drawing.Size(200, 29);
            this.SelectTypeCmb.TabIndex = 10;
            this.SelectTypeCmb.SelectedIndexChanged += new System.EventHandler(this.SelectTypeCmb_SelectedIndexChanged);
            // 
            // SelectSupplierLbl
            // 
            this.SelectSupplierLbl.AutoSize = true;
            this.SelectSupplierLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectSupplierLbl.Location = new System.Drawing.Point(327, 34);
            this.SelectSupplierLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectSupplierLbl.Name = "SelectSupplierLbl";
            this.SelectSupplierLbl.Size = new System.Drawing.Size(116, 21);
            this.SelectSupplierLbl.TabIndex = 9;
            this.SelectSupplierLbl.Text = "Select Supplier:";
            // 
            // SelectTypeLbl
            // 
            this.SelectTypeLbl.AutoSize = true;
            this.SelectTypeLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectTypeLbl.Location = new System.Drawing.Point(17, 34);
            this.SelectTypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectTypeLbl.Name = "SelectTypeLbl";
            this.SelectTypeLbl.Size = new System.Drawing.Size(90, 21);
            this.SelectTypeLbl.TabIndex = 8;
            this.SelectTypeLbl.Text = "Select Type:";
            // 
            // EnterRestockLevelTxt
            // 
            this.EnterRestockLevelTxt.Location = new System.Drawing.Point(499, 97);
            this.EnterRestockLevelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EnterRestockLevelTxt.Name = "EnterRestockLevelTxt";
            this.EnterRestockLevelTxt.PlaceholderText = "10";
            this.EnterRestockLevelTxt.Size = new System.Drawing.Size(148, 29);
            this.EnterRestockLevelTxt.TabIndex = 7;
            this.EnterRestockLevelTxt.TextChanged += new System.EventHandler(this.EnterRestockLevelTxt_TextChanged);
            // 
            // EnterRestockLevelLbl
            // 
            this.EnterRestockLevelLbl.AutoSize = true;
            this.EnterRestockLevelLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterRestockLevelLbl.Location = new System.Drawing.Point(327, 100);
            this.EnterRestockLevelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterRestockLevelLbl.Name = "EnterRestockLevelLbl";
            this.EnterRestockLevelLbl.Size = new System.Drawing.Size(168, 21);
            this.EnterRestockLevelLbl.TabIndex = 6;
            this.EnterRestockLevelLbl.Text = "Set Item Restock Level:";
            // 
            // EnterStockAmountTxt
            // 
            this.EnterStockAmountTxt.Location = new System.Drawing.Point(166, 97);
            this.EnterStockAmountTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EnterStockAmountTxt.Name = "EnterStockAmountTxt";
            this.EnterStockAmountTxt.PlaceholderText = "50";
            this.EnterStockAmountTxt.Size = new System.Drawing.Size(145, 29);
            this.EnterStockAmountTxt.TabIndex = 5;
            this.EnterStockAmountTxt.TextChanged += new System.EventHandler(this.EnterStockAmountTxt_TextChanged);
            // 
            // EnterStockAmountLbl
            // 
            this.EnterStockAmountLbl.AutoSize = true;
            this.EnterStockAmountLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterStockAmountLbl.Location = new System.Drawing.Point(12, 100);
            this.EnterStockAmountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterStockAmountLbl.Name = "EnterStockAmountLbl";
            this.EnterStockAmountLbl.Size = new System.Drawing.Size(150, 21);
            this.EnterStockAmountLbl.TabIndex = 4;
            this.EnterStockAmountLbl.Text = "Enter Stock Amount:";
            // 
            // EnterPriceTxt
            // 
            this.EnterPriceTxt.Location = new System.Drawing.Point(447, 64);
            this.EnterPriceTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EnterPriceTxt.Name = "EnterPriceTxt";
            this.EnterPriceTxt.PlaceholderText = "49.99";
            this.EnterPriceTxt.Size = new System.Drawing.Size(200, 29);
            this.EnterPriceTxt.TabIndex = 3;
            this.EnterPriceTxt.TextChanged += new System.EventHandler(this.EnterPriceTxt_TextChanged);
            // 
            // EnterPriceLbl
            // 
            this.EnterPriceLbl.AutoSize = true;
            this.EnterPriceLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPriceLbl.Location = new System.Drawing.Point(356, 66);
            this.EnterPriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterPriceLbl.Name = "EnterPriceLbl";
            this.EnterPriceLbl.Size = new System.Drawing.Size(87, 21);
            this.EnterPriceLbl.TabIndex = 2;
            this.EnterPriceLbl.Text = "Enter Price:";
            // 
            // EnterNameTxt
            // 
            this.EnterNameTxt.Location = new System.Drawing.Point(111, 64);
            this.EnterNameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.EnterNameTxt.Name = "EnterNameTxt";
            this.EnterNameTxt.PlaceholderText = "Pointy Top Hat";
            this.EnterNameTxt.Size = new System.Drawing.Size(200, 29);
            this.EnterNameTxt.TabIndex = 1;
            this.EnterNameTxt.TextChanged += new System.EventHandler(this.EnterNameTxt_TextChanged);
            // 
            // EnterNameLbl
            // 
            this.EnterNameLbl.AutoSize = true;
            this.EnterNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterNameLbl.Location = new System.Drawing.Point(12, 67);
            this.EnterNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterNameLbl.Name = "EnterNameLbl";
            this.EnterNameLbl.Size = new System.Drawing.Size(95, 21);
            this.EnterNameLbl.TabIndex = 0;
            this.EnterNameLbl.Text = "Enter Name:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.Location = new System.Drawing.Point(327, 28);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(88, 30);
            this.CancelBtn.TabIndex = 12;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ItemDetailInstructionsLbl
            // 
            this.ItemDetailInstructionsLbl.AutoSize = true;
            this.ItemDetailInstructionsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ItemDetailInstructionsLbl.Location = new System.Drawing.Point(6, 29);
            this.ItemDetailInstructionsLbl.MaximumSize = new System.Drawing.Size(660, 0);
            this.ItemDetailInstructionsLbl.Name = "ItemDetailInstructionsLbl";
            this.ItemDetailInstructionsLbl.Size = new System.Drawing.Size(657, 63);
            this.ItemDetailInstructionsLbl.TabIndex = 13;
            this.ItemDetailInstructionsLbl.Text = resources.GetString("ItemDetailInstructionsLbl.Text");
            // 
            // EnterFurtherItemDetailsGrp
            // 
            this.EnterFurtherItemDetailsGrp.Controls.Add(this.EnterFurtherDetailsTxt);
            this.EnterFurtherItemDetailsGrp.Controls.Add(this.ItemDetailInstructionsLbl);
            this.EnterFurtherItemDetailsGrp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterFurtherItemDetailsGrp.Location = new System.Drawing.Point(7, 169);
            this.EnterFurtherItemDetailsGrp.Name = "EnterFurtherItemDetailsGrp";
            this.EnterFurtherItemDetailsGrp.Size = new System.Drawing.Size(667, 257);
            this.EnterFurtherItemDetailsGrp.TabIndex = 14;
            this.EnterFurtherItemDetailsGrp.TabStop = false;
            this.EnterFurtherItemDetailsGrp.Text = "Enter Further Item Details / Charactoristics";
            // 
            // EnterFurtherDetailsTxt
            // 
            this.EnterFurtherDetailsTxt.Location = new System.Drawing.Point(5, 102);
            this.EnterFurtherDetailsTxt.Multiline = true;
            this.EnterFurtherDetailsTxt.Name = "EnterFurtherDetailsTxt";
            this.EnterFurtherDetailsTxt.PlaceholderText = "Size, 20, 22, 24, 26. Colour, Green, Blue, Red, Yellow.";
            this.EnterFurtherDetailsTxt.Size = new System.Drawing.Size(656, 149);
            this.EnterFurtherDetailsTxt.TabIndex = 14;
            this.EnterFurtherDetailsTxt.TextChanged += new System.EventHandler(this.EnterFurtherDetailsTxt_TextChanged);
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddItemBtn.Location = new System.Drawing.Point(223, 28);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(88, 30);
            this.AddItemBtn.TabIndex = 15;
            this.AddItemBtn.Text = "Add Item";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // AddNewItemGrp
            // 
            this.AddNewItemGrp.Controls.Add(this.CancelBtn);
            this.AddNewItemGrp.Controls.Add(this.AddItemBtn);
            this.AddNewItemGrp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewItemGrp.Location = new System.Drawing.Point(7, 426);
            this.AddNewItemGrp.Name = "AddNewItemGrp";
            this.AddNewItemGrp.Size = new System.Drawing.Size(667, 76);
            this.AddNewItemGrp.TabIndex = 16;
            this.AddNewItemGrp.TabStop = false;
            this.AddNewItemGrp.Text = "Add Item?";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 506);
            this.Controls.Add(this.AddNewItemGrp);
            this.Controls.Add(this.EnterFurtherItemDetailsGrp);
            this.Controls.Add(this.EnterItemDetailsGrp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.EnterItemDetailsGrp.ResumeLayout(false);
            this.EnterItemDetailsGrp.PerformLayout();
            this.EnterFurtherItemDetailsGrp.ResumeLayout(false);
            this.EnterFurtherItemDetailsGrp.PerformLayout();
            this.AddNewItemGrp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox EnterItemDetailsGrp;
        private TextBox EnterNameTxt;
        private Label EnterNameLbl;
        private TextBox EnterRestockLevelTxt;
        private Label EnterRestockLevelLbl;
        private TextBox EnterStockAmountTxt;
        private Label EnterStockAmountLbl;
        private TextBox EnterPriceTxt;
        private Label EnterPriceLbl;
        private ComboBox SelectSupplierCmb;
        private ComboBox SelectTypeCmb;
        private Label SelectSupplierLbl;
        private Label SelectTypeLbl;
        private Button CancelBtn;
        private Label ItemDetailInstructionsLbl;
        private GroupBox EnterFurtherItemDetailsGrp;
        private TextBox EnterFurtherDetailsTxt;
        private Button AddItemBtn;
        private GroupBox AddNewItemGrp;
        private TextBox EnterMakeTxt;
        private Label EnterMakeLbl;
    }
}