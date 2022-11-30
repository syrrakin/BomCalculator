using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Security;
using Dapper;

namespace CommonLib.Helpers
{
    public static class SqlHelper
    {
        public static SqlConnection GetConnection(string connectionString, string userName = null, SecureString userPassword = null )
        {
            if (userName == null)
            {
                return new SqlConnection(connectionString);
            }
            if (userPassword == null)
            {
                userPassword = new SecureString();
            }
            userPassword.MakeReadOnly();
            return new SqlConnection(connectionString, new SqlCredential(userName, userPassword));
        }

        public static bool IsExistTable(SqlConnection connection, string tableName)
        {
            string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @Name";
            return connection.ExecuteScalar<int>(query, new { Name = tableName }) == 1;
        }
    
    }
}
