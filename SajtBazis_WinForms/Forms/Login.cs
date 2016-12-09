using System;
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
                    if (DatabaseManager.Login(username, password) > 0)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    string username = String.Empty;
                    string password = String.Empty;
                    tsl_Login.Text = "Check your username and password and try again!" + ex.Message;
                    //DatabaseManager.ConnectionClose();
                }

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DatabaseManager.ConnectionClose();
            Close();
        }
    }
}
