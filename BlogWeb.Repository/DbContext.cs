using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace BlogWeb.Repository
{
    public class DbContext
    {
        public DbConnection GetConnection()
        {
            return DbConn.OpenConnection();
        }
    }
}
