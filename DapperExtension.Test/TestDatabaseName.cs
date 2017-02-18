using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Net.Extension.Test
{
    public class TestDatabaseName : DbContext
    {
        public  const string dbConnStr = "tclvcangorder";
        public TestDatabaseName() : base(dbConnStr)
        {
        }
    }
}
