using System;

namespace SajtBazis_WinForms.Database
{
    class DatabaseException : Exception
    {
        //hiba 
        public DatabaseException(string hiba) : base("[Database failure!]" + hiba)
            {

        }
    }
}
