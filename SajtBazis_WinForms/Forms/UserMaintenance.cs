using System;
using System.Windows.Forms;
using SajtBazis_WinForms.Classes;
using SajtBazis_WinForms.Database;

namespace SajtBazis_WinForms.Forms
{
    public partial class UserMaintenance : Form
    {
        public UserMaintenance()
        {
            InitializeComponent();
        }

        //Buttons
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_UserSearch_Click(object sender, EventArgs e)
        {
            string searchuser = tbx_UserName.Text;
            string searchemail = tbx_Email.Text;
            int searchpermission = cmb_Permission.SelectedIndex;

            listBox1.DataSource = null;
            listBox1.DataSource = DatabaseManager.SearchUser(searchuser, searchemail, searchpermission);
        }

        private void UserMaintenance_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DatabaseManager.SelectAllUser();
            cmb_Permission.DataSource = Enum.GetValues(typeof(Permissions));
        }
    }
}

