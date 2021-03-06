﻿using SajtBazis_WinForms.Classes;
using SajtBazis_WinForms.Database;
using System;
using System.Windows.Forms;

namespace SajtBazis_WinForms.Forms
{
    public partial class UserNew : Form
    {
        Users selectedUser;
        internal Users SelectedUser
        {
            get { return selectedUser; }
            //set { selectedUser = value; }
        }

        public UserNew()
        {
            InitializeComponent();
            cmb_Permission.DataSource = Enum.GetValues(typeof(Permissions));
        }

        internal UserNew(Users modify)
        {
            InitializeComponent();
            selectedUser = modify;
            cmb_Permission.DataSource = Enum.GetValues(typeof(Permissions));
            cmb_Permission.SelectedIndex = (int)modify.Permission;
            tbx_Username.Text = modify.Username;
            tbx_Password.Text = modify.Password;
            tbx_Name.Text = modify.Name;
            tbx_Email.Text = modify.Email;
            tbx_Username.Enabled = false;

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx_Username.Text.Trim() != string.Empty && tbx_Password.Text.Trim() != string.Empty && tbx_Email.Text.Trim() != string.Empty && tbx_Name.Text.Trim() != string.Empty)
                {
                    if (selectedUser == null)
                    {
                        selectedUser = new Users(tbx_Username.Text.Trim(), tbx_Password.Text.Trim(), tbx_Name.Text.Trim(), (Permissions)cmb_Permission.SelectedIndex, tbx_Email.Text.Trim());
                        DatabaseManager.UserNew(selectedUser);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        selectedUser.Password = tbx_Password.Text;
                        selectedUser.Email = tbx_Email.Text;
                        selectedUser.Name = tbx_Name.Text;
                        selectedUser.Permission = (Permissions)cmb_Permission.SelectedIndex;
                        DatabaseManager.UserModify(selectedUser);
                        DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    tsl_ManageUser.Text = "Please fill out all the required fields!";
                }
            }
            catch (DatabaseException ex)
            {
                tsl_ManageUser.Text = "Error: " + ex.Message;
                DialogResult = DialogResult.None;
            }
        }
    }
}
