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
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_Search = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.cmb_Brand = new System.Windows.Forms.ComboBox();
            this.cmb_Market = new System.Windows.Forms.ComboBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.lbl_Market = new System.Windows.Forms.Label();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.txb_BarCode = new System.Windows.Forms.TextBox();
            this.cmb_Factory = new System.Windows.Forms.ComboBox();
            this.cmb_Category = new System.Windows.Forms.ComboBox();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.tbx_PartNumber = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_BarCode = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_PartNumber = new System.Windows.Forms.Label();
            this.grb_Results = new System.Windows.Forms.GroupBox();
            this.btn_ShowData = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grb_Search.SuspendLayout();
            this.grb_Results.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
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
            this.usersToolStripMenuItem,
            this.productsToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // grb_Search
            // 
            this.grb_Search.Controls.Add(this.label1);
            this.grb_Search.Controls.Add(this.cmb_Type);
            this.grb_Search.Controls.Add(this.cmb_Brand);
            this.grb_Search.Controls.Add(this.cmb_Market);
            this.grb_Search.Controls.Add(this.lbl_Type);
            this.grb_Search.Controls.Add(this.lbl_Market);
            this.grb_Search.Controls.Add(this.lbl_Brand);
            this.grb_Search.Controls.Add(this.txb_BarCode);
            this.grb_Search.Controls.Add(this.cmb_Factory);
            this.grb_Search.Controls.Add(this.cmb_Category);
            this.grb_Search.Controls.Add(this.txb_Description);
            this.grb_Search.Controls.Add(this.tbx_PartNumber);
            this.grb_Search.Controls.Add(this.btn_Search);
            this.grb_Search.Controls.Add(this.lbl_BarCode);
            this.grb_Search.Controls.Add(this.lbl_Factory);
            this.grb_Search.Controls.Add(this.lbl_Category);
            this.grb_Search.Controls.Add(this.lbl_Description);
            this.grb_Search.Controls.Add(this.lbl_PartNumber);
            this.grb_Search.Location = new System.Drawing.Point(12, 27);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.Size = new System.Drawing.Size(860, 109);
            this.grb_Search.TabIndex = 1;
            this.grb_Search.TabStop = false;
            this.grb_Search.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "The search returned xy results.";
            // 
            // cmb_Type
            // 
            this.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Location = new System.Drawing.Point(733, 22);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(121, 21);
            this.cmb_Type.TabIndex = 33;
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.Location = new System.Drawing.Point(733, 48);
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(121, 21);
            this.cmb_Brand.TabIndex = 32;
            // 
            // cmb_Market
            // 
            this.cmb_Market.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Market.FormattingEnabled = true;
            this.cmb_Market.Location = new System.Drawing.Point(557, 21);
            this.cmb_Market.Name = "cmb_Market";
            this.cmb_Market.Size = new System.Drawing.Size(121, 21);
            this.cmb_Market.TabIndex = 31;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(684, 25);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(34, 13);
            this.lbl_Type.TabIndex = 30;
            this.lbl_Type.Text = "Type:";
            // 
            // lbl_Market
            // 
            this.lbl_Market.AutoSize = true;
            this.lbl_Market.Location = new System.Drawing.Point(508, 25);
            this.lbl_Market.Name = "lbl_Market";
            this.lbl_Market.Size = new System.Drawing.Size(43, 13);
            this.lbl_Market.TabIndex = 29;
            this.lbl_Market.Text = "Market:";
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Location = new System.Drawing.Point(684, 51);
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
            // cmb_Factory
            // 
            this.cmb_Factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Factory.FormattingEnabled = true;
            this.cmb_Factory.Location = new System.Drawing.Point(557, 48);
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.Size = new System.Drawing.Size(121, 21);
            this.cmb_Factory.TabIndex = 24;
            // 
            // cmb_Category
            // 
            this.cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category.FormattingEnabled = true;
            this.cmb_Category.Location = new System.Drawing.Point(368, 48);
            this.cmb_Category.Name = "cmb_Category";
            this.cmb_Category.Size = new System.Drawing.Size(134, 21);
            this.cmb_Category.TabIndex = 23;
            // 
            // txb_Description
            // 
            this.txb_Description.Location = new System.Drawing.Point(236, 22);
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(266, 20);
            this.txb_Description.TabIndex = 22;
            // 
            // tbx_PartNumber
            // 
            this.tbx_PartNumber.Location = new System.Drawing.Point(81, 22);
            this.tbx_PartNumber.Name = "tbx_PartNumber";
            this.tbx_PartNumber.Size = new System.Drawing.Size(80, 20);
            this.tbx_PartNumber.TabIndex = 21;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(779, 75);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
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
            this.lbl_Factory.Location = new System.Drawing.Point(508, 51);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(45, 13);
            this.lbl_Factory.TabIndex = 5;
            this.lbl_Factory.Text = "Factory:";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(310, 51);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(52, 13);
            this.lbl_Category.TabIndex = 3;
            this.lbl_Category.Text = "Category:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(167, 25);
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
            this.grb_Results.Controls.Add(this.btn_ShowData);
            this.grb_Results.Controls.Add(this.listBox1);
            this.grb_Results.Location = new System.Drawing.Point(12, 153);
            this.grb_Results.Name = "grb_Results";
            this.grb_Results.Size = new System.Drawing.Size(860, 496);
            this.grb_Results.TabIndex = 5;
            this.grb_Results.TabStop = false;
            this.grb_Results.Text = "Results";
            // 
            // btn_ShowData
            // 
            this.btn_ShowData.Location = new System.Drawing.Point(779, 19);
            this.btn_ShowData.Name = "btn_ShowData";
            this.btn_ShowData.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowData.TabIndex = 4;
            this.btn_ShowData.Text = "Show Data";
            this.btn_ShowData.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(848, 433);
            this.listBox1.TabIndex = 3;
            // 
            // MainSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.grb_Results);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search - SajtBázis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainSearch_FormClosing);
            this.Load += new System.EventHandler(this.MainSearch_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grb_Search.ResumeLayout(false);
            this.grb_Search.PerformLayout();
            this.grb_Results.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox grb_Search;
        private System.Windows.Forms.Label lbl_BarCode;
        private System.Windows.Forms.Label lbl_Factory;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_PartNumber;
        private System.Windows.Forms.TextBox txb_BarCode;
        private System.Windows.Forms.ComboBox cmb_Factory;
        private System.Windows.Forms.ComboBox cmb_Category;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.TextBox tbx_PartNumber;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox grb_Results;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.ComboBox cmb_Brand;
        private System.Windows.Forms.ComboBox cmb_Market;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label lbl_Market;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Button btn_ShowData;
        private System.Windows.Forms.Label label1;
    }
}