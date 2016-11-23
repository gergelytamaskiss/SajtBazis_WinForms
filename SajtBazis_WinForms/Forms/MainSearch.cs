using SajtBazis_WinForms.Classes;
using SajtBazis_WinForms.Forms;
using System;
using System.Windows.Forms;
using SajtBazis_WinForms.Database;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;

namespace SajtBazis_WinForms
{
    public partial class MainSearch : Form
    {
        public MainSearch()
        {
            InitializeComponent();

        }

        private void MainSearch_Load(object sender, EventArgs e)
        {
            //PRODUCTS TAB
            chb_Type.DataSource = Enum.GetValues(typeof(Types));
            chb_Brand.DataSource = Enum.GetValues(typeof(Brands));
            chb_Market.DataSource = Enum.GetValues(typeof(Markets));
            chb_Factory.DataSource = Enum.GetValues(typeof(Factories));

            //ResetCheckedListBoxes();
            ButtonsEnabled();

            lsv_ProductsSearch.GridLines = true;
            lsv_ProductsSearch.View = View.Details;
            lsv_ProductsSearch.FullRowSelect = true;
            lsv_ProductsSearch.Columns.Add("ID", 30);
            lsv_ProductsSearch.Columns.Add("Part number", 40);
            lsv_ProductsSearch.Columns.Add("Description", 220);
            lsv_ProductsSearch.Columns.Add("Brand", 80);
            lsv_ProductsSearch.Columns.Add("Market", 50);
            lsv_ProductsSearch.Columns.Add("Factory", 80);
            lsv_ProductsSearch.Columns.Add("Type", 50);
            lsv_ProductsSearch.Columns.Add("Barcode", 60);
            lsv_ProductsSearch.Columns.Add("Width", 50);
            lsv_ProductsSearch.Columns.Add("Heigth", 50);
            lsv_ProductsSearch.Columns.Add("Length", 50);
            lsv_ProductsSearch.Columns.Add("Pieces", 50);
            lsv_ProductsSearch.Columns.Add("Temperature", 80);

            LsvProductsRefresh();

            //USERS TAB
            chb_UserPermission.DataSource = Enum.GetValues(typeof(Permissions));
            for (int i = 0; i < chb_UserPermission.Items.Count; i++)
            {
                chb_UserPermission.SetItemChecked(i, true);
            }

            lsv_Users.GridLines = true;
            lsv_Users.View = View.Details;
            lsv_Users.FullRowSelect = true;
            lsv_Users.Columns.Add("ID", 30);
            lsv_Users.Columns.Add("Username", 100);
            lsv_Users.Columns.Add("Password", 100);
            lsv_Users.Columns.Add("Name", 130);
            lsv_Users.Columns.Add("Permission", 100);
            lsv_Users.Columns.Add("Email", 180);

            LsvUsersRefresh();

            //PRODUCT MAINTENANCE TAB
            lsv_ProductsMaintenance.GridLines = true;
            lsv_ProductsMaintenance.View = View.Details;
            lsv_ProductsMaintenance.FullRowSelect = true;
            lsv_ProductsMaintenance.Columns.Add("ID", 30);
            lsv_ProductsMaintenance.Columns.Add("Part number", 40);
            lsv_ProductsMaintenance.Columns.Add("Description", 220);
            lsv_ProductsMaintenance.Columns.Add("Brand", 80);
            lsv_ProductsMaintenance.Columns.Add("Market", 50);
            lsv_ProductsMaintenance.Columns.Add("Factory", 80);
            lsv_ProductsMaintenance.Columns.Add("Type", 50);
            lsv_ProductsMaintenance.Columns.Add("Barcode", 60);
            lsv_ProductsMaintenance.Columns.Add("Width", 50);
            lsv_ProductsMaintenance.Columns.Add("Heigth", 50);
            lsv_ProductsMaintenance.Columns.Add("Length", 50);
            lsv_ProductsMaintenance.Columns.Add("Pieces", 50);
            lsv_ProductsMaintenance.Columns.Add("Temperature", 80);

            LsvProductsRefresh();
            LsvProductsMaintenanceRefresh();
        }


