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
using System.Text;

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
            /*if (LoggedUser.loggedUserId == 0)
            {
                MessageBox.Show("Admin");

            }
            else if (LoggedUser.loggedUserId == 1)
            {
                MessageBox.Show("DM");
            }*/

            //PRODUCTS TAB
            chb_Type.DataSource = Enum.GetValues(typeof(Types));
            chb_Brand.DataSource = Enum.GetValues(typeof(Brands));
            chb_Market.DataSource = Enum.GetValues(typeof(Markets));
            chb_Factory.DataSource = Enum.GetValues(typeof(Factories));

            //ResetCheckedListBoxes();
            ButtonsEnabled();

            lsv_SearchProducts.GridLines = true;
            lsv_SearchProducts.View = View.Details;
            lsv_SearchProducts.FullRowSelect = true;
            lsv_SearchProducts.Columns.Add("ID", 30);
            lsv_SearchProducts.Columns.Add("Part number", 40);
            lsv_SearchProducts.Columns.Add("Description", 220);
            lsv_SearchProducts.Columns.Add("Brand", 80);
            lsv_SearchProducts.Columns.Add("Market", 50);
            lsv_SearchProducts.Columns.Add("Factory", 80);
            lsv_SearchProducts.Columns.Add("Type", 50);
            lsv_SearchProducts.Columns.Add("Barcode", 60);
            lsv_SearchProducts.Columns.Add("Width", 50);
            lsv_SearchProducts.Columns.Add("Heigth", 50);
            lsv_SearchProducts.Columns.Add("Length", 50);
            lsv_SearchProducts.Columns.Add("Pieces", 50);
            lsv_SearchProducts.Columns.Add("Temperature", 80);

            LsvProductSearchRefresh();

            //USERS TAB
            chb_UserPermission.DataSource = Enum.GetValues(typeof(Permissions));
            for (int i = 0; i < chb_UserPermission.Items.Count; i++)
            {
                chb_UserPermission.SetItemChecked(i, true);
            }

            lsv_ManageUsers.GridLines = true;
            lsv_ManageUsers.View = View.Details;
            lsv_ManageUsers.FullRowSelect = true;
            lsv_ManageUsers.Columns.Add("ID", 30);
            lsv_ManageUsers.Columns.Add("Username", 100);
            lsv_ManageUsers.Columns.Add("Password", 100);
            lsv_ManageUsers.Columns.Add("Name", 130);
            lsv_ManageUsers.Columns.Add("Permission", 100);
            lsv_ManageUsers.Columns.Add("Email", 180);

            LsvUsersRefresh();

            //PRODUCT MAINTENANCE TAB
            lsv_ManageProducts.GridLines = true;
            lsv_ManageProducts.View = View.Details;
            lsv_ManageProducts.FullRowSelect = true;
            lsv_ManageProducts.Columns.Add("ID", 30);
            lsv_ManageProducts.Columns.Add("Part number", 40);
            lsv_ManageProducts.Columns.Add("Description", 220);
            lsv_ManageProducts.Columns.Add("Brand", 80);
            lsv_ManageProducts.Columns.Add("Market", 50);
            lsv_ManageProducts.Columns.Add("Factory", 80);
            lsv_ManageProducts.Columns.Add("Type", 50);
            lsv_ManageProducts.Columns.Add("Barcode", 60);
            lsv_ManageProducts.Columns.Add("Width", 50);
            lsv_ManageProducts.Columns.Add("Heigth", 50);
            lsv_ManageProducts.Columns.Add("Length", 50);
            lsv_ManageProducts.Columns.Add("Pieces", 50);
            lsv_ManageProducts.Columns.Add("Temperature", 80);

            LsvProductSearchRefresh();
            LsvProductManageRefresh();
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
                LsvProductSearchRefresh();
                LsvProductManageRefresh();
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
                LsvProductSearchRefresh();
                LsvUsersRefresh();
                toolStripStatusLabel2.Text = "All table refreshed!";
            }
            catch (Exception)
            {
                toolStripStatusLabel2.Text = "Error:";
            }

        }
        #endregion

        #region ####SEARCH TAB####

        #region ProductCheckedListBoxes       

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
        #endregion

        public void LsvProductSearchRefresh()
        {
            try
            {
                int i = 1;
                lsv_SearchProducts.BeginUpdate();
                lsv_SearchProducts.Items.Clear();

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
                    lsv_SearchProducts.Items.Add(row);
                    i++;
                }
                lsv_SearchProducts.EndUpdate();
                lsv_SearchProducts.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ButtonsEnabled()
        {
            //if (chb_Factory.CheckedItems.Count == 0)
            //{
            //    chb_Type.Enabled = false;
            //    btn_TypeAll.Enabled = false;
            //    btn_TypeNone.Enabled = false;
            //}
            //else
            //{
            //    chb_Type.Enabled = true;
            //    btn_TypeAll.Enabled = true;
            //    btn_TypeNone.Enabled = true;
            //}

            //if (chb_Type.CheckedItems.Count == 0)
            //{
            //    chb_Market.Enabled = false;
            //    btn_MarketAll.Enabled = false;
            //    btn_MarketNone.Enabled = false;
            //}
            //else
            //{
            //    chb_Market.Enabled = true;
            //    btn_MarketAll.Enabled = true;
            //    btn_MarketNone.Enabled = true;
            //}

            //if (chb_Market.CheckedItems.Count == 0)
            //{
            //    chb_Brand.Enabled = false;
            //    btn_BrandAll.Enabled = false;
            //    btn_BrandNone.Enabled = false;
            //}
            //else
            //{
            //    chb_Brand.Enabled = true;
            //    btn_BrandAll.Enabled = true;
            //    btn_BrandNone.Enabled = true;
            //}
        }

        private void btn_ClearByDetails_Click(object sender, EventArgs e)
        {
            tbx_ByDetailsDescription.Clear();
            nud_ByDetailsPartNumber.Value = 0;
            nud_ByDetailsBarCode.Value = 0;
            LsvProductSearchRefresh();
        }

        private void btn_SearchByDetails_Click(object sender, EventArgs e)
        {
            string searchDescription = tbx_ByDetailsDescription.Text.Trim();
            int searchPartNumber = (int)nud_ByDetailsPartNumber.Value;
            int searchBarCode = (int)nud_ByDetailsBarCode.Value;

            try
            {
                int i = 1;
                lsv_SearchProducts.BeginUpdate();
                lsv_SearchProducts.Items.Clear();

                foreach (var item in DatabaseManager.SearchProductByDetails(searchDescription, searchPartNumber, searchBarCode))
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
                    lsv_SearchProducts.Items.Add(row);
                    i++;
                }
                lsv_SearchProducts.EndUpdate();
                lsv_SearchProducts.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        private void btn_ClearByList_Click(object sender, EventArgs e)
        {

        }

        private void btn_SearchByList_Click(object sender, EventArgs e)
        {            
            List<int> searchFactory = new List<int>();
            List<int> searchType = new List<int>();
            List<int> searchMarket = new List<int>();
            List<int> searchBrand = new List<int>();

            if (chb_Factory.CheckedItems.Count != 0)
            {
                for (int i = 0; i < chb_Factory.Items.Count; i++)
                {
                    if (chb_Factory.GetItemChecked(i))
                    {
                        searchFactory.Add((int)chb_Factory.Items[i]);
                    }
                }
            }

            if (chb_Type.CheckedItems.Count != 0)
            {
                for (int i = 0; i < chb_Type.Items.Count; i++)
                {
                    if (chb_Type.GetItemChecked(i))
                    {
                        searchType.Add((int)chb_Type.Items[i]);
                    }
                }
            }

            if (chb_Market.CheckedItems.Count != 0)
            {
                for (int i = 0; i < chb_Market.Items.Count; i++)
                {
                    if (chb_Market.GetItemChecked(i))
                    {
                        searchMarket.Add((int)chb_Market.Items[i]);
                    }
                }
            }

            if (chb_Brand.CheckedItems.Count != 0)
            {
                for (int i = 0; i < chb_Brand.Items.Count; i++)
                {
                    if (chb_Brand.GetItemChecked(i))
                    {
                        searchBrand.Add((int)chb_Brand.Items[i]);
                    }
                }
            }

            try
            {
                int i = 1;
                lsv_SearchProducts.BeginUpdate();
                lsv_SearchProducts.Items.Clear();

                foreach (var item in DatabaseManager.SearchProductByList(searchFactory, searchType, searchMarket, searchBrand))
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
                    lsv_SearchProducts.Items.Add(row);
                    i++;
                }
                lsv_SearchProducts.EndUpdate();
                lsv_SearchProducts.Refresh();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel2.Text = ex.Message;
            }
        }
        #endregion

        #region ####MANAGE USERS TAB####

        #region USER CHECKEDLISTBOXES

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

        public void LsvUsersRefresh()
        {
            try
            {
                int i = 1;
                lsv_ManageUsers.BeginUpdate();
                lsv_ManageUsers.Items.Clear();

                foreach (var item in DatabaseManager.SelectAllUser())
                {
                    ListViewItem row = new ListViewItem(i.ToString());
                    row.SubItems.Add(item.Username);
                    row.SubItems.Add(item.Password);
                    row.SubItems.Add(item.Name);
                    row.SubItems.Add(item.Permission.ToString());
                    row.SubItems.Add(item.Email);
                    lsv_ManageUsers.Items.Add(row);
                    i++;
                }
                lsv_ManageUsers.EndUpdate();
                lsv_ManageUsers.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_ClearUser_Click(object sender, EventArgs e)
        {
            tbx_SearchUserName.Clear();
            for (int i = 0; i < chb_UserPermission.Items.Count; i++)
            {
                chb_UserPermission.SetItemChecked(i, true);
            }
            LsvUsersRefresh();
        }

        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            string searchUserName = tbx_SearchUserName.Text.Trim();
            List<int> searchPermission = new List<int>();

            if (chb_UserPermission.CheckedItems.Count != 0)
            {
                for (int i = 0; i < chb_UserPermission.Items.Count; i++)
                {
                    if (chb_UserPermission.GetItemChecked(i))
                    {
                        searchPermission.Add((int)chb_UserPermission.Items[i]);
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
                lsv_ManageUsers.BeginUpdate();
                lsv_ManageUsers.Items.Clear();

                foreach (var item in DatabaseManager.SearchUser(searchUserName, searchPermission))
                {
                    ListViewItem row = new ListViewItem(i.ToString());
                    row.SubItems.Add(item.Username);
                    row.SubItems.Add(item.Password);
                    row.SubItems.Add(item.Name);
                    row.SubItems.Add(item.Permission.ToString());
                    row.SubItems.Add(item.Email);
                    lsv_ManageUsers.Items.Add(row);
                    i++;
                }
                lsv_ManageUsers.EndUpdate();
                lsv_ManageUsers.Refresh();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel2.Text = ex.Message;
            }
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            UserNew userwindow = new UserNew();
            userwindow.ShowDialog();
            LsvUsersRefresh();
        }

        private void btn_ModifyUser_Click(object sender, EventArgs e)
        {
            //if (lsv_ManageUsers.FocusedItem.Index != -1)
            //{
            //    UserNew userwindow = new UserNew((Users)lsv_ManageUsers.FocusedItem);
            //    if (userwindow.ShowDialog() == DialogResult.OK)
            //    {

            //    }
            //}
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
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

        private void btn_ManageUsersExport_Click(object sender, EventArgs e)
        {

        }

        public static void ListViewToCSV(ListView listView, string filePath, bool includeHidden)
        {
            //make header string
            StringBuilder result = new StringBuilder();
            WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listView.Columns[i].Text);

            //export data rows
            foreach (ListViewItem listItem in listView.Items)
                WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listItem.SubItems[i].Text);

            File.WriteAllText(filePath, result.ToString());
        }

        private static void WriteCSVRow(StringBuilder result, int itemsCount, Func<int, bool> isColumnNeeded, Func<int, string> columnValue)
        {
            bool isFirstTime = true;
            for (int i = 0; i < itemsCount; i++)
            {
                if (!isColumnNeeded(i))
                    continue;

                if (!isFirstTime)
                    result.Append(",");
                isFirstTime = false;

                result.Append(String.Format("\"{0}\"", columnValue(i)));
            }
            result.AppendLine();
        }

        #endregion       

        #region ####MANAGE PRODUCTS TAB####
        public void LsvProductManageRefresh()
        {
            try
            {
                int i = 1;
                lsv_ManageProducts.BeginUpdate();
                lsv_ManageProducts.Items.Clear();

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
                    lsv_ManageProducts.Items.Add(row);
                    i++;
                }
                lsv_ManageProducts.EndUpdate();
                lsv_ManageProducts.Refresh();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_SearchProduct_Click(object sender, EventArgs e)
        {
            string searchDescription = tbx_ManageDescription.Text.Trim();
            int searchPartNumber = (int)nud_ManagePartNumber.Value;
            int searchBarCode = (int)nud_ManageBarCode.Value;

            try
            {
                int i = 1;
                lsv_ManageProducts.BeginUpdate();
                lsv_ManageProducts.Items.Clear();

                foreach (var item in DatabaseManager.SearchProductByDetails(searchDescription, searchPartNumber, searchBarCode))
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
                    lsv_ManageProducts.Items.Add(row);
                    i++;
                }
                lsv_ManageProducts.EndUpdate();
                lsv_ManageProducts.Refresh();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel2.Text = ex.Message;
            }
        }

        private void btn_ClearProduct_Click(object sender, EventArgs e)
        {
            tbx_ManageDescription.Clear();
            nud_ManagePartNumber.Value = 0;
            nud_ManageBarCode.Value = 0;
            LsvProductManageRefresh();
        }

        #endregion

        
    }
}



