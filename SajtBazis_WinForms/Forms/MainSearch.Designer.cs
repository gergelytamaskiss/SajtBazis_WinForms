using SajtBazis_WinForms.Classes;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSearch));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realoadAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewhelptoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_ByList = new System.Windows.Forms.GroupBox();
            this.btn_ClearByList = new System.Windows.Forms.Button();
            this.btn_SearchByList = new System.Windows.Forms.Button();
            this.btn_FactoryNone = new System.Windows.Forms.Button();
            this.btn_MarketNone = new System.Windows.Forms.Button();
            this.btn_BrandNone = new System.Windows.Forms.Button();
            this.btn_TypeNone = new System.Windows.Forms.Button();
            this.btn_FactoryAll = new System.Windows.Forms.Button();
            this.btn_MarketAll = new System.Windows.Forms.Button();
            this.btn_BrandAll = new System.Windows.Forms.Button();
            this.btn_TypeAll = new System.Windows.Forms.Button();
            this.chb_Factory = new System.Windows.Forms.CheckedListBox();
            this.chb_Type = new System.Windows.Forms.CheckedListBox();
            this.chb_Brand = new System.Windows.Forms.CheckedListBox();
            this.chb_Market = new System.Windows.Forms.CheckedListBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Market = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.nud_ByDetailsBarCode = new System.Windows.Forms.NumericUpDown();
            this.btn_ClearByDetails = new System.Windows.Forms.Button();
            this.tbx_ByDetailsDescription = new System.Windows.Forms.TextBox();
            this.btn_SearchByDetails = new System.Windows.Forms.Button();
            this.lbl_ByDetailsBarCode = new System.Windows.Forms.Label();
            this.lbl_ByDetailsDescription = new System.Windows.Forms.Label();
            this.lbl_ByDetailsPartNumber = new System.Windows.Forms.Label();
            this.grb_SearchProductsResults = new System.Windows.Forms.GroupBox();
            this.btn_SearchProductsExport = new System.Windows.Forms.Button();
            this.lsv_SearchProducts = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbp_SearchProducts = new System.Windows.Forms.TabPage();
            this.grb_ByDetails = new System.Windows.Forms.GroupBox();
            this.nud_ByDetailsPartNumber = new System.Windows.Forms.NumericUpDown();
            this.tbp_ManageUsers = new System.Windows.Forms.TabPage();
            this.grb_ManageUsers = new System.Windows.Forms.GroupBox();
            this.btn_ModifyUser = new System.Windows.Forms.Button();
            this.btn_NewUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.grb_ManageUsersResult = new System.Windows.Forms.GroupBox();
            this.btn_ManageUsersExport = new System.Windows.Forms.Button();
            this.lsv_ManageUsers = new System.Windows.Forms.ListView();
            this.grb_SearchUsers = new System.Windows.Forms.GroupBox();
            this.btn_PermissionNone = new System.Windows.Forms.Button();
            this.btn_PermissionAll = new System.Windows.Forms.Button();
            this.btn_ClearUser = new System.Windows.Forms.Button();
            this.chb_UserPermission = new System.Windows.Forms.CheckedListBox();
            this.lbl_PermissionSearch = new System.Windows.Forms.Label();
            this.btn_SearchUser = new System.Windows.Forms.Button();
            this.lbl_UsernameSearch = new System.Windows.Forms.Label();
            this.tbx_SearchUserName = new System.Windows.Forms.TextBox();
            this.tbp_ManageProduct = new System.Windows.Forms.TabPage();
            this.grb_ManageProducts = new System.Windows.Forms.GroupBox();
            this.btn_ModifyProduct = new System.Windows.Forms.Button();
            this.btn_NewProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.grb_SearchProducts = new System.Windows.Forms.GroupBox();
            this.nud_ManagePartNumber = new System.Windows.Forms.NumericUpDown();
            this.lbl_ManageDescription = new System.Windows.Forms.Label();
            this.lbl_ManagePartNumber = new System.Windows.Forms.Label();
            this.nud_ManageBarCode = new System.Windows.Forms.NumericUpDown();
            this.lbl_ManageBarCode = new System.Windows.Forms.Label();
            this.btn_SearchProduct = new System.Windows.Forms.Button();
            this.tbx_ManageDescription = new System.Windows.Forms.TextBox();
            this.btn_ClearProduct = new System.Windows.Forms.Button();
            this.grb_ManageProductsResult = new System.Windows.Forms.GroupBox();
            this.btn_ManageProductsExport = new System.Windows.Forms.Button();
            this.lsv_ManageProducts = new System.Windows.Forms.ListView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grb_ByList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ByDetailsBarCode)).BeginInit();
            this.grb_SearchProductsResults.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbp_SearchProducts.SuspendLayout();
            this.grb_ByDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ByDetailsPartNumber)).BeginInit();
            this.tbp_ManageUsers.SuspendLayout();
            this.grb_ManageUsers.SuspendLayout();
            this.grb_ManageUsersResult.SuspendLayout();
            this.grb_SearchUsers.SuspendLayout();
            this.tbp_ManageProduct.SuspendLayout();
            this.grb_ManageProducts.SuspendLayout();
            this.grb_SearchProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ManagePartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ManageBarCode)).BeginInit();
            this.grb_ManageProductsResult.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
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
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadProductsToolStripMenuItem,
            this.reloadUsersToolStripMenuItem,
            this.realoadAllToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.maintenanceToolStripMenuItem.Text = "Database";
            // 
            // reloadProductsToolStripMenuItem
            // 
            this.reloadProductsToolStripMenuItem.Name = "reloadProductsToolStripMenuItem";
            this.reloadProductsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.reloadProductsToolStripMenuItem.Text = "Reload Products";
            this.reloadProductsToolStripMenuItem.Click += new System.EventHandler(this.reloadProductsToolStripMenuItem_Click);
            // 
            // reloadUsersToolStripMenuItem
            // 
            this.reloadUsersToolStripMenuItem.Name = "reloadUsersToolStripMenuItem";
            this.reloadUsersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.reloadUsersToolStripMenuItem.Text = "Reload Users";
            this.reloadUsersToolStripMenuItem.Click += new System.EventHandler(this.reloadUsersToolStripMenuItem_Click);
            // 
            // realoadAllToolStripMenuItem
            // 
            this.realoadAllToolStripMenuItem.Name = "realoadAllToolStripMenuItem";
            this.realoadAllToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.realoadAllToolStripMenuItem.Text = "Reload All";
            this.realoadAllToolStripMenuItem.Click += new System.EventHandler(this.realoadAllToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewhelptoolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewhelptoolStripMenuItem
            // 
            this.viewhelptoolStripMenuItem.Name = "viewhelptoolStripMenuItem";
            this.viewhelptoolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewhelptoolStripMenuItem.Text = "View Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // grb_ByList
            // 
            this.grb_ByList.Controls.Add(this.btn_ClearByList);
            this.grb_ByList.Controls.Add(this.btn_SearchByList);
            this.grb_ByList.Controls.Add(this.btn_FactoryNone);
            this.grb_ByList.Controls.Add(this.btn_MarketNone);
            this.grb_ByList.Controls.Add(this.btn_BrandNone);
            this.grb_ByList.Controls.Add(this.btn_TypeNone);
            this.grb_ByList.Controls.Add(this.btn_FactoryAll);
            this.grb_ByList.Controls.Add(this.btn_MarketAll);
            this.grb_ByList.Controls.Add(this.btn_BrandAll);
            this.grb_ByList.Controls.Add(this.btn_TypeAll);
            this.grb_ByList.Controls.Add(this.chb_Factory);
            this.grb_ByList.Controls.Add(this.chb_Type);
            this.grb_ByList.Controls.Add(this.chb_Brand);
            this.grb_ByList.Controls.Add(this.chb_Market);
            this.grb_ByList.Controls.Add(this.lbl_Type);
            this.grb_ByList.Controls.Add(this.lbl_Market);
            this.grb_ByList.Controls.Add(this.lbl_Brand);
            this.grb_ByList.Controls.Add(this.lbl_Factory);
            this.grb_ByList.Location = new System.Drawing.Point(345, 6);
            this.grb_ByList.Name = "grb_ByList";
            this.grb_ByList.Size = new System.Drawing.Size(601, 193);
            this.grb_ByList.TabIndex = 1;
            this.grb_ByList.TabStop = false;
            this.grb_ByList.Text = "By list";
            // 
            // btn_ClearByList
            // 
            this.btn_ClearByList.Location = new System.Drawing.Point(513, 111);
            this.btn_ClearByList.Name = "btn_ClearByList";
            this.btn_ClearByList.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearByList.TabIndex = 52;
            this.btn_ClearByList.Text = "Clear";
            this.btn_ClearByList.UseVisualStyleBackColor = true;
            this.btn_ClearByList.Click += new System.EventHandler(this.btn_ClearByList_Click);
            // 
            // btn_SearchByList
            // 
            this.btn_SearchByList.Location = new System.Drawing.Point(513, 151);
            this.btn_SearchByList.Name = "btn_SearchByList";
            this.btn_SearchByList.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchByList.TabIndex = 51;
            this.btn_SearchByList.Text = "Search";
            this.btn_SearchByList.UseVisualStyleBackColor = true;
            this.btn_SearchByList.Click += new System.EventHandler(this.btn_SearchByList_Click);
            // 
            // btn_FactoryNone
            // 
            this.btn_FactoryNone.Location = new System.Drawing.Point(9, 151);
            this.btn_FactoryNone.Name = "btn_FactoryNone";
            this.btn_FactoryNone.Size = new System.Drawing.Size(120, 23);
            this.btn_FactoryNone.TabIndex = 50;
            this.btn_FactoryNone.Text = "None";
            this.btn_FactoryNone.UseVisualStyleBackColor = true;
            this.btn_FactoryNone.Click += new System.EventHandler(this.btn_FactoryNone_Click);
            // 
            // btn_MarketNone
            // 
            this.btn_MarketNone.Location = new System.Drawing.Point(261, 151);
            this.btn_MarketNone.Name = "btn_MarketNone";
            this.btn_MarketNone.Size = new System.Drawing.Size(120, 23);
            this.btn_MarketNone.TabIndex = 49;
            this.btn_MarketNone.Text = "None";
            this.btn_MarketNone.UseVisualStyleBackColor = true;
            this.btn_MarketNone.Click += new System.EventHandler(this.btnMarketNone_Click);
            // 
            // btn_BrandNone
            // 
            this.btn_BrandNone.Location = new System.Drawing.Point(387, 151);
            this.btn_BrandNone.Name = "btn_BrandNone";
            this.btn_BrandNone.Size = new System.Drawing.Size(120, 23);
            this.btn_BrandNone.TabIndex = 48;
            this.btn_BrandNone.Text = "None";
            this.btn_BrandNone.UseVisualStyleBackColor = true;
            this.btn_BrandNone.Click += new System.EventHandler(this.btn_BrandNone_Click);
            // 
            // btn_TypeNone
            // 
            this.btn_TypeNone.Location = new System.Drawing.Point(135, 151);
            this.btn_TypeNone.Name = "btn_TypeNone";
            this.btn_TypeNone.Size = new System.Drawing.Size(120, 23);
            this.btn_TypeNone.TabIndex = 47;
            this.btn_TypeNone.Text = "None";
            this.btn_TypeNone.UseVisualStyleBackColor = true;
            this.btn_TypeNone.Click += new System.EventHandler(this.btn_TypeNone_Click);
            // 
            // btn_FactoryAll
            // 
            this.btn_FactoryAll.Location = new System.Drawing.Point(9, 37);
            this.btn_FactoryAll.Name = "btn_FactoryAll";
            this.btn_FactoryAll.Size = new System.Drawing.Size(120, 23);
            this.btn_FactoryAll.TabIndex = 46;
            this.btn_FactoryAll.Text = "All";
            this.btn_FactoryAll.UseVisualStyleBackColor = true;
            this.btn_FactoryAll.Click += new System.EventHandler(this.btn_FactoryAll_Click);
            // 
            // btn_MarketAll
            // 
            this.btn_MarketAll.Location = new System.Drawing.Point(261, 37);
            this.btn_MarketAll.Name = "btn_MarketAll";
            this.btn_MarketAll.Size = new System.Drawing.Size(120, 23);
            this.btn_MarketAll.TabIndex = 45;
            this.btn_MarketAll.Text = "All";
            this.btn_MarketAll.UseVisualStyleBackColor = true;
            this.btn_MarketAll.Click += new System.EventHandler(this.btn_MarketAll_Click);
            // 
            // btn_BrandAll
            // 
            this.btn_BrandAll.Location = new System.Drawing.Point(387, 37);
            this.btn_BrandAll.Name = "btn_BrandAll";
            this.btn_BrandAll.Size = new System.Drawing.Size(120, 23);
            this.btn_BrandAll.TabIndex = 44;
            this.btn_BrandAll.Text = "All";
            this.btn_BrandAll.UseVisualStyleBackColor = true;
            this.btn_BrandAll.Click += new System.EventHandler(this.btn_BrandAll_Click);
            // 
            // btn_TypeAll
            // 
            this.btn_TypeAll.Location = new System.Drawing.Point(135, 37);
            this.btn_TypeAll.Name = "btn_TypeAll";
            this.btn_TypeAll.Size = new System.Drawing.Size(120, 23);
            this.btn_TypeAll.TabIndex = 43;
            this.btn_TypeAll.Text = "All";
            this.btn_TypeAll.UseVisualStyleBackColor = true;
            this.btn_TypeAll.Click += new System.EventHandler(this.btn_TypeAll_Click);
            // 
            // chb_Factory
            // 
            this.chb_Factory.FormattingEnabled = true;
            this.chb_Factory.Location = new System.Drawing.Point(9, 66);
            this.chb_Factory.Name = "chb_Factory";
            this.chb_Factory.Size = new System.Drawing.Size(120, 79);
            this.chb_Factory.TabIndex = 35;
            this.chb_Factory.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chb_Factory_ItemCheck);
            // 
            // chb_Type
            // 
            this.chb_Type.FormattingEnabled = true;
            this.chb_Type.Location = new System.Drawing.Point(135, 66);
            this.chb_Type.Name = "chb_Type";
            this.chb_Type.Size = new System.Drawing.Size(120, 79);
            this.chb_Type.TabIndex = 33;
            this.chb_Type.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chb_Type_ItemCheck);
            // 
            // chb_Brand
            // 
            this.chb_Brand.FormattingEnabled = true;
            this.chb_Brand.Location = new System.Drawing.Point(387, 66);
            this.chb_Brand.Name = "chb_Brand";
            this.chb_Brand.Size = new System.Drawing.Size(120, 79);
            this.chb_Brand.TabIndex = 32;
            this.chb_Brand.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chb_Brand_ItemCheck);
            // 
            // chb_Market
            // 
            this.chb_Market.FormattingEnabled = true;
            this.chb_Market.Location = new System.Drawing.Point(261, 66);
            this.chb_Market.Name = "chb_Market";
            this.chb_Market.Size = new System.Drawing.Size(120, 79);
            this.chb_Market.TabIndex = 31;
            this.chb_Market.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chb_Market_ItemCheck);
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(132, 16);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(34, 13);
            this.lbl_Type.TabIndex = 30;
            this.lbl_Type.Text = "Type:";
            // 
            // lbl_Market
            // 
            this.lbl_Market.AutoSize = true;
            this.lbl_Market.Location = new System.Drawing.Point(258, 16);
            this.lbl_Market.Name = "lbl_Market";
            this.lbl_Market.Size = new System.Drawing.Size(43, 13);
            this.lbl_Market.TabIndex = 29;
            this.lbl_Market.Text = "Market:";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Location = new System.Drawing.Point(384, 16);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(38, 13);
            this.lbl_Brand.TabIndex = 28;
            this.lbl_Brand.Text = "Brand:";
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.AutoSize = true;
            this.lbl_Factory.Location = new System.Drawing.Point(6, 16);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(45, 13);
            this.lbl_Factory.TabIndex = 5;
            this.lbl_Factory.Text = "Factory:";
            // 
            // nud_ByDetailsBarCode
            // 
            this.nud_ByDetailsBarCode.Location = new System.Drawing.Point(81, 91);
            this.nud_ByDetailsBarCode.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_ByDetailsBarCode.Name = "nud_ByDetailsBarCode";
            this.nud_ByDetailsBarCode.Size = new System.Drawing.Size(62, 20);
            this.nud_ByDetailsBarCode.TabIndex = 55;
            // 
            // btn_ClearByDetails
            // 
            this.btn_ClearByDetails.Location = new System.Drawing.Point(244, 111);
            this.btn_ClearByDetails.Name = "btn_ClearByDetails";
            this.btn_ClearByDetails.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearByDetails.TabIndex = 41;
            this.btn_ClearByDetails.Text = "Clear";
            this.btn_ClearByDetails.UseVisualStyleBackColor = true;
            this.btn_ClearByDetails.Click += new System.EventHandler(this.btn_ClearByDetails_Click);
            // 
            // tbx_ByDetailsDescription
            // 
            this.tbx_ByDetailsDescription.Location = new System.Drawing.Point(81, 39);
            this.tbx_ByDetailsDescription.Name = "tbx_ByDetailsDescription";
            this.tbx_ByDetailsDescription.Size = new System.Drawing.Size(238, 20);
            this.tbx_ByDetailsDescription.TabIndex = 22;
            // 
            // btn_SearchByDetails
            // 
            this.btn_SearchByDetails.Location = new System.Drawing.Point(244, 151);
            this.btn_SearchByDetails.Name = "btn_SearchByDetails";
            this.btn_SearchByDetails.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchByDetails.TabIndex = 16;
            this.btn_SearchByDetails.Text = "Search";
            this.btn_SearchByDetails.UseVisualStyleBackColor = true;
            this.btn_SearchByDetails.Click += new System.EventHandler(this.btn_SearchByDetails_Click);
            // 
            // lbl_ByDetailsBarCode
            // 
            this.lbl_ByDetailsBarCode.AutoSize = true;
            this.lbl_ByDetailsBarCode.Location = new System.Drawing.Point(6, 93);
            this.lbl_ByDetailsBarCode.Name = "lbl_ByDetailsBarCode";
            this.lbl_ByDetailsBarCode.Size = new System.Drawing.Size(54, 13);
            this.lbl_ByDetailsBarCode.TabIndex = 6;
            this.lbl_ByDetailsBarCode.Text = "Bar Code:";
            // 
            // lbl_ByDetailsDescription
            // 
            this.lbl_ByDetailsDescription.AutoSize = true;
            this.lbl_ByDetailsDescription.Location = new System.Drawing.Point(6, 42);
            this.lbl_ByDetailsDescription.Name = "lbl_ByDetailsDescription";
            this.lbl_ByDetailsDescription.Size = new System.Drawing.Size(63, 13);
            this.lbl_ByDetailsDescription.TabIndex = 1;
            this.lbl_ByDetailsDescription.Text = "Description:";
            // 
            // lbl_ByDetailsPartNumber
            // 
            this.lbl_ByDetailsPartNumber.AutoSize = true;
            this.lbl_ByDetailsPartNumber.Location = new System.Drawing.Point(6, 67);
            this.lbl_ByDetailsPartNumber.Name = "lbl_ByDetailsPartNumber";
            this.lbl_ByDetailsPartNumber.Size = new System.Drawing.Size(69, 13);
            this.lbl_ByDetailsPartNumber.TabIndex = 0;
            this.lbl_ByDetailsPartNumber.Text = "Part Number:";
            // 
            // grb_SearchProductsResults
            // 
            this.grb_SearchProductsResults.Controls.Add(this.btn_SearchProductsExport);
            this.grb_SearchProductsResults.Controls.Add(this.lsv_SearchProducts);
            this.grb_SearchProductsResults.Location = new System.Drawing.Point(8, 205);
            this.grb_SearchProductsResults.Name = "grb_SearchProductsResults";
            this.grb_SearchProductsResults.Size = new System.Drawing.Size(938, 461);
            this.grb_SearchProductsResults.TabIndex = 5;
            this.grb_SearchProductsResults.TabStop = false;
            this.grb_SearchProductsResults.Text = "Results";
            // 
            // btn_SearchProductsExport
            // 
            this.btn_SearchProductsExport.Location = new System.Drawing.Point(857, 432);
            this.btn_SearchProductsExport.Name = "btn_SearchProductsExport";
            this.btn_SearchProductsExport.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchProductsExport.TabIndex = 1;
            this.btn_SearchProductsExport.Text = "Export";
            this.btn_SearchProductsExport.UseVisualStyleBackColor = true;
            this.btn_SearchProductsExport.Click += new System.EventHandler(this.btn_SearchProductsExport_Click);
            // 
            // lsv_SearchProducts
            // 
            this.lsv_SearchProducts.Location = new System.Drawing.Point(9, 19);
            this.lsv_SearchProducts.Name = "lsv_SearchProducts";
            this.lsv_SearchProducts.Size = new System.Drawing.Size(923, 407);
            this.lsv_SearchProducts.TabIndex = 0;
            this.lsv_SearchProducts.UseCompatibleStateImageBehavior = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbp_SearchProducts);
            this.tabControl1.Controls.Add(this.tbp_ManageUsers);
            this.tabControl1.Controls.Add(this.tbp_ManageProduct);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 698);
            this.tabControl1.TabIndex = 6;
            // 
            // tbp_SearchProducts
            // 
            this.tbp_SearchProducts.Controls.Add(this.grb_ByDetails);
            this.tbp_SearchProducts.Controls.Add(this.grb_ByList);
            this.tbp_SearchProducts.Controls.Add(this.grb_SearchProductsResults);
            this.tbp_SearchProducts.Location = new System.Drawing.Point(4, 22);
            this.tbp_SearchProducts.Name = "tbp_SearchProducts";
            this.tbp_SearchProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_SearchProducts.Size = new System.Drawing.Size(952, 672);
            this.tbp_SearchProducts.TabIndex = 0;
            this.tbp_SearchProducts.Text = "Search products";
            this.tbp_SearchProducts.UseVisualStyleBackColor = true;
            // 
            // grb_ByDetails
            // 
            this.grb_ByDetails.Controls.Add(this.nud_ByDetailsPartNumber);
            this.grb_ByDetails.Controls.Add(this.lbl_ByDetailsDescription);
            this.grb_ByDetails.Controls.Add(this.lbl_ByDetailsPartNumber);
            this.grb_ByDetails.Controls.Add(this.nud_ByDetailsBarCode);
            this.grb_ByDetails.Controls.Add(this.lbl_ByDetailsBarCode);
            this.grb_ByDetails.Controls.Add(this.btn_SearchByDetails);
            this.grb_ByDetails.Controls.Add(this.tbx_ByDetailsDescription);
            this.grb_ByDetails.Controls.Add(this.btn_ClearByDetails);
            this.grb_ByDetails.Location = new System.Drawing.Point(8, 6);
            this.grb_ByDetails.Name = "grb_ByDetails";
            this.grb_ByDetails.Size = new System.Drawing.Size(331, 193);
            this.grb_ByDetails.TabIndex = 6;
            this.grb_ByDetails.TabStop = false;
            this.grb_ByDetails.Text = "By details";
            // 
            // nud_ByDetailsPartNumber
            // 
            this.nud_ByDetailsPartNumber.Location = new System.Drawing.Point(81, 65);
            this.nud_ByDetailsPartNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_ByDetailsPartNumber.Name = "nud_ByDetailsPartNumber";
            this.nud_ByDetailsPartNumber.Size = new System.Drawing.Size(62, 20);
            this.nud_ByDetailsPartNumber.TabIndex = 58;
            // 
            // tbp_ManageUsers
            // 
            this.tbp_ManageUsers.Controls.Add(this.grb_ManageUsers);
            this.tbp_ManageUsers.Controls.Add(this.grb_ManageUsersResult);
            this.tbp_ManageUsers.Controls.Add(this.grb_SearchUsers);
            this.tbp_ManageUsers.Location = new System.Drawing.Point(4, 22);
            this.tbp_ManageUsers.Name = "tbp_ManageUsers";
            this.tbp_ManageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ManageUsers.Size = new System.Drawing.Size(952, 672);
            this.tbp_ManageUsers.TabIndex = 1;
            this.tbp_ManageUsers.Text = "Manage users";
            this.tbp_ManageUsers.UseVisualStyleBackColor = true;
            // 
            // grb_ManageUsers
            // 
            this.grb_ManageUsers.Controls.Add(this.btn_ModifyUser);
            this.grb_ManageUsers.Controls.Add(this.btn_NewUser);
            this.grb_ManageUsers.Controls.Add(this.btn_DeleteUser);
            this.grb_ManageUsers.Location = new System.Drawing.Point(318, 6);
            this.grb_ManageUsers.Name = "grb_ManageUsers";
            this.grb_ManageUsers.Size = new System.Drawing.Size(124, 193);
            this.grb_ManageUsers.TabIndex = 24;
            this.grb_ManageUsers.TabStop = false;
            this.grb_ManageUsers.Text = "Manage";
            // 
            // btn_ModifyUser
            // 
            this.btn_ModifyUser.Location = new System.Drawing.Point(15, 60);
            this.btn_ModifyUser.Name = "btn_ModifyUser";
            this.btn_ModifyUser.Size = new System.Drawing.Size(91, 23);
            this.btn_ModifyUser.TabIndex = 1;
            this.btn_ModifyUser.Text = "Modify selected";
            this.btn_ModifyUser.UseVisualStyleBackColor = true;
            this.btn_ModifyUser.Click += new System.EventHandler(this.btn_ModifyUser_Click);
            // 
            // btn_NewUser
            // 
            this.btn_NewUser.Location = new System.Drawing.Point(15, 31);
            this.btn_NewUser.Name = "btn_NewUser";
            this.btn_NewUser.Size = new System.Drawing.Size(91, 23);
            this.btn_NewUser.TabIndex = 17;
            this.btn_NewUser.Text = "New user";
            this.btn_NewUser.UseVisualStyleBackColor = true;
            this.btn_NewUser.Click += new System.EventHandler(this.btn_NewUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(15, 89);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(91, 23);
            this.btn_DeleteUser.TabIndex = 16;
            this.btn_DeleteUser.Text = "Delete selected";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // grb_ManageUsersResult
            // 
            this.grb_ManageUsersResult.Controls.Add(this.dataGridView1);
            this.grb_ManageUsersResult.Controls.Add(this.btn_ManageUsersExport);
            this.grb_ManageUsersResult.Controls.Add(this.lsv_ManageUsers);
            this.grb_ManageUsersResult.Location = new System.Drawing.Point(8, 205);
            this.grb_ManageUsersResult.Name = "grb_ManageUsersResult";
            this.grb_ManageUsersResult.Size = new System.Drawing.Size(938, 461);
            this.grb_ManageUsersResult.TabIndex = 23;
            this.grb_ManageUsersResult.TabStop = false;
            this.grb_ManageUsersResult.Text = "Results";
            // 
            // btn_ManageUsersExport
            // 
            this.btn_ManageUsersExport.Location = new System.Drawing.Point(857, 432);
            this.btn_ManageUsersExport.Name = "btn_ManageUsersExport";
            this.btn_ManageUsersExport.Size = new System.Drawing.Size(75, 23);
            this.btn_ManageUsersExport.TabIndex = 2;
            this.btn_ManageUsersExport.Text = "Export";
            this.btn_ManageUsersExport.UseVisualStyleBackColor = true;
            this.btn_ManageUsersExport.Click += new System.EventHandler(this.btn_ManageUsersExport_Click);
            // 
            // lsv_ManageUsers
            // 
            this.lsv_ManageUsers.Location = new System.Drawing.Point(6, 19);
            this.lsv_ManageUsers.Name = "lsv_ManageUsers";
            this.lsv_ManageUsers.Size = new System.Drawing.Size(428, 407);
            this.lsv_ManageUsers.TabIndex = 1;
            this.lsv_ManageUsers.UseCompatibleStateImageBehavior = false;
            // 
            // grb_SearchUsers
            // 
            this.grb_SearchUsers.Controls.Add(this.btn_PermissionNone);
            this.grb_SearchUsers.Controls.Add(this.btn_PermissionAll);
            this.grb_SearchUsers.Controls.Add(this.btn_ClearUser);
            this.grb_SearchUsers.Controls.Add(this.chb_UserPermission);
            this.grb_SearchUsers.Controls.Add(this.lbl_PermissionSearch);
            this.grb_SearchUsers.Controls.Add(this.btn_SearchUser);
            this.grb_SearchUsers.Controls.Add(this.lbl_UsernameSearch);
            this.grb_SearchUsers.Controls.Add(this.tbx_SearchUserName);
            this.grb_SearchUsers.Location = new System.Drawing.Point(6, 6);
            this.grb_SearchUsers.Name = "grb_SearchUsers";
            this.grb_SearchUsers.Size = new System.Drawing.Size(306, 193);
            this.grb_SearchUsers.TabIndex = 21;
            this.grb_SearchUsers.TabStop = false;
            this.grb_SearchUsers.Text = "Search";
            // 
            // btn_PermissionNone
            // 
            this.btn_PermissionNone.Location = new System.Drawing.Point(9, 145);
            this.btn_PermissionNone.Name = "btn_PermissionNone";
            this.btn_PermissionNone.Size = new System.Drawing.Size(96, 23);
            this.btn_PermissionNone.TabIndex = 28;
            this.btn_PermissionNone.Text = "None";
            this.btn_PermissionNone.UseVisualStyleBackColor = true;
            this.btn_PermissionNone.Click += new System.EventHandler(this.btn_PermissionNone_Click);
            // 
            // btn_PermissionAll
            // 
            this.btn_PermissionAll.Location = new System.Drawing.Point(9, 46);
            this.btn_PermissionAll.Name = "btn_PermissionAll";
            this.btn_PermissionAll.Size = new System.Drawing.Size(96, 23);
            this.btn_PermissionAll.TabIndex = 27;
            this.btn_PermissionAll.Text = "All";
            this.btn_PermissionAll.UseVisualStyleBackColor = true;
            this.btn_PermissionAll.Click += new System.EventHandler(this.btn_PermissionAll_Click);
            // 
            // btn_ClearUser
            // 
            this.btn_ClearUser.Location = new System.Drawing.Point(214, 110);
            this.btn_ClearUser.Name = "btn_ClearUser";
            this.btn_ClearUser.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearUser.TabIndex = 22;
            this.btn_ClearUser.Text = "Clear";
            this.btn_ClearUser.UseVisualStyleBackColor = true;
            this.btn_ClearUser.Click += new System.EventHandler(this.btn_ClearUser_Click);
            // 
            // chb_UserPermission
            // 
            this.chb_UserPermission.FormattingEnabled = true;
            this.chb_UserPermission.Location = new System.Drawing.Point(9, 75);
            this.chb_UserPermission.Name = "chb_UserPermission";
            this.chb_UserPermission.Size = new System.Drawing.Size(96, 64);
            this.chb_UserPermission.TabIndex = 26;
            // 
            // lbl_PermissionSearch
            // 
            this.lbl_PermissionSearch.AutoSize = true;
            this.lbl_PermissionSearch.Location = new System.Drawing.Point(6, 31);
            this.lbl_PermissionSearch.Name = "lbl_PermissionSearch";
            this.lbl_PermissionSearch.Size = new System.Drawing.Size(60, 13);
            this.lbl_PermissionSearch.TabIndex = 21;
            this.lbl_PermissionSearch.Text = "Permission:";
            // 
            // btn_SearchUser
            // 
            this.btn_SearchUser.Location = new System.Drawing.Point(214, 151);
            this.btn_SearchUser.Name = "btn_SearchUser";
            this.btn_SearchUser.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchUser.TabIndex = 19;
            this.btn_SearchUser.Text = "Search";
            this.btn_SearchUser.UseVisualStyleBackColor = true;
            this.btn_SearchUser.Click += new System.EventHandler(this.btn_SearchUser_Click);
            // 
            // lbl_UsernameSearch
            // 
            this.lbl_UsernameSearch.AutoSize = true;
            this.lbl_UsernameSearch.Location = new System.Drawing.Point(123, 51);
            this.lbl_UsernameSearch.Name = "lbl_UsernameSearch";
            this.lbl_UsernameSearch.Size = new System.Drawing.Size(58, 13);
            this.lbl_UsernameSearch.TabIndex = 3;
            this.lbl_UsernameSearch.Text = "Username:";
            // 
            // tbx_SearchUserName
            // 
            this.tbx_SearchUserName.Location = new System.Drawing.Point(189, 48);
            this.tbx_SearchUserName.Name = "tbx_SearchUserName";
            this.tbx_SearchUserName.Size = new System.Drawing.Size(100, 20);
            this.tbx_SearchUserName.TabIndex = 7;
            // 
            // tbp_ManageProduct
            // 
            this.tbp_ManageProduct.Controls.Add(this.grb_ManageProducts);
            this.tbp_ManageProduct.Controls.Add(this.grb_SearchProducts);
            this.tbp_ManageProduct.Controls.Add(this.grb_ManageProductsResult);
            this.tbp_ManageProduct.Location = new System.Drawing.Point(4, 22);
            this.tbp_ManageProduct.Name = "tbp_ManageProduct";
            this.tbp_ManageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_ManageProduct.Size = new System.Drawing.Size(952, 672);
            this.tbp_ManageProduct.TabIndex = 2;
            this.tbp_ManageProduct.Text = "Manage products";
            this.tbp_ManageProduct.UseVisualStyleBackColor = true;
            // 
            // grb_ManageProducts
            // 
            this.grb_ManageProducts.Controls.Add(this.btn_ModifyProduct);
            this.grb_ManageProducts.Controls.Add(this.btn_NewProduct);
            this.grb_ManageProducts.Controls.Add(this.btn_DeleteProduct);
            this.grb_ManageProducts.Location = new System.Drawing.Point(350, 6);
            this.grb_ManageProducts.Name = "grb_ManageProducts";
            this.grb_ManageProducts.Size = new System.Drawing.Size(124, 193);
            this.grb_ManageProducts.TabIndex = 56;
            this.grb_ManageProducts.TabStop = false;
            this.grb_ManageProducts.Text = "Manage";
            // 
            // btn_ModifyProduct
            // 
            this.btn_ModifyProduct.Location = new System.Drawing.Point(15, 60);
            this.btn_ModifyProduct.Name = "btn_ModifyProduct";
            this.btn_ModifyProduct.Size = new System.Drawing.Size(91, 23);
            this.btn_ModifyProduct.TabIndex = 1;
            this.btn_ModifyProduct.Text = "Modify selected";
            this.btn_ModifyProduct.UseVisualStyleBackColor = true;
            // 
            // btn_NewProduct
            // 
            this.btn_NewProduct.Location = new System.Drawing.Point(15, 31);
            this.btn_NewProduct.Name = "btn_NewProduct";
            this.btn_NewProduct.Size = new System.Drawing.Size(91, 23);
            this.btn_NewProduct.TabIndex = 17;
            this.btn_NewProduct.Text = "New product";
            this.btn_NewProduct.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Location = new System.Drawing.Point(15, 89);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(91, 23);
            this.btn_DeleteProduct.TabIndex = 16;
            this.btn_DeleteProduct.Text = "Delete selected";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            // 
            // grb_SearchProducts
            // 
            this.grb_SearchProducts.Controls.Add(this.nud_ManagePartNumber);
            this.grb_SearchProducts.Controls.Add(this.lbl_ManageDescription);
            this.grb_SearchProducts.Controls.Add(this.lbl_ManagePartNumber);
            this.grb_SearchProducts.Controls.Add(this.nud_ManageBarCode);
            this.grb_SearchProducts.Controls.Add(this.lbl_ManageBarCode);
            this.grb_SearchProducts.Controls.Add(this.btn_SearchProduct);
            this.grb_SearchProducts.Controls.Add(this.tbx_ManageDescription);
            this.grb_SearchProducts.Controls.Add(this.btn_ClearProduct);
            this.grb_SearchProducts.Location = new System.Drawing.Point(8, 6);
            this.grb_SearchProducts.Name = "grb_SearchProducts";
            this.grb_SearchProducts.Size = new System.Drawing.Size(336, 193);
            this.grb_SearchProducts.TabIndex = 55;
            this.grb_SearchProducts.TabStop = false;
            this.grb_SearchProducts.Text = "Search";
            // 
            // nud_ManagePartNumber
            // 
            this.nud_ManagePartNumber.Location = new System.Drawing.Point(81, 65);
            this.nud_ManagePartNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_ManagePartNumber.Name = "nud_ManagePartNumber";
            this.nud_ManagePartNumber.Size = new System.Drawing.Size(62, 20);
            this.nud_ManagePartNumber.TabIndex = 58;
            // 
            // lbl_ManageDescription
            // 
            this.lbl_ManageDescription.AutoSize = true;
            this.lbl_ManageDescription.Location = new System.Drawing.Point(6, 42);
            this.lbl_ManageDescription.Name = "lbl_ManageDescription";
            this.lbl_ManageDescription.Size = new System.Drawing.Size(63, 13);
            this.lbl_ManageDescription.TabIndex = 1;
            this.lbl_ManageDescription.Text = "Description:";
            // 
            // lbl_ManagePartNumber
            // 
            this.lbl_ManagePartNumber.AutoSize = true;
            this.lbl_ManagePartNumber.Location = new System.Drawing.Point(6, 67);
            this.lbl_ManagePartNumber.Name = "lbl_ManagePartNumber";
            this.lbl_ManagePartNumber.Size = new System.Drawing.Size(69, 13);
            this.lbl_ManagePartNumber.TabIndex = 0;
            this.lbl_ManagePartNumber.Text = "Part Number:";
            // 
            // nud_ManageBarCode
            // 
            this.nud_ManageBarCode.Location = new System.Drawing.Point(81, 91);
            this.nud_ManageBarCode.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_ManageBarCode.Name = "nud_ManageBarCode";
            this.nud_ManageBarCode.Size = new System.Drawing.Size(62, 20);
            this.nud_ManageBarCode.TabIndex = 55;
            // 
            // lbl_ManageBarCode
            // 
            this.lbl_ManageBarCode.AutoSize = true;
            this.lbl_ManageBarCode.Location = new System.Drawing.Point(6, 93);
            this.lbl_ManageBarCode.Name = "lbl_ManageBarCode";
            this.lbl_ManageBarCode.Size = new System.Drawing.Size(54, 13);
            this.lbl_ManageBarCode.TabIndex = 6;
            this.lbl_ManageBarCode.Text = "Bar Code:";
            // 
            // btn_SearchProduct
            // 
            this.btn_SearchProduct.Location = new System.Drawing.Point(244, 151);
            this.btn_SearchProduct.Name = "btn_SearchProduct";
            this.btn_SearchProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchProduct.TabIndex = 16;
            this.btn_SearchProduct.Text = "Search";
            this.btn_SearchProduct.UseVisualStyleBackColor = true;
            this.btn_SearchProduct.Click += new System.EventHandler(this.btn_SearchProduct_Click);
            // 
            // tbx_ManageDescription
            // 
            this.tbx_ManageDescription.Location = new System.Drawing.Point(81, 39);
            this.tbx_ManageDescription.Name = "tbx_ManageDescription";
            this.tbx_ManageDescription.Size = new System.Drawing.Size(238, 20);
            this.tbx_ManageDescription.TabIndex = 22;
            // 
            // btn_ClearProduct
            // 
            this.btn_ClearProduct.Location = new System.Drawing.Point(244, 111);
            this.btn_ClearProduct.Name = "btn_ClearProduct";
            this.btn_ClearProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearProduct.TabIndex = 41;
            this.btn_ClearProduct.Text = "Clear";
            this.btn_ClearProduct.UseVisualStyleBackColor = true;
            this.btn_ClearProduct.Click += new System.EventHandler(this.btn_ClearProduct_Click);
            // 
            // grb_ManageProductsResult
            // 
            this.grb_ManageProductsResult.Controls.Add(this.btn_ManageProductsExport);
            this.grb_ManageProductsResult.Controls.Add(this.lsv_ManageProducts);
            this.grb_ManageProductsResult.Location = new System.Drawing.Point(8, 205);
            this.grb_ManageProductsResult.Name = "grb_ManageProductsResult";
            this.grb_ManageProductsResult.Size = new System.Drawing.Size(938, 461);
            this.grb_ManageProductsResult.TabIndex = 54;
            this.grb_ManageProductsResult.TabStop = false;
            this.grb_ManageProductsResult.Text = "Results";
            // 
            // btn_ManageProductsExport
            // 
            this.btn_ManageProductsExport.Location = new System.Drawing.Point(857, 432);
            this.btn_ManageProductsExport.Name = "btn_ManageProductsExport";
            this.btn_ManageProductsExport.Size = new System.Drawing.Size(75, 23);
            this.btn_ManageProductsExport.TabIndex = 1;
            this.btn_ManageProductsExport.Text = "Export";
            this.btn_ManageProductsExport.UseVisualStyleBackColor = true;
            this.btn_ManageProductsExport.Click += new System.EventHandler(this.btn_ManageProductsExport_Click);
            // 
            // lsv_ManageProducts
            // 
            this.lsv_ManageProducts.Location = new System.Drawing.Point(6, 19);
            this.lsv_ManageProducts.Name = "lsv_ManageProducts";
            this.lsv_ManageProducts.Size = new System.Drawing.Size(926, 407);
            this.lsv_ManageProducts.TabIndex = 0;
            this.lsv_ManageProducts.UseCompatibleStateImageBehavior = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 740);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(984, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(440, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 407);
            this.dataGridView1.TabIndex = 3;
            // 
            // MainSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search - SajtBázis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainSearch_FormClosing);
            this.Load += new System.EventHandler(this.MainSearch_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grb_ByList.ResumeLayout(false);
            this.grb_ByList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ByDetailsBarCode)).EndInit();
            this.grb_SearchProductsResults.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbp_SearchProducts.ResumeLayout(false);
            this.grb_ByDetails.ResumeLayout(false);
            this.grb_ByDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ByDetailsPartNumber)).EndInit();
            this.tbp_ManageUsers.ResumeLayout(false);
            this.grb_ManageUsers.ResumeLayout(false);
            this.grb_ManageUsersResult.ResumeLayout(false);
            this.grb_SearchUsers.ResumeLayout(false);
            this.grb_SearchUsers.PerformLayout();
            this.tbp_ManageProduct.ResumeLayout(false);
            this.grb_ManageProducts.ResumeLayout(false);
            this.grb_SearchProducts.ResumeLayout(false);
            this.grb_SearchProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ManagePartNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ManageBarCode)).EndInit();
            this.grb_ManageProductsResult.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox grb_ByList;
        private System.Windows.Forms.Label lbl_ByDetailsBarCode;
        private System.Windows.Forms.Label lbl_Factory;
        private System.Windows.Forms.Label lbl_ByDetailsDescription;
        private System.Windows.Forms.Label lbl_ByDetailsPartNumber;
        private System.Windows.Forms.TextBox tbx_ByDetailsDescription;
        private System.Windows.Forms.Button btn_SearchByDetails;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox grb_SearchProductsResults;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Market;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbp_SearchProducts;
        private System.Windows.Forms.TabPage tbp_ManageUsers;
        private System.Windows.Forms.TabPage tbp_ManageProduct;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grb_ManageUsersResult;
        private System.Windows.Forms.Button btn_ModifyUser;
        private System.Windows.Forms.Button btn_NewUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.GroupBox grb_SearchUsers;
        private System.Windows.Forms.Label lbl_PermissionSearch;
        private System.Windows.Forms.Button btn_SearchUser;
        private System.Windows.Forms.Label lbl_UsernameSearch;
        private System.Windows.Forms.TextBox tbx_SearchUserName;
        private System.Windows.Forms.GroupBox grb_ManageUsers;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckedListBox chb_Factory;
        private System.Windows.Forms.CheckedListBox chb_Type;
        private System.Windows.Forms.CheckedListBox chb_Brand;
        private System.Windows.Forms.CheckedListBox chb_Market;
        private System.Windows.Forms.GroupBox grb_ManageProductsResult;
        private System.Windows.Forms.ToolStripMenuItem viewhelptoolStripMenuItem;
        private System.Windows.Forms.ListView lsv_ManageUsers;
        private System.Windows.Forms.ListView lsv_SearchProducts;
        private System.Windows.Forms.Button btn_ClearByDetails;
        private System.Windows.Forms.ToolStripMenuItem reloadProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realoadAllToolStripMenuItem;
        private System.Windows.Forms.Button btn_FactoryNone;
        private System.Windows.Forms.Button btn_MarketNone;
        private System.Windows.Forms.Button btn_BrandNone;
        private System.Windows.Forms.Button btn_TypeNone;
        private System.Windows.Forms.Button btn_FactoryAll;
        private System.Windows.Forms.Button btn_MarketAll;
        private System.Windows.Forms.Button btn_BrandAll;
        private System.Windows.Forms.Button btn_TypeAll;
        private System.Windows.Forms.Button btn_ClearUser;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckedListBox chb_UserPermission;
        private System.Windows.Forms.NumericUpDown nud_ByDetailsBarCode;
        private System.Windows.Forms.Button btn_PermissionNone;
        private System.Windows.Forms.Button btn_PermissionAll;
        private System.Windows.Forms.ListView lsv_ManageProducts;
        private System.Windows.Forms.Button btn_ClearByList;
        private System.Windows.Forms.Button btn_SearchByList;
        private System.Windows.Forms.Button btn_SearchProductsExport;
        private System.Windows.Forms.GroupBox grb_ByDetails;
        private System.Windows.Forms.NumericUpDown nud_ByDetailsPartNumber;
        private System.Windows.Forms.Button btn_ManageUsersExport;
        private System.Windows.Forms.GroupBox grb_ManageProducts;
        private System.Windows.Forms.Button btn_ModifyProduct;
        private System.Windows.Forms.Button btn_NewProduct;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.GroupBox grb_SearchProducts;
        private System.Windows.Forms.NumericUpDown nud_ManagePartNumber;
        private System.Windows.Forms.Label lbl_ManageDescription;
        private System.Windows.Forms.Label lbl_ManagePartNumber;
        private System.Windows.Forms.NumericUpDown nud_ManageBarCode;
        private System.Windows.Forms.Label lbl_ManageBarCode;
        private System.Windows.Forms.Button btn_SearchProduct;
        private System.Windows.Forms.TextBox tbx_ManageDescription;
        private System.Windows.Forms.Button btn_ClearProduct;
        private System.Windows.Forms.Button btn_ManageProductsExport;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}