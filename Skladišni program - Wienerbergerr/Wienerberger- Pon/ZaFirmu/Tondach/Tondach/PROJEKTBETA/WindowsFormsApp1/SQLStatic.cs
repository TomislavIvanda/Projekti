using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Main
{
    static class SQLStatic
    
        {
            public static SqlConnection GetSqlkonekcija()
            {
                return new SqlConnection(@"Data Source=desktop-neiglp9;Initial Catalog=ProjektZavrsno;Integrated Security=True");
            }
        }
    }

