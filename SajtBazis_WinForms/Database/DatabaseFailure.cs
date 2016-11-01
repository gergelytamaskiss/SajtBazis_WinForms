using SajtBazis_WinForms.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SajtBazis_WinForms.Database
{
    class DatabaseFailure
    {
        string message;

        public string Message
        {
            get { return message; }
            //set { message = value; }
        }

        Products failure;

        internal Products Failure
        {
            get { return failure; }
            //set { failure = value; }
        }

        public DatabaseFailure(string message, Products failure)
        {
            this.message = message;
            this.failure = failure;
        }

        public override string ToString()
        {
            return message;
            //return base.ToString();
        }
    }
}
