using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SajtBazis_WinForms.Classes
{
    class Users
    {
        enum Permissions
        {
            User,
            Admin
        }

        private int id;

        public int ID
        {
            get { return id; }
            set { if (id == 0) { id = value; } }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

    }
}
