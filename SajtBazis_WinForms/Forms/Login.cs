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

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                DatabaseManager.ConnectionOpen(ConfigurationManager.ConnectionStrings["SajtBazis_WinForms.Properties.Settings.SajtBazis_DataBaseConnectionString"].ConnectionString);                
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tbx_Username.Text.Trim() == string.Empty && tbx_Password.Text.Trim() == string.Empty)
            {
                toolStripStatusLabel1.Text = "You need to provide your username and password to login!";
            }
            else
            {
                try
                {
                    string username = tbx_Username.Text;
                    string password = tbx_Password.Text;
                    DatabaseManager.Login(username, password);
                }
                catch (Exception)
                {
                    tbx_Password.Text = String.Empty;
                    toolStripStatusLabel1.Text = "Check your username and password and try again!";                    
                }
            }

            //DatabaseManager.ConnectionClose();
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
