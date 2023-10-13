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
            this.LoginNameEntryTxt = new System.Windows.Forms.TextBox();
            this.LoginPasswordEntryLbl = new System.Windows.Forms.Label();
            this.LoginNameEntryLbl = new System.Windows.Forms.Label();
            this.SystemLoginLbl = new System.Windows.Forms.Label();
            this.TabAccCreate = new System.Windows.Forms.TabPage();
            this.CreateAccControlsGrp = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EnterAccountRankCmb = new System.Windows.Forms.ComboBox();
            this.EnterPasswordConfirmTxt = new System.Windows.Forms.TextBox();
            this.EnterPasswordTxt = new System.Windows.Forms.TextBox();
            this.EnterUsernameTxt = new System.Windows.Forms.TextBox();
            this.EnterPaswordConfirmLbl = new System.Windows.Forms.Label();
            this.EnterAccountRankLbl = new System.Windows.Forms.Label();
            this.EnterPasswordLbl = new System.Windows.Forms.Label();
            this.EnterNameLbl = new System.Windows.Forms.Label();
            this.CreateAccountHeaderLbl = new System.Windows.Forms.Label();
            this.CreateAccDetailsGrp = new System.Windows.Forms.GroupBox();
            this.CreateAccGDPRGrp = new System.Windows.Forms.GroupBox();
            this.GDPRNoConcentRdbtn = new System.Windows.Forms.RadioButton();
            this.GDPRConcentRdbtn = new System.Windows.Forms.RadioButton();
            this.EnterGDPRInfoLbl = new System.Windows.Forms.Label();
            this.EnterGDPRLbl = new System.Windows.Forms.Label();
            this.TabShop = new System.Windows.Forms.TabPage();
            this.TabAdmin = new System.Windows.Forms.TabPage();
            this.TabAccDetails = new System.Windows.Forms.TabPage();
            this.NavSystemMain.SuspendLayout();
            this.TabLogin.SuspendLayout();
            this.TabAccCreate.SuspendLayout();
            this.CreateAccControlsGrp.SuspendLayout();
            this.CreateAccDetailsGrp.SuspendLayout();
            this.CreateAccGDPRGrp.SuspendLayout();
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
            this.NavSystemMain.Location = new System.Drawing.Point(6, 6);
            this.NavSystemMain.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NavSystemMain.Name = "NavSystemMain";
            this.NavSystemMain.SelectedIndex = 0;
            this.NavSystemMain.Size = new System.Drawing.Size(803, 456);
            this.NavSystemMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.NavSystemMain.TabIndex = 0;
            // 
            // TabLogin
            // 
            this.TabLogin.Controls.Add(this.NewAccountBtn);
            this.TabLogin.Controls.Add(this.ForgotPasswordBtn);
            this.TabLogin.Controls.Add(this.LoginBtn);
            this.TabLogin.Controls.Add(this.LoginPasswordEntryTxt);
            this.TabLogin.Controls.Add(this.LoginNameEntryTxt);
            this.TabLogin.Controls.Add(this.LoginPasswordEntryLbl);
            this.TabLogin.Controls.Add(this.LoginNameEntryLbl);
            this.TabLogin.Controls.Add(this.SystemLoginLbl);
            this.TabLogin.Location = new System.Drawing.Point(4, 5);
            this.TabLogin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabLogin.Name = "TabLogin";
            this.TabLogin.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabLogin.Size = new System.Drawing.Size(795, 447);
            this.TabLogin.TabIndex = 0;
            this.TabLogin.Text = "LoginTab";
            this.TabLogin.UseVisualStyleBackColor = true;
            // 
            // NewAccountBtn
            // 
            this.NewAccountBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewAccountBtn.Location = new System.Drawing.Point(493, 287);
            this.NewAccountBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.NewAccountBtn.Name = "NewAccountBtn";
            this.NewAccountBtn.Size = new System.Drawing.Size(138, 29);
            this.NewAccountBtn.TabIndex = 7;
            this.NewAccountBtn.Text = "New Account";
            this.NewAccountBtn.UseVisualStyleBackColor = true;
            this.NewAccountBtn.Click += new System.EventHandler(this.NewAccountBtn_Click);
            // 
            // ForgotPasswordBtn
            // 
            this.ForgotPasswordBtn.Enabled = false;
            this.ForgotPasswordBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForgotPasswordBtn.Location = new System.Drawing.Point(311, 287);
            this.ForgotPasswordBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.ForgotPasswordBtn.Name = "ForgotPasswordBtn";
            this.ForgotPasswordBtn.Size = new System.Drawing.Size(172, 29);
            this.ForgotPasswordBtn.TabIndex = 6;
            this.ForgotPasswordBtn.Text = "Forgotton Password";
            this.ForgotPasswordBtn.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(161, 287);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(138, 29);
            this.LoginBtn.TabIndex = 5;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // LoginPasswordEntryTxt
            // 
            this.LoginPasswordEntryTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginPasswordEntryTxt.Location = new System.Drawing.Point(322, 203);
            this.LoginPasswordEntryTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LoginPasswordEntryTxt.Name = "LoginPasswordEntryTxt";
            this.LoginPasswordEntryTxt.Size = new System.Drawing.Size(229, 29);
            this.LoginPasswordEntryTxt.TabIndex = 4;
            // 
            // LoginNameEntryTxt
            // 
            this.LoginNameEntryTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginNameEntryTxt.Location = new System.Drawing.Point(322, 159);
            this.LoginNameEntryTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LoginNameEntryTxt.Name = "LoginNameEntryTxt";
            this.LoginNameEntryTxt.Size = new System.Drawing.Size(229, 29);
            this.LoginNameEntryTxt.TabIndex = 3;
            // 
            // LoginPasswordEntryLbl
            // 
            this.LoginPasswordEntryLbl.AutoSize = true;
            this.LoginPasswordEntryLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginPasswordEntryLbl.Location = new System.Drawing.Point(238, 207);
            this.LoginPasswordEntryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginPasswordEntryLbl.Name = "LoginPasswordEntryLbl";
            this.LoginPasswordEntryLbl.Size = new System.Drawing.Size(79, 21);
            this.LoginPasswordEntryLbl.TabIndex = 2;
            this.LoginPasswordEntryLbl.Text = "Password:";
            // 
            // LoginNameEntryLbl
            // 
            this.LoginNameEntryLbl.AutoSize = true;
            this.LoginNameEntryLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginNameEntryLbl.Location = new System.Drawing.Point(263, 162);
            this.LoginNameEntryLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginNameEntryLbl.Name = "LoginNameEntryLbl";
            this.LoginNameEntryLbl.Size = new System.Drawing.Size(55, 21);
            this.LoginNameEntryLbl.TabIndex = 1;
            this.LoginNameEntryLbl.Text = "Name:";
            // 
            // SystemLoginLbl
            // 
            this.SystemLoginLbl.AutoSize = true;
            this.SystemLoginLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SystemLoginLbl.Location = new System.Drawing.Point(330, 79);
            this.SystemLoginLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SystemLoginLbl.Name = "SystemLoginLbl";
            this.SystemLoginLbl.Size = new System.Drawing.Size(138, 28);
            this.SystemLoginLbl.TabIndex = 0;
            this.SystemLoginLbl.Text = "System Login";
            // 
            // TabAccCreate
            // 
            this.TabAccCreate.Controls.Add(this.CreateAccControlsGrp);
            this.TabAccCreate.Controls.Add(this.EnterAccountRankCmb);
            this.TabAccCreate.Controls.Add(this.EnterPasswordConfirmTxt);
            this.TabAccCreate.Controls.Add(this.EnterUsernameTxt);
            this.TabAccCreate.Controls.Add(this.EnterPaswordConfirmLbl);
            this.TabAccCreate.Controls.Add(this.EnterAccountRankLbl);
            this.TabAccCreate.Controls.Add(this.EnterPasswordLbl);
            this.TabAccCreate.Controls.Add(this.EnterNameLbl);
            this.TabAccCreate.Controls.Add(this.CreateAccountHeaderLbl);
            this.TabAccCreate.Controls.Add(this.CreateAccGDPRGrp);
            this.TabAccCreate.Controls.Add(this.CreateAccDetailsGrp);
            this.TabAccCreate.Location = new System.Drawing.Point(4, 5);
            this.TabAccCreate.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabAccCreate.Name = "TabAccCreate";
            this.TabAccCreate.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabAccCreate.Size = new System.Drawing.Size(795, 447);
            this.TabAccCreate.TabIndex = 1;
            this.TabAccCreate.Text = "CreateAccountTab";
            this.TabAccCreate.UseVisualStyleBackColor = true;
            // 
            // CreateAccControlsGrp
            // 
            this.CreateAccControlsGrp.Controls.Add(this.button2);
            this.CreateAccControlsGrp.Controls.Add(this.button1);
            this.CreateAccControlsGrp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccControlsGrp.Location = new System.Drawing.Point(11, 344);
            this.CreateAccControlsGrp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CreateAccControlsGrp.Name = "CreateAccControlsGrp";
            this.CreateAccControlsGrp.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CreateAccControlsGrp.Size = new System.Drawing.Size(776, 100);
            this.CreateAccControlsGrp.TabIndex = 7;
            this.CreateAccControlsGrp.TabStop = false;
            this.CreateAccControlsGrp.Text = "Controlls";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(387, 43);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Create Account";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(246, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back To Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EnterAccountRankCmb
            // 
            this.EnterAccountRankCmb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterAccountRankCmb.FormattingEnabled = true;
            this.EnterAccountRankCmb.Location = new System.Drawing.Point(136, 119);
            this.EnterAccountRankCmb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EnterAccountRankCmb.Name = "EnterAccountRankCmb";
            this.EnterAccountRankCmb.Size = new System.Drawing.Size(240, 29);
            this.EnterAccountRankCmb.TabIndex = 3;
            // 
            // EnterPasswordConfirmTxt
            // 
            this.EnterPasswordConfirmTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordConfirmTxt.Location = new System.Drawing.Point(525, 119);
            this.EnterPasswordConfirmTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EnterPasswordConfirmTxt.Name = "EnterPasswordConfirmTxt";
            this.EnterPasswordConfirmTxt.Size = new System.Drawing.Size(240, 29);
            this.EnterPasswordConfirmTxt.TabIndex = 2;
            // 
            // EnterPasswordTxt
            // 
            this.EnterPasswordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordTxt.Location = new System.Drawing.Point(514, 88);
            this.EnterPasswordTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EnterPasswordTxt.Name = "EnterPasswordTxt";
            this.EnterPasswordTxt.Size = new System.Drawing.Size(240, 29);
            this.EnterPasswordTxt.TabIndex = 2;
            // 
            // EnterUsernameTxt
            // 
            this.EnterUsernameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterUsernameTxt.Location = new System.Drawing.Point(136, 89);
            this.EnterUsernameTxt.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.EnterUsernameTxt.Name = "EnterUsernameTxt";
            this.EnterUsernameTxt.Size = new System.Drawing.Size(240, 29);
            this.EnterUsernameTxt.TabIndex = 2;
            // 
            // EnterPaswordConfirmLbl
            // 
            this.EnterPaswordConfirmLbl.AutoSize = true;
            this.EnterPaswordConfirmLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPaswordConfirmLbl.Location = new System.Drawing.Point(385, 122);
            this.EnterPaswordConfirmLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterPaswordConfirmLbl.Name = "EnterPaswordConfirmLbl";
            this.EnterPaswordConfirmLbl.Size = new System.Drawing.Size(140, 21);
            this.EnterPaswordConfirmLbl.TabIndex = 1;
            this.EnterPaswordConfirmLbl.Text = "Confirm Password:";
            // 
            // EnterAccountRankLbl
            // 
            this.EnterAccountRankLbl.AutoSize = true;
            this.EnterAccountRankLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterAccountRankLbl.Location = new System.Drawing.Point(28, 121);
            this.EnterAccountRankLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterAccountRankLbl.Name = "EnterAccountRankLbl";
            this.EnterAccountRankLbl.Size = new System.Drawing.Size(108, 21);
            this.EnterAccountRankLbl.TabIndex = 1;
            this.EnterAccountRankLbl.Text = "Account Rank:";
            // 
            // EnterPasswordLbl
            // 
            this.EnterPasswordLbl.AutoSize = true;
            this.EnterPasswordLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterPasswordLbl.Location = new System.Drawing.Point(446, 91);
            this.EnterPasswordLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterPasswordLbl.Name = "EnterPasswordLbl";
            this.EnterPasswordLbl.Size = new System.Drawing.Size(79, 21);
            this.EnterPasswordLbl.TabIndex = 1;
            this.EnterPasswordLbl.Text = "Password:";
            // 
            // EnterNameLbl
            // 
            this.EnterNameLbl.AutoSize = true;
            this.EnterNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterNameLbl.Location = new System.Drawing.Point(81, 92);
            this.EnterNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterNameLbl.Name = "EnterNameLbl";
            this.EnterNameLbl.Size = new System.Drawing.Size(55, 21);
            this.EnterNameLbl.TabIndex = 1;
            this.EnterNameLbl.Text = "Name:";
            // 
            // CreateAccountHeaderLbl
            // 
            this.CreateAccountHeaderLbl.AutoSize = true;
            this.CreateAccountHeaderLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccountHeaderLbl.Location = new System.Drawing.Point(299, 25);
            this.CreateAccountHeaderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateAccountHeaderLbl.Name = "CreateAccountHeaderLbl";
            this.CreateAccountHeaderLbl.Size = new System.Drawing.Size(186, 28);
            this.CreateAccountHeaderLbl.TabIndex = 0;
            this.CreateAccountHeaderLbl.Text = "Create an Account";
            // 
            // CreateAccDetailsGrp
            // 
            this.CreateAccDetailsGrp.Controls.Add(this.EnterPasswordTxt);
            this.CreateAccDetailsGrp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccDetailsGrp.Location = new System.Drawing.Point(11, 1);
            this.CreateAccDetailsGrp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CreateAccDetailsGrp.Name = "CreateAccDetailsGrp";
            this.CreateAccDetailsGrp.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CreateAccDetailsGrp.Size = new System.Drawing.Size(776, 191);
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
            this.CreateAccGDPRGrp.Location = new System.Drawing.Point(11, 200);
            this.CreateAccGDPRGrp.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CreateAccGDPRGrp.Name = "CreateAccGDPRGrp";
            this.CreateAccGDPRGrp.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CreateAccGDPRGrp.Size = new System.Drawing.Size(776, 135);
            this.CreateAccGDPRGrp.TabIndex = 6;
            this.CreateAccGDPRGrp.TabStop = false;
            this.CreateAccGDPRGrp.Text = "Data Protection Agreement";
            // 
            // GDPRNoConcentRdbtn
            // 
            this.GDPRNoConcentRdbtn.AutoSize = true;
            this.GDPRNoConcentRdbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GDPRNoConcentRdbtn.Location = new System.Drawing.Point(387, 101);
            this.GDPRNoConcentRdbtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GDPRNoConcentRdbtn.Name = "GDPRNoConcentRdbtn";
            this.GDPRNoConcentRdbtn.Size = new System.Drawing.Size(159, 25);
            this.GDPRNoConcentRdbtn.TabIndex = 5;
            this.GDPRNoConcentRdbtn.TabStop = true;
            this.GDPRNoConcentRdbtn.Text = "I Do Not Concent";
            this.GDPRNoConcentRdbtn.UseVisualStyleBackColor = true;
            // 
            // GDPRConcentRdbtn
            // 
            this.GDPRConcentRdbtn.AutoSize = true;
            this.GDPRConcentRdbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GDPRConcentRdbtn.Location = new System.Drawing.Point(227, 101);
            this.GDPRConcentRdbtn.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GDPRConcentRdbtn.Name = "GDPRConcentRdbtn";
            this.GDPRConcentRdbtn.Size = new System.Drawing.Size(100, 25);
            this.GDPRConcentRdbtn.TabIndex = 5;
            this.GDPRConcentRdbtn.TabStop = true;
            this.GDPRConcentRdbtn.Text = "I Concent";
            this.GDPRConcentRdbtn.UseVisualStyleBackColor = true;
            // 
            // EnterGDPRInfoLbl
            // 
            this.EnterGDPRInfoLbl.AutoSize = true;
            this.EnterGDPRInfoLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.EnterGDPRInfoLbl.Location = new System.Drawing.Point(58, 26);
            this.EnterGDPRInfoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterGDPRInfoLbl.MaximumSize = new System.Drawing.Size(715, 0);
            this.EnterGDPRInfoLbl.Name = "EnterGDPRInfoLbl";
            this.EnterGDPRInfoLbl.Size = new System.Drawing.Size(700, 63);
            this.EnterGDPRInfoLbl.TabIndex = 4;
            this.EnterGDPRInfoLbl.Text = resources.GetString("EnterGDPRInfoLbl.Text");
            // 
            // EnterGDPRLbl
            // 
            this.EnterGDPRLbl.AutoSize = true;
            this.EnterGDPRLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterGDPRLbl.Location = new System.Drawing.Point(9, 26);
            this.EnterGDPRLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnterGDPRLbl.Name = "EnterGDPRLbl";
            this.EnterGDPRLbl.Size = new System.Drawing.Size(48, 21);
            this.EnterGDPRLbl.TabIndex = 1;
            this.EnterGDPRLbl.Text = "T/C\'s:";
            // 
            // TabShop
            // 
            this.TabShop.Location = new System.Drawing.Point(4, 5);
            this.TabShop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabShop.Name = "TabShop";
            this.TabShop.Size = new System.Drawing.Size(795, 447);
            this.TabShop.TabIndex = 2;
            this.TabShop.Text = "ShopTab";
            this.TabShop.UseVisualStyleBackColor = true;
            // 
            // TabAdmin
            // 
            this.TabAdmin.Location = new System.Drawing.Point(4, 5);
            this.TabAdmin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabAdmin.Name = "TabAdmin";
            this.TabAdmin.Size = new System.Drawing.Size(795, 447);
            this.TabAdmin.TabIndex = 3;
            this.TabAdmin.Text = "AdminTab";
            this.TabAdmin.UseVisualStyleBackColor = true;
            // 
            // TabAccDetails
            // 
            this.TabAccDetails.Location = new System.Drawing.Point(4, 5);
            this.TabAccDetails.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.TabAccDetails.Name = "TabAccDetails";
            this.TabAccDetails.Size = new System.Drawing.Size(795, 447);
            this.TabAccDetails.TabIndex = 4;
            this.TabAccDetails.Text = "AccountDetailsTab";
            this.TabAccDetails.UseVisualStyleBackColor = true;
            // 
            // MainSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 467);
            this.Controls.Add(this.NavSystemMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "MainSystem";
            this.Text = "Sarre Running Sports";
            this.NavSystemMain.ResumeLayout(false);
            this.TabLogin.ResumeLayout(false);
            this.TabLogin.PerformLayout();
            this.TabAccCreate.ResumeLayout(false);
            this.TabAccCreate.PerformLayout();
            this.CreateAccControlsGrp.ResumeLayout(false);
            this.CreateAccDetailsGrp.ResumeLayout(false);
            this.CreateAccDetailsGrp.PerformLayout();
            this.CreateAccGDPRGrp.ResumeLayout(false);
            this.CreateAccGDPRGrp.PerformLayout();
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
        private TextBox LoginNameEntryTxt;
        private Label LoginPasswordEntryLbl;
        private Label LoginNameEntryLbl;
        private Label SystemLoginLbl;
        private Label EnterNameLbl;
        private Label CreateAccountHeaderLbl;
        private Label EnterGDPRLbl;
        private Label EnterAccountRankLbl;
        private Label EnterPasswordLbl;
        private TextBox EnterPasswordTxt;
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