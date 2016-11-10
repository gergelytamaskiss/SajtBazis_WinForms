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
        Select, //0
        Admin, //1
        Datamanager, //2
        User //3
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

        //DateTime dateCreated;

        //public DateTime DateCreated
        //{
        //    get { return dateCreated; }
        //    set { dateCreated = value; }
        //}

        public Users(string username, string password, Permissions permission, string email)
        {
            Username = username;
            Password = password;
            this.permission = permission;
            Email = email;
            //this.dateCreated = dateCreated;
        }

        
        public override string ToString()
        {
            return "Username: " + username + " | Permission: " + permission + " | Email: " + email;
        }
    }
}
