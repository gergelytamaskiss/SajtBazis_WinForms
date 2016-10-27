using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SajtBazis_WinForms.Classes
{
    enum Permissions
    {
        admin,
        datamanager,
        user
    }
    class Users
    {
        Permissions permission;
        internal Permissions Permission
        {
            get { return permission; }
            //set { permission = value; }
        }

        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        DateTime dateCreated;

        public DateTime DateCreated
        {
            get { return dateCreated; }
            //set { dateCreated = value; }
        }

        public Users(Permissions permission, string username, string password, string email, DateTime dateCreated)
        {
            this.permission = permission;
            this.dateCreated = dateCreated;
            Username = username;
            Password = password;
            Email = email;
        }

        //public override XElement ToXML()
        //{
        //   
        //}
    }
}
