﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SajtBazis_WinForms.Classes
{
    enum Permissions
    {
        Admin, //0
        Datamanager, //1
        User //2
    }
    class Users
    {
        int id;
        public int Id
        {
            get { return id; }
            set { if (id == 0) { id = value; } }
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
            //set { permission = value; }
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
            set { dateCreated = value; }
        }

        public Users(string username, string password, string name, Permissions permission, string email)
        {
            //Id = id;
            Username = username;
            Password = password;
            Name = name;
            this.permission = permission;
            Email = email;
            //this.dateCreated = dateCreated;
        }

        public override string ToString()
        {
            return "Username: " + username + " | Permission: " + permission + " | Email: " + email;
        }

        //public override string ToCSV()
        //{
        //    return $"{Id};{username};{password};{(int)permission};{email}";
        //}
    }
}
