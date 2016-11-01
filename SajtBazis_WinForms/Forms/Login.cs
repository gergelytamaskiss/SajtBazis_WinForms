using System;
using System.Configuration;
using System.Windows.Forms;
using SajtBazis_WinForms.Database;

namespace SajtBazis_WinForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //##kérdés: statuslabelbe hogy célszerû átadni üzenetet; hogy lehet kezdõformot bezárni, miután az új form megnyilt
        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.ConnectionOpen(ConfigurationManager.ConnectionStrings["SajtBazis_WinForms.Properties.Settings.SajtBazis_DataBaseConnectionString"].ConnectionString);
                //sbl_Status.Text = "Succesfully connected to database.";
            }
            catch (Exception ex)
            {
                sbl_Status.Text = "Error: " + ex.Message;
            }

        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tbx_Username.Text.Trim() == string.Empty && tbx_Password.Text.Trim() == string.Empty)
            {
                sbl_Status.Text = "You need to provide your username and password to login!";
            }
            else
            {
                try
                {
                    string username = tbx_Username.Text;
                    string password = tbx_Password.Text;
                    DatabaseManager.Login(username, password);
                    sbl_Status.Text = "Successfully logged in!";
                }
                catch (Exception ex)
                {
                    tbx_Password.Text = String.Empty;
                    sbl_Status.Text = ex.Message;
                }
            }
        }


        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
            DatabaseManager.ConnectionClose();
        }

    }
}
