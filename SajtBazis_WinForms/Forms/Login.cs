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

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.ConnectionOpen(ConfigurationManager.ConnectionStrings["SajtBazis_WinForms.Properties.Settings.SajtBazis_DataBaseConnectionString"].ConnectionString);

                if (tbx_Username.Text.Trim() == string.Empty || tbx_Password.Text.Trim() == string.Empty)
                {
                    tsl_Login.Text = "You need to provide your username and password to login!";
                }
                else
                {
                    try
                    {
                        string username = tbx_Username.Text;
                        string password = tbx_Password.Text;
                        DatabaseManager.Login(username, password);
                        //this.Close();
                    }
                    catch (Exception)
                    {
                        string username = String.Empty;
                        string password = String.Empty;                    
                        tsl_Login.Text = "Check your username and password and try again!";
                    }

                }
            }
            catch (Exception ex)
            {
                tsl_Login.Text = ex.Message;
            }            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
            DatabaseManager.ConnectionClose();
        }
    }
}
