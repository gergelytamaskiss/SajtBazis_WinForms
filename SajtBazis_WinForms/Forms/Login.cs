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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DatabaseManager.ConnectionOpen(ConfigurationManager.ConnectionStrings["SajtBazis_WinForms.Properties.Settings.SajtBazis_DataBaseConnectionString"].ConnectionString);
            toolStripStatusLabel1.Text = "Hello";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT Count(*) FROM Users 
                                        WHERE Username=@uname and 
                                        Password=@pass", connection);

                    cmd.Parameters.AddWithValue("@uname", txb_Username.Text);
                    cmd.Parameters.AddWithValue("@pass", txb_Password.Text);
                    int result = (int)cmd.ExecuteScalar();
                    if (result > 0)
                        MessageBox.Show("Login Success");
                    else
                        MessageBox.Show("Incorrect login");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected error:" + ex.Message);
                }
            }
        }

       
    }
}}
