using System;
using System.Data.SqlClient;


namespace SajtBazis_WinForms.Database
{
    static class DatabaseManager
    {
        //Connection Open
        static SqlConnection connection = new SqlConnection();

        public static void ConnectionOpen(string connStr)
        {
            try
            {
                connection.ConnectionString = connStr;
                connection.Open();
            }
            catch (Exception)
            {
                throw new DatabaseException("Connecting to database failed!");
            }
        }

        //Connection Close
        public static void ConnectionClose()
        {
            try
            {
                connection.Close();
            }
            catch (Exception)
            {
                throw new DatabaseException("Disconecting from database failed!");
            }
        }
    }
}
