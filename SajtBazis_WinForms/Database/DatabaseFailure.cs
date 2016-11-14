using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SajtBazis_WinForms.Database
{
    class DatabaseFailure : Exception
    {
        string originalMessage;

        public string OriginalMessage
        {
            get { return originalMessage; }
            //set { originalMessage = value; }
        }

        public DatabaseFailure(string message, string originalMessage): base(message)
        {
            this.originalMessage = originalMessage;
        }

    }
}
