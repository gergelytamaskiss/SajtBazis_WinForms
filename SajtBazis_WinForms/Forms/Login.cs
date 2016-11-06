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
                //Service-based
                //DatabaseManager.ConnectionOpen(ConfigurationManager.ConnectionStrings["SajtBazis_WinForms.Properties.Settings.SajtBazis_DataBaseConnectionString"].ConnectionString);

                //SQL server
                DatabaseManager.ConnectionOpen(ConfigurationManager.ConnectionStrings["Data Source=219886e7-d1a7-4d53-880e-a6ad00d1c58a.sqlserver.sequelizer.com;Persist Security Info=True;User ID=ehydjpnmeavjggvk;Password=yspoaNVLPGY6xiujZkcrBVpxZFfifhVP3LSwuyiDDtAXUJfbMQDcnH6KcYwBHLEG"].ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tbx_Username.Text.Trim() == string.Empty && tbx_Password.Text.Trim() == string.Empty)
            {
                MessageBox.Show("You need to provide your username and password to login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string username = tbx_Username.Text;
                    string password = tbx_Password.Text;
                    DatabaseManager.Login(username, password);
                }
                catch (Exception ex)
                {
                    tbx_Password.Text = String.Empty;
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
