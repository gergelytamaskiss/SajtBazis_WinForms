namespace SajtBazis_WinForms.Forms
{
    partial class ProductNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductNew));
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Brand = new System.Windows.Forms.Label();
            this.lbl_PartNumber = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.cmb_Brand = new System.Windows.Forms.ComboBox();
            this.tbx_Description = new System.Windows.Forms.TextBox();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.lbl_Market = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsl_ManageProduct = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmb_Market = new System.Windows.Forms.ComboBox();
            this.cmb_Factory = new System.Windows.Forms.ComboBox();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.nud_PartNumber = new System.Windows.Forms.NumericUpDown();
            this.nud_BarCode = new System.Windows.Forms.NumericUpDown();
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.nud_Heigth = new System.Windows.Forms.NumericUpDown();
            this.lbl_BarCode = new System.Windows.Forms.Label();
            this.nud_Length = new System.Windows.Forms.NumericUpDown();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.lbl_Heigth = new System.Windows.Forms.Label();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.lbl_Pieces = new System.Windows.Forms.Label();
            this.nud_Pieces = new System.Windows.Forms.NumericUpDown();
            this.nud_Temperature = new System.Windows.Forms.NumericUpDown();
            this.lbl_Temperature = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PartNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Heigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pieces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Temperature)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(555, 154);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 0;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(651, 154);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lbl_Brand
            // 
            this.lbl_Brand.AutoSize = true;
            this.lbl_Brand.Location = new System.Drawing.Point(547, 25);
            this.lbl_Brand.Name = "lbl_Brand";
            this.lbl_Brand.Size = new System.Drawing.Size(38, 13);
            this.lbl_Brand.TabIndex = 36;
            this.lbl_Brand.Text = "Brand:";
            // 
            // lbl_PartNumber
            // 
            this.lbl_PartNumber.AutoSize = true;
            this.lbl_PartNumber.Location = new System.Drawing.Point(16, 51);
            this.lbl_PartNumber.Name = "lbl_PartNumber";
            this.lbl_PartNumber.Size = new System.Drawing.Size(67, 13);
            this.lbl_PartNumber.TabIndex = 28;
            this.lbl_PartNumber.Text = "Part number:";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(16, 25);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(63, 13);
            this.lbl_Description.TabIndex = 29;
            this.lbl_Description.Text = "Description:";
            // 
            // cmb_Brand
            // 
            this.cmb_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Brand.FormattingEnabled = true;
            this.cmb_Brand.Location = new System.Drawing.Point(591, 21);
            this.cmb_Brand.Name = "cmb_Brand";
            this.cmb_Brand.Size = new System.Drawing.Size(135, 21);
            this.cmb_Brand.TabIndex = 35;
            // 
            // tbx_Description
            // 
            this.tbx_Description.Location = new System.Drawing.Point(89, 22);
            this.tbx_Description.Name = "tbx_Description";
            this.tbx_Description.Size = new System.Drawing.Size(260, 20);
            this.tbx_Description.TabIndex = 31;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.AutoSize = true;
            this.lbl_Factory.Location = new System.Drawing.Point(540, 78);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(45, 13);
            this.lbl_Factory.TabIndex = 34;
            this.lbl_Factory.Text = "Factory:";
            // 
            // lbl_Market
            // 
            this.lbl_Market.AutoSize = true;
            this.lbl_Market.Location = new System.Drawing.Point(542, 51);
            this.lbl_Market.Name = "lbl_Market";
            this.lbl_Market.Size = new System.Drawing.Size(43, 13);
            this.lbl_Market.TabIndex = 33;
            this.lbl_Market.Text = "Market:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl_ManageProduct});
            this.statusStrip1.Location = new System.Drawing.Point(0, 196);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsl_ManageProduct
            // 
            this.tsl_ManageProduct.Name = "tsl_ManageProduct";
            this.tsl_ManageProduct.Size = new System.Drawing.Size(0, 17);
            // 
            // cmb_Market
            // 
            this.cmb_Market.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Market.FormattingEnabled = true;
            this.cmb_Market.Location = new System.Drawing.Point(591, 48);
            this.cmb_Market.Name = "cmb_Market";
            this.cmb_Market.Size = new System.Drawing.Size(135, 21);
            this.cmb_Market.TabIndex = 39;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Factory.FormattingEnabled = true;
            this.cmb_Factory.Location = new System.Drawing.Point(591, 75);
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.Size = new System.Drawing.Size(135, 21);
            this.cmb_Factory.TabIndex = 40;
            // 
            // cmb_Type
            // 
            this.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Location = new System.Drawing.Point(591, 102);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(135, 21);
            this.cmb_Type.TabIndex = 42;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Location = new System.Drawing.Point(551, 105);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(34, 13);
            this.lbl_Type.TabIndex = 41;
            this.lbl_Type.Text = "Type:";
            // 
            // nud_PartNumber
            // 
            this.nud_PartNumber.Location = new System.Drawing.Point(89, 49);
            this.nud_PartNumber.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_PartNumber.Name = "nud_PartNumber";
            this.nud_PartNumber.Size = new System.Drawing.Size(84, 20);
            this.nud_PartNumber.TabIndex = 43;
            // 
            // nud_BarCode
            // 
            this.nud_BarCode.Location = new System.Drawing.Point(89, 75);
            this.nud_BarCode.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_BarCode.Name = "nud_BarCode";
            this.nud_BarCode.Size = new System.Drawing.Size(84, 20);
            this.nud_BarCode.TabIndex = 44;
            // 
            // nud_Width
            // 
            this.nud_Width.Location = new System.Drawing.Point(427, 75);
            this.nud_Width.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(84, 20);
            this.nud_Width.TabIndex = 45;
            // 
            // nud_Heigth
            // 
            this.nud_Heigth.Location = new System.Drawing.Point(427, 23);
            this.nud_Heigth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Heigth.Name = "nud_Heigth";
            this.nud_Heigth.Size = new System.Drawing.Size(84, 20);
            this.nud_Heigth.TabIndex = 46;
            // 
            // lbl_BarCode
            // 
            this.lbl_BarCode.AutoSize = true;
            this.lbl_BarCode.Location = new System.Drawing.Point(16, 78);
            this.lbl_BarCode.Name = "lbl_BarCode";
            this.lbl_BarCode.Size = new System.Drawing.Size(53, 13);
            this.lbl_BarCode.TabIndex = 47;
            this.lbl_BarCode.Text = "Bar code:";
            // 
            // nud_Length
            // 
            this.nud_Length.Location = new System.Drawing.Point(427, 49);
            this.nud_Length.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_Length.Name = "nud_Length";
            this.nud_Length.Size = new System.Drawing.Size(84, 20);
            this.nud_Length.TabIndex = 48;
            // 
            // lbl_Width
            // 
            this.lbl_Width.AutoSize = true;
            this.lbl_Width.Location = new System.Drawing.Point(378, 77);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(38, 13);
            this.lbl_Width.TabIndex = 49;
            this.lbl_Width.Text = "Width:";
            // 
            // lbl_Heigth
            // 
            this.lbl_Heigth.AutoSize = true;
            this.lbl_Heigth.Location = new System.Drawing.Point(378, 25);
            this.lbl_Heigth.Name = "lbl_Heigth";
            this.lbl_Heigth.Size = new System.Drawing.Size(41, 13);
            this.lbl_Heigth.TabIndex = 50;
            this.lbl_Heigth.Text = "Heigth:";
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(378, 51);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(43, 13);
            this.lbl_Length.TabIndex = 51;
            this.lbl_Length.Text = "Length:";
            // 
            // lbl_Pieces
            // 
            this.lbl_Pieces.AutoSize = true;
            this.lbl_Pieces.Location = new System.Drawing.Point(189, 77);
            this.lbl_Pieces.Name = "lbl_Pieces";
            this.lbl_Pieces.Size = new System.Drawing.Size(42, 13);
            this.lbl_Pieces.TabIndex = 52;
            this.lbl_Pieces.Text = "Pieces:";
            // 
            // nud_Pieces
            // 
            this.nud_Pieces.Location = new System.Drawing.Point(265, 75);
            this.nud_Pieces.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_Pieces.Name = "nud_Pieces";
            this.nud_Pieces.Size = new System.Drawing.Size(84, 20);
            this.nud_Pieces.TabIndex = 53;
            // 
            // nud_Temperature
            // 
            this.nud_Temperature.Location = new System.Drawing.Point(265, 48);
            this.nud_Temperature.Name = "nud_Temperature";
            this.nud_Temperature.Size = new System.Drawing.Size(84, 20);
            this.nud_Temperature.TabIndex = 54;
            // 
            // lbl_Temperature
            // 
            this.lbl_Temperature.AutoSize = true;
            this.lbl_Temperature.Location = new System.Drawing.Point(189, 51);
            this.lbl_Temperature.Name = "lbl_Temperature";
            this.lbl_Temperature.Size = new System.Drawing.Size(70, 13);
            this.lbl_Temperature.TabIndex = 55;
            this.lbl_Temperature.Text = "Temperature:";
            // 
            // ProductNew
            // 
            this.AcceptButton = this.btn_Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(748, 218);
            this.Controls.Add(this.lbl_Temperature);
            this.Controls.Add(this.nud_Temperature);
            this.Controls.Add(this.nud_Pieces);
            this.Controls.Add(this.lbl_Pieces);
            this.Controls.Add(this.lbl_Length);
            this.Controls.Add(this.lbl_Heigth);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.nud_Length);
            this.Controls.Add(this.lbl_BarCode);
            this.Controls.Add(this.nud_Heigth);
            this.Controls.Add(this.nud_Width);
            this.Controls.Add(this.nud_BarCode);
            this.Controls.Add(this.nud_PartNumber);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.cmb_Factory);
            this.Controls.Add(this.cmb_Market);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_Brand);
            this.Controls.Add(this.lbl_PartNumber);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.cmb_Brand);
            this.Controls.Add(this.tbx_Description);
            this.Controls.Add(this.lbl_Factory);
            this.Controls.Add(this.lbl_Market);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage product";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PartNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_BarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Heigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Pieces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Temperature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Brand;
        private System.Windows.Forms.Label lbl_PartNumber;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.ComboBox cmb_Brand;
        private System.Windows.Forms.TextBox tbx_Description;
        private System.Windows.Forms.Label lbl_Factory;
        private System.Windows.Forms.Label lbl_Market;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsl_ManageProduct;
        private System.Windows.Forms.ComboBox cmb_Market;
        private System.Windows.Forms.ComboBox cmb_Factory;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.NumericUpDown nud_PartNumber;
        private System.Windows.Forms.NumericUpDown nud_BarCode;
        private System.Windows.Forms.NumericUpDown nud_Width;
        private System.Windows.Forms.NumericUpDown nud_Heigth;
        private System.Windows.Forms.Label lbl_BarCode;
        private System.Windows.Forms.NumericUpDown nud_Length;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.Label lbl_Heigth;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.Label lbl_Pieces;
        private System.Windows.Forms.NumericUpDown nud_Pieces;
        private System.Windows.Forms.NumericUpDown nud_Temperature;
        private System.Windows.Forms.Label lbl_Temperature;
    }
}