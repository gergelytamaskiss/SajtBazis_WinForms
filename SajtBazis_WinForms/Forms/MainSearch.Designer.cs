namespace SajtBazis_WinForms
{
    partial class MainSearch
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_Parameters = new System.Windows.Forms.GroupBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Market = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.txb_BarCode = new System.Windows.Forms.TextBox();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.tbx_PartNumber = new System.Windows.Forms.TextBox();
            this.btn_ProductSearch = new System.Windows.Forms.Button();
            this.lbl_BarCode = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_PartNumber = new System.Windows.Forms.Label();
            this.grb_Results = new System.Windows.Forms.GroupBox();
            this.lsb_Products = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_Search = new System.Windows.Forms.TabPage();
            this.tbp_UserMaintenance = new System.Windows.Forms.TabPage();
            this.grb_Manage = new System.Windows.Forms.GroupBox();
            this.btn_UserModify = new System.Windows.Forms.Button();
            this.btn_UserNew = new System.Windows.Forms.Button();
            this.btn_UserDelete = new System.Windows.Forms.Button();
            this.grb_UserResult = new System.Windows.Forms.GroupBox();
            this.lsb_Users = new System.Windows.Forms.ListBox();
            this.grb_UserSearch = new System.Windows.Forms.GroupBox();
            this.lbl_Permission = new System.Windows.Forms.Label();
            this.cmb_Permission = new System.Windows.Forms.ComboBox();
            this.btn_UserSearch = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.tbx_UserName = new System.Windows.Forms.TextBox();
            this.tbp_ProductMaintenance = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ProductModify = new System.Windows.Forms.Button();
            this.btn_ProductNew = new System.Windows.Forms.Button();
            this.btn_ProductDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox3 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox4 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox5 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.grb_Parameters.SuspendLayout();
            this.grb_Results.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbp_Search.SuspendLayout();
            this.tbp_UserMaintenance.SuspendLayout();
            this.grb_Manage.SuspendLayout();
            this.grb_UserResult.SuspendLayout();
            this.grb_UserSearch.SuspendLayout();
            this.tbp_ProductMaintenance.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.quitToolStripMenuItem.Text = "Logout";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // grb_Parameters
            // 
            this.grb_Parameters.Controls.Add(this.checkedListBox5);
            this.grb_Parameters.Controls.Add(this.checkedListBox4);
            this.grb_Parameters.Controls.Add(this.checkedListBox3);
            this.grb_Parameters.Controls.Add(this.checkedListBox2);
            this.grb_Parameters.Controls.Add(this.checkedListBox1);
            this.grb_Parameters.Controls.Add(this.lbl_Type);
            this.grb_Parameters.Controls.Add(this.lbl_Market);
            this.grb_Parameters.Controls.Add(this.lbl_Brand);
            this.grb_Parameters.Controls.Add(this.txb_BarCode);
            this.grb_Parameters.Controls.Add(this.txb_Description);
            this.grb_Parameters.Controls.Add(this.tbx_PartNumber);
            this.grb_Parameters.Controls.Add(this.btn_ProductSearch);
            this.grb_Parameters.Controls.Add(this.lbl_BarCode);
            this.grb_Parameters.Controls.Add(this.lbl_Factory);
            this.grb_Parameters.Controls.Add(this.lbl_Category);
            this.grb_Parameters.Controls.Add(this.lbl_Description);
            this.grb_Parameters.Controls.Add(this.lbl_PartNumber);
            this.grb_Parameters.Location = new System.Drawing.Point(8, 6);
            this.grb_Parameters.Name = "grb_Parameters";
            this.grb_Parameters.Size = new System.Drawing.Size(860, 231);
            this.grb_Parameters.TabIndex = 1;
            this.grb_Parameters.TabStop = false;
            this.grb_Parameters.Text = "Parameters";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(725, 16);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(34, 13);
            this.lbl_Type.TabIndex = 30;
            this.lbl_Type.Text = "Type:";
            // 
            // lbl_Market
            // 
            this.lbl_Market.AutoSize = true;
            this.lbl_Market.Location = new System.Drawing.Point(467, 16);
            this.lbl_Market.Name = "lbl_Market";
            this.lbl_Market.Size = new System.Drawing.Size(43, 13);
            this.lbl_Market.TabIndex = 29;
            this.lbl_Market.Text = "Market:";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Location = new System.Drawing.Point(593, 16);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(38, 13);
            this.lbl_Brand.TabIndex = 28;
            this.lbl_Brand.Text = "Brand:";
            // 
            // txb_BarCode
            // 
            this.txb_BarCode.Location = new System.Drawing.Point(81, 48);
            this.txb_BarCode.Name = "txb_BarCode";
            this.txb_BarCode.Size = new System.Drawing.Size(223, 20);
            this.txb_BarCode.TabIndex = 25;
            // 
            // txb_Description
            // 
            this.txb_Description.Location = new System.Drawing.Point(81, 72);
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(223, 20);
            this.txb_Description.TabIndex = 22;
            // 
            // tbx_PartNumber
            // 
            this.tbx_PartNumber.Location = new System.Drawing.Point(81, 22);
            this.tbx_PartNumber.Name = "tbx_PartNumber";
            this.tbx_PartNumber.Size = new System.Drawing.Size(80, 20);
            this.tbx_PartNumber.TabIndex = 21;
            // 
            // btn_ProductSearch
            // 
            this.btn_ProductSearch.Location = new System.Drawing.Point(779, 202);
            this.btn_ProductSearch.Name = "btn_ProductSearch";
            this.btn_ProductSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_ProductSearch.TabIndex = 16;
            this.btn_ProductSearch.Text = "Search";
            this.btn_ProductSearch.UseVisualStyleBackColor = true;
            this.btn_ProductSearch.Click += new System.EventHandler(this.btn_ProductSearch_Click);
            // 
            // lbl_BarCode
            // 
            this.lbl_BarCode.AutoSize = true;
            this.lbl_BarCode.Location = new System.Drawing.Point(6, 51);
            this.lbl_BarCode.Name = "lbl_BarCode";
            this.lbl_BarCode.Size = new System.Drawing.Size(54, 13);
            this.lbl_BarCode.TabIndex = 6;
            this.lbl_BarCode.Text = "Bar Code:";
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.AutoSize = true;
            this.lbl_Factory.Location = new System.Drawing.Point(341, 16);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(45, 13);
            this.lbl_Factory.TabIndex = 5;
            this.lbl_Factory.Text = "Factory:";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(6, 115);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(52, 13);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Category:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(6, 75);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 1;
            this.lbl_Description.Text = "Description:";
            // 
            // lbl_PartNumber
            // 
            this.lbl_PartNumber.AutoSize = true;
            this.lbl_PartNumber.Location = new System.Drawing.Point(6, 25);
            this.lbl_PartNumber.Name = "lbl_PartNumber";
            this.lbl_PartNumber.Size = new System.Drawing.Size(69, 13);
            this.lbl_PartNumber.TabIndex = 0;
            this.lbl_PartNumber.Text = "Part Number:";
            // 
            // grb_Results
            // 
            this.grb_Results.Controls.Add(this.lsb_Products);
            this.grb_Results.Location = new System.Drawing.Point(8, 289);
            this.grb_Results.Name = "grb_Results";
            this.grb_Results.Size = new System.Drawing.Size(860, 284);
            this.grb_Results.TabIndex = 5;
            this.grb_Results.TabStop = false;
            this.grb_Results.Text = "Results";
            // 
            // lsb_Products
            // 
            this.lsb_Products.FormattingEnabled = true;
            this.lsb_Products.Location = new System.Drawing.Point(9, 19);
            this.lsb_Products.Name = "lsb_Products";
            this.lsb_Products.Size = new System.Drawing.Size(845, 251);
            this.lsb_Products.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_Search);
            this.tabControl1.Controls.Add(this.tbp_UserMaintenance);
            this.tabControl1.Controls.Add(this.tbp_ProductMaintenance);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(885, 605);
            this.tabControl1.TabIndex = 6;
            // 
            // tbp_Search
            // 
            this.tbp_Search.Controls.Add(this.grb_Parameters);
            this.tbp_Search.Controls.Add(this.grb_Results);
            this.tbp_Search.Location = new System.Drawing.Point(4, 22);
            this.tbp_Search.Name = "tbp_Search";
            this.tbp_Search.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_Search.Size = new System.Drawing.Size(877, 579);
            this.tbp_Search.TabIndex = 0;
            this.tbp_Search.Text = "Search Products";
            this.tbp_Search.UseVisualStyleBackColor = true;
            // 
            // tbp_UserMaintenance
            // 
            this.tbp_UserMaintenance.Controls.Add(this.grb_Manage);
            this.tbp_UserMaintenance.Controls.Add(this.grb_UserResult);
            this.tbp_UserMaintenance.Controls.Add(this.grb_UserSearch);
            this.tbp_UserMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tbp_UserMaintenance.Name = "tbp_UserMaintenance";
            this.tbp_UserMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_UserMaintenance.Size = new System.Drawing.Size(877, 579);
            this.tbp_UserMaintenance.TabIndex = 1;
            this.tbp_UserMaintenance.Text = "User Maintenance";
            this.tbp_UserMaintenance.UseVisualStyleBackColor = true;
            // 
            // grb_Manage
            // 
            this.grb_Manage.Controls.Add(this.btn_UserModify);
            this.grb_Manage.Controls.Add(this.btn_UserNew);
            this.grb_Manage.Controls.Add(this.btn_UserDelete);
            this.grb_Manage.Location = new System.Drawing.Point(220, 6);
            this.grb_Manage.Name = "grb_Manage";
            this.grb_Manage.Size = new System.Drawing.Size(122, 123);
            this.grb_Manage.TabIndex = 24;
            this.grb_Manage.TabStop = false;
            this.grb_Manage.Text = "Manage";
            // 
            // btn_UserModify
            // 
            this.btn_UserModify.Location = new System.Drawing.Point(15, 55);
            this.btn_UserModify.Name = "btn_UserModify";
            this.btn_UserModify.Size = new System.Drawing.Size(91, 23);
            this.btn_UserModify.TabIndex = 1;
            this.btn_UserModify.Text = "Modify selected";
            this.btn_UserModify.UseVisualStyleBackColor = true;
            this.btn_UserModify.Click += new System.EventHandler(this.btn_UserModify_Click);
            // 
            // btn_UserNew
            // 
            this.btn_UserNew.Location = new System.Drawing.Point(15, 26);
            this.btn_UserNew.Name = "btn_UserNew";
            this.btn_UserNew.Size = new System.Drawing.Size(91, 23);
            this.btn_UserNew.TabIndex = 17;
            this.btn_UserNew.Text = "New user";
            this.btn_UserNew.UseVisualStyleBackColor = true;
            this.btn_UserNew.Click += new System.EventHandler(this.btn_UserNew_Click);
            // 
            // btn_UserDelete
            // 
            this.btn_UserDelete.Location = new System.Drawing.Point(15, 84);
            this.btn_UserDelete.Name = "btn_UserDelete";
            this.btn_UserDelete.Size = new System.Drawing.Size(91, 23);
            this.btn_UserDelete.TabIndex = 16;
            this.btn_UserDelete.Text = "Delete selected";
            this.btn_UserDelete.UseVisualStyleBackColor = true;
            this.btn_UserDelete.Click += new System.EventHandler(this.btn_UserDelete_Click);
            // 
            // grb_UserResult
            // 
            this.grb_UserResult.Controls.Add(this.lsb_Users);
            this.grb_UserResult.Location = new System.Drawing.Point(8, 150);
            this.grb_UserResult.Name = "grb_UserResult";
            this.grb_UserResult.Size = new System.Drawing.Size(863, 423);
            this.grb_UserResult.TabIndex = 23;
            this.grb_UserResult.TabStop = false;
            this.grb_UserResult.Text = "Results";
            // 
            // lsb_Users
            // 
            this.lsb_Users.FormattingEnabled = true;
            this.lsb_Users.Location = new System.Drawing.Point(6, 19);
            this.lsb_Users.Name = "lsb_Users";
            this.lsb_Users.Size = new System.Drawing.Size(851, 394);
            this.lsb_Users.TabIndex = 0;
            // 
            // grb_UserSearch
            // 
            this.grb_UserSearch.Controls.Add(this.lbl_Permission);
            this.grb_UserSearch.Controls.Add(this.cmb_Permission);
            this.grb_UserSearch.Controls.Add(this.btn_UserSearch);
            this.grb_UserSearch.Controls.Add(this.lbl_Username);
            this.grb_UserSearch.Controls.Add(this.tbx_UserName);
            this.grb_UserSearch.Location = new System.Drawing.Point(6, 6);
            this.grb_UserSearch.Name = "grb_UserSearch";
            this.grb_UserSearch.Size = new System.Drawing.Size(208, 123);
            this.grb_UserSearch.TabIndex = 21;
            this.grb_UserSearch.TabStop = false;
            this.grb_UserSearch.Text = "Search";
            // 
            // lbl_Permission
            // 
            this.lbl_Permission.AutoSize = true;
            this.lbl_Permission.Location = new System.Drawing.Point(17, 26);
            this.lbl_Permission.Name = "lbl_Permission";
            this.lbl_Permission.Size = new System.Drawing.Size(60, 13);
            this.lbl_Permission.TabIndex = 21;
            this.lbl_Permission.Text = "Permission:";
            // 
            // cmb_Permission
            // 
            this.cmb_Permission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Permission.FormattingEnabled = true;
            this.cmb_Permission.Location = new System.Drawing.Point(83, 23);
            this.cmb_Permission.Name = "cmb_Permission";
            this.cmb_Permission.Size = new System.Drawing.Size(100, 21);
            this.cmb_Permission.TabIndex = 20;
            // 
            // btn_UserSearch
            // 
            this.btn_UserSearch.Location = new System.Drawing.Point(108, 83);
            this.btn_UserSearch.Name = "btn_UserSearch";
            this.btn_UserSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_UserSearch.TabIndex = 19;
            this.btn_UserSearch.Text = "Search";
            this.btn_UserSearch.UseVisualStyleBackColor = true;
            this.btn_UserSearch.Click += new System.EventHandler(this.btn_UserSearch_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(17, 60);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Username:";
            // 
            // tbx_UserName
            // 
            this.tbx_UserName.Location = new System.Drawing.Point(83, 57);
            this.tbx_UserName.Name = "tbx_UserName";
            this.tbx_UserName.Size = new System.Drawing.Size(100, 20);
            this.tbx_UserName.TabIndex = 7;
            // 
            // tbp_ProductMaintenance
            // 
            this.tbp_ProductMaintenance.Controls.Add(this.groupBox3);
            this.tbp_ProductMaintenance.Controls.Add(this.groupBox2);
            this.tbp_ProductMaintenance.Controls.Add(this.groupBox1);
            this.tbp_ProductMaintenance.Location = new System.Drawing.Point(4, 22);
            this.tbp_ProductMaintenance.Name = "tbp_ProductMaintenance";
            this.tbp_ProductMaintenance.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ProductMaintenance.Size = new System.Drawing.Size(877, 579);
            this.tbp_ProductMaintenance.TabIndex = 2;
            this.tbp_ProductMaintenance.Text = "Product Maintenance";
            this.tbp_ProductMaintenance.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Part Number:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(84, 25);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 20);
            this.textBox5.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Description:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(84, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 50;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(906, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 123);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ProductModify);
            this.groupBox2.Controls.Add(this.btn_ProductNew);
            this.groupBox2.Controls.Add(this.btn_ProductDelete);
            this.groupBox2.Location = new System.Drawing.Point(399, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(122, 123);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage";
            // 
            // btn_ProductModify
            // 
            this.btn_ProductModify.Location = new System.Drawing.Point(15, 55);
            this.btn_ProductModify.Name = "btn_ProductModify";
            this.btn_ProductModify.Size = new System.Drawing.Size(91, 23);
            this.btn_ProductModify.TabIndex = 1;
            this.btn_ProductModify.Text = "Modify selected";
            this.btn_ProductModify.UseVisualStyleBackColor = true;
            // 
            // btn_ProductNew
            // 
            this.btn_ProductNew.Location = new System.Drawing.Point(15, 26);
            this.btn_ProductNew.Name = "btn_ProductNew";
            this.btn_ProductNew.Size = new System.Drawing.Size(91, 23);
            this.btn_ProductNew.TabIndex = 17;
            this.btn_ProductNew.Text = "New product";
            this.btn_ProductNew.UseVisualStyleBackColor = true;
            // 
            // btn_ProductDelete
            // 
            this.btn_ProductDelete.Location = new System.Drawing.Point(15, 84);
            this.btn_ProductDelete.Name = "btn_ProductDelete";
            this.btn_ProductDelete.Size = new System.Drawing.Size(91, 23);
            this.btn_ProductDelete.TabIndex = 16;
            this.btn_ProductDelete.Text = "Delete selected";
            this.btn_ProductDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(8, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(863, 423);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(851, 394);
            this.listBox1.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(728, 34);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 31;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(596, 34);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox2.TabIndex = 32;
            // 
            // checkedListBox3
            // 
            this.checkedListBox3.FormattingEnabled = true;
            this.checkedListBox3.Location = new System.Drawing.Point(470, 34);
            this.checkedListBox3.Name = "checkedListBox3";
            this.checkedListBox3.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox3.TabIndex = 33;
            // 
            // checkedListBox4
            // 
            this.checkedListBox4.FormattingEnabled = true;
            this.checkedListBox4.Location = new System.Drawing.Point(344, 34);
            this.checkedListBox4.Name = "checkedListBox4";
            this.checkedListBox4.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox4.TabIndex = 34;
            // 
            // checkedListBox5
            // 
            this.checkedListBox5.FormattingEnabled = true;
            this.checkedListBox5.Location = new System.Drawing.Point(9, 131);
            this.checkedListBox5.Name = "checkedListBox5";
            this.checkedListBox5.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox5.TabIndex = 35;
            // 
            // MainSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 661);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search - SajtBázis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainSearch_FormClosing);
            this.Load += new System.EventHandler(this.MainSearch_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grb_Parameters.ResumeLayout(false);
            this.grb_Parameters.PerformLayout();
            this.grb_Results.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbp_Search.ResumeLayout(false);
            this.tbp_UserMaintenance.ResumeLayout(false);
            this.grb_Manage.ResumeLayout(false);
            this.grb_UserResult.ResumeLayout(false);
            this.grb_UserSearch.ResumeLayout(false);
            this.grb_UserSearch.PerformLayout();
            this.tbp_ProductMaintenance.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox grb_Parameters;
        private System.Windows.Forms.Label lbl_BarCode;
        private System.Windows.Forms.Label lbl_Factory;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_PartNumber;
        private System.Windows.Forms.TextBox txb_BarCode;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.TextBox tbx_PartNumber;
        private System.Windows.Forms.Button btn_ProductSearch;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox grb_Results;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Market;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_Search;
        private System.Windows.Forms.TabPage tbp_UserMaintenance;
        private System.Windows.Forms.TabPage tbp_ProductMaintenance;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grb_UserResult;
        private System.Windows.Forms.Button btn_UserModify;
        private System.Windows.Forms.Button btn_UserNew;
        private System.Windows.Forms.Button btn_UserDelete;
        private System.Windows.Forms.GroupBox grb_UserSearch;
        private System.Windows.Forms.Label lbl_Permission;
        private System.Windows.Forms.ComboBox cmb_Permission;
        private System.Windows.Forms.Button btn_UserSearch;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox tbx_UserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox grb_Manage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox lsb_Products;
        private System.Windows.Forms.ListBox lsb_Users;
        private System.Windows.Forms.CheckedListBox checkedListBox5;
        private System.Windows.Forms.CheckedListBox checkedListBox4;
        private System.Windows.Forms.CheckedListBox checkedListBox3;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ProductModify;
        private System.Windows.Forms.Button btn_ProductNew;
        private System.Windows.Forms.Button btn_ProductDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}