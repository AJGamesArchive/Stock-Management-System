namespace Stock_Management_System
{
    partial class MainSystem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavSystemMain = new System.Windows.Forms.TabControl();
            this.TabLogin = new System.Windows.Forms.TabPage();
            this.NewAccountBtn = new System.Windows.Forms.Button();
            this.ForgotPasswordBtn = new System.Windows.Forms.Button();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginPasswordEntryTxt = new System.Windows.Forms.TextBox();
            this.LoginEmailEntryTxt = new System.Windows.Forms.TextBox();
            this.LoginPasswordEntryLbl = new System.Windows.Forms.Label();
            this.LoginEmailEntryLbl = new System.Windows.Forms.Label();
            this.SystemLoginLbl = new System.Windows.Forms.Label();
            this.TabAccCreate = new System.Windows.Forms.TabPage();
            this.TabShop = new System.Windows.Forms.TabPage();
            this.TabAdmin = new System.Windows.Forms.TabPage();
            this.TabAccDetails = new System.Windows.Forms.TabPage();
            this.NavSystemMain.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavSystemMain
            // 
            this.NavSystemMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.NavSystemMain.Controls.Add(this.TabLogin);
            this.NavSystemMain.Controls.Add(this.TabAccCreate);
            this.NavSystemMain.Controls.Add(this.TabShop);
            this.NavSystemMain.Controls.Add(this.TabAdmin);
            this.NavSystemMain.Controls.Add(this.TabAccDetails);
            this.NavSystemMain.ItemSize = new System.Drawing.Size(0, 1);
            this.NavSystemMain.Location = new System.Drawing.Point(12, 12);
            this.NavSystemMain.Name = "NavSystemMain";
            this.NavSystemMain.SelectedIndex = 0;
            this.NavSystemMain.Size = new System.Drawing.Size(1130, 739);
            this.NavSystemMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.NavSystemMain.TabIndex = 0;
            // 
            // TabLogin
            // 
            this.TabLogin.Controls.Add(this.NewAccountBtn);
            this.TabLogin.Controls.Add(this.ForgotPasswordBtn);
            this.TabLogin.Controls.Add(this.LoginBtn);
            this.TabLogin.Controls.Add(this.LoginPasswordEntryTxt);
            this.TabLogin.Controls.Add(this.LoginEmailEntryTxt);
            this.TabLogin.Controls.Add(this.LoginPasswordEntryLbl);
            this.TabLogin.Controls.Add(this.LoginEmailEntryLbl);
            this.TabLogin.Controls.Add(this.SystemLoginLbl);
            this.TabLogin.Location = new System.Drawing.Point(4, 5);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TabLogin.Size = new System.Drawing.Size(1122, 730);
            this.TabLogin.TabIndex = 0;
            this.TabLogin.Text = "LoginTab";
            this.TabLogin.UseVisualStyleBackColor = true;
            // 
            // NewAccountBtn
            // 
            this.NewAccountBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewAccountBtn.Location = new System.Drawing.Point(736, 530);
            this.NewAccountBtn.Name = "NewAccountBtn";
            this.NewAccountBtn.Size = new System.Drawing.Size(257, 62);
            this.NewAccountBtn.TabIndex = 7;
            this.NewAccountBtn.Text = "New Customer";
            this.NewAccountBtn.UseVisualStyleBackColor = true;
            this.NewAccountBtn.Click += new System.EventHandler(this.NewAccountBtn_Click);
            // 
            // ForgotPasswordBtn
            // 
            this.ForgotPasswordBtn.Enabled = false;
            this.ForgotPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForgotPasswordBtn.Location = new System.Drawing.Point(397, 530);
            this.ForgotPasswordBtn.Name = "ForgotPasswordBtn";
            this.ForgotPasswordBtn.Size = new System.Drawing.Size(319, 62);
            this.ForgotPasswordBtn.TabIndex = 6;
            this.ForgotPasswordBtn.Text = "Forgotton Password";
            this.ForgotPasswordBtn.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(119, 530);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(257, 62);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // LoginPasswordEntryTxt
            // 
            this.LoginPasswordEntryTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginPasswordEntryTxt.Location = new System.Drawing.Point(406, 356);
            this.LoginPasswordEntryTxt.Name = "LoginPasswordEntryTxt";
            this.LoginPasswordEntryTxt.Size = new System.Drawing.Size(421, 50);
            this.LoginPasswordEntryTxt.TabIndex = 4;
            // 
            // LoginEmailEntryTxt
            // 
            this.LoginEmailEntryTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginEmailEntryTxt.Location = new System.Drawing.Point(406, 262);
            this.LoginEmailEntryTxt.Name = "LoginEmailEntryTxt";
            this.LoginEmailEntryTxt.Size = new System.Drawing.Size(421, 50);
            this.LoginEmailEntryTxt.TabIndex = 3;
            // 
            // LoginPasswordEntryLbl
            // 
            this.LoginPasswordEntryLbl.AutoSize = true;
            this.LoginPasswordEntryLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginPasswordEntryLbl.Location = new System.Drawing.Point(233, 359);
            this.LoginPasswordEntryLbl.Name = "LoginPasswordEntryLbl";
            this.LoginPasswordEntryLbl.Size = new System.Drawing.Size(160, 45);
            this.LoginPasswordEntryLbl.TabIndex = 2;
            this.LoginPasswordEntryLbl.Text = "Password:";
            // 
            // LoginEmailEntryLbl
            // 
            this.LoginEmailEntryLbl.AutoSize = true;
            this.LoginEmailEntryLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginEmailEntryLbl.Location = new System.Drawing.Point(290, 262);
            this.LoginEmailEntryLbl.Name = "LoginEmailEntryLbl";
            this.LoginEmailEntryLbl.Size = new System.Drawing.Size(103, 45);
            this.LoginEmailEntryLbl.TabIndex = 1;
            this.LoginEmailEntryLbl.Text = "Email:";
            // 
            // SystemLoginLbl
            // 
            this.SystemLoginLbl.AutoSize = true;
            this.SystemLoginLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SystemLoginLbl.Location = new System.Drawing.Point(406, 101);
            this.SystemLoginLbl.Name = "SystemLoginLbl";
            this.SystemLoginLbl.Size = new System.Drawing.Size(274, 54);
            this.SystemLoginLbl.TabIndex = 0;
            this.SystemLoginLbl.Text = "System Login";
            // 
            // TabAccCreate
            // 
            this.TabAccCreate.Location = new System.Drawing.Point(4, 5);
            this.TabAccCreate.Name = "TabAccCreate";
            this.TabAccCreate.Padding = new System.Windows.Forms.Padding(3);
            this.TabAccCreate.Size = new System.Drawing.Size(1122, 730);
            this.TabAccCreate.TabIndex = 1;
            this.TabAccCreate.Text = "CreateAccountTab";
            this.TabAccCreate.UseVisualStyleBackColor = true;
            // 
            // TabShop
            // 
            this.TabShop.Location = new System.Drawing.Point(4, 5);
            this.TabShop.Name = "TabShop";
            this.TabShop.Size = new System.Drawing.Size(1122, 730);
            this.TabShop.TabIndex = 2;
            this.TabShop.Text = "ShopTab";
            this.TabShop.UseVisualStyleBackColor = true;
            // 
            // TabAdmin
            // 
            this.TabAdmin.Location = new System.Drawing.Point(4, 5);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.Size = new System.Drawing.Size(1122, 730);
            this.TabAdmin.TabIndex = 3;
            this.TabAdmin.Text = "AdminTab";
            this.TabAdmin.UseVisualStyleBackColor = true;
            // 
            // TabAccDetails
            // 
            this.TabAccDetails.Location = new System.Drawing.Point(4, 5);
            this.TabAccDetails.Name = "TabAccDetails";
            this.TabAccDetails.Size = new System.Drawing.Size(1122, 730);
            this.TabAccDetails.TabIndex = 4;
            this.TabAccDetails.Text = "AccountDetailsTab";
            this.TabAccDetails.UseVisualStyleBackColor = true;
            // 
            // MainSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 758);
            this.Controls.Add(this.NavSystemMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainSystem";
            this.Text = "Sarre Running Sports";
            this.NavSystemMain.ResumeLayout(false);
            this.TabLogin.ResumeLayout(false);
            this.TabLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl NavSystemMain;
        private TabPage TabLogin;
        private TabPage TabAccCreate;
        private TabPage TabShop;
        private TabPage TabAdmin;
        private TabPage TabAccDetails;
        private Button NewAccountBtn;
        private Button ForgotPasswordBtn;
        private Button LoginBtn;
        private TextBox LoginPasswordEntryTxt;
        private TextBox LoginEmailEntryTxt;
        private Label LoginPasswordEntryLbl;
        private Label LoginEmailEntryLbl;
        private Label SystemLoginLbl;
    }
}