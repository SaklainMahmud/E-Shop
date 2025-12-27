using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace E_Shop.Database
{
    public abstract class DatabaseConnection
    {
        const string connectionString = @"Your connection string";
        public static SqlConnection databaseConnect()
        {
            return new SqlConnection(connectionString);
        }
    }
}
