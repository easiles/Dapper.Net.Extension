using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Net.Extension
{
    public abstract class DbContext
    {
        public SqlClient SqlClient { get; set; }

        protected DbContext(string dbConnStr)
        {
            SqlClient = new SqlClient(dbConnStr);
        }
    }
}
