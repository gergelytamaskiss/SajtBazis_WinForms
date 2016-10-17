using System;

namespace SajtBazis_WinForms.Database
{
    class DatabaseException : Exception
    {
        //hiba 
        public DatabaseException(string error) : base("[Database failure!]" + error)
            {

        }
    }
}
