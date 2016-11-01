using System;

namespace SajtBazis_WinForms.Database
{
    class DatabaseException : Exception
    {
        string originalMessage;

        public string OriginalMessage
        {
            get { return originalMessage; }
            //set { originalMessage = value; }
        }

        public DatabaseException(string message, string originalMessage) : base(message)
        {
            this.originalMessage = originalMessage;
        }
    }
}

