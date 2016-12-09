using SajtBazis_WinForms.Classes;
using SajtBazis_WinForms.Database;
using System;
using System.Windows.Forms;

namespace SajtBazis_WinForms.Forms
{
    public partial class ProductNew : Form
    {
        Products selectedProduct;
        internal Products SelectedProduct
        {
            get { return selectedProduct; }
            //set { selectedProduct = value; }
        }

        public ProductNew()
        {
            InitializeComponent();
            cmb_Brand.DataSource = Enum.GetValues(typeof(Brands));
            cmb_Market.DataSource = Enum.GetValues(typeof(Markets));
            cmb_Type.DataSource = Enum.GetValues(typeof(Types));
            cmb_Factory.DataSource = Enum.GetValues(typeof(Factories));
        }

        internal ProductNew(Products modify)
        {
            InitializeComponent();
            selectedProduct = modify;
            nud_PartNumber.Value = modify.PartNumber;
            tbx_Description.Text = modify.Description;
            cmb_Brand.DataSource = Enum.GetValues(typeof(Brands));
            cmb_Market.DataSource = Enum.GetValues(typeof(Markets));
            cmb_Factory.DataSource = Enum.GetValues(typeof(Factories));
            cmb_Type.DataSource = Enum.GetValues(typeof(Types));
            cmb_Brand.SelectedIndex = (int)modify.Brand;
            cmb_Market.SelectedIndex = (int)modify.Market;
            cmb_Factory.SelectedIndex = (int)modify.Factory;
            cmb_Type.SelectedIndex = (int)modify.Type;
            nud_BarCode.Value = modify.BarCode;
            nud_Width.Value = modify.Width;
            nud_Heigth.Value = modify.Height;
            nud_Length.Value = modify.Length;
            nud_Pieces.Value = modify.Pieces;
            nud_Temperature.Value = modify.Temperature;
            nud_PartNumber.Enabled = false;

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (nud_PartNumber.Value != 0 && tbx_Description.Text.Trim() != string.Empty && nud_BarCode.Value != 0 && nud_Heigth.Value != 0 && nud_Length.Value != 0 && nud_Width.Value != 0  && nud_Temperature.Value != 0)
                {
                    if (selectedProduct == null)
                    {
                        selectedProduct = new Products((int)nud_PartNumber.Value, tbx_Description.Text.Trim(), (Brands)cmb_Brand.SelectedIndex, (Markets)cmb_Market.SelectedIndex, (Factories)cmb_Factory.SelectedIndex, (Types)cmb_Type.SelectedIndex, (int)nud_BarCode.Value, (int)nud_Width.Value, (int)nud_Heigth.Value, (int)nud_Length.Value, (int)nud_Pieces.Value, (int)nud_Temperature.Value); DatabaseManager.ProductNew(selectedProduct);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        selectedProduct.PartNumber = (int)nud_PartNumber.Value;
                        selectedProduct.Description = tbx_Description.Text;
                        
                        selectedProduct.BarCode = (int)nud_BarCode.Value;
                        selectedProduct.Width = (int)nud_Width.Value;
                        selectedProduct.Height = (int)nud_Heigth.Value;
                        selectedProduct.Length = (int)nud_Length.Value;
                        selectedProduct.Pieces = (int)nud_Pieces.Value;
                        selectedProduct.Temperature = (int)nud_Temperature.Value;
                        selectedProduct.Brand = (Brands)cmb_Brand.SelectedIndex;
                        selectedProduct.Type = (Types)cmb_Type.SelectedIndex;
                        selectedProduct.Factory = (Factories)cmb_Factory.SelectedIndex;
                        selectedProduct.Market = (Markets)cmb_Market.SelectedIndex;
                        DatabaseManager.ProductModify(selectedProduct);
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    tsl_ManageProduct.Text = "Please fill out all the required fields!";
                }
            }
            catch (DatabaseException ex)
            {
                tsl_ManageProduct.Text = "Error: " + ex.Message;
                DialogResult = DialogResult.None;
            }
        }
    }
}
