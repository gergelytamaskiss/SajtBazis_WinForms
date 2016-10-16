using System;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            {
                //if (txb_Username.Text.Trim() == string.Empty && txb_Password.Text.Trim() == string.Empty)
                //{
                    try
                    {
                        SqlConnection connection = new SqlConnection();
                        connection.ConnectionString = ConfigurationManager.ConnectionStrings["SajtBazis_WinForms.Properties.Settings.SajtBazis_DataBaseConnectionString"].ConnectionString;
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Users 
                                        WHERE Username=@uname and 
                                        Password=@pass", connection);
                        cmd.Parameters.AddWithValue("@uname", txb_Username.Text);
                        cmd.Parameters.AddWithValue("@pass", txb_Password.Text);
                        int result = (int)cmd.ExecuteScalar();
                        if (result > 0)
                        {
                            MessageBox.Show("Login Success");
                            MainSearch mainwindow = new MainSearch();
                            mainwindow.Show();
                        this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You need to provide your username and password to login!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected error:" + ex.Message);
                    }
                }
                //else
                //{
                //    MessageBox.Show("Please check your username and password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            //}

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
        }
    }
}