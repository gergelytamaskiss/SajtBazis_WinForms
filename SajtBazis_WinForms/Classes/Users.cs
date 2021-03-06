﻿namespace SajtBazis_WinForms.Classes
{
    enum Permissions
    {
        Admin,
        Datamanager,
        User
    }
    class Users
    {
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

        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        Permissions permission;
        internal Permissions Permission
        {
            get { return permission; }
            set { permission = value; }
        }

        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }       

        public Users(string username, string password, string name, Permissions permission, string email)
        {
            Username = username;
            Password = password;
            Name = name;
            this.permission = permission;
            Email = email;            
        }

        public override string ToString()
        {
            return "Username: " + username + " | Permission: " + permission + " | Email: " + email;
        }        
    }
}
