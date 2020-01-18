using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tondach

{
    static class SQLStatic

    {
        public static SqlConnection GetSqlkonekcija()
        {
            return new SqlConnection(@"Data Source=DESKTOP-I87B01L;Initial Catalog=wienerberger;Integrated Security=True");
        }
    }
}

