using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public static class ConnectionSingleton
    {
       static SqlConnection conn;
       public static SqlConnection GetConnection()
        {

            if (conn == null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder["Data Source"] = "PHUONGDAM\\SQLEXPRESS";
                builder["integrated Security"] = true;
                builder["Initial Catalog"] = "UserManagement";
                builder.UserID = "PHUONGDAM\\DELL";
                conn = new SqlConnection(builder.ConnectionString);
                conn.Open();
                return conn;
            }
            else
                return conn;
        }
        
    }
}