        private void MainSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }

        #region MENUSTRIP       
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutwindow = new About();
            aboutwindow.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reloadProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LsvProductsRefresh();
                LsvProductsMaintenanceRefresh();
                toolStripStatusLabel2.Text = "Products table(s) refreshed!";
            }
            catch (Exception)
            {
                toolStripStatusLabel2.Text = "Error:";
            }

        }

        private void reloadUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LsvUsersRefresh();
                toolStripStatusLabel2.Text = "Users table refreshed!";
            }
            catch (Exception)
            {
                toolStripStatusLabel2.Text = "Error:";
            }

        }

        private void realoadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LsvProductsRefresh();
                LsvUsersRefresh();
                toolStripStatusLabel2.Text = "All table refreshed!";
            }
            catch (Exception)
            {
                toolStripStatusLabel2.Text = "Error:";
            }

        }
        #endregion

        #region CheckedListBoxes
        //CHECKEDLISTBOXES PRODUCTS TAB

        public void ResetCheckedListBoxes()
        {
            for (int i = 0; i < chb_Type.Items.Count; i++)
            {
                chb_Type.SetItemChecked(i, true);
            }

            for (int i = 0; i < chb_Brand.Items.Count; i++)
            {
                chb_Brand.SetItemChecked(i, true);
            }

            for (int i = 0; i < chb_Market.Items.Count; i++)
            {
                chb_Market.SetItemChecked(i, true);
            }

            for (int i = 0; i < chb_Factory.Items.Count; i++)
            {
                chb_Factory.SetItemChecked(i, true);
            }
        }

        private void btn_TypeNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_Type.Items.Count; i++)
            {
                chb_Type.SetItemChecked(i, false);
            }
        }

        private void btn_BrandNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_Brand.Items.Count; i++)
            {
                chb_Brand.SetItemChecked(i, false);
            }
        }

        private void btnMarketNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_Market.Items.Count; i++)
            {
                chb_Market.SetItemChecked(i, false);
            }
        }

        private void btn_FactoryNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_Factory.Items.Count; i++)
            {
                chb_Factory.SetItemChecked(i, false);
            }
        }

        private void btn_TypeAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_Type.Items.Count; i++)
            {
                chb_Type.SetItemChecked(i, true);
            }
        }

        private void btn_BrandAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_Brand.Items.Count; i++)
            {
                chb_Brand.SetItemChecked(i, true);
            }
        }

        private void btn_MarketAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_Market.Items.Count; i++)
            {
                chb_Market.SetItemChecked(i, true);
            }
        }

        private void btn_FactoryAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_Factory.Items.Count; i++)
            {
                chb_Factory.SetItemChecked(i, true);
            }
        }

        //CHECKEDLISTBOXES USERS TAB
        private void btn_PermissionAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_UserPermission.Items.Count; i++)
            {
                chb_UserPermission.SetItemChecked(i, true);
            }
        }

        private void btn_PermissionNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chb_UserPermission.Items.Count; i++)
            {
                chb_UserPermission.SetItemChecked(i, false);
            }
        }
        #endregion

        #region ####PRODUCTS TAB####

        public void ButtonsEnabled()
        {
            if (chb_Factory.CheckedItems.Count == 0)
            {
                chb_Type.Enabled = false;
                btn_TypeAll.Enabled = false;
                btn_TypeNone.Enabled = false;
            }
            else
            {
                chb_Type.Enabled = true;
                btn_TypeAll.Enabled = true;
                btn_TypeNone.Enabled = true;
            }

            if (chb_Type.CheckedItems.Count == 0)
            {
                chb_Market.Enabled = false;
                btn_MarketAll.Enabled = false;
                btn_MarketNone.Enabled = false;
            }
            else
            {
                chb_Market.Enabled = true;
                btn_MarketAll.Enabled = true;
                btn_MarketNone.Enabled = true;
            }

            if (chb_Market.CheckedItems.Count == 0)
            {
                chb_Brand.Enabled = false;
                btn_BrandAll.Enabled = false;
                btn_BrandNone.Enabled = false;
            }
            else
            {
                chb_Brand.Enabled = true;
                btn_BrandAll.Enabled = true;
                btn_BrandNone.Enabled = true;
            }
        }

        public void LsvProductsRefresh()
        {
            try
            {
                int i = 1;
                lsv_ProductsSearch.BeginUpdate();
                lsv_ProductsSearch.Items.Clear();

                foreach (var item in DatabaseManager.SelectAllProduct())
                {
                    ListViewItem row = new ListViewItem(i.ToString());
                    row.SubItems.Add(item.PartNumber.ToString());
                    row.SubItems.Add(item.Description);
                    row.SubItems.Add(item.Brand.ToString());
                    row.SubItems.Add(item.Market.ToString());
                    row.SubItems.Add(item.Factory.ToString());
                    row.SubItems.Add(item.Type.ToString());
                    row.SubItems.Add(item.BarCode.ToString());
                    row.SubItems.Add(item.Width.ToString());
                    row.SubItems.Add(item.Height.ToString());
                    row.SubItems.Add(item.Length.ToString());
                    row.SubItems.Add(item.Pieces.ToString());
                    row.SubItems.Add(item.Temperature.ToString());
                    lsv_ProductsSearch.Items.Add(row);
                    i++;
                }
                lsv_ProductsSearch.EndUpdate();
                lsv_ProductsSearch.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void LsvProductsMaintenanceRefresh()
        {
            try
            {
                int i = 1;
                lsv_ProductsMaintenance.BeginUpdate();
                lsv_ProductsMaintenance.Items.Clear();

                foreach (var item in DatabaseManager.SelectAllProduct())
                {
                    ListViewItem row = new ListViewItem(i.ToString());
                    row.SubItems.Add(item.PartNumber.ToString());
                    row.SubItems.Add(item.Description);
                    row.SubItems.Add(item.Brand.ToString());
                    row.SubItems.Add(item.Market.ToString());
                    row.SubItems.Add(item.Factory.ToString());
                    row.SubItems.Add(item.Type.ToString());
                    row.SubItems.Add(item.BarCode.ToString());
                    row.SubItems.Add(item.Width.ToString());
                    row.SubItems.Add(item.Height.ToString());
                    row.SubItems.Add(item.Length.ToString());
                    row.SubItems.Add(item.Pieces.ToString());
                    row.SubItems.Add(item.Temperature.ToString());
                    lsv_ProductsMaintenance.Items.Add(row);
                    i++;
                }
                lsv_ProductsMaintenance.EndUpdate();
                lsv_ProductsMaintenance.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_ProductClear_Click(object sender, EventArgs e)
        {
            ResetCheckedListBoxes();
            nud_PartNumber.Value = 0;
            tbx_Description.Clear();
            tbx_BarCode.Clear();
            LsvProductsRefresh();
        }

        private void btn_ProductSearch_Click(object sender, EventArgs e)
        {
            int searchpartnumber = (int)nud_PartNumber.Value;
            string searchdescription = tbx_Description.Text.Trim();
            try
            {
                int k = 1;
                lsv_ProductsSearch.BeginUpdate();
                lsv_ProductsSearch.Items.Clear();
                DatabaseManager.CreateProductSearchSql(searchpartnumber, searchdescription);

                foreach (var item in DatabaseManager.SearchProduct(searchpartnumber, searchdescription))
                {
                    ListViewItem row = new ListViewItem(k.ToString());
                    row.SubItems.Add(item.PartNumber.ToString());
                    row.SubItems.Add(item.Description);
                    row.SubItems.Add(item.Brand.ToString());
                    row.SubItems.Add(item.Market.ToString());
                    row.SubItems.Add(item.Factory.ToString());
                    row.SubItems.Add(item.Type.ToString());
                    row.SubItems.Add(item.BarCode.ToString());
                    row.SubItems.Add(item.Width.ToString());
                    row.SubItems.Add(item.Height.ToString());
                    row.SubItems.Add(item.Length.ToString());
                    row.SubItems.Add(item.Pieces.ToString());
                    row.SubItems.Add(item.Temperature.ToString());
                    lsv_ProductsSearch.Items.Add(row);
                    k++;
                }
                lsv_ProductsSearch.EndUpdate();
                lsv_ProductsSearch.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion

        #region ####USERS TAB####

        public void LsvUsersRefresh()
        {
            try
            {
                int i = 1;
                lsv_Users.BeginUpdate();
                lsv_Users.Items.Clear();

                foreach (var item in DatabaseManager.SelectAllUser())
                {
                    ListViewItem row = new ListViewItem(i.ToString());
                    row.SubItems.Add(item.Username);
                    row.SubItems.Add(item.Password);
                    row.SubItems.Add(item.Name);
                    row.SubItems.Add(item.Permission.ToString());
                    row.SubItems.Add(item.Email);
                    lsv_Users.Items.Add(row);
                    i++;
                }
                lsv_Users.EndUpdate();
                lsv_Users.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_UserClear_Click(object sender, EventArgs e)
        {
            tbx_UserNameSearch.Clear();
            for (int i = 0; i < chb_UserPermission.Items.Count; i++)
            {
                chb_UserPermission.SetItemChecked(i, true);
            }
            LsvUsersRefresh();
        }

        private void btn_UserSearch_Click(object sender, EventArgs e)
        {
            string searchusername = tbx_UserNameSearch.Text.Trim();
            List<int> searchpermission = new List<int>();

            if (chb_UserPermission.CheckedItems.Count != 0)
            {
                for (int i = 0; i < chb_UserPermission.Items.Count; i++)
                {
                    if (chb_UserPermission.GetItemChecked(i))
                    {
                        searchpermission.Add((int)chb_UserPermission.Items[i]);
                    }
                }
            }
            else
            {
                toolStripStatusLabel2.Text = "You need to select at least one permission to search!";
            }

            try
            {
                int i = 1;
                lsv_Users.BeginUpdate();
                lsv_Users.Items.Clear();

                foreach (var item in DatabaseManager.SearchUser(searchusername, searchpermission))
                {
                    ListViewItem row = new ListViewItem(i.ToString());
                    row.SubItems.Add(item.Username);
                    row.SubItems.Add(item.Password);
                    row.SubItems.Add(item.Name);
                    row.SubItems.Add(item.Permission.ToString());
                    row.SubItems.Add(item.Email);
                    lsv_Users.Items.Add(row);
                    i++;
                }
                lsv_Users.EndUpdate();
                lsv_Users.Refresh();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel2.Text = ex.Message;
            }
        }

        private void btn_UserNew_Click(object sender, EventArgs e)
        {
            UserNew userwindow = new UserNew();
            userwindow.ShowDialog();
            LsvUsersRefresh();
        }

        private void btn_UserModify_Click(object sender, EventArgs e)
        {
            //if (lsv_Users.FocusedItem.Index != -1)
            //{
            //    UserNew userwindow = new UserNew((Users)lsv_Users.FocusedItem);
            //    if (userwindow.ShowDialog() == DialogResult.OK)
            //    {

            //    }
            //}
        }

        private void btn_UserDelete_Click(object sender, EventArgs e)
        {
            //    if (lsv_Users.FocusedItem.Index != -1 && MessageBox.Show("Do you really want to delete the selected user?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            //    {
            //        try
            //        {
            //            DatabaseManager.UserDelete((Users)lsv_Users.FocusedItem.Index);
            //            toolStripStatusLabel1.Text = "User successfully deleted!";
            //        }
            //        catch (DatabaseException ex)
            //        {
            //            toolStripStatusLabel1.Text = "Error: " + ex.OriginalMessage;
            //        }
            //    }
        }



        #endregion


        private void lbl_BarCode_Click(object sender, EventArgs e)
        {

        }

        private void chb_Factory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chb_Factory_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ButtonsEnabled();
        }

        private void chb_Type_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ButtonsEnabled();
        }

        private void chb_Market_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ButtonsEnabled();
        }

        private void chb_Brand_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ButtonsEnabled();
        }
    }
}

