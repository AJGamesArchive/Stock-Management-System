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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSystem));
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
            this.CreateAccountHeaderLbl = new System.Windows.Forms.Label();
            this.EnterUsernameLbl = new System.Windows.Forms.Label();
            this.EnterEmailLbl = new System.Windows.Forms.Label();
            this.EnterPasswordLbl = new System.Windows.Forms.Label();
            this.EnterAccountRankLbl = new System.Windows.Forms.Label();
            this.EnterGDPRLbl = new System.Windows.Forms.Label();
            this.EnterUsernameTxt = new System.Windows.Forms.TextBox();
            this.EnterEmailTxt = new System.Windows.Forms.TextBox();
            this.EnterPasswordTxt = new System.Windows.Forms.TextBox();
            this.EnterPaswordConfirmLbl = new System.Windows.Forms.Label();
            this.EnterPasswordConfirmTxt = new System.Windows.Forms.TextBox();
            this.EnterAccountRankCmb = new System.Windows.Forms.ComboBox();
            this.EnterGDPRInfoLbl = new System.Windows.Forms.Label();
            this.CreateAccDetailsGrp = new System.Windows.Forms.GroupBox();
            this.CreateAccGDPRGrp = new System.Windows.Forms.GroupBox();
            this.GDPRConcentRdbtn = new System.Windows.Forms.RadioButton();
            this.GDPRNoConcentRdbtn = new System.Windows.Forms.RadioButton();
            this.CreateAccControlsGrp = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NavSystemMain.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.TabAccCreate.SuspendLayout();
            this.CreateAccGDPRGrp.SuspendLayout();
            this.CreateAccControlsGrp.SuspendLayout();
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
            this.NavSystemMain.Size = new System.Drawing.Size(1492, 972);
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
            this.TabAccCreate.Controls.Add(this.CreateAccControlsGrp);
            this.TabAccCreate.Controls.Add(this.EnterAccountRankCmb);
            this.TabAccCreate.Controls.Add(this.EnterPasswordConfirmTxt);
            this.TabAccCreate.Controls.Add(this.EnterPasswordTxt);
            this.TabAccCreate.Controls.Add(this.EnterEmailTxt);
            this.TabAccCreate.Controls.Add(this.EnterUsernameTxt);
            this.TabAccCreate.Controls.Add(this.EnterPaswordConfirmLbl);
            this.TabAccCreate.Controls.Add(this.EnterAccountRankLbl);
            this.TabAccCreate.Controls.Add(this.EnterPasswordLbl);
            this.TabAccCreate.Controls.Add(this.EnterEmailLbl);
            this.TabAccCreate.Controls.Add(this.EnterUsernameLbl);
            this.TabAccCreate.Controls.Add(this.CreateAccountHeaderLbl);
            this.TabAccCreate.Controls.Add(this.CreateAccDetailsGrp);
            this.TabAccCreate.Controls.Add(this.CreateAccGDPRGrp);
            this.TabAccCreate.Location = new System.Drawing.Point(4, 5);
            this.TabAccCreate.Name = "TabAccCreate";
            this.TabAccCreate.Padding = new System.Windows.Forms.Padding(3);
            this.TabAccCreate.Size = new System.Drawing.Size(1484, 963);
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
            // CreateAccountHeaderLbl
            // 
            this.CreateAccountHeaderLbl.AutoSize = true;
            this.CreateAccountHeaderLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccountHeaderLbl.Location = new System.Drawing.Point(556, 53);
            this.CreateAccountHeaderLbl.Name = "CreateAccountHeaderLbl";
            this.CreateAccountHeaderLbl.Size = new System.Drawing.Size(368, 54);
            this.CreateAccountHeaderLbl.TabIndex = 0;
            this.CreateAccountHeaderLbl.Text = "Create an Account";
            // 
            // EnterUsernameLbl
            // 
            this.EnterUsernameLbl.AutoSize = true;
            this.EnterUsernameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterUsernameLbl.Location = new System.Drawing.Point(77, 195);
            this.EnterUsernameLbl.Name = "EnterUsernameLbl";
            this.EnterUsernameLbl.Size = new System.Drawing.Size(170, 45);
            this.EnterUsernameLbl.TabIndex = 1;
            this.EnterUsernameLbl.Text = "Username:";
            // 
            // EnterEmailLbl
            // 
            this.EnterEmailLbl.AutoSize = true;
            this.EnterEmailLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterEmailLbl.Location = new System.Drawing.Point(144, 254);
            this.EnterEmailLbl.Name = "EnterEmailLbl";
            this.EnterEmailLbl.Size = new System.Drawing.Size(103, 45);
            this.EnterEmailLbl.TabIndex = 1;
            this.EnterEmailLbl.Text = "Email:";
            // 
            // EnterPasswordLbl
            // 
            this.EnterPasswordLbl.AutoSize = true;
            this.EnterPasswordLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordLbl.Location = new System.Drawing.Point(829, 195);
            this.EnterPasswordLbl.Name = "EnterPasswordLbl";
            this.EnterPasswordLbl.Size = new System.Drawing.Size(160, 45);
            this.EnterPasswordLbl.TabIndex = 1;
            this.EnterPasswordLbl.Text = "Password:";
            // 
            // EnterAccountRankLbl
            // 
            this.EnterAccountRankLbl.AutoSize = true;
            this.EnterAccountRankLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterAccountRankLbl.Location = new System.Drawing.Point(25, 320);
            this.EnterAccountRankLbl.Name = "EnterAccountRankLbl";
            this.EnterAccountRankLbl.Size = new System.Drawing.Size(222, 45);
            this.EnterAccountRankLbl.TabIndex = 1;
            this.EnterAccountRankLbl.Text = "Account Rank:";
            // 
            // EnterGDPRLbl
            // 
            this.EnterGDPRLbl.AutoSize = true;
            this.EnterGDPRLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterGDPRLbl.Location = new System.Drawing.Point(17, 56);
            this.EnterGDPRLbl.Name = "EnterGDPRLbl";
            this.EnterGDPRLbl.Size = new System.Drawing.Size(97, 45);
            this.EnterGDPRLbl.TabIndex = 1;
            this.EnterGDPRLbl.Text = "T/C\'s:";
            // 
            // EnterUsernameTxt
            // 
            this.EnterUsernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterUsernameTxt.Location = new System.Drawing.Point(253, 194);
            this.EnterUsernameTxt.Name = "EnterUsernameTxt";
            this.EnterUsernameTxt.Size = new System.Drawing.Size(443, 50);
            this.EnterUsernameTxt.TabIndex = 2;
            // 
            // EnterEmailTxt
            // 
            this.EnterEmailTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterEmailTxt.Location = new System.Drawing.Point(253, 254);
            this.EnterEmailTxt.Name = "EnterEmailTxt";
            this.EnterEmailTxt.Size = new System.Drawing.Size(443, 50);
            this.EnterEmailTxt.TabIndex = 2;
            // 
            // EnterPasswordTxt
            // 
            this.EnterPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordTxt.Location = new System.Drawing.Point(995, 195);
            this.EnterPasswordTxt.Name = "EnterPasswordTxt";
            this.EnterPasswordTxt.Size = new System.Drawing.Size(443, 50);
            this.EnterPasswordTxt.TabIndex = 2;
            // 
            // EnterPaswordConfirmLbl
            // 
            this.EnterPaswordConfirmLbl.AutoSize = true;
            this.EnterPaswordConfirmLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPaswordConfirmLbl.Location = new System.Drawing.Point(706, 257);
            this.EnterPaswordConfirmLbl.Name = "EnterPaswordConfirmLbl";
            this.EnterPaswordConfirmLbl.Size = new System.Drawing.Size(283, 45);
            this.EnterPaswordConfirmLbl.TabIndex = 1;
            this.EnterPaswordConfirmLbl.Text = "Confirm Password:";
            // 
            // EnterPasswordConfirmTxt
            // 
            this.EnterPasswordConfirmTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordConfirmTxt.Location = new System.Drawing.Point(995, 257);
            this.EnterPasswordConfirmTxt.Name = "EnterPasswordConfirmTxt";
            this.EnterPasswordConfirmTxt.Size = new System.Drawing.Size(443, 50);
            this.EnterPasswordConfirmTxt.TabIndex = 2;
            // 
            // EnterAccountRankCmb
            // 
            this.EnterAccountRankCmb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterAccountRankCmb.FormattingEnabled = true;
            this.EnterAccountRankCmb.Location = new System.Drawing.Point(253, 317);
            this.EnterAccountRankCmb.Name = "EnterAccountRankCmb";
            this.EnterAccountRankCmb.Size = new System.Drawing.Size(443, 53);
            this.EnterAccountRankCmb.TabIndex = 3;
            // 
            // EnterGDPRInfoLbl
            // 
            this.EnterGDPRInfoLbl.AutoSize = true;
            this.EnterGDPRInfoLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EnterGDPRInfoLbl.Location = new System.Drawing.Point(107, 56);
            this.EnterGDPRInfoLbl.MaximumSize = new System.Drawing.Size(1350, 0);
            this.EnterGDPRInfoLbl.Name = "EnterGDPRInfoLbl";
            this.EnterGDPRInfoLbl.Size = new System.Drawing.Size(1269, 135);
            this.EnterGDPRInfoLbl.TabIndex = 4;
            this.EnterGDPRInfoLbl.Text = resources.GetString("EnterGDPRInfoLbl.Text");
            // 
            // CreateAccDetailsGrp
            // 
            this.CreateAccDetailsGrp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccDetailsGrp.Location = new System.Drawing.Point(20, 3);
            this.CreateAccDetailsGrp.Name = "CreateAccDetailsGrp";
            this.CreateAccDetailsGrp.Size = new System.Drawing.Size(1441, 407);
            this.CreateAccDetailsGrp.TabIndex = 5;
            this.CreateAccDetailsGrp.TabStop = false;
            this.CreateAccDetailsGrp.Text = "Account Details";
            // 
            // CreateAccGDPRGrp
            // 
            this.CreateAccGDPRGrp.Controls.Add(this.GDPRNoConcentRdbtn);
            this.CreateAccGDPRGrp.Controls.Add(this.GDPRConcentRdbtn);
            this.CreateAccGDPRGrp.Controls.Add(this.EnterGDPRInfoLbl);
            this.CreateAccGDPRGrp.Controls.Add(this.EnterGDPRLbl);
            this.CreateAccGDPRGrp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccGDPRGrp.Location = new System.Drawing.Point(20, 427);
            this.CreateAccGDPRGrp.Name = "CreateAccGDPRGrp";
            this.CreateAccGDPRGrp.Size = new System.Drawing.Size(1441, 287);
            this.CreateAccGDPRGrp.TabIndex = 6;
            this.CreateAccGDPRGrp.TabStop = false;
            this.CreateAccGDPRGrp.Text = "Data Protection Agreement";
            // 
            // GDPRConcentRdbtn
            // 
            this.GDPRConcentRdbtn.AutoSize = true;
            this.GDPRConcentRdbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GDPRConcentRdbtn.Location = new System.Drawing.Point(421, 215);
            this.GDPRConcentRdbtn.Name = "GDPRConcentRdbtn";
            this.GDPRConcentRdbtn.Size = new System.Drawing.Size(192, 49);
            this.GDPRConcentRdbtn.TabIndex = 5;
            this.GDPRConcentRdbtn.TabStop = true;
            this.GDPRConcentRdbtn.Text = "I Concent";
            this.GDPRConcentRdbtn.UseVisualStyleBackColor = true;
            // 
            // GDPRNoConcentRdbtn
            // 
            this.GDPRNoConcentRdbtn.AutoSize = true;
            this.GDPRNoConcentRdbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GDPRNoConcentRdbtn.Location = new System.Drawing.Point(719, 215);
            this.GDPRNoConcentRdbtn.Name = "GDPRNoConcentRdbtn";
            this.GDPRNoConcentRdbtn.Size = new System.Drawing.Size(311, 49);
            this.GDPRNoConcentRdbtn.TabIndex = 5;
            this.GDPRNoConcentRdbtn.TabStop = true;
            this.GDPRNoConcentRdbtn.Text = "I Do Not Concent";
            this.GDPRNoConcentRdbtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccControlsGrp
            // 
            this.CreateAccControlsGrp.Controls.Add(this.button2);
            this.CreateAccControlsGrp.Controls.Add(this.button1);
            this.CreateAccControlsGrp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccControlsGrp.Location = new System.Drawing.Point(20, 733);
            this.CreateAccControlsGrp.Name = "CreateAccControlsGrp";
            this.CreateAccControlsGrp.Size = new System.Drawing.Size(1441, 213);
            this.CreateAccControlsGrp.TabIndex = 7;
            this.CreateAccControlsGrp.TabStop = false;
            this.CreateAccControlsGrp.Text = "Controlls";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(456, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back To Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(718, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 65);
            this.button2.TabIndex = 0;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 996);
            this.Controls.Add(this.NavSystemMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainSystem";
            this.Text = "Sarre Running Sports";
            this.NavSystemMain.ResumeLayout(false);
            this.TabLogin.ResumeLayout(false);
            this.TabLogin.PerformLayout();
            this.TabAccCreate.ResumeLayout(false);
            this.TabAccCreate.PerformLayout();
            this.CreateAccGDPRGrp.ResumeLayout(false);
            this.CreateAccGDPRGrp.PerformLayout();
            this.CreateAccControlsGrp.ResumeLayout(false);
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
        private Label EnterUsernameLbl;
        private Label CreateAccountHeaderLbl;
        private Label EnterGDPRLbl;
        private Label EnterAccountRankLbl;
        private Label EnterPasswordLbl;
        private Label EnterEmailLbl;
        private TextBox EnterPasswordTxt;
        private TextBox EnterEmailTxt;
        private TextBox EnterUsernameTxt;
        private TextBox EnterPasswordConfirmTxt;
        private Label EnterPaswordConfirmLbl;
        private ComboBox EnterAccountRankCmb;
        private Label EnterGDPRInfoLbl;
        private GroupBox CreateAccDetailsGrp;
        private GroupBox CreateAccGDPRGrp;
        private RadioButton GDPRNoConcentRdbtn;
        private RadioButton GDPRConcentRdbtn;
        private GroupBox CreateAccControlsGrp;
        private Button button2;
        private Button button1;
    }
}