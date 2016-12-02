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
using System.ComponentModel;

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
            if (LoggedUser.loggedUserId == 2)
            {
                ((Control)tbp_ManageUsers).Enabled = false;
                grb_SearchUsers.Visible = false;
                grb_ManageUsers.Visible = false;
                grb_ManageUsersResult.Visible = false;

                reloadUsersToolStripMenuItem.Visible = false;
                realoadAllToolStripMenuItem.Visible = false;

                ((Control)tbp_ManageProduct).Enabled = false;
                grb_SearchProducts.Visible = false;
                grb_ManageProducts.Visible = false;
                grb_ManageProductsResult.Visible = false;

                LsvProductSearchRefresh();

            }
            else if (LoggedUser.loggedUserId == 1)
            {
                ((Control)tbp_ManageUsers).Enabled = false;
                grb_SearchUsers.Visible = false;
                grb_ManageUsers.Visible = false;
                grb_ManageUsersResult.Visible = false;

                lbl_Auth2.Visible = false;
                reloadUsersToolStripMenuItem.Visible = false;
                realoadAllToolStripMenuItem.Visible = false;

                LsvProductSearchRefresh();
                LsvProductManageRefresh();
            }
            else if (LoggedUser.loggedUserId == 0)
            {
                lbl_Auth.Visible = false;
                lbl_Auth2.Visible = false;
                LsvProductSearchRefresh();
                LsvUsersRefresh();
                LsvProductManageRefresh();
            }

            chb_Type.DataSource = Enum.GetValues(typeof(Types));
            chb_Brand.DataSource = Enum.GetValues(typeof(Brands));
            chb_Market.DataSource = Enum.GetValues(typeof(Markets));
            chb_Factory.DataSource = Enum.GetValues(typeof(Factories));

            lsv_SearchProducts.GridLines = true;
            lsv_SearchProducts.View = View.Details;
            lsv_SearchProducts.FullRowSelect = true;
            lsv_SearchProducts.Columns.Add("ID", 30);
            lsv_SearchProducts.Columns.Add("Part number", 50);
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
            lsv_SearchProducts.Columns.Add("Temperature", 75);

            ResetCheckedListBoxes();

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
        }


        private void MainSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;

            }
        }

        #region EXPORT
        public static void ListViewToCSV(ListView listView, string filePath, bool includeHidden)
        {
            StringBuilder result = new StringBuilder();
            WriteCSVRow(result, listView.Columns.Count, i => includeHidden || listView.Columns[i].Width > 0, i => listView.Columns[i].Text);

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

        #region MENUSTRIP       
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutwindow = new About();
            aboutwindow.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            DatabaseManager.ConnectionClose();
        }

        private void reloadProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LsvProductSearchRefresh();
                LsvProductManageRefresh();
                tsl_MainSearch.Text = "Products tables refreshed!";
            }
            catch (Exception ex)
            {
                tsl_MainSearch.Text = "Error:" + ex.Message;
            }
        }

        private void reloadUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LsvUsersRefresh();
                tsl_MainSearch.Text = "Users table refreshed!";
            }
            catch (Exception ex)
            {
                tsl_MainSearch.Text = "Error:" + ex.Message;
            }
        }

        private void realoadAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LsvProductSearchRefresh();
                LsvUsersRefresh();
                tsl_MainSearch.Text = "All table refreshed!";
            }
            catch (Exception ex)
            {
                tsl_MainSearch.Text = "Error:" + ex.Message;
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

        private void btn_ClearByDetails_Click(object sender, EventArgs e)
        {
            tbx_ByDetailsDescription.Clear();
            nud_ByDetailsPartNumber.Value = 0;
            nud_ByDetailsBarCode.Value = 0;
            LsvProductSearchRefresh();
            tsl_MainSearch.Text = "";
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
                if (lsv_SearchProducts.Items.Count == 0)
                {
                    tsl_MainSearch.Text = "Your search returned " + lsv_SearchProducts.Items.Count + " result(s). Please check your search parameters and check again!";
                }
                else
                {
                    tsl_MainSearch.Text = "Your search returned " + lsv_SearchProducts.Items.Count + " result(s)";
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_ClearByList_Click(object sender, EventArgs e)
        {
            ResetCheckedListBoxes();
            LsvProductSearchRefresh();
            tsl_MainSearch.Text = "";
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
                if (searchFactory.Count > 0 && searchType.Count > 0 && searchMarket.Count > 0 && searchBrand.Count > 0)
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
                    if (lsv_SearchProducts.Items.Count == 0)
                    {
                        tsl_MainSearch.Text = "Your search returned " + lsv_SearchProducts.Items.Count + " result(s). Please check your search parameters and check again!";
                    }
                    else
                    {
                        tsl_MainSearch.Text = "Your search returned " + lsv_SearchProducts.Items.Count + " result(s)";
                    }                    
                }
                else
                {
                    tsl_MainSearch.Text = "You need to select at least one item from each list!";
                }
            }
            catch (Exception ex)
            {
                tsl_MainSearch.Text = ex.Message;
            }
        }

        private void btn_SearchProductsExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.DefaultExt = "*.csv";
            saveFileDialog1.Filter = "CSV files|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ListViewToCSV(lsv_SearchProducts, saveFileDialog1.FileName, false);
                tsl_MainSearch.Text = saveFileDialog1.FileName + " succesfully exported!";
            }
        }
        #endregion

        #region ####MANAGE USERS TAB####

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

                    Users usersListViewObj = new Users(item.Username, item.Password, item.Name.ToString(), item.Permission, item.Email);
                    row.Tag = usersListViewObj;

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
            tsl_MainSearch.Text = "";
        }

        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            string searchUserName = tbx_SearchUserName.Text.Trim();
            List<int> searchPermission = new List<int>();
            tsl_MainSearch.Text = "";

            if (chb_UserPermission.CheckedItems.Count != 0)
            {
                for (int i = 0; i < chb_UserPermission.Items.Count; i++)
                {
                    if (chb_UserPermission.GetItemChecked(i))
                    {
                        searchPermission.Add((int)chb_UserPermission.Items[i]);
                    }
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
                    tsl_MainSearch.Text = "Your search returned " + lsv_ManageUsers.Items.Count + " result(s)";
                }
                catch (Exception ex)
                {
                    tsl_MainSearch.Text = ex.Message;
                }
            }
            else
            {
                tsl_MainSearch.Text = "You need to select at least one permission to search!";
            }
        }

        private void btn_NewUser_Click(object sender, EventArgs e)
        {
            tsl_MainSearch.Text = "";

            UserNew userWindow = new UserNew();
            userWindow.ShowDialog();
            LsvUsersRefresh();
            //if (userwindow.ShowDialog() == DialogResult.OK)
            //{
            //    tsl_MainSearch.Text = "User succesfully added!";
            //    LsvUsersRefresh();
            //}
        }

        private void btn_ModifyUser_Click(object sender, EventArgs e)
        {
            tsl_MainSearch.Text = "";

            if (lsv_ManageUsers.SelectedItems.Count != 0)
            {
                UserNew userwindow = new UserNew((Users)lsv_ManageUsers.SelectedItems[0].Tag);
                if (userwindow.ShowDialog() == DialogResult.OK)
                {
                    LsvUsersRefresh();
                    tsl_MainSearch.Text = "User successfully modified!";
                }
            }
            else
            {
                tsl_MainSearch.Text = "Select a user to modify!";
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            tsl_MainSearch.Text = "";
            if (lsv_ManageUsers.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Do you really want to delete the selected user?", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string selected = (lsv_ManageUsers.SelectedItems[0].SubItems[1]).Text;

                        DatabaseManager.UserDelete(selected);
                        LsvUsersRefresh();

                        tsl_MainSearch.Text = "User successfully deleted!";
                    }
                    catch (DatabaseException ex)
                    {
                        tsl_MainSearch.Text = "Error: " + ex.OriginalMessage;
                    }
                }
            }
            else
            {
                tsl_MainSearch.Text = "Select a user to delete!";
            }
        }

        private void btn_ManageUsersExport_Click(object sender, EventArgs e)
        {
            tsl_MainSearch.Text = "";

            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.DefaultExt = "*.csv";
            saveFileDialog1.Filter = "CSV files|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ListViewToCSV(lsv_ManageUsers, saveFileDialog1.FileName, false);
                tsl_MainSearch.Text = saveFileDialog1.FileName + " succesfully exported!";
            }
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

                    Products productsListViewObj = new Products(item.PartNumber, item.Description, item.Brand, item.Market, item.Factory, item.Type, item.BarCode, item.Width, item.Height, item.Length, item.Pieces, item.Temperature);
                    row.Tag = productsListViewObj;
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
                tsl_MainSearch.Text = "Your search returned " + lsv_ManageProducts.Items.Count + " result(s)";
            }
            catch (Exception ex)
            {
                tsl_MainSearch.Text = ex.Message;
            }
        }

        private void btn_ClearProduct_Click(object sender, EventArgs e)
        {
            tbx_ManageDescription.Clear();
            nud_ManagePartNumber.Value = 0;
            nud_ManageBarCode.Value = 0;
            LsvProductManageRefresh();
            tsl_MainSearch.Text = "";
        }

        private void btn_ManageProductsExport_Click(object sender, EventArgs e)
        {
            tsl_MainSearch.Text = "";

            saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog1.DefaultExt = "*.csv";
            saveFileDialog1.Filter = "CSV files|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ListViewToCSV(lsv_ManageProducts, saveFileDialog1.FileName, false);
                tsl_MainSearch.Text = saveFileDialog1.FileName + " succesfully exported!";
            }
        }

        private void btn_NewProduct_Click(object sender, EventArgs e)
        {
            tsl_MainSearch.Text = "";

            ProductNew productWindow = new ProductNew();
            productWindow.ShowDialog();
            LsvProductManageRefresh();
            //if (productwindow.ShowDialog() == DialogResult.OK)
            //{
            //    tsl_MainSearch.Text = "Product succesfully added!";
            //    LsvUsersRefresh();
            //}
        }

        private void btn_ModifyProduct_Click(object sender, EventArgs e)
        {
            tsl_MainSearch.Text = "";

            if (lsv_ManageProducts.SelectedItems.Count != 0)
            {
                ProductNew productWindow = new ProductNew((Products)lsv_ManageProducts.SelectedItems[0].Tag);
                if (productWindow.ShowDialog() == DialogResult.OK)
                {
                    LsvProductManageRefresh();
                    tsl_MainSearch.Text = "Product successfully modified!";
                }
            }
            else
            {
                tsl_MainSearch.Text = "Select a product to modify!";
            }
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {

            tsl_MainSearch.Text = "";
            if (lsv_ManageProducts.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Do you really want to delete the selected product?", "Delete product", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        string selectedproduct = (lsv_ManageProducts.SelectedItems[0].SubItems[1]).Text;

                        DatabaseManager.ProductDelete(selectedproduct);
                        LsvProductManageRefresh();

                        tsl_MainSearch.Text = "Product successfully deleted!";
                    }
                    catch (DatabaseException ex)
                    {
                        tsl_MainSearch.Text = "Error: " + ex.OriginalMessage;
                    }
                }
            }
            else
            {
                tsl_MainSearch.Text = "Select a product to delete!";
            }
        }
        #endregion
    }
}



