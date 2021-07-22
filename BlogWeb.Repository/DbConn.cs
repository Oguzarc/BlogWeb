using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace BlogWeb.Repository
{
    public class DbConn
    {
        public static string conn = "Server=DESKTOP-8MDJJIV; Database=BlogDB;Trusted_Connection=True;MultipleActiveResultSets=true";

        public static DbConnection OpenConnection()
        {
            SqlConnection con = new SqlConnection(conn);
            return con;
        }
    }
}
