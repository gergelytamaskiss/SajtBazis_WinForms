using SajtBazis_WinForms.Classes;
using SajtBazis_WinForms.Forms;
using System;
using System.Windows.Forms;
using SajtBazis_WinForms.Database;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SajtBazis_WinForms
{
    public partial class MainSearch : Form
    {
        public MainSearch()
        {
            InitializeComponent();
            //Products tab
            dgv_Products.DataSource = null;
            dgv_Products.DataSource = DatabaseManager.SelectAllProduct();
            cmb_Brand.DataSource = Enum.GetValues(typeof(Brands));
            cmb_Category.DataSource = Enum.GetValues(typeof(Categories));
            cmb_Market.DataSource = Enum.GetValues(typeof(Markets));
            cmb_Factory.DataSource = Enum.GetValues(typeof(Factories));
            cmb_Type.DataSource = Enum.GetValues(typeof(Types));
            //Users tab
            dgv_Users.DataSource = null;
            dgv_Users.AutoGenerateColumns = true;
            dgv_Users.DataSource = DatabaseManager.SelectAllUser();
            //UserSearchHelper();
            //int usercount = dgv_Users.Rows.Count;
            //toolStripStatusLabel1.Text = Convert.ToString(usercount) + " user(s) found";
            cmb_Permission.DataSource = Enum.GetValues(typeof(Permissions));
        }

        private void MainSearch_Load(object sender, EventArgs e)
        {

        }      
    

        private void MainSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }

        //Menustrip        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutwindow = new About();
            aboutwindow.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int searchpartnumber = int.Parse(tbx_PartNumber.Text);
            string searchdescription = txb_Description.Text;
            int searchbrand = cmb_Brand.SelectedIndex;
            int searchcategory = cmb_Category.SelectedIndex;
            int searchmarket = cmb_Market.SelectedIndex;
            int searchfactory = cmb_Factory.SelectedIndex;
            int searchtype = cmb_Type.SelectedIndex;
            int searchbarcode = int.Parse(txb_BarCode.Text);

            dgv_Products.DataSource = null;
            dgv_Products.DataSource = DatabaseManager.SearchProduct(searchpartnumber, searchdescription, searchbrand, searchcategory, searchmarket, searchfactory, searchtype, searchbarcode);
        }

        private void btn_UserSearch_Click(object sender, EventArgs e)
        {
            string searchuser = tbx_UserName.Text;
            int searchpermission = cmb_Permission.SelectedIndex;


            try
            {
                DatabaseManager.ConnectionOpen(ConfigurationManager.ConnectionStrings["SajtBazis_WinForms.Properties.Settings.SajtBazis_DataBaseConnectionString"].ConnectionString);

                if (cmb_Permission.SelectedIndex != 0)
                {
                    //tbx_UserName.Enabled = false;
                    dgv_Users.DataSource = null;
                    dgv_Users.DataSource = DatabaseManager.SearchUserByPermission(searchpermission);
                }
                else
                {
                    //tbx_UserName.Enabled = true;
                    dgv_Users.DataSource = null;
                    dgv_Users.DataSource = DatabaseManager.SearchUserByName(Convert.ToString(searchpermission));
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }

            DatabaseManager.ConnectionClose();
        }

        private void UserSearchHelper()
        {
            if (cmb_Permission.SelectedIndex == 0)
            {
                tbx_UserName.Enabled = false;
            }
            else
            {
                tbx_UserName.Enabled = true;
            }

        }

        private void btn_UserNew_Click(object sender, EventArgs e)
        {
            //UserNew newuserwindow = new UserNew();
            //if (newuserwindow.DialogResult() == DialogResult.OK)
            //{

            //}
        }
    }
}
